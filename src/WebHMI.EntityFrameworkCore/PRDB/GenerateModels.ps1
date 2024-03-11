Write-Host "This is a PowerShell script to generate DB entities and context for PRDB database" -ForegroundColor Green

# Path where the powershell script is located
$LocalPath = gl

# Path where the models classes should be written
$PathModels = $LocalPath.ToString() + '\dbo'

# Path to location where PRDB context file is located
$PathContext = $LocalPath.ToString()

# DB connection string
#$DBConnString = 'Driver={ODBC Driver 17 for SQL Server}; server=L2NCTR\PRJ_01; database=PRDB; Uid=prdb; Pwd=a423pa'
$DBConnString = 'Server=L2NCTR\PRJ_01;Database=PRDB;User Id=prdb;Password=a423pa;TrustServerCertificate=True;'

# The path to the EntityFrameworkCore.csproj file
$ProjectPath = $LocalPath.ToString() + '\..\'

# Delete old models
Write-Host 'Deleting old models...'
$PathModelsToDelete = $PathModels.ToString() + '*.cs'
DEL $PathModelsToDelete

# Generate models with EF scaffold tool
Write-Host 'Generating new models...'

dotnet ef dbcontext scaffold $DBConnString Microsoft.EntityFrameworkCore.SqlServer `
--project $ProjectPath `
--context-dir $PathContext `
--output-dir $PathModels `
--namespace 'WebHMI.PRDB.Dbo' `
--context-namespace 'WebHMI.PRDB' `
--context 'PrdbContext' `
--force `
--no-build `
--no-onconfiguring `
#-t STDDIRDCCOILER `
#-t V_MAT_STRUCT_ENTRY `
#-t LOG_INDEX `
#-t LOG_FORMAT `

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
