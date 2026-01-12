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
-t Me `
-t Mes `
-t AOPPass `
-t CsCrs `
-t CsPerf `
-t CsProfile `
-t CsRtCooling `
-t CsStrategy `
-t DirFmPfcCycShiftP `
-t DirFmPfcCycShiftPPass `
-t DirFmPfcParaP `
-t V_MAT_STRUCT_ENTRY `
-t DPFM `
-t DPHRM `
-t EdLogEnt `
-t EdOrdEnt `
-t EdPhyEnt `
-t IHP `
-t ISCP `
-t ISCPPass `
-t DirFmPfcParaPPass `
-t LP `
-t LPPass `
-t RCP `
-t RCPPass `
-t RGLP `
-t SpOrd2Pc `
-t SpOrd2PcStand `
-t SRP `
-t StdAOP `
-t StdAOPPass `
-t StdCompPlan `
-t StdCsCoilTempOffset `
-t StdCsCrs `
-t StdCsPerf `
-t StdCsProfile `
-t StdCsRtCooling `
-t StdCsStrategy `
-t StdDirFmPfcCycShiftP `
-t StdDirFmPfcCycShiftPPass `
-t StdDirFmPfcParaP `
-t StdDirFmPfcParaPPass `
-t StdDPFM `
-t StdDPHRM `
-t StdDPRampFM `
-t StdDPRampHRM `
-t StdIHP `
-t StdISCP `
-t StdISCPPass `
-t StdLP `
-t StdLPPass `
-t StdRCP `
-t StdRCPPass `
-t StdRGLP `
-t StdRGLPPass `
-t StdSRP `
-t StdSRPPass `
-t StdTP `
-t StdTPPass `
-t StdWMP `
-t StdWMPPass `
-t TP `
-t TPPass `
-t HmiCoil `
-t HMI_V_PRODSEQUENCE_COMPLETE `
-t AggregateSelection `
-t ApsRef `
-t CsPcResults `
-t DPRampFM `
-t DPRampHRM `
-t HMI_V_INLINE_MATERIALS `
-t HMI_V_MAT_INFO_SHORT `
-t HMI_V_ROLL_INVENTORY `
-t Log_Format `
-t Log_Index `
-t Log_Data `
-t MatDat `
-t Defect `
-t HMI_V_PRODSEQUENCE `
-t PlantLimits `
-t PlantParam `
-t RollChamfer `
-t RollClass `
-t RGLPPass `
-t RollData `
-t RollProperty `
-t RollShapeCoeff `
-t RollShapeCurveCustom `
-t SRPPass `
-t Stat_DirFmPfcParaPPass `
-t WMPPass `
-t  CalDss `
-t CalDssAct `
-t CalPade `
-t CalPadeAct `
-t HMI_V_ROLLINGHISTORYSEQ `
-t MosParam `
-t Log_Language_Setup `
-t Log_Colour `
-t Setup_Colour `
-t MosSwitches `
-t ProgParameter `



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
