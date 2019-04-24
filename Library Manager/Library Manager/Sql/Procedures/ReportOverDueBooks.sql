CREATE OR ALTER PROCEDURE Libraries.OverDueBooks
AS

DECLARE @CurrentDate DATETIME =  SYSDATETIMEOFFSET();
WITH CteSource (BookName, MemberID, CheckedOutDate, DueBackDate, Diff) AS (
	SELECT T.[Name] AS BookName, IT.MemberID, IT.CheckedOutDate, IT.DueBackDate,
		DATEDIFF(day,IT.DueBackDate, @CurrentDate) AS Diff
	FROM Libraries.ItemsOut IT
		INNER JOIN Libraries.Book B ON IT.BookID = B.BookID
		INNER JOIN Libraries.Title T ON B.TitleID = T.TitleID
	WHERE IT.DueBackDate < @CurrentDate
		AND IT.ReturnedDate IS NULL
)
SELECT C.BookName, C.MemberID, C.CheckedOutDate, C.DueBackDate, C.Diff
FROM CteSource C 
WHERE Diff > 31
ORDER BY C.DueBackDate

--REPORT QUERY
--Returns the name of the book that has not been returned for over a month of when it was dues back,
--the member ID of who has it, when it was checked out, and when it was due back 
