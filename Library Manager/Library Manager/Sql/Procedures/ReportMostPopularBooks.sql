CREATE OR ALTER PROCEDURE Libraries.ReportMostPopularBooks
AS 

SELECT TOP(10) WITH TIES COUNT(*) NumOfCheckOuts, T.[Name],
	MAX(I.CheckedOutDate) AS LastCheckedOut,
	MAX(T.PublicationYear) AS NewerBooks
FROM Libraries.Title T
	INNER JOIN Libraries.Book B ON B.TitleID = T.TitleID
	INNER JOIN Libraries.ItemsOut I ON I.BookID = B.BookID
GROUP BY T.TitleID, T.[Name]
ORDER BY COUNT(*) DESC, MAX(I.CheckedOutDate) DESC, MAX(T.PublicationYear) DESC

--REPORT QUERY
--Retrieves the most checked out books by latest publication date, and latest checked out date
--displays the number of times books have been checked out, name of book, 
--latest check out date, and latest release date
