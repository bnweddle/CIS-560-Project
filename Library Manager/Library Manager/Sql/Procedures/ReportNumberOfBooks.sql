CREATE OR ALTER PROCEDURE Libraries.ReportNumberOfBooks
AS

SELECT L.[Name], T.[Name], B.Quantity,
	SUM(B.Quantity) OVER(PARTITION BY T.TitleID) TotalNumOfBooks
FROM Libraries.Book B
	INNER JOIN Libraries.Library L ON L.LibraryID = B.LibraryID
	INNER JOIN Libraries.Title T ON T.TitleID = B.TitleID
GROUP BY T.[Name], B.Quantity, L.[Name], T.TitleID


--REPORT QUERY
--Reports the total number of each book from all libraries, the quantity of books at each library
--Gives the Name of the library and the Name of the Book
