using System;
using System.Security.Cryptography;


namespace OOP2Projekt
{
    public class RsaEncryption
    {
        public static (string PublicKey, string PrivateKey) GenerateRsaKeys()
        {
            using (RSA rsa = RSA.Create())
            {
                return (Convert.ToBase64String(rsa.ExportRSAPublicKey()), Convert.ToBase64String(rsa.ExportRSAPrivateKey()));
            }
        }

        public static byte[] EncryptSymmetricKey(byte[] key, string publicKey)
        {
            using (RSA rsa = RSA.Create())
            {
                rsa.ImportRSAPublicKey(Convert.FromBase64String(publicKey), out _);
                return rsa.Encrypt(key, RSAEncryptionPadding.Pkcs1);
            }
        }

        public static byte[] DecryptSymmetricKey(byte[] encryptedKey, string privateKey)
        {
            using (RSA rsa = RSA.Create())
            {
                rsa.ImportRSAPrivateKey(Convert.FromBase64String(privateKey), out _);
                return rsa.Decrypt(encryptedKey, RSAEncryptionPadding.Pkcs1);
            }
        }
    }
}
