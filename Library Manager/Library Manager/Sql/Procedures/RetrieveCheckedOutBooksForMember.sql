CREATE OR ALTER PROCEDURE Libraries.CheckedOutBooksForMember
	@MemberID INT
AS

SELECT T.ItemsOutID, I.LibraryID, I.BookID, I.CheckedOutDate, I.DueBackDate, I.ReturnedDate
FROM Libraries.ItemsOut I
	INNER JOIN Libraries.Member M ON M.MemberID = I.MemberID
		AND M.MemberID = @MemberID
WHERE I.ReturnedDate IS NULL


