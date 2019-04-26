IF NOT EXISTS
   (
      SELECT *
      FROM sys.schemas s
      WHERE s.[name] = N'Libraries'
   )
BEGIN
   EXEC(N'CREATE SCHEMA [Libraries] AUTHORIZATION [dbo]');
END;

--CREATE SCHEMA Libraries