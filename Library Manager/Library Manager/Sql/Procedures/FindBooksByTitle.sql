CREATE OR ALTER PROCEDURE Libraries.FindBooksByTitle
	@TitleNamePattern NVARCHAR(265)
AS
SELECT T.TitleID, T.ISBN, T.[Name], T.AuthorID, T.PublicationYear
FROM Libraries.Title T
WHERE T.[Name] LIKE '%' + @TitleNamePattern + '%'