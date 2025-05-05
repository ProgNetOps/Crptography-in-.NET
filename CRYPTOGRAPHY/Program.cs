using System.Security.Cryptography;

for (int i = 0; i < 10; i++)
{
    var randomNumber = RandomNumberGenerator.GetBytes(32);
    Console.WriteLine(Convert.ToBase64String(randomNumber));
}