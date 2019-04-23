CREATE OR ALTER PROCEDURE Libraries.FindBooksByTitle
	@TitleNamePattern NVARCHAR(265)
AS
SELECT T.TitleID, T.ISBN, T.[Name], A.FullName, T.PublicationYear
FROM Libraries.Title T
	INNER JOIN Libraries.Author A ON A.AuthorID = T.AuthorID
		AND T.[Name] LIKE '%' + @TitleNamePattern + '%'