CREATE OR ALTER PROCEDURE Libraries.GetMemberForEmail
   @Email NVARCHAR(128)
AS

SELECT M.MemberID
FROM Libraries.Member M
WHERE M.Email = @Email;
GO