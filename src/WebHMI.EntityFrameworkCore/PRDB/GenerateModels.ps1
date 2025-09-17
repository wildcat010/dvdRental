Write-Host "This is a PowerShell script to generate DB entities and context for PRDB database" -ForegroundColor Green

$Env:PROJPATH =''
$Env:projectDir =''
# Path where the powershell script is located
$LocalPath = gl

# Path where the models classes should be written
$PathModels = $LocalPath.ToString() + '\Dbo'

# Path to location where PRDB context file is located
$PathContext = $LocalPath.ToString()

# DB connection string
$DBConnString = 'Server=ESPSTDNCTR\PRDB;Database=PRDB;User Id=sa;Password=X.admin1;TrustServerCertificate=True;'

# The path to the EntityFrameworkCore.csproj file
$ProjectPath = Split-Path $LocalPath -Parent

# Delete old models
$PathModelsToDelete = $PathModels.ToString() + '\*.cs'
Write-Host 'Deleting old models from ' $PathModelsToDelete.ToString()
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

# Change base class from DbContext to AbpDbContext
Write-Host 'Adjusting PrdbContext file to project requirements...'

$PathModelContext = $PathContext.ToString() + '\PrdbContext.cs'
((Get-Content -path $PathModelContext -Raw) -replace ' DbContext',' AbpDbContext') | Set-Content -Path $PathModelContext

# Add ABP using statement
$UsingDirective = "using Abp.EntityFrameworkCore;"
$Content = Get-Content -Path $PathModelContext -Raw -Encoding UTF8
$NewContent = $UsingDirective + "`n" + $Content

#Save changes to PrdbContext.cs
$retryCount = 0
$success = $false

while (-not $success -and $retryCount -lt 5) {
  try {
    $NewContent | Set-Content -Path $PathModelContext -Encoding UTF8
    $success = $true
  } catch {
		Write-Host 'Failed to update PrdbContext file, retrying...' -ForegroundColor Red
    Start-Sleep -Seconds 1
    $retryCount++
  }
}

if (-not $success) {
  Write-Host "Failed to write to $PathModelContext after several attempts." -ForegroundColor Red
} else {
	Write-Host 'EF Core models regenerated' -ForegroundColor Green
}

pause
