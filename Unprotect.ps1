$input = Read-Host "Enter the Base64-encoded encrypted data from the source host:"
$decryptedData = [System.Security.Cryptography.ProtectedData]::Unprotect(
    [Convert]::FromBase64String($input),
    $null,
    [System.Security.Cryptography.DataProtectionScope]::CurrentUser
)
Write-Output "`nHere's your output encoded string:`n"
Write-Output ([Convert]::ToBase64String($decryptedData))