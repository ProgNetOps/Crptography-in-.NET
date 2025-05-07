using System.Security.Cryptography;
using System.Text;

const string original = "How are you";
byte[] key = RandomNumberGenerator.GetBytes(16);
byte[] iv = RandomNumberGenerator.GetBytes(8);

var encrypted = TripleDesEncryption.Encrypt(Encoding.UTF8.GetBytes(original), key, iv);

var decrypted = TripleDesEncryption.Decrypt(encrypted, key, iv);

var decryptedMessage = Encoding.UTF8.GetString(decrypted);


Console.WriteLine("Triple DES Encryption Demonstration in .NET");
Console.WriteLine("--------------------------------------------");
Console.WriteLine();
Console.WriteLine("Original Text = " + original);
Console.WriteLine("Encrypted Text = " + Convert.ToBase64String(encrypted));
Console.WriteLine("Decrypted Text = " + decryptedMessage);