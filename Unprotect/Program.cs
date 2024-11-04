using System;
using System.Security.Cryptography;
// See https://aka.ms/new-console-template for more information
Console.WriteLine(Convert.ToBase64String(ProtectedData.Unprotect(Convert.FromBase64String(Console.ReadLine()), null, DataProtectionScope.CurrentUser)));