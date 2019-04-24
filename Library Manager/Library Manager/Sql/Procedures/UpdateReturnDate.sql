CREATE OR ALTER PROCEDURE Libraries.UpdateReturnDate
	@TitleID INT
AS

UPDATE Libraries.ItemsOut 
SET ReturnedDate = GETDATE()
FROM Libraries.Title T
	INNER JOIN Libraries.Book B ON B.TitleID = T.TitleID
	INNER JOIN Libraries.ItemsOut I ON I.BookID = B.BookID
WHERE T.TitleID = @TitleID
	AND I.ReturnedDate IS NULL

/*Updates the returned date of a book from given ID*/