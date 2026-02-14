# PowerShell script to clean up duplicate and misplaced project folders
# Run this script from the Week06 directory

Write-Host "Cleaning up duplicate and misplaced folders..." -ForegroundColor Yellow

# Remove the FiveColors2 folder that's incorrectly inside BedAndBreakfast project
$path1 = "CSC240-06-01-BedAndBreakfast-LDM\FiveColors2"
if (Test-Path $path1) {
    Write-Host "Removing: $path1" -ForegroundColor Cyan
    Remove-Item -Path $path1 -Recurse -Force
    Write-Host "? Removed $path1" -ForegroundColor Green
} else {
    Write-Host "Path not found: $path1" -ForegroundColor Gray
}

# Remove the nested duplicate Visual Programming folder structure
$path2 = "CSC240-06-01-BedAndBreakfast-LDM\Visual Programming"
if (Test-Path $path2) {
    Write-Host "Removing: $path2" -ForegroundColor Cyan
    Remove-Item -Path $path2 -Recurse -Force
    Write-Host "? Removed $path2" -ForegroundColor Green
} else {
    Write-Host "Path not found: $path2" -ForegroundColor Gray
}

Write-Host "`nCleanup complete!" -ForegroundColor Green
Write-Host "`nYour workspace should now have:" -ForegroundColor Yellow
Write-Host "  - CSC240-06-01-BedAndBreakfast-LDM (Bed & Breakfast project)" -ForegroundColor White
Write-Host "  - CSC240-06-02-FiveColors2-LDM (Five Colors project)" -ForegroundColor White
Write-Host "`nNext steps:" -ForegroundColor Yellow
Write-Host "  1. Stage the changes: git add ." -ForegroundColor White
Write-Host "  2. Commit: git commit -m 'Clean up duplicate folders'" -ForegroundColor White
Write-Host "  3. Push to GitHub: git push" -ForegroundColor White
