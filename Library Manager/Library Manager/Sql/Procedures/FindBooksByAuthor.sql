CREATE OR ALTER PROCEDURE Libraries.FindBooksByAuthor
	@AuthorNamePattern NVARCHAR(255),
	@LibraryID INT
AS

SELECT COUNT(I.ItemsOutID) CheckedOut, B.Quantity - COUNT(I.ItemsOutID) AS Available,T.TitleID, A.FullName, T.ISBN, T.[Name], T.PublicationYear AS Published, B.Quantity
FROM Libraries.Title T
	INNER JOIN Libraries.Author A ON A.AuthorID = T.AuthorID
	INNER JOIN Libraries.Book B ON B.TitleID = T.TitleID
	LEFT JOIN Libraries.ItemsOut I ON I.BookID = B.BookID
		AND I.ReturnedDate IS NULL
WHERE B.LibraryID = @LibraryID
	AND A.FullName LIKE '%' + @AuthorNamePattern + '%'
GROUP BY T.TitleID, A.FullName, T.ISBN, T.[Name], T.PublicationYear, B.Quantity