﻿/*Returns the list of books the specific member has currently checked out (not returned) and 
 gives all inforamtion connected with each book*/
CREATE OR ALTER PROCEDURE Libraries.CheckedOutBooksForMember
	@MemberID INT
AS

SELECT I.ItemsOutID, M.LibraryID, I.BookID, I.CheckedOutDate, I.DueBackDate, I.ReturnedDate, T.[Name]
FROM Libraries.ItemsOut I
	INNER JOIN Libraries.Member M ON M.MemberID = I.MemberID
		AND M.MemberID = @MemberID
	INNER JOIN Libraries.Book B  ON B.LibraryID = I.LibraryID
		AND B.BookID = I.BookID
	INNER JOIN Libraries.Title T ON T.TitleID = b.TitleID
WHERE I.ReturnedDate IS NULL

