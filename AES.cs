using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace AESTOOL
{
    public class AES
    {
        private string defaultKey = "0123456789abcdef";
        public AES(string key = null)
        {
            if (!string.IsNullOrWhiteSpace(key))
                defaultKey = key;
        }
        public string Encrypt(string text, int resultType)
        {
            if (string.IsNullOrWhiteSpace(text)) return "";
            var key = Encoding.UTF8.GetBytes(defaultKey);
            var plaintextBuffer = Encoding.UTF8.GetBytes(text);
            var rijndael = Rijndael.Create();
            rijndael.Mode = CipherMode.ECB;
            rijndael.Padding = PaddingMode.ISO10126;
            rijndael.Key = key;
            var transForm = rijndael.CreateEncryptor();
            var cipherTextBuffer = transForm.TransformFinalBlock(plaintextBuffer, 0, plaintextBuffer.Length);
            var result = "";
            switch (resultType)
            {
                case 0://output base64
                    result = Convert.ToBase64String(cipherTextBuffer);
                    break;
                case 1://output hex
                    result = BitConverter.ToString(cipherTextBuffer, 0).Replace("-", string.Empty);
                    break;
            }
            transForm.Dispose();
            return result;
        }
        public string Decrypt(string text, int resultType)
        {
            if (string.IsNullOrWhiteSpace(text)) return "";
            var key = Encoding.UTF8.GetBytes(defaultKey);
            var iv = key;
            byte[] cipherTextBuffer = new byte[0];
            switch (resultType)
            {
                case 0:
                    cipherTextBuffer = Convert.FromBase64String(text);
                    break;
                case 1:
                    cipherTextBuffer = HexStringToByteArray(text);
                    break;
            }
            var rijndael = Rijndael.Create();
            rijndael.Mode = CipherMode.ECB;
            rijndael.Padding = PaddingMode.ISO10126;
            var transForm = rijndael.CreateDecryptor(key, iv);
            var plaintextBuffer = transForm.TransformFinalBlock(cipherTextBuffer, 0, cipherTextBuffer.Length);
            var result = Encoding.UTF8.GetString(plaintextBuffer);
            return result;
        }

        public static byte[] HexStringToByteArray(string hexStr)
        {
            if (hexStr.Length % 2 != 0)
            {
                throw new Exception("Hex format error.");
            }
            byte[] arr = new byte[hexStr.Length / 2];
            for (int i = 0; i < hexStr.Length / 2; i++)
            {
                arr[i] = Convert.ToByte(hexStr.Substring(i * 2, 2), 16);
            }
            return arr;
        }
    }
}
