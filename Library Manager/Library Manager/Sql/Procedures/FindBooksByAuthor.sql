CREATE OR ALTER PROCEDURE Libraries.FindBooksByAuthor
	@AuthorNamePattern NVARCHAR(255),
	@MemberID INT
AS

SELECT T.TitleID, T.ISBN, T.[Name], A.FullName, T.PublicationYear, T.AuthorID
FROM Libraries.Author A
	INNER JOIN Libraries.Title T ON T.AuthorID = A.AuthorID
	INNER JOIN Libraries.Book B ON B.TitleID = T.TitleID
	INNER JOIN Libraries.ItemsOut I ON I.BookID = B.BookID
		AND I.ReturnedDate IS NOT NULL
		AND I.LibraryID = B.LibraryID
		AND B.Quantity > 0
	INNER JOIN Libraries.Member M ON M.LibraryID = B.LibraryID
		AND M.MemberID = @MemberID
WHERE (A.FullName LIKE '%' + @AuthorNamePattern + '%')