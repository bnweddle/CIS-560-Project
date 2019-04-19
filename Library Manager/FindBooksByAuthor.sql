CREATE OR ALTER PROCEDURE Libraries.FindBooksByAuthor
	@AuthorID INT
AS
SELECT T.TitleID, T.ISBN, T.[Name], A.FullName, T.PublicationYear
FROM Libraries.Titles T
	INNER JOIN Libraries.Author A ON A.AuthorID = T.AuthorID
		AND T.AuthorID = @AuthorID