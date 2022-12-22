using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ma_Hoa_Thay_The
{
    class Program
    {
        static void Main(string[] args)
        {
            string cipherText, plainText, text;

            text = "Enemy Coming heLlo WoRld";
            string cipherAlphabet = "IAUTMOCSNREBDLHVWYFPZJXKGQ";
            //string cipherAlphabet = "iautmocsnrebdlhvwyfpzjxkgq";
            string newcipherAlphabet = cipherAlphabet.ToLower();
            bool encipherResult = Encipher(text, newcipherAlphabet, out cipherText);
            bool decipherResult = Decipher(cipherText, newcipherAlphabet, out plainText);
            Console.WriteLine("Key: " + cipherAlphabet);
            Console.WriteLine("Plain Text: " + text);
            Console.WriteLine("Cipher Text: " + cipherText);
            Console.WriteLine("Plain text after decrypt: " + plainText);
            Console.ReadKey();  //dừng màn hình
        }
        //Mã Hoá và Giải Mã = Phương Pháp Thay Thế
        private static bool Cipher(string input, string oldAlphabet, string newAlphabet, out string output)
        {
            output = string.Empty;

            if (oldAlphabet.Length != newAlphabet.Length)
                return false;

            for (int i = 0; i < input.Length; ++i)
            {
                int oldCharIndex = oldAlphabet.IndexOf(char.ToLower(input[i]));

                if (oldCharIndex >= 0)
                    output += char.IsUpper(input[i]) ? char.ToUpper(newAlphabet[oldCharIndex]) : newAlphabet[oldCharIndex];
                else
                    output += input[i];
            }
            return true;
        }

        public static bool Encipher(string input, string cipherAlphabet, out string output)
        {
            string plainAlphabet = "abcdefghijklmnopqrstuvwxyz";
            return Cipher(input, plainAlphabet, cipherAlphabet, out output);
        }

        public static bool Decipher(string input, string cipherAlphabet, out string output)
        {
            string plainAlphabet = "abcdefghijklmnopqrstuvwxyz";
            return Cipher(input, cipherAlphabet, plainAlphabet, out output);
        }
    }
}