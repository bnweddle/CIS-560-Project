CREATE OR ALTER PROCEDURE Libraries.GetMemberEmail
   @Email NVARCHAR(128)
AS

SELECT M.Email
FROM Libraries.Member M
WHERE M.Email = @Email;
GO