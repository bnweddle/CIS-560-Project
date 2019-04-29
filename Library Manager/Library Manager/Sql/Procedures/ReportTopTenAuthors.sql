CREATE or ALTER PROCEDURE Libraries.ReportTopTenAuthors
	@MemberID int
as

SELECT TOP(3) WITH TIES COUNT(*) NumOfCheckOuts, a.FirstName, a.LastName, a.MiddleName,
	a.FullName, a.AuthorID
FROM Libraries.Title t
	INNER JOIN Libraries.Author a on a.AuthorID = t.AuthorID
	INNER JOIN Libraries.Book b on b.TitleID = t.TitleID
	INNER JOIN Libraries.ItemsOut I ON I.BookID = b.BookID
WHERE I.MemberID = @MemberID
GROUP BY a.FirstName, a.LastName, a.MiddleName, a.FullName, a.AuthorID
ORDER BY COUNT(*) DESC, a.FirstName desc, a.LastName desc, a.MiddleName desc,
	a.FullName desc, a.AuthorID DESC
    
--REPORT QUERY
--Should return the top three authors for the specific member
--Decides the top three by comparing the num of times a book has been checked out by the member