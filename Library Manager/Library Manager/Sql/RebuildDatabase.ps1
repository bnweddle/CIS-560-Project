# Set-ExecutionPolicy RemoteSigned
# Install-Module sqlserver
# Update-Module sqlserver
# Import-Module sqlserver

Param(
   [string] $Server = "(localdb)\MSSQLLocalDb",
   [string] $Database = "master"
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
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Tables\DropTables.sql"

# Schema
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Tables\Schema.sql"

# Tables
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Tables\Library.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Tables\Members.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Tables\Author.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Tables\Title.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Tables\Book.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Tables\ItemsOut.sql"


# Stored Procedures
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Procedures\Person.CreateCheckOut.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Procedures\Person.CreateMember.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Procedures\Person.FindBooksByTitle.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Procedures\Person.FindBooksByAuthor.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Procedures\Person.GetMemberByEmail.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Procedures\Person.GetTitleByLibrary.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Procedures\Person.ReportMostPopularBooks.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Procedures\Person.ReportNumberOfBooks.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Procedures\Person.ReportOverDueBooks.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Procedures\Person.ReportTopTenAuthors.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Procedures\Person.RetrieveCheckedOutBooksForMember.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Procedures\Person.RetrieveLibraryByName.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Procedures\Person.UpdateReturnDate.sql"

# Data
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Data\TempBooks.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Data\LibraryValues.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Data\MemberValues.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Data\AuthorValues.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Data\TitleValues.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Data\BookValues.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Data\ItemsOutValues.sql"

Write-Host "Rebuild completed."
Write-Host ""
#>