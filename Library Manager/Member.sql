IF OBJECT_ID(N'Libraries.Member') IS NULL
BEGIN
   CREATE TABLE Libraries.Member
   (
		MemberID INT NOT NULL IDENTITY(1,1),
		LibraryID INT NOT NULL REFERENCES Libraries.Library(LibraryID),
		FirstName NVARCHAR(32) NOT NULL,
		LastName NVARCHAR(32) NOT NULL,
		Email NVARCHAR(128) NOT NULL,
		Phone NVARCHAR(64) NOT NULL,

		UNIQUE(MemberID, Email),
		UNIQUE(LibraryID, MemberID),

       CONSTRAINT [PK_Libraries_Member_MemberID] PRIMARY KEY CLUSTERED
       (
	       MemberID ASC
       )  
   );
END;


