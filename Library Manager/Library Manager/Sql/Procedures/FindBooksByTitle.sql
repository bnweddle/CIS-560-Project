﻿/*returns many or a few books based on the entry the user gives and searches through all 
possible titles where there are still available books for the user to check out by 
comparing the Num of CheckedOut books with the Quantity the specific library holds*/ 
CREATE OR ALTER PROCEDURE Libraries.FindBooksByTitle
	@TitleNamePattern NVARCHAR(265),
	@LibraryID INT
AS
SELECT COUNT(I.ItemsOutID) CheckedOut, B.Quantity - COUNT(I.ItemsOutID) AS Available,T.TitleID, A.FullName, T.ISBN, T.[Name], T.PublicationYear AS Published, B.Quantity
FROM Libraries.Title T
	INNER JOIN Libraries.Author A ON A.AuthorID = T.AuthorID
	INNER JOIN Libraries.Book B ON B.TitleID = T.TitleID
	LEFT JOIN Libraries.ItemsOut I ON I.BookID = B.BookID
		AND I.ReturnedDate IS NULL
WHERE B.LibraryID = @LibraryID
	AND T.[Name] LIKE '%' + @TitleNamePattern + '%'
GROUP BY T.TitleID, A.FullName, T.ISBN, T.[Name], T.PublicationYear, B.Quantity
