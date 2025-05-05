using System.Security.Cryptography;

for (int i = 0; i < 10; i++)
{
    var randomNumber = RandomNumberGenerator.GetBytes(32);

    //conversion to base64string is just encoding from one format to a more human-readable format; it is not encryption.
    var base64String = Convert.ToBase64String(randomNumber);
    Console.WriteLine(base64String);
}