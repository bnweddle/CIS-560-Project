/*Updates the returned date of a book to the current date/date user returned the book
from given item out Id */
CREATE OR ALTER PROCEDURE Libraries.UpdateReturnDate
	@ItemsOutID INT
AS

UPDATE Libraries.ItemsOut 
SET ReturnedDate = GETDATE()
FROM Libraries.ItemsOut I
WHERE I.ItemsOutID = @ItemsOutID
	AND I.ReturnedDate IS NULL

