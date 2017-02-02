
$env:PSModulePath = "$($env:APPDATA)\..\Local\Apps\SharePointPnPPowerShellOnline;"+$env:PSModulePath		

Connect-SPOnline -Url <SP Online Url> -Credentials <Windows Secure Store ID>

Set-SPOTraceLog -On -Level Debug

$web=Get-SPOWeb

$host.ui.RawUI.WindowTitle = "Shell on  to $($web.ServerRelativeUrl)"

Write-Host "Connected to $($web.ServerRelativeUrl)"
