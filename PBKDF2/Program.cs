using System.Diagnostics;
using System.Security.Cryptography;

const string passwordToHash = "VeryComplexPassword";

Console.WriteLine("Password-Based Key Derivation Function Demonstration in .NET");
Console.WriteLine("------------------------------");
Console.WriteLine("PBKDF2 Hashes");
Console.WriteLine();


HashPassword(passwordToHash, 100);
HashPassword(passwordToHash, 1000);
HashPassword(passwordToHash, 10000);
HashPassword(passwordToHash, 50000);
HashPassword(passwordToHash, 100000);
HashPassword(passwordToHash, 200000);
HashPassword(passwordToHash, 500000);
HashPassword(passwordToHash, 1000000);
HashPassword(passwordToHash, 15000000);
HashPassword(passwordToHash, 20000000);
HashPassword(passwordToHash, 30000000);





Console.ReadLine();


static void HashPassword(string passwordToHash, int numberOfRounds)
{
    var sw = Stopwatch.StartNew();

    var hashedPassword = Rfc2898DeriveBytes.Pbkdf2(passwordToHash,
        RandomNumberGenerator.GetBytes(32), numberOfRounds, 
        HashAlgorithmName.SHA256,
        32);

    sw.Stop();

    Console.WriteLine();
    Console.WriteLine($"Password to hash : {passwordToHash}");
    Console.WriteLine($"Hashed Password : {Convert.ToBase64String(hashedPassword)}");
    Console.WriteLine($"Iterations < {numberOfRounds}> Elapsed Time : {sw.ElapsedMilliseconds}");
}