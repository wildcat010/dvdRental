if (-NOT ([Security.Principal.WindowsPrincipal][Security.Principal.WindowsIdentity]::GetCurrent()).IsInRole([Security.Principal.WindowsBuiltInRole] "Administrator")) {
    Write-Host "Please open PowerShell as an Administrator and then run this script" -ForegroundColor Red
    Write-Host "Press Enter to exit..."
    Read-Host
    Exit
}

$scriptsFolder = "C:\scripts"
if (!(Test-Path $scriptsFolder)) {
    New-Item -Path $scriptsFolder -ItemType Directory
    Write-Host "Created '$scriptsFolder' folder"
}

while ($true) {
    Write-Host "Please enter the valid path to the folder with logs"
    $logPath = Read-Host

    if (Test-Path $logPath) {
        Write-Host "Folder found"
        break;
    }

    Write-Host "Path doesn't exist"
}

$daysToArchive = 7
$daysToDelete = 30

$logScriptContent = @"
`$logPath = "$logPath"
`$zipThreshold = (Get-Date).AddDays(-$daysToArchive)
`$deleteThreshold = (Get-Date).AddDays(-$daysToDelete)

# Archive logs older older than a specified number of days
`$oldLogFiles = Get-ChildItem -Path `$logPath | Where-Object { (`$_.Name -like '*.log*') -and `$_.LastWriteTime -lt `$zipThreshold }
if (`$oldLogFiles.Count -gt 0) {
    `$zipName = "archived_logs_{0:dd_MM_yyyy}.zip" -f (Get-Date)
    `$oldLogFiles | Compress-Archive -DestinationPath ("`$logPath\`$zipName") -Update
    `$oldLogFiles | Remove-Item
}

# Delete files older than a specified number of days
Get-ChildItem -Path `$logPath | Where-Object { `$_.LastWriteTime -lt `$deleteThreshold } | Remove-Item
"@

$logScriptPath = "$scriptsFolder\log_maintain_script.ps1"
Set-Content -Path $logScriptPath -Value $logScriptContent
Write-Host "Script '$logScriptPath' updated"

$taskAction = New-ScheduledTaskAction -Execute "powershell.exe" -Argument "-ExecutionPolicy Bypass $logScriptPath"
$taskTrigger = New-ScheduledTaskTrigger -Daily -At (Get-Date).Date.AddHours(3) -DaysInterval $daysToArchive
$taskName = "Maintain log files"
$taskSettings = New-ScheduledTaskSettingsSet `
    -AllowStartIfOnBatteries `
    -DontStopIfGoingOnBatteries `
    -DontStopOnIdleEnd `
    -StartWhenAvailable `
    -RestartInterval (New-TimeSpan -Minutes 1) `
    -RestartCount 3 `
    -ExecutionTimeLimit 0

$existingTask = Get-ScheduledTask | Where-Object { $_.TaskName -eq $taskName }
if ($null -ne $existingTask) {
    Unregister-ScheduledTask -TaskName $taskName -Confirm:$false
    Write-Host "Task '$existingTask' was deleted, because it was already registred"
}

$taskPrincipal = New-ScheduledTaskPrincipal -UserId "NT AUTHORITY\SYSTEM" -LogonType ServiceAccount
$scheduledTask = New-ScheduledTask -Action $taskAction -Trigger $taskTrigger -Settings $taskSettings -Principal $taskPrincipal
Register-ScheduledTask -TaskName $taskName -InputObject $scheduledTask
Write-Host "Task created."
