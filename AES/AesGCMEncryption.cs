
using System.Security.Cryptography;

public static class AesGcmEncryption
{
    public static (byte[], byte[]) Encrypt(byte[] dataToEncrypt, byte[] key, byte[] nonce, byte[] associatedData)
    {
        //these will be filled during the encryption
        var tag = new byte[16];
        var cipherText = new byte[dataToEncrypt.Length];

        using var aesGcm = new AesGcm(key);
        aesGcm.Encrypt(nonce, dataToEncrypt, cipherText, tag, associatedData);

        //The cipher text is the encrypted data and the tag is the HMAC generated as part of the encryption process.
        return (cipherText, tag);
    }

    public static byte[] Decrypt(byte[] cipherText, byte[] key, byte[] nonce, byte[] tag, byte[] associatedData)
    {
        //An initialized byte array to hold the decrypted data
        var decryptedData = new byte[cipherText.Length];

        using var aesGcm = new AesGcm(key);
        aesGcm.Decrypt(nonce, cipherText, tag, decryptedData, associatedData);

        return decryptedData;
    }
}