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
$DBConnString = 'Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=L2NCTR)(PORT=1521))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=prdb)));User Id=PRDB;Password=a423pa;'

# The path to the EntityFrameworkCore.csproj file
$ProjectPath = Split-Path $LocalPath -Parent

# Delete old models
$PathModelsToDelete = $PathModels.ToString() + '\*.cs'
Write-Host 'Deleting old models from ' $PathModelsToDelete.ToString()
DEL $PathModelsToDelete

# Generate models with EF scaffold tool
Write-Host 'Generating new models...'

dotnet ef dbcontext scaffold $DBConnString Oracle.EntityFrameworkCore `
--project $ProjectPath `
--context-dir $PathContext `
--output-dir $PathModels `
--namespace 'WebHMI.PRDB.Dbo' `
--context-namespace 'WebHMI.PRDB' `
--context 'PrdbContext' `
--force `
--no-build `
--no-onconfiguring `
-t ME `
-t MES `
-t AOPPASS `
-t ADORD2PC `
-t ADORD2PCSTAND `
-t CSCRS `
-t CSPERF `
-t CSPROFILE `
-t CSRTCOOLING `
-t CSSTRATEGY `
-t DIRFMPFCCYCSHIFTP `
-t DIRFMPFCCYCSHIFTPPASS `
-t DIRFMPFCPARAP `
-t V_MAT_STRUCT_ENTRY `
-t DPFM `
-t DPHRM `
-t EDLOGENT `
-t EDORDENT `
-t EDPHYENT `
-t IHP `
-t ISCP `
-t ISCPPASS `
-t DIRFMPFCPARAPPASS `
-t LP `
-t LPPASS `
-t RCP `
-t RCPPASS `
-t RGLP `
-t SPORD2PC `
-t SPORD2PCSTAND `
-t SRP `
-t STDAOP `
-t STDAOPPASS `
-t STDCOMPPLAN `
-t STDCSCOILTEMPOFFSET `
-t STDCSCRS `
-t STDCSPERF `
-t STDCSPROFILE `
-t STDCSRTCOOLING `
-t STDDIRFMPFCCYCSHIFTP `
-t STDDIRFMPFCCYCSHIFTPPASS `
-t STDDIRFMPFCPARAP `
-t STDDIRFMPFCPARAPPASS `
-t STDDPFM `
-t STDDPHRM `
-t STDDPRAMPFM `
-t STDDPRAMPHRM `
-t STDIHP `
-t STDISCP `
-t STDISCPPASS `
-t STDLP `
-t STDLPPASS `
-t STDRCP `
-t STDRCPPASS `
-t STDRGLP `
-t STDRGLPPASS `
-t STDSRP `
-t STDSRPPASS `
-t STDTP `
-t STDTPPASS `
-t STDWMP `
-t STDWMPPASS `
-t STDPC `
-t STDPCRAMP `
-t TP `
-t TPPASS `
-t HMICOIL `
-t HMI_V_PRODSEQUENCE `
-t HMI_V_PRODSEQUENCE_COMPLETE `
-t AGGREGATESELECTION `
-t APSREF `
-t CSPCRESULTS `
-t DPRAMPFM `
-t DPRAMPHRM `
-t HMI_V_INLINE_MATERIALS `
-t HMI_V_MAT_INFO_SHORT `
-t HMI_V_ROLL_INVENTORY `
-t LOG_FORMAT `
-t LOG_INDEX `
-t LOG_DATA `
-t MATDAT `
-t DEFECT `
-t PLANTLIMITS `
-t PLANTPARAM `
-t ROLLCHAMFER `
-t ROLLCLASS `
-t RGLPPASS `
-t ROLLDATA `
-t ROLLPROPERTY `
-t ROLLSHAPECOEFF `
-t ROLLSHAPECURVECUSTOM `
-t SRPPASS `
-t STAT_DIRFMPFCPARAPPASS `
-t WMPPASS `
-t CALDSS `
-t CALDSSACT `
-t CALPADE `
-t CALPADEACT `
-t HMI_V_ROLLINGHISTORYSEQ `
-t MOSPARAM `
-t LOG_LANGUAGE_SETUP `
-t LOG_COLOUR `
-t SETUP_COLOUR `
-t MOSSWITCHES `
-t PROGPARAMETER `
-t STAT_ADORD1PC `
-t STAT_ADORD2PC `
-t STAT_ADORD2PCSTAND `
-t STAT_ADORDENT `
-t STAT_CSCOILTEMPOFFSET `
-t STAT_CSCRS `
-t STAT_CSEDGEMASKING `
-t STAT_CSPERF `
-t STAT_CSPROFILE `
-t STAT_CSRTCOOLING `
-t STAT_CSSTRATEGY `
-t STAT_DIRFMPFCCYCSHIFTP `
-t STAT_DIRFMPFCCYCSHIFTPPASS `
-t STAT_DIRFMPFCPARAP `
-t STAT_DIRFMPFCPARAPPASS `
-t STAT_EDLOGENT `
-t STAT_EDORDENT `
-t STAT_EDPHYENT `
-t STAT_LPPASS `
-t STAT_MSMDIR `
-t STAT_SPLOGENT `
-t STAT_SPORD1PCSTAND `
-t STAT_SPORD2PC `
-t STAT_SPORD2PCSTAND `
-t STAT_SPORDENT `
-t STAT_SPPHYENT `
-t CSPROFILE `
-t CSSTRATEGY `
-t CSRTCOOLING `
-t CSCRS `
-t STDCSSTRATEGY `
-t CSPCCURVE `
-t CSPCSPEEDDIAG `
-t CSPROTDATA `
-t CSPROTTICKS `
-t CSPROTSIMILAR `
-t PRODDATACORE `
-t HEAT `
-t CSEDGEMASKING `
-t STDCSEDGEMASKING `
-t CSMAINTENANCEVALVESTEST `
-t STAT_SPPHYENT `
-t HMI_V_ACTUALSEQUENCE `
-t CSMAINT_SEQUENCE `
-t CSMAINT_STEP `
-t CSCALIBRATIONCONFIG `
-t HMI_V_PRODUCTION_HISTORY `
-t HMI_V_ACTUALHEAT `



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
