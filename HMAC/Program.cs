using HMAC;
using System.Security.Cryptography;
using System.Text;

const string originalMessage1 = "Original Message To Hash";
const string originalMessage2 = "Original Message To Hash 2";

Console.WriteLine("HMAC Demonstration in .NET");
Console.WriteLine("-----------------------");
Console.WriteLine();

var key = RandomNumberGenerator.GetBytes(32);

var hmacMd5Message1 = Hmac.ComputeHmacmd5(Encoding.UTF8.GetBytes(originalMessage1), key);
var hmacMd5Message2 = Hmac.ComputeHmacmd5(Encoding.UTF8.GetBytes(originalMessage2), key);

var hmacSha1Message1 = Hmac.ComputeHmacsha1(Encoding.UTF8.GetBytes(originalMessage1), key);
var hmacSha1Message2 = Hmac.ComputeHmacsha1(Encoding.UTF8.GetBytes(originalMessage2), key);

var hmacSha256Message1 = Hmac.ComputeHmacsha256(Encoding.UTF8.GetBytes(originalMessage1), key);
var hmacSha256Message2 = Hmac.ComputeHmacsha256(Encoding.UTF8.GetBytes(originalMessage2), key);

var hmacSha512Message1 = Hmac.ComputeHmacsha512(Encoding.UTF8.GetBytes(originalMessage1), key);
var hmacSha512Message2 = Hmac.ComputeHmacsha512(Encoding.UTF8.GetBytes(originalMessage2), key);


Console.WriteLine();
Console.WriteLine("MD5 HMAC");
Console.WriteLine();
Console.WriteLine($"Message 1 Hash = {Convert.ToBase64String(hmacMd5Message1)}");
Console.WriteLine($"Message 2 Hash = {Convert.ToBase64String(hmacMd5Message2)}");

Console.WriteLine();
Console.WriteLine("SHA 1 HMAC");
Console.WriteLine();
Console.WriteLine($"Message 1 Hash = {Convert.ToBase64String(hmacSha1Message1)}");
Console.WriteLine($"Message 2 Hash = {Convert.ToBase64String(hmacSha1Message2)}");

Console.WriteLine();
Console.WriteLine("SHA 256 HMAC");
Console.WriteLine();
Console.WriteLine($"Message 1 Hash = {Convert.ToBase64String(hmacSha256Message1)}");
Console.WriteLine($"Message 2 Hash = {Convert.ToBase64String(hmacSha256Message2)}");


Console.WriteLine();
Console.WriteLine("SHA 512 HMAC");
Console.WriteLine();
Console.WriteLine($"Message 1 Hash = {Convert.ToBase64String(hmacSha512Message1)}");
Console.WriteLine($"Message 2 Hash = {Convert.ToBase64String(hmacSha512Message2)}");
