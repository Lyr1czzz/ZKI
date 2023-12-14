using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЗКИ
{
    public partial class LR8 : Form
    {
        public LR8()
        {
            InitializeComponent();
        }

        public int Key { get; set; }
        public string Fraza { get; set; }

        public string cezarEnc { get; set; }

        public string Letters = "abcdefghijklmnopqrstuvwxyz0123456789";
        public string EncryptFraza { get; set; }
        public int[] Gamma;

        private void btnApplyKeyCezar_Click(object sender, EventArgs e)
        {
            if (txtKeyCezar.Text == string.Empty) return;
            Key = int.Parse(txtKeyCezar.Text);
        }

        private void btnApplyFrazaCezar_Click(object sender, EventArgs e)
        {
            if (txtFrazaCezar.Text == string.Empty) return;
            Fraza = txtFrazaCezar.Text;
            cezarEnc = EncryptCezar();
            for (int i = 0; i < cezarEnc.Length; i++)
            {
                for (int j = 0; j < Letters.Length; j++)
                {
                    if (cezarEnc[i] == Letters[j])
                    {
                        txtMessage.Text += j + " ";
                    }
                }
            }
            timer1.Start();
        }

        public string EncryptCezar()
        {
            StringBuilder encryptMessage = new StringBuilder();
            for (int i = 0; i < Fraza.Length; i++)
            {
                for (int j = 0; j < Letters.Length; j++)
                {
                    int index = j + Key;

                    if (index > Letters.Length)
                        index -= Letters.Length;

                    if (Fraza[i] == Letters[j])
                        encryptMessage.Append(Letters[index]);
                }
            }
            EncryptFraza = encryptMessage.ToString();
            return encryptMessage.ToString();
        }

        public string DecryptCezar()
        {
            StringBuilder encryptMessage = new StringBuilder();
            for (int i = 0; i < txtResult.Text.Length; i++)
            {
                for (int j = 0; j < Letters.Length; j++)
                {
                    int index = j - Key;

                    if (index < 0)
                        index += Letters.Length;

                    if (txtResult.Text[i] == Letters[j])
                        encryptMessage.Append(Letters[index]);
                }
            }
            return encryptMessage.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtGamma.Text = "";
            Gamma = new int[cezarEnc.Length];
            Random random = new Random();
            for (int i = 0; i < cezarEnc.Length; i++)
            {
                int number = random.Next(0, 32);
                Gamma[i] = number;
            }
            for (int i = 0; i < Gamma.Length; i++)
            {
                txtGamma.Text += Gamma[i] + " ";
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void LR8_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = cezarEnc;
            StringBuilder result = new();
            for (int i = 0; i < message.Length; i++)
            {
                for (int j = 0; j < Letters.Length; j++)
                {
                    if (Letters[j] == message[i])
                    {
                        result.Append(Letters[(Gamma[i] + j) % Letters.Length]);
                        break;
                    }
                }
            }
            txtResult.Text = result.ToString();
            SaveToFile(result.ToString() + " " + txtGamma.Text + " " + txtFrazaCezar.Text + " " + txtKeyCezar.Text);
        }

        private void SaveToFile(string text)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt";
            saveFileDialog.Title = "Сохранить файл";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                File.WriteAllText(filePath, text);
                MessageBox.Show("Файл успешно сохранен.");
            }
        }

        private string ReadFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt";
            openFileDialog.Title = "Выберите файл";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                string fileContent = File.ReadAllText(filePath);
                return fileContent;
            }

            return string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReadFile().Split(" ");
            textBox1.Text = txtResult.Text;
            StringBuilder result = new();

            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                for (int j = 0; j < Letters.Length; j++)
                {
                    if (Letters[j] == textBox1.Text[i])
                    {
                        result.Append(Letters[(j + Letters.Length - Gamma[i]) % Letters.Length]);
                        break;
                    }
                }
            }
            txtResult.Text = result.ToString();
            txtResult.Text = DecryptCezar();
        }
    }
}
