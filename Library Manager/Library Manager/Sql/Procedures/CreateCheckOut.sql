CREATE OR ALTER PROCEDURE Libraries.CheckOut
   @ItemsOutID INT OUTPUT,
   @CheckedOutDate DATETIME OUTPUT,
   @DueBackDate DATETIME OUTPUT,
   @ReturnedDate DATETIME OUTPUT,
   @Title NVARCHAR(265) OUTPUT,
   @TitleID INT,
   @MemberID INT,
   @LibraryID INT
AS

DECLARE @BookID INT = (
	SELECT B.BookID
	FROM Libraries.Book B
	WHERE B.TitleID = @TitleID
		AND B.LibraryID = @LibraryID)

INSERT Libraries.ItemsOut(BookID, MemberID, LibraryID, CheckedOutDate, DueBackDate, ReturnedDate)
VALUES(@BookID, @MemberID, @LibraryID, @CheckedOutDate, @DueBackDate, @ReturnedDate)

SET @ItemsOutID = SCOPE_IDENTITY();
SET @CheckedOutDate = GETDATE();
SET @DueBackDate = DATEADD(DAY, 21, GETDATE())
SET @ReturnedDate = NULL
SET @Title =  (
			SELECT T.[Name]
			  FROM Libraries.Title T
				 INNER JOIN Libraries.Book B ON B.TitleID = T.TitleID
					AND B.BookID = @BookID
				 INNER JOIN Libraries.ItemsOut I ON I.BookID = B.BookID
					AND I.ItemsOutID = @ItemsOutID)

/*Member checks out a specific book(s) from specific library */