using System;
using System.Linq;
using System.Text;

namespace MyEnigmaApp
{
    public static class Cipher
    {
        private static readonly string RussianAlphabetLower = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
        private static readonly string RussianAlphabetUpper = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";

        public enum CipherMethod
        {
            VigenereRussian,
            Caesar,
            Reverse
        }

        public static string Encrypt(string input, string key, CipherMethod method)
        {
            switch (method)
            {
                case CipherMethod.VigenereRussian:
                    return TransformVigenere(input, key, true);
                case CipherMethod.Caesar:
                    return CaesarEncrypt(input, 3); // пример: сдвиг на 3
                case CipherMethod.Reverse:
                    return Reverse(input);
                default:
                    return input;
            }
        }

        public static string Decrypt(string input, string key, CipherMethod method)
        {
            switch (method)
            {
                case CipherMethod.VigenereRussian:
                    return TransformVigenere(input, key, false);
                case CipherMethod.Caesar:
                    return CaesarDecrypt(input, 3);
                case CipherMethod.Reverse:
                    return Reverse(input); // reverse для дешифровки тот же
                default:
                    return input;
            }
        }

        private static string TransformVigenere(string text, string key, bool encrypting)
        {
            if (string.IsNullOrEmpty(key))
                return text;

            StringBuilder result = new StringBuilder();
            int keyIndex = 0;

            foreach (char c in text)
            {
                if (IsRussianLetter(c))
                {
                    bool isUpper = char.IsUpper(c);
                    string alphabet = isUpper ? RussianAlphabetUpper : RussianAlphabetLower;
                    int index = alphabet.IndexOf(c);

                    char keyChar = key[keyIndex % key.Length];
                    int keyShift = GetShiftFromChar(keyChar);

                    int newIndex;
                    if (encrypting)
                        newIndex = (index + keyShift) % alphabet.Length;
                    else
                        newIndex = (index - keyShift + alphabet.Length) % alphabet.Length;

                    result.Append(alphabet[newIndex]);
                    keyIndex++;
                }
                else
                {
                    result.Append(c); // не шифруем пробелы, знаки, цифры
                }
            }

            return result.ToString();
        }

        private static bool IsRussianLetter(char c)
        {
            return RussianAlphabetLower.Contains(char.ToLower(c));
        }

        private static int GetShiftFromChar(char c)
        {
            c = char.ToLower(c);
            if (RussianAlphabetLower.Contains(c))
                return RussianAlphabetLower.IndexOf(c);
            else if (char.IsLetter(c))
                return (char.ToLower(c) - 'a') % 26;
            else
                return 0;
        }

        private static string CaesarEncrypt(string text, int shift)
        {
            StringBuilder result = new StringBuilder();

            foreach (char c in text)
            {
                if (IsRussianLetter(c))
                {
                    bool isUpper = char.IsUpper(c);
                    string alphabet = isUpper ? RussianAlphabetUpper : RussianAlphabetLower;
                    int index = alphabet.IndexOf(c);
                    int newIndex = (index + shift) % alphabet.Length;
                    result.Append(alphabet[newIndex]);
                }
                else
                {
                    result.Append(c);
                }
            }

            return result.ToString();
        }

        private static string CaesarDecrypt(string text, int shift)
        {
            return CaesarEncrypt(text, -shift + RussianAlphabetLower.Length);
        }

        private static string Reverse(string text)
        {
            char[] chars = text.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }
    }
}
