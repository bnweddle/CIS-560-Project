INSERT Libraries.Author(FullName, FirstName, MiddleName, LastName)
SELECT DISTINCT B.Author,
	IIF(
		FS.FirstSeparator <= 0,
		N'',
		SUBSTRING(B.Author, 1, FS.FirstSeparator - 1)) AS FirstName,
	IIF(
		FS.FirstSeparator <= 0 OR SS.SecondSeparator <= 0,
		N'',
		SUBSTRING(B.Author, FS.FirstSeparator + 1, SS.SecondSeparator - FS.FirstSeparator - 1)) AS MiddleName,
	CASE
		WHEN FS.FirstSeparator <= 0 THEN B.Author
		WHEN SS.SecondSeparator <= 0 THEN SUBSTRING(B.Author, FS.FirstSeparator + 1, 255)
		ELSE SUBSTRING(B.Author, SS.SecondSeparator + 1, 255)
	END AS LastName
FROM dbo.Books B
	CROSS APPLY
		(
			VALUES
				(
					CHARINDEX(N' ', B.Author, 1)
				)
		) FS(FirstSeparator)
	CROSS APPLY
		(
			VALUES
				(
					IIF(FS.FirstSeparator <= 0, 0, CHARINDEX(N' ', B.Author, FS.FirstSeparator + 1))
				)
		) SS(SecondSeparator);