using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ma_Hoa_Caesar
{
    class Program
    {
        //Mã hoá và giải mã 1 file văn bản ASCII = Caesar
        public static string ReadFile()
        {
            var filename = "ASCII_File.txt";

            // Get current working directory (..\bin\Debug)
            //string directory = Directory.GetCurrentDirectory();
            string workingDirectory = Environment.CurrentDirectory;

            // Get the current PROJECT directory - nhận lấy thư mục PROJECT hiện tại
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;
            Console.Write("Read the file at path: ");
            Console.WriteLine($"{projectDirectory}");

            // Kết hợp các chuỗi thành dường dẫn
            var fullpath = Path.Combine(projectDirectory, filename);
            string readText = File.ReadAllText(fullpath);
            return readText;
        }
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
            int key;
            string str;
            do
            {
                Console.Write("Nhap key: ");
                str = Console.ReadLine();
            } while (str == "");
            key = int.Parse(str);
            text = ReadFile();
            cipherText = Encipher_Caesar(text, key);
            plainText=Decipher(cipherText, key);
            Console.WriteLine("Key = " + key.ToString());
            Console.WriteLine("Plain Text: " + text);
            Console.WriteLine("Cipher Text: " + cipherText);
            Console.WriteLine("Plain text after decrypt: " + plainText);
            Console.ReadKey();
        }
    }
}