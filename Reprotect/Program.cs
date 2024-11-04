// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography;
Console.WriteLine(Convert.ToBase64String(ProtectedData.Protect(Convert.FromBase64String(Console.ReadLine()), null, DataProtectionScope.CurrentUser)));