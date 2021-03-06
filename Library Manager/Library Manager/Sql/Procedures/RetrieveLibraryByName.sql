﻿/*Retrieves the information of the specific library applied by the user*/
CREATE OR ALTER PROCEDURE Libraries.RetrieveLibraryByName
	@LibraryName NVARCHAR(265)
AS

SELECT L.LibraryID, L.[State], L.City
FROM Libraries.[Library] L
WHERE L.Name = @LibraryName