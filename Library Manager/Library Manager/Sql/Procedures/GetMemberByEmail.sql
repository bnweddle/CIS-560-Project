/*Based on the Email the user gives checks to see if member exists and if so returns 
 all information for that specific member*/
CREATE OR ALTER PROCEDURE Libraries.GetMemberForEmail
   @Email NVARCHAR(128)
AS

SELECT M.MemberID, M.LibraryID, M.FirstName, M.LastName, M.Phone
FROM Libraries.Member M
WHERE M.Email = @Email;
GO