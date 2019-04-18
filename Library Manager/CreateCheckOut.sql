CREATE OR ALTER PROCEDURE Libraries.CheckOut
   @ItemsOutID INT OUTPUT,
   @BookID INT,
   @MemberID INT,
   @LibraryID INT
AS

INSERT Libraries.ItemsOut(BookID, MemberID, LibraryID, CheckedOutDate, DueBackDate, ReturnedDate)
VALUES(@BookID, @MemberID, @LibraryID, GETDATE(), DATEADD(DAY, 21, GETDATE()), NULL)

SET @ItemsOutID = SCOPE_IDENTITY();


/*Member checks out a specific book(s) from specific library */