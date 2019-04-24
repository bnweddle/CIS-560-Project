# Set-ExecutionPolicy RemoteSigned
# Install-Module sqlserver
# Update-Module sqlserver
# Import-Module sqlserver

<#

For this script to work, you must have created already created the database
If you haven't created the database, you will get the following error:

	Cannot open database "DatabaseNameHere" requested by the login.
#>

Param(
   [string] $Server = "(localdb)\MSSQLLocalDb",
   [string] $Database = "LocalDB"
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
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Tables\Member.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Tables\Author.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Tables\Title.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Tables\Book.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Tables\ItemsOut.sql"

# Stored Procedures
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Procedures\CreateCheckOut.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Procedures\CreateMember.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Procedures\FindBooksByTitle.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Procedures\FindBooksByAuthor.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Procedures\GetMemberByEmail.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Procedures\GetTitleByLibraryID.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Procedures\ReportMostPopularBooks.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Procedures\ReportNumberOfBooks.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Procedures\ReportOverDueBooks.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Procedures\ReportTopTenAuthors.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Procedures\RetrieveCheckedOutBooksForMember.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Procedures\RetrieveLibraryByName.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Procedures\UpdateReturnDate.sql"

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