using System;
using System.IO;
using System.Security.Cryptography;

namespace OOP2Projekt
{
    public class AesEncryption
    {
        public static (byte[] EncryptedContent, byte[] Key, byte[] IV) EncryptContent(string plainText)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.KeySize = 256; // Koristimo 256-bitni AES ključ
                aesAlg.GenerateKey();
                aesAlg.GenerateIV();

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                    {
                        swEncrypt.Write(plainText);
                    }

                    // Vratimo šifrirane podatke, ključ i IV
                    return (msEncrypt.ToArray(), aesAlg.Key, aesAlg.IV);
                }
            }
        }

        public static string DecryptContent(byte[] cipherText, byte[] key, byte[] iv)
        {
            if (key == null || key.Length != 32) // 32 bytea = 256 bita
                throw new ArgumentException("Invalid AES key length.");
            if (iv == null || iv.Length != 16) // 16 bytea za IV
                throw new ArgumentException("Invalid AES IV length.");

            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = key;
                aesAlg.IV = iv;

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                {
                    // Povratak dešifriranog teksta
                    return srDecrypt.ReadToEnd();
                }
            }
        }
    }
}
