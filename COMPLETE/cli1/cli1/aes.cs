﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace cli1
{
    class aes
    {
        public string Encrypt(string iPlainStr, string iCompleteEncodedKey, string dateTime)
        {
            string time = dateTime.Substring(0, 16);

            RijndaelManaged aesEncryption = new RijndaelManaged();
            aesEncryption.KeySize = 256;
            aesEncryption.BlockSize = 128;
            aesEncryption.Mode = CipherMode.CBC;
            aesEncryption.Padding = PaddingMode.None;
            aesEncryption.IV = Encoding.ASCII.GetBytes(time);
            aesEncryption.Key = Encoding.ASCII.GetBytes(Encoding.ASCII.GetString(Encoding.ASCII.GetBytes(iCompleteEncodedKey)));
            byte[] plainText = UTF8Encoding.UTF8.GetBytes(iPlainStr);
            ICryptoTransform crypto = aesEncryption.CreateEncryptor();
            byte[] cipherText = crypto.TransformFinalBlock(plainText, 0, plainText.Length);
            return Convert.ToBase64String(cipherText);
        }


        public string Decrypt(string iEncryptedText, string iCompleteEncodedKey, string dateTime)
        {
            string time = dateTime.Substring(0, 16);
            RijndaelManaged aesEncryption = new RijndaelManaged();
            aesEncryption.KeySize = 256;
            aesEncryption.BlockSize = 128;
            aesEncryption.Mode = CipherMode.CBC;
            aesEncryption.Padding = PaddingMode.None;
            aesEncryption.IV = Encoding.ASCII.GetBytes(time);
            aesEncryption.Key = Encoding.ASCII.GetBytes(Encoding.ASCII.GetString(Encoding.ASCII.GetBytes(iCompleteEncodedKey)));
            ICryptoTransform decrypto = aesEncryption.CreateDecryptor();
            byte[] encryptedBytes = Convert.FromBase64CharArray(iEncryptedText.ToCharArray(), 0, iEncryptedText.Length);
            return ASCIIEncoding.UTF8.GetString(decrypto.TransformFinalBlock(encryptedBytes, 0, encryptedBytes.Length));
        }

    }
}
