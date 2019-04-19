CREATE OR ALTER PROCEDURE Libraries.CheckedOutBooksForMember
	@MemberID INT
AS

SELECT L.[Name], T.[Name], I.CheckedOutDate, I.DueBackDate
FROM Libraries.ItemsOut I
	INNER JOIN Libraries.Member M ON M.MemberID = I.MemberID
		AND M.MemberID = @MemberID
	INNER JOIN Libraries.Library L On L.LibraryID = M.LibraryID
	INNER JOIN Libraries.Book B ON B.BookID = I.BookID
	INNER JOIN Libraries.Title T ON T.TitleID = B.TitleID
WHERE I.ReturnedDate IS NULL


