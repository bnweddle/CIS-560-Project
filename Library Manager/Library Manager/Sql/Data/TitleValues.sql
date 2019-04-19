INSERT Libraries.Title(A.AuthorID, ISBN, [Name], PublicationYear)
SELECT A.AuthorID, B.ISBN, B.Title, B.YearOfPublication
FROM dbo.Books B
	INNER JOIN Libraries.Author A ON A.FullName = B.Author