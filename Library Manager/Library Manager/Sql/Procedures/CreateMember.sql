CREATE OR ALTER PROCEDURE Libraries.CreateMember
   @MemberID INT OUTPUT,
   @LibraryID INT,
   @FirstName NVARCHAR(32),
   @LastName NVARCHAR(32),
   @Email NVARCHAR(128),
   @Phone NVARCHAR(64)
AS

INSERT Libraries.Member(LibraryID, FirstName, LastName, Email, Phone)
VALUES(@LibraryID, @FirstName, @LastName, @Email, @Phone)

SET @MemberID = SCOPE_IDENTITY();