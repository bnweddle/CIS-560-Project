CREATE OR ALTER PROCEDURE Libraries.CheckedOutBooks
AS

SELECT B.LibraryID, T.[Name], M.Email, I.CheckedOutDate, I.DueBackDate
FROM Libraries.ItemsOut I
	INNER JOIN Libraries.Book B ON B.BookID = I.BookID
	INNER JOIN Libraries.Member M ON M.MemberID = I.MemberID
		AND B.LibraryID = M.LibraryID
	INNER JOIN Libraries.Title T ON T.TitleID = B.TitleID
WHERE I.ReturnedDate IS NULL


