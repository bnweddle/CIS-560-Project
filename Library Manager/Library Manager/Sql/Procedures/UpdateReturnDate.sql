CREATE PROCEDURE Libraries.UpdateReturnDate
	@ItemsOutID INT
AS

UPDATE Libraries.ItemsOut 
SET ReturnedDate = GETDATE()
WHERE ItemsOutID = @ItemsOutID
	AND ReturnedDate IS NULL

/*Updates the returned date of a book from given ID*/