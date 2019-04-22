Param(
   [string] $Server = "(localdb)\MSSQLLocalDb",
   [string] $Database = "LibraryDB"
)

# This script requires the SQL Server module for PowerShell.
# The below commands may be required.

# To check whether the module is installed.
# Get-Module -ListAvailable -Name Sqlps;

# Install the SQL Server Module
# Install-module -Name SqlServer -Scope CurrentUser

# Import the SQL Server Module.    
# Import-Module Sqlps -DisableNameChecking;

Write-Host ""
Write-Host "Rebuilding database $Database on $Server..."

# Drop Tables
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Sql\Tables\DropTables.sql"

# Schema
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Sql\Tables\Schema.sql"

# Tables
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Sql\Tables\Library.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Sql\Tables\Members.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Sql\Tables\Author.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Sql\Tables\Title.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Sql\Tables\Book.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Sql\Tables\ItemsOut.sql"


# Stored Procedures
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Sql\Procedures\Person.CreateCheckOut.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Sql\Procedures\Person.CreateMember.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Sql\Procedures\Person.FindBooksByTitle.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Sql\Procedures\Person.FindBooksByAuthor.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Sql\Procedures\Person.GetMemberByEmail.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Sql\Procedures\Person.GetTitleByLibrary.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Sql\Procedures\Person.ReportMostPopularBooks.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Sql\Procedures\Person.ReportNumberOfBooks.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Sql\Procedures\Person.ReportOverDueBooks.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Sql\Procedures\Person.ReportTopTenAuthors.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Sql\Procedures\Person.RetrieveCheckedOutBooksForMember.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Sql\Procedures\Person.RetrieveLibraryByName.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Sql\Procedures\Person.UpdateReturnDate.sql"

# Data
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Sql\Data\TempBooks.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Sql\Data\LibraryValues.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Sql\Data\MemberValues.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Sql\Data\AuthorValues.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Sql\Data\TitleValues.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Sql\Data\BookValues.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Sql\Data\ItemsOutValues.sql"

Write-Host "Rebuild completed."
Write-Host ""
