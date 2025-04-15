using System;
using System.Text;

namespace MyEnigmaApp
{
    public static class Cipher
    {
        public static string Encrypt(string input, string key)
        {
            if (string.IsNullOrEmpty(key)) return input;

            StringBuilder result = new StringBuilder();
            key = key.ToUpper();
            int keyIndex = 0;

            foreach (char c in input)
            {
                if (char.IsLetter(c))
                {
                    bool isUpper = char.IsUpper(c);
                    char offset = isUpper ? 'A' : 'a';
                    int shift = key[keyIndex % key.Length] - 'A';
                    char encryptedChar = (char)(((c - offset + shift) % 26) + offset);
                    result.Append(encryptedChar);
                    keyIndex++;
                }
                else
                {
                    result.Append(c); // не шифруем пробелы и знаки
                }
            }

            return result.ToString();
        }

        public static string Decrypt(string input, string key)
        {
            if (string.IsNullOrEmpty(key)) return input;

            StringBuilder result = new StringBuilder();
            key = key.ToUpper();
            int keyIndex = 0;

            foreach (char c in input)
            {
                if (char.IsLetter(c))
                {
                    bool isUpper = char.IsUpper(c);
                    char offset = isUpper ? 'A' : 'a';
                    int shift = key[keyIndex % key.Length] - 'A';
                    char decryptedChar = (char)(((c - offset - shift + 26) % 26) + offset);
                    result.Append(decryptedChar);
                    keyIndex++;
                }
                else
                {
                    result.Append(c); // не шифруем пробелы и знаки
                }
            }

            return result.ToString();
        }
    }
}
