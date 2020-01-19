$scriptPath = Split-Path -Parent $PSCommandPath
$deployPath = Join-Path -Path $scriptPath -ChildPath ".deploy"
$packagesDeployPath = Join-Path -Path $deployPath -ChildPath "packages"

if ( Test-Path -Path $deployPath -PathType Container )
{
    Write-Host "Clearing deploy folder: $deployPath"
    Remove-Item $deployPath -Recurse -Force
}

Write-Host "Testing PlatformSpecific MSTests"
dotnet test test/PlatformSpecific.MSTest.Tests/PlatformSpecific.MSTest.Tests.csproj -c Release

Write-Host "Testing PlatformSpecific XUnit"
dotnet test test/PlatformSpecific.XUnit.Tests/PlatformSpecific.XUnit.Tests.csproj -c Release

Write-Host "Deploying packages"
dotnet pack -o $packagesDeployPath

Write-Host "Done"