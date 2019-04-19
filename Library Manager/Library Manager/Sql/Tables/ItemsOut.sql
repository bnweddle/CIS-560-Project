CREATE TABLE Libraries.ItemsOut
(
	ItemsOutID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	BookID INT NOT NULL REFERENCES Libraries.Book(BookID),
	LibraryID INT NOT NULL,
	MemberID INT NOT NULL,
	CheckedOutDate DATETIME NOT NULL,
	DueBackDate DATETIME NOT NULL,
	ReturnedDate DATETIME NULL,
	
	FOREIGN KEY(LibraryID, MemberID)
	REFERENCES Libraries.Member(LibraryID, MemberID),

	FOREIGN KEY(LibraryID, BookID)
	REFERENCES Libraries.Book(LibraryID, BookID)
)