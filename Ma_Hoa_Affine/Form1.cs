namespace Ma_Hoa_Affine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string AfineEncrypt(string plainText, int a, int b)
        {
            string cipherText = "";

            char[] chars = plainText.ToUpper().ToCharArray();

            foreach(char c in chars)
            {
                int x = Convert.ToInt32(c - 65);
                cipherText += Convert.ToChar(((a * x + b) % 26) + 65);
            }
            return cipherText;
        }

        public static string AffineDecrypt(string cipherText, int a, int b)
        {
            string plainText = "";

            int aInverse = MultiplicativeInverse(a);

            char[] chars= cipherText.ToUpper().ToCharArray();

            foreach(char c in chars)
            {
                int x = Convert.ToInt32(c - 65);
                if (x - b < 0)
                    x = Convert.ToInt32(x) + 26;
                plainText += Convert.ToChar(((aInverse * (x - b)) % 26) + 65);
            }    
            return plainText;
        }

        public static int MultiplicativeInverse(int a)
        {
            for (int x = 1; x < 27; x++) 
            {
                if ((a * x) % 26 == 1) 
                    return x;
            }
            throw new Exception("No multiplicative inverse found!");
        }

        private void Ma_Hoa_Button_Click(object sender, EventArgs e)
        {
            string text = tbPlainText.Text;
            int key1 = Convert.ToInt32(tbKey1.Text);
            int key2 = Convert.ToInt32(tbKey2.Text);
            string cipherText = AfineEncrypt(text, key1, key2);
            tbCipherText.Text = cipherText;
        }

        private void Giai_Ma_Button_Click(object sender, EventArgs e)
        {
            string cipherText = tbCipherText.Text;
            int key1 = Convert.ToInt32(tbKey1.Text);
            int key2 = Convert.ToInt32(tbKey2.Text);
            string plainText = AffineDecrypt(cipherText, key1, key2);
            tbPlainText.Text = plainText;
        }

        private void Clear_Button_Click(object sender, EventArgs e)
        {
            tbPlainText.Clear();
            tbKey1.Clear();
            tbKey2.Clear();
            tbCipherText.Clear();
            tbPlainText.Focus();
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}