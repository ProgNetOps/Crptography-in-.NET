//TEST AesCBC

using System.Security.Cryptography;
using System.Text;

const String original = "hello there";
var key = RandomNumberGenerator.GetBytes(32);
var iv = RandomNumberGenerator.GetBytes(16);

var encrypted = AesEncryption.Encrypt(Encoding.UTF8.GetBytes(original), key, iv);



Console.WriteLine("ENCRYPTED STRING------------");
Console.WriteLine(Convert.ToBase64String(encrypted));

var decrypted = AesEncryption.Decrypt(encrypted, key, iv);

Console.WriteLine("DECRYPTED------------");
Console.WriteLine(Encoding.UTF8.GetString(decrypted));

