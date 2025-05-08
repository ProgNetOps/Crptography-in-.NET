//TEST AesCBC
using System.Security.Cryptography;
using System.Text;


//TestAesCbc();
TestAesGCM();

static void TestAesCbc()
{
    const String original = "Not a number is NaN";
    var key = RandomNumberGenerator.GetBytes(32);
    var iv = RandomNumberGenerator.GetBytes(16);

    var encrypted = AesEncryption.Encrypt(Encoding.UTF8.GetBytes(original), key, iv);



    Console.WriteLine("------ENCRYPTED STRING-------");
    Console.WriteLine(Convert.ToBase64String(encrypted));

    var decrypted = AesEncryption.Decrypt(encrypted, key, iv);
    Console.WriteLine();

    Console.WriteLine("-----DECRYPTED------");
    Console.WriteLine(Encoding.UTF8.GetString(decrypted));
}



static void TestAesGCM()
{
    const String original = "Text to encrypt";

    var gcmKey = RandomNumberGenerator.GetBytes(32);
    var nonce = RandomNumberGenerator.GetBytes(12);

    try
    {
        (byte[] cipherText, byte[] tag) result = AesGcmEncryption.Encrypt(Encoding.UTF8.GetBytes(original), gcmKey, nonce, Encoding.UTF8.GetBytes("some metadata"));

        byte[] decryptedText = AesGcmEncryption.Decrypt(result.cipherText, gcmKey, nonce, result.tag, Encoding.UTF8.GetBytes("some metadata"));

        Console.WriteLine("AES GCM Encryption Demonstration");
        Console.WriteLine("--------------------------");
        Console.WriteLine();
        Console.WriteLine("Original Text = " + original);
        Console.WriteLine("Encrypted Text = " + Convert.ToBase64String(result.cipherText));
        Console.WriteLine("Decypted Text = " + Encoding.UTF8.GetString(decryptedText));

    }
    catch (CryptographicException ex)
    {
        Console.WriteLine(ex.Message);
    }
    catch (ArgumentException ex)
    {
        Console.WriteLine(ex.Message);
    }
}


