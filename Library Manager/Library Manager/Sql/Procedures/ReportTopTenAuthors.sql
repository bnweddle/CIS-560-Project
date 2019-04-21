CREATE or ALTER PROCEDURE Libraries.ReportTopTenAuthors
as

SELECT TOP(10) WITH TIES COUNT(*) NumOfCheckOuts, a.FirstName, a.LastName
FROM Libraries.Title t
	INNER JOIN Libraries.Author a on a.AuthorID = t.AuthorID
GROUP BY a.FirstName, a.LastName
ORDER BY COUNT(*) DESC, a.FirstName desc, a.LastName desc

--soz ripped this from reportmostpopularbooks