CREATE OR ALTER PROCEDURE Libraries.FindBooksByTitle
	@TitleNamePattern NVARCHAR(265),
	@MemberID INT
AS
SELECT DISTINCT T.TitleID, T.ISBN, T.[Name], T.PublicationYear, T.AuthorID
FROM Libraries.Book B
	INNER JOIN Libraries.Title T ON T.TitleID = B.TitleID
		AND T.[Name] LIKE '%' + @TitleNamePattern + '%'
	INNER JOIN Libraries.ItemsOut I ON I.BookID = B.BookID
		AND I.ReturnedDate IS NOT NULL
	INNER JOIN Libraries.Member M ON M.LibraryID = B.LibraryID
		AND M.MemberID = @MemberID
