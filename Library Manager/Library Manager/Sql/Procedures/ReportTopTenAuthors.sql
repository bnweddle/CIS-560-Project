CREATE or ALTER PROCEDURE Libraries.ReportTopTenAuthors
@MemberID int
as

SELECT TOP(10) WITH TIES COUNT(*) NumOfCheckOuts, a.FirstName, a.LastName, a.MiddleName,
	a.FullName, a.AuthorID
FROM Libraries.Title t
	INNER JOIN Libraries.Author a on a.AuthorID = t.AuthorID
	INNER JOIN Libraries.Book b on b.TitleID = t.TitleID
	INNER JOIN Libraries.[Library] l on l.LibraryID = b.LibraryID
	INNER JOIN Libraries.Member m on m.LibraryID = l.LibraryID
		AND @MemberID = m.MemberID
GROUP BY a.FirstName, a.LastName, a.MiddleName, a.FullName, a.AuthorID
ORDER BY COUNT(*) DESC, a.FirstName desc, a.LastName desc, a.MiddleName desc,
	a.FullName desc, a.AuthorID desc

--soz ripped this from reportmostpopularbooks