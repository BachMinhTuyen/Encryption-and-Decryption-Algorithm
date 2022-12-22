using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ma_Hoa_Caesar
{
    class Program
    {
        private static char Cipher(char ch, int key)
        {
            if (!char.IsLetter(ch))
                return ch;
            char offset = char.IsUpper(ch) ? 'A' : 'a';
            return (char)((((ch + key) - offset) % 26) + offset);
        }
        public static string Encipher(string input, int key)
        {
            string output = string.Empty;
            foreach (char ch in input)
                output += Cipher(ch, key);
            return output;
        }
        public static string Decipher(string input, int key)
        {
            return Encipher(input, 26 - key);
        }
        static void Main(string[] args)
        {
            //string text = "FOUR SCORE AND SEVEN YEARS AGO";
            //string cipherText = Encipher(text, 3);
            string cipherText = "IRXU VFRUH DQG VHYHQ BHDUV DJR";
            string plainText = Decipher(cipherText, 3);
            Console.WriteLine(plainText);
            Console.ReadKey();
        }
    }
}