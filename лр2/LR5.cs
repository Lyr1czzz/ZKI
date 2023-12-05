using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ЗКИ
{
    public partial class LR5 : Form
    {
        public string KeyVijener { get; set; }
        public string KeyMessageVijener { get; set; }
        public string Letters = "abcdefghijklmnopqrstuvwxyz";
        public string LettersForPleifer = "abcdefghijklmnopqrstuvwxyz -.,";
        public string CryptoSystemMessage { get; set; }
        List<string> CryptSystem = new();
        public string[] Alf { get; set; }

        public LR5()
        {
            InitializeComponent();
        }

        public void SetCryptoSystem(string frazaCezar)
        {
            StringBuilder cryptoSystemMessage = new StringBuilder();
            StringBuilder Rows = new StringBuilder();
            for (int i = 0; i < frazaCezar.Length; i++)
            {
                cryptoSystemMessage.Append(frazaCezar[i]);
                Rows.Append(frazaCezar[i]);
                Rows.Append("\n");
            }

            for (int i = 0; i < Letters.Length; i++)
            {
                if (frazaCezar.IndexOf(Letters[i]) != -1) continue;
                cryptoSystemMessage.Append(Letters[i]);
                Rows.Append(Letters[i]);
                Rows.Append("\n");
            }

            txtColumns.Text = cryptoSystemMessage.ToString();
            txtRows.Text = Rows.ToString();

            CryptoSystemMessage = cryptoSystemMessage.ToString();
            for (int i = 0; i < 26; i++)
            {
                CryptSystem.Add(cryptoSystemMessage.ToString());
                txtCryptoSchem.Text += cryptoSystemMessage.ToString() + "\n";
                cryptoSystemMessage.Append(cryptoSystemMessage[0]);
                cryptoSystemMessage.Remove(0, 1);
            }
        }

        public string EncryptVijer(string message)
        {
            string newKey = "";
            while (newKey.Length < KeyMessageVijener.Length)
            {
                newKey += KeyVijener;
            }
            StringBuilder encryptVijer = new StringBuilder();
            for (int i = 0; i < message.Length; i++)
            {
                int rowIndex = CryptoSystemMessage.IndexOf(message[i]);
                int colIndex = CryptoSystemMessage.IndexOf(newKey[i]);
                encryptVijer.Append(CryptSystem[rowIndex][colIndex]);
            }
            return encryptVijer.ToString();
        }

        public void SetAlf(string key)
        {
            SetCryptoSystem(KeyVijener);
            string s = EncryptVijer(KeyMessageVijener);
            for (int i = 0; i < s.Length; i++)
            {
                if (richTextBox1.Text.IndexOf(s[i]) == -1)
                {
                    richTextBox1.Text += s[i];
                }
            }
            int count = richTextBox1.Text.Length;
            for (int i = 0; i < Letters.Length; i++)
            {
                if (richTextBox1.Text.IndexOf(Letters[i]) == -1)
                {
                    richTextBox1.Text += Letters[i];
                    count++;
                    if (count % 6 == 0)
                    {
                        richTextBox1.Text += "\n";
                    }
                }
            }
            richTextBox1.Text += ",. -";

            Alf = richTextBox1.Text.Split('\n');
        }

        public void EncruptPleifer(string message)
        {
            StringBuilder encruptMessage = new StringBuilder();
            for (int i = 0; i < message.Length - 1; i += 2)
            {
                int row1 = 0, row2 = 0;
                int col1 = 0, col2 = 0;
                for (int j = 0; j < Alf.Length; j++)
                {

                    for (int k = 0; k < Alf[0].Length; k++)
                    {
                        if (message[i] == Alf[j][k])
                        {
                            row1 = j;
                            col1 = k;
                        }

                        if (message[i + 1] == Alf[j][k])
                        {
                            row2 = j;
                            col2 = k;
                        }
                    }
                }
                if (row1 != row2 && col1 != col2)
                {
                    encruptMessage.Append(Alf[row1][col2]);
                    encruptMessage.Append(Alf[row2][col1]);
                    continue;
                }
                else if (row1 == row2)
                {
                    if (col1 >= 5)
                        encruptMessage.Append(Alf[row1][(col1 + 1) - 6]);
                    else
                        encruptMessage.Append(Alf[row1][col1 + 1]);

                    if (col2 >= 5)
                        encruptMessage.Append(Alf[row2][(col2 + 1) - 6]);
                    else
                        encruptMessage.Append(Alf[row2][col2 + 1]);
                    continue;
                }
                else if (col1 == col2)
                {
                    if (row1 >= 4)
                        encruptMessage.Append(Alf[row1 + 1 - 5][col1]);
                    else
                        encruptMessage.Append(Alf[row1 + 1][col1]);

                    if (row2 >= 4)
                        encruptMessage.Append(Alf[row2 + 1 - 5][col2]);
                    else
                        encruptMessage.Append(Alf[row2 + 1][col2]);
                    continue;
                }
            }
            richTextBox3.Text += '\n' + encruptMessage.ToString();
        }

        public void DencruptPleifer(string message)
        {
            StringBuilder encruptMessage = new StringBuilder();
            for (int i = 0; i < message.Length - 1; i += 2)
            {
                int row1 = 0, row2 = 0;
                int col1 = 0, col2 = 0;
                for (int j = 0; j < Alf.Length; j++)
                {

                    for (int k = 0; k < Alf[0].Length; k++)
                    {
                        if (message[i] == Alf[j][k])
                        {
                            row1 = j;
                            col1 = k;
                        }

                        if (message[i + 1] == Alf[j][k])
                        {
                            row2 = j;
                            col2 = k;
                        }
                    }
                }
                if (row1 != row2 && col1 != col2)
                {
                    encruptMessage.Append(Alf[row1][col2]);
                    encruptMessage.Append(Alf[row2][col1]);
                    continue;
                }
                else if (row1 == row2)
                {
                    if (col1 <= 0)
                        encruptMessage.Append(Alf[row1][(col1 - 1) + 6]);
                    else
                        encruptMessage.Append(Alf[row1][col1 - 1]);

                    if (col2 <= 0)
                        encruptMessage.Append(Alf[row2][(col2 - 1) + 6]);
                    else
                        encruptMessage.Append(Alf[row2][col2 - 1]);
                    continue;
                }
                else if (col1 == col2)
                {
                    if (row1 <= 0)
                        encruptMessage.Append(Alf[row1 - 1 + 5][col1]);
                    else
                        encruptMessage.Append(Alf[row1 - 1][col1]);

                    if (row2 <= 0)
                        encruptMessage.Append(Alf[row2 - 1 + 5][col2]);
                    else
                        encruptMessage.Append(Alf[row2 - 1][col2]);
                    continue;
                }
            }
            richTextBox3.Text += '\n' + encruptMessage.ToString();
        }

        private void LR5_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnApplyKeyCezar_Click(object sender, EventArgs e)
        {
            KeyVijener = txtKey.Text;

        }

        private void btnApplyFrazaCezar_Click(object sender, EventArgs e)
        {
            KeyMessageVijener = txtMessage.Text;
            SetCryptoSystem(KeyVijener);
            SetAlf(EncryptVijer(KeyMessageVijener));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EncruptPleifer(richTextBox2.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DencruptPleifer(richTextBox2.Text);
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

        private void button4_Click(object sender, EventArgs e)
        {
            SaveToFile(richTextBox3.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = ReadFile();
        }
    }
}
