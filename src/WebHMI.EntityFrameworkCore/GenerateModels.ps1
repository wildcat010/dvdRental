Write-Host "This is a PowerShell script to generate DB entities and context for WebHMI project"
#Path where the powershell script is located. It is expected to be in project WebHMI.API.EntityFrameworkCore root folder
$LocalPath = gl
#Path where the models classes should be written
$PathModels = $LocalPath.ToString() + '\..\WebHMI.Core\Prdb\'
#Path to location where PRDB context file is located
$PathContext = $LocalPath.ToString() + '\PRDB'
$ModelsName = 'PrdbContext'
$ModelsNamespace = 'WebHMI.Prdb'
$ContextNamespace =  'WebHMI.PRDB'
$PathModelsToDelete = $PathModels.ToString() + '*.cs'
Write-Host 'Deleting old models from ' $PathModelsToDelete.ToString()
DEL $PathModelsToDelete

#DB connection string, here a TNS name for Oracle 19 DB with user and password
Write-Host 'Running scaffold on database objects to genereate models and context'
$DBConnString = 'Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=ML-NCTR-SRV02)(PORT=1521))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=prdb)));User Id=PRDB;Password=a423pa;'

#generate models with EF scaffold tool
dotnet ef dbcontext scaffold $DBConnString Oracle.EntityFrameworkCore `
--context-dir $PathContext `
--output-dir $PathModels `
--namespace $ModelsNamespace `
--context-namespace $ContextNamespace `
--context $ModelsName `
--force `
--no-build `
--no-onconfiguring `
-t SPORD1PC `

Write-Host 'Adjusting PrdbContext.cs file to project requirements...'

#change base class from DbContext to AbpDbContext
$PathModelContext = $PathContext.ToString() + '\PrdbContext.cs'
((Get-Content -path $PathModelContext -Raw) -replace ' DbContext',' AbpDbContext') | Set-Content -Path $PathModelContext

#remove lines 11 to 13 with paremeterless constructor  public PrdbContext() from just generated PrdbContext.cs file, line index is 0 based
#$lines = [IO.File]::ReadAllLines($PathModelContext)
#Set-Content -Encoding UTF8 $PathModelContext -Value $lines[0..9 + 14..($lines.Count-1)]

# Add using statement
$UsingDirective = "using Abp.EntityFrameworkCore;"
$Content = Get-Content -Path $PathModelContext -Raw -Encoding UTF8
$NewContent = $UsingDirective + "`n" + $Content
$NewContent | Set-Content -Path $PathModelContext -Encoding UTF8

Write-Host 'EF Core models regenerated'
pause
