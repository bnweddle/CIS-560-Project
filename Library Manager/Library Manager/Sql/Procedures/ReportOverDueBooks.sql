CREATE OR ALTER PROCEDURE Libraries.OverDueBooks

@CurrentDate DATETIME

AS
WITH CteSource (BookName, MemberID, CheckedOutDate, DueBackDate, Diff) AS (
	SELECT T.[Name] AS BookName, IT.MemberID, IT.CheckedOutDate, IT.DueBackDate,
		DATEDIFF(days,IT.DueBackDate, @CurrentDate) AS Diff
	FROM Libraries.ItemsOut IT
		INNER JOIN Libraries.Book B ON IT.BookID = B.BookID
		INNER JOIN Libraries.Title T ON B.TitleID = T.TitleID
	WHERE IT.DueBackDate < @CurrentDate
		AND IT.ReturnDate IS NULL
)

SELECT C.BookName, C.MemberID,C.CheckOutDate, C.DueBackDate
FROM CteSource C 
WHERE Diff > 20
ORDER BY IT.DueBackDate
SET @CurrentDate = SYSDATETIMEOFFSET()
--REPORT QUERY
--Returns the name of the book, the member ID of who has it, when it was checked out, and when it 
--was due back 
