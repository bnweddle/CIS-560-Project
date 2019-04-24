CREATE OR ALTER PROCEDURE Libraries.FindBooksByTitle
	@TitleNamePattern NVARCHAR(265),
	@MemberID INT
AS
SELECT T.TitleID, T.ISBN, T.[Name], T.AuthorID, T.PublicationYear
FROM Libraries.Title T
	INNER JOIN Libraries.Book B ON B.TitleID = T.TitleID
		AND B.Quantity > 0
	INNER JOIN Libraries.ItemsOut I ON I.BookID = B.BookID
		AND I.ReturnedDate IS NOT NULL
	INNER JOIN Libraries.[Library] L ON L.LibraryID = B.LibraryID
	INNER JOIN Libraries.Member M ON M.LibraryID = L.LibraryID
		AND M.MemberID = @MemberID
WHERE T.[Name] LIKE '%' + @TitleNamePattern + '%'