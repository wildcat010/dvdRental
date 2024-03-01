Write-Host "This is a PowerShell script to generate DB entities and context for WebHMI project"

#Path where the powershell script is located. It is expected to be in project WebHMI.EntityFrameworkCore root folder
$LocalPath = gl

#Path where the models classes should be written
$PathModels = $LocalPath.ToString() + '\..\WebHMI.Core\Prdb\'

#Path to location where PRDB context file is located
$PathContext = $LocalPath.ToString() + '\EntityFrameworkCore\PRDB'

$ModelsName = 'PrdbContext'
$ModelsNamespace = 'WebHMI.Prdb'
$ContextNamespace =  ' WebHMI.EntityFrameworkCore.PRDB'
$PathModelsToDelete = $PathModels.ToString() + '*.cs'

Write-Host 'Deleting old models from ' $PathModelsToDelete.ToString()
DEL $PathModelsToDelete

Write-Host 'Running scaffold on database objects to genereate models and context'
$DBConnString = 'Name=ConnectionStrings:PRDB'

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
-t PLANTLIMITS `

Write-Host 'Adjusting PrdbContext.cs file to project requirements'

#change base class from DbContext to AbpDbContext
$PathModelContext = $PathContext.ToString() + '\PrdbContext.cs'
((Get-Content -path $PathModelContext -Raw) -replace ' DbContext',' AbpDbContext') | Set-Content -Path $PathModelContext

#remove lines 11 to 13 with paremeterless constructor  public PrdbContext() from just generated PrdbContext.cs file, line index is 0 based
$lines = [IO.File]::ReadAllLines($PathModelContext)
Set-Content -Encoding UTF8 $PathModelContext -Value $lines[0..9 + 14..($lines.Count-1)]

#add required using lines to generated code after last one
(Get-Content -Encoding UTF8 $PathModelContext) |
    Foreach-Object {
        $_ # send the current line to output
        if ($_ -match "using Microsoft.EntityFrameworkCore.Metadata;")
        {
            #Add Lines after the selected pattern
            #"Text To Add"
            'using Abp.EntityFrameworkCore;',
            'using Abp.EntityFrameworkCore.Repositories;'
        }
    } | Set-Content $PathModelContext

Write-Host 'Renaming files'

Write-Host 'All EF models generated, ready to build'
pause
