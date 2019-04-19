DECLARE @StartDate DATETIME = '03-01-2019';

WITH SourceCte(BookId, MemberId, LibraryID, Quantity,
	CheckOutDate, DueDate, ReturnDate, CheckedOutOccurrence) AS
(
	SELECT B.BookID, M.MemberID, B.LibraryID, B.Quantity,
		DATEADD(DAY, DC.CheckedOut, @StartDate) AS CheckedOutDate,
		DATEADD(DAY, 20, DATEADD(DAY, DC.CheckedOut, @StartDate)) AS DateDueBack,
		IIF(R.Returned = 0, NULL, DATEADD(DAY, R.Returned, DATEADD(DAY, DC.CheckedOut, @StartDate))) AS ReturnedDate,
		ROW_NUMBER() OVER(PARTITION BY B.BookID ORDER BY (CHECKSUM(NEWID()))) AS CheckedOutOccurrence 
	FROM Libraries.Book B
		INNER JOIN Libraries.Member M ON M.LibraryID = B.LibraryID
		CROSS APPLY 
		(
			VALUES(B.LibraryID * B.BookID % 31)
		) DC(CheckedOut)
		CROSS APPLY 
		(
			VALUES(B.LibraryID * M.MemberID % 22)
		) R (Returned)
	WHERE R.Returned >= 0
) 
INSERT Libraries.ItemsOut(BookID, MemberID, LibraryID, CheckedOutDate, DueBackDate, ReturnedDate)
SELECT S.BookId, S.MemberId, S.LibraryID, S.CheckOutDate, S.DueDate, S.ReturnDate
FROM SourceCte S
WHERE S.CheckedOutOccurrence <= S.Quantity 