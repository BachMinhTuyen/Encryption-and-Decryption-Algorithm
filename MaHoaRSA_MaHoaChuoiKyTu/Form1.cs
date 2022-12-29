using System.Security.Cryptography;
using System.Text;

namespace Bai1
{
    public partial class Form1 : Form
    {
        public static string filePath;
        public Form1()
        {
            InitializeComponent();
        }
        static public byte[] Encryption(byte[] Data, RSAParameters RSAKey, bool DoOAEPPadding)
        {
            try
            {
                byte[] encryptedData;
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {
                    RSA.ImportParameters(RSAKey);
                    encryptedData = RSA.Encrypt(Data, DoOAEPPadding);
                }
                return encryptedData;
            }
            catch (CryptographicException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
        static public byte[] Decryption(byte[] Data, RSAParameters RSAKey, bool DoOAEPPadding)
        {
            try
            {
                byte[] decryptedData;
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {
                    RSA.ImportParameters(RSAKey);
                    decryptedData = RSA.Decrypt(Data, DoOAEPPadding);
                }
                return decryptedData;
            }
            catch (CryptographicException e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }
        UnicodeEncoding ByteConverter = new UnicodeEncoding();
        RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
         byte[] plaintext;
         byte[] encryptedtext;

        private void btn_Upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            if (op.ShowDialog() == DialogResult.OK)
            {
                txb_File.Text = op.FileName;
                filePath = op.FileName;
                string[] lines = File.ReadAllLines(filePath);
                FileStream fs = new FileStream(filePath, FileMode.Open);
                StreamReader rd = new StreamReader(fs, Encoding.UTF8);
                String result = rd.ReadToEnd();
                txb_Message.Text = result;  
            }

        }

        private void btn_Encrypt_Click(object sender, EventArgs e)
        {
            plaintext = ByteConverter.GetBytes(txb_Message.Text);
            encryptedtext = Encryption(plaintext, RSA.ExportParameters(false), false);
            txb_Encrypt.Text = ByteConverter.GetString(encryptedtext);
        }

        private void btn_Decrypt_Click(object sender, EventArgs e)
        {
            //encryptedtext = txb_Encrypt.Text;
            byte[] decryptedtex = Decryption(encryptedtext, RSA.ExportParameters(true), false);
            txb_Decrypt.Text = ByteConverter.GetString(decryptedtex);
        }
    }
}