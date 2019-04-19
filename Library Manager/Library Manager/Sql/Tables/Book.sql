CREATE TABLE Libraries.Book
(
	BookID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	LibraryID INT NOT NULL REFERENCES Libraries.Library(LibraryID),
	TitleID INT NOT NULL FOREIGN KEY REFERENCES Libraries.Title(TitleID),
	Quantity INT NOT NULL,

	UNIQUE(LibraryID, BookID),
	UNIQUE(LibraryID,TitleID)
)