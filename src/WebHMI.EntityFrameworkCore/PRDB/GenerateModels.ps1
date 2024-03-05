Write-Host "This is a PowerShell script to generate DB entities and context for PRDB database" -ForegroundColor Green

# Path where the powershell script is located
$LocalPath = gl

# Path where the models classes should be written
$PathModels = $LocalPath.ToString() + '\..\..\WebHMI.Core\Prdb\'

# Path to location where PRDB context file is located
$PathContext = $LocalPath.ToString()

# Oracle DB connection string
$DBConnString = 'Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=ML-NCTR-SRV02)(PORT=1521))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=prdb)));User Id=PRDB;Password=a423pa;'

# The path to the EntityFrameworkCore.csproj file
$ProjectPath = $LocalPath.ToString() + '\..\'

# Delete old models
Write-Host 'Deleting old models...'
$PathModelsToDelete = $PathModels.ToString() + '*.cs'
DEL $PathModelsToDelete

# Generate models with EF scaffold tool
Write-Host 'Generating new models...'

dotnet ef dbcontext scaffold $DBConnString Oracle.EntityFrameworkCore `
--project $ProjectPath `
--context-dir $PathContext `
--output-dir $PathModels `
--namespace 'WebHMI.PRDB' `
--context-namespace 'WebHMI.PRDB' `
--context 'PrdbContext' `
--force `
--no-build `
--no-onconfiguring `
-t STDDIRDCCOILER `

# Change base class from DbContext to AbpDbContext
Write-Host 'Adjusting PrdbContext file to project requirements...'

$PathModelContext = $PathContext.ToString() + '\PrdbContext.cs'
((Get-Content -path $PathModelContext -Raw) -replace ' DbContext',' AbpDbContext') | Set-Content -Path $PathModelContext

# Add ABP using statement
$UsingDirective = "using Abp.EntityFrameworkCore;"
$Content = Get-Content -Path $PathModelContext -Raw -Encoding UTF8
$NewContent = $UsingDirective + "`n" + $Content
$NewContent | Set-Content -Path $PathModelContext -Encoding UTF8

Write-Host 'EF Core models regenerated' -ForegroundColor Green
pause
