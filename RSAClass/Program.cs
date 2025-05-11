
using RSAClass;
using System.Text;

NewRSAEncryptDecrypt();
NewRSAEncryptDecryptWithKeyExport();


static void NewRSAEncryptDecrypt()
{
    var rsa = new NewRSA();
    const string original = "Text to encrypt";

    var encrypted = rsa.Encrypt(original);
    var decrypted = rsa.Decrypt(encrypted);


    Console.WriteLine("New RSA Encryption Demonstration in .Net");
    Console.WriteLine("--------------------------");
    Console.WriteLine();
    Console.WriteLine($"Original Text = {original}");
    Console.WriteLine();
    Console.WriteLine($"Encrypted Text = {Convert.ToBase64String(encrypted)}");
    Console.WriteLine();
    Console.WriteLine($"Decrypted Text = {Encoding.Default.GetString(decrypted)}");
    Console.WriteLine();
    Console.WriteLine();
}


static void NewRSAEncryptDecryptWithKeyExport()
{
    var rsa = new NewRSA();
    byte[] encryptedPrivateKey = rsa.ExportPrivateKey(100000, "iwf57yn783425y");
    byte[] publicKey = rsa.ExportPublicKey();

    const string original = "Text to encrypt";
    var encrypted = rsa.Encrypt(original);

    var rsa2 = new NewRSA();
    rsa2.ImportPublicKey(publicKey);
    rsa2.ImportEncryptedPrivateKey(encryptedPrivateKey, "iwf57yn783425y");

    var decrypted = rsa2.Decrypt(encrypted);


    Console.WriteLine("New RSA Encryption with Imported Key Demonstration in .NET");
    Console.WriteLine("------------------------");
    Console.WriteLine();
    Console.WriteLine($"Original Text = {original}");
    Console.WriteLine();
    Console.WriteLine($"Encrypted Text = {Convert.ToBase64String(encrypted)}");
    Console.WriteLine();
    Console.WriteLine($"Decrypted Text = {Encoding.Default.GetString(decrypted)}");
    Console.WriteLine();
}