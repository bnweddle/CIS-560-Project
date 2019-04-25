CREATE OR ALTER PROCEDURE Libraries.FindBooksByAuthor
	@AuthorNamePattern NVARCHAR(255),
	@MemberID INT
AS

SELECT T.TitleID, T.ISBN, T.[Name], A.FullName, T.PublicationYear, T.AuthorID
FROM Libraries.Book B
	INNER JOIN Libraries.Title T ON T.TitleID = B.TitleID
	INNER JOIN Libraries.Author A ON A.AuthorID = T.AuthorID
		AND A.FullName LIKE '%' + @AuthorNamePattern + '%'
	INNER JOIN Libraries.ItemsOut I ON I.BookID = B.BookID
		AND I.ReturnedDate IS NOT NULL
	INNER JOIN Libraries.Member M ON M.LibraryID = B.LibraryID
		AND M.MemberID = @MemberID