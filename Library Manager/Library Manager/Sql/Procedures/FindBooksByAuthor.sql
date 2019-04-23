CREATE OR ALTER PROCEDURE Libraries.FindBooksByAuthor
	@AuthorNamePattern NVARCHAR(255)
	--DataDelegate "%" + AuthorNamePattern + "%"
AS

SELECT T.TitleID, T.ISBN, T.[Name], A.FullName, T.PublicationYear, T.AuthorID
FROM Libraries.Author A
	INNER JOIN Libraries.Title T ON T.AuthorID = A.AuthorID
		AND (A.FullName LIKE '%' + @AuthorNamePattern + '%')