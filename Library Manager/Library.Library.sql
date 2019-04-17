IF OBJECT_ID(N'Libraries.Library') IS NULL
BEGIN
   CREATE TABLE Libraries.Library
   (
		LibraryID INT NOT NULL IDENTITY(1,1), 
		[Name] NVARCHAR(256) NOT NULL UNIQUE,
		City NVARCHAR(64) NOT NULL,
		[State] NVARCHAR(64) NOT NULL,

      CONSTRAINT [PK_Libraries_Library_LibrayID] PRIMARY KEY CLUSTERED
      (
         LibraryID ASC
      )  
   );
END;

/*Unique Key Constraits*/
IF NOT EXISTS
   (
      SELECT *
      FROM sys.key_constraints kc
      WHERE kc.parent_object_id = OBJECT_ID(N'Libraries.Library')
         AND kc.[name] = N'UK_Libraries_Library_Name'
   )
BEGIN
   ALTER TABLE Libraries.Library
   ADD CONSTRAINT [UK_Library_Library_Name] UNIQUE NONCLUSTERED
	(
		[Name] ASC
	)
END;