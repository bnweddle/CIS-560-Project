--Might need this/Might not: ignore for now
CREATE OR ALTER PROCEDURE Libraries.GetTitleByLibraries
	@LibraryID INT
AS 

SELECT T.[Name]
FROM Libraries.Title T
	INNER JOIN Libraries.Book B ON B.TitleID = T.TitleID
		AND B.LibraryID  = @LibraryID