using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЗКИ
{
    public partial class LR9 : Form
    {
        public LR9()
        {
            InitializeComponent();
        }
        int P { get; set; }
        int G { get; set; }
        int K { get; set; }
        BigInteger A { get; set; }
        BigInteger B { get; set; }
        int X { get; set; }
        BigInteger Y { get; set; }
        Dictionary<int, int> dictionary = new Dictionary<int, int>()
        {
            { 29, 2 },
        };
        public string Letters = "abcdefghijklmnopqrstuvwxyz123";
        Random random = new Random();

        int GetRandomP(int[] keys)
        {
            int randomIndex = random.Next(0, keys.Length);
            return keys[randomIndex];
        }

        int GetRandomX()
        {
            return random.Next(1, P);
        }

        BigInteger GetRandomY()
        {
            return BigInteger.ModPow(G, X, P);
        }

        BigInteger GetRandomA()
        {
            return (BigInteger)Math.Pow(G, K) % P;
        }

        BigInteger GetRandomB(int M)
        {
            return (BigInteger.ModPow(Y, K, P)*M) % P;
        }

        static int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        static int GenerateK(int p)
        {
            Random random = new Random();
            while (true)
            {
                int k = random.Next(2, p - 1);
                if (GCD(k, p - 1) == 1)
                    return k;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] keysArray = dictionary.Keys.ToArray();
            P = GetRandomP(keysArray);
            txt.Text += "P = " + P + "\n";
            G = dictionary[P];
            txt.Text += "G = " + G + "\n";
            X = GetRandomX();
            txt.Text += "X = " + X + "\n";
            Y = GetRandomY();
            txt.Text += "Y = " + Y + "\n";
            K = GenerateK(P);
            txt.Text += "K = " + K + "\n";
            A = GetRandomA();
            txt.Text += "A = " + A + "\n";

            for (int i = 0; i < richTextBox1.Text.Length; i++)
            {
                B = GetRandomB(Letters.IndexOf(richTextBox1.Text[i])+1);
                richTextBox2.Text += " " + A;
                richTextBox3.Text += " " + B;
                txtM.Text += Letters.IndexOf(richTextBox1.Text[i].ToString()) + "\n";
            }

        }

        private void LR9_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var a = richTextBox2.Text.Split(' ');
            var b = richTextBox3.Text.Split(' ');
            richTextBox1.Clear();
            for (int i = 1 ; i < a.Length; i++)
            {
                BigInteger B = BigInteger.Parse(b[i]);
                BigInteger A = BigInteger.Parse(a[i]);
                BigInteger inA = BigInteger.ModPow(A, P - 1 - X, P);
                BigInteger index = (B * inA) % P;
                richTextBox1.Text += Letters[(int)index-1];
            }
        }
    }
}