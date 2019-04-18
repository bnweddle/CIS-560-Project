CREATE OR ALTER PROCEDURE Libraries.CheckedOutBooks
AS

SELECT L.LibraryID, L.[Name], L.City, L.[State]
FROM Libraries.[Library] L