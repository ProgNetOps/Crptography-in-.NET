using System.Security.Cryptography;

public static class TripleDesEncryption
{
    public static byte[] Encrypt(byte[] dataToEncrypt, byte[] key, byte[] iv)
    {
        using var tripleDes = TripleDES.Create();
        tripleDes.Key = key;

        return tripleDes.EncryptCbc(dataToEncrypt, iv);
    }

    public static byte[] Decrypt(byte[] dataToDecrypt, byte[] key, byte[] iv)
    {
        using var tripleDes = TripleDES.Create();
        tripleDes.Key = key;

        return tripleDes.DecryptCbc(dataToDecrypt, iv);
    }
}