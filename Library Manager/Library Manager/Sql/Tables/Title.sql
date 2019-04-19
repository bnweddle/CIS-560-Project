﻿CREATE TABLE Libraries.Title
(
	TitleID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	ISBN NVARCHAR(13) NOT NULL CONSTRAINT UK_Libraries_Title_ISBN UNIQUE NONCLUSTERED,
	AuthorID INT NOT NULL FOREIGN KEY REFERENCES Libraries.Author(AuthorID),
	[Name] NVARCHAR(265) NOT NULL,
	PublicationYear SMALLINT NOT NULL
)