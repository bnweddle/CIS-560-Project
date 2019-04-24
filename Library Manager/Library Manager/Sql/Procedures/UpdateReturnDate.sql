CREATE OR ALTER PROCEDURE Libraries.UpdateReturnDate
	@ItemsOutID INT
AS

UPDATE Libraries.ItemsOut 
SET ReturnedDate = GETDATE()
FROM Libraries.ItemsOut I
WHERE I.ItemsOutID = @ItemsOutID
	AND I.ReturnedDate IS NULL

/*Updates the returned date of a book from given ID*/