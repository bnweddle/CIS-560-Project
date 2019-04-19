CREATE OR ALTER PROCEDURE Libraries.RetrieveLibraries
	@LibraryID INT
AS

SELECT L.LibraryID, L.[Name], L.City, L.[State]
FROM Libraries.[Library] L
WHERE L.LibraryID = @LibraryID