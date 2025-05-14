using Hasher;
using System.Text;

const string originalMessage1 = "Original Message to hash ";
const string originalMessage2 = "Original Message to hash";

Console.WriteLine("Secure HashData Demonstration in .NET");
Console.WriteLine("-------------------");
Console.WriteLine();
Console.WriteLine($"Original Messsage 1 = {originalMessage1}");
Console.WriteLine($"Original Messsage 2 = {originalMessage2}");
Console.WriteLine();


var md5HashedMessage1 = HashData.ComputeHashMd5(Encoding.UTF8.GetBytes(originalMessage1));
var md5HashedMessage2 = HashData.ComputeHashMd5(Encoding.UTF8.GetBytes(originalMessage2));


var sha1HashedMessage1 = HashData.ComputeHashSha1(Encoding.UTF8.GetBytes(originalMessage1));
var sha1HashedMessage2 = HashData.ComputeHashSha1(Encoding.UTF8.GetBytes(originalMessage2));


var sha256HashedMessage1 = HashData.ComputeHashSha256(Encoding.UTF8.GetBytes(originalMessage1));
var sha256HashedMessage2 = HashData.ComputeHashSha256(Encoding.UTF8.GetBytes(originalMessage2));


var sha512HashedMessage1 = HashData.ComputeHashSha512(Encoding.UTF8.GetBytes(originalMessage1));
var sha512HashedMessage2 = HashData.ComputeHashSha512(Encoding.UTF8.GetBytes(originalMessage2));

Console.WriteLine();
Console.WriteLine("MD5 Hashes");
Console.WriteLine();
Console.WriteLine($"Message 1 hash = {Convert.ToBase64String(md5HashedMessage1)}");
Console.WriteLine($"Message 2 hash = {Convert.ToBase64String(md5HashedMessage2)}");
Console.WriteLine();
Console.WriteLine("SHA1 Hashes");
Console.WriteLine();
Console.WriteLine($"Message 1 hash = {Convert.ToBase64String(sha1HashedMessage1)}");
Console.WriteLine($"Message 2 hash = {Convert.ToBase64String(sha1HashedMessage2)}");
Console.WriteLine();
Console.WriteLine("SHA256 Hashes");
Console.WriteLine();
Console.WriteLine($"Message 1 hash = {Convert.ToBase64String(sha256HashedMessage1)}");
Console.WriteLine($"Message 2 hash = {Convert.ToBase64String(sha256HashedMessage1)}");
Console.WriteLine();
Console.WriteLine("SHA512 Hashes");
Console.WriteLine();
Console.WriteLine($"Message 1 hash = {Convert.ToBase64String(sha512HashedMessage1)}");
Console.WriteLine($"Message 2 hash = {Convert.ToBase64String(sha512HashedMessage1)}");
Console.WriteLine();