CREATE OR ALTER PROCEDURE Libraries.OverDueBooks
AS

SELECT T.[Name] AS BookName, IT.MemberID, IT.CheckedOutDate, IT.DueBackDate
FROM Libraries.ItemsOut IT
	INNER JOIN Libraries.Book B ON IT.BookID = B.BookID
	INNER JOIN Libraries.Title T ON B.TitleID = T.TitleID
WHERE IT.DueBackDate < CAST(GETDATE() AS DATE)
ORDER BY IT.DueBackDate

--REPORT QUERY
--Returns the name of the book, the member ID of who has it, when it was checked out, and when it 
--was due back 
--I was thinking this would be sorted by the most recent over due book