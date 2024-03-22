# Set Working Directory
Split-Path $MyInvocation.MyCommand.Path | Push-Location
[Environment]::CurrentDirectory = $PWD

Remove-Item "$env:RELOADEDIIMODS/p4gpc.musicenhancementpack/*" -Force -Recurse
dotnet publish "./p4gpc.musicenhancementpack.csproj" -c Release -o "$env:RELOADEDIIMODS/p4gpc.musicenhancementpack" /p:OutputPath="./bin/Release" /p:ReloadedILLink="true"

# Restore Working Directory
Pop-Location