using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace ЗКИ
{
    public partial class LR4 : Form
    {
        public int Key { get; set; }
        public string Fraza { get; set; }
        public string EncryptFraza { get; set; }

        public string Letters = "abcdefghijklmnopqrstuvwxyz";
        List<string> CryptSystem = new();
        public string MessageForEncrypt { get; set; }
        public string MessageForDencrypt { get; set; }
        public string EncryptMessage { get; set; }

        public string CryptoSystemMessage { get; set; }

        public LR4()
        {
            InitializeComponent();
        }

        private void btnApplyKeyCezar_Click(object sender, EventArgs e)
        {
            if (txtKeyCezar.Text == string.Empty) return;
            Key = int.Parse(txtKeyCezar.Text);
        }

        private void btnApplyFrazaCezar_Click(object sender, EventArgs e)
        {
            if (txtFrazaCezar.Text == string.Empty) return;
            Fraza = txtFrazaCezar.Text;
            SetCryptoSystem(EncryptCezar());
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

        public string EncryptVijer(string message)
        {
            string newKey = "";
            while (newKey.Length < MessageForEncrypt.Length)
            {
                newKey += EncryptFraza;
            }
            StringBuilder encryptVijer = new StringBuilder();
            for (int i = 0; i < MessageForEncrypt.Length; i++)
            {
                int rowIndex = MessageForEncrypt.IndexOf(message[i]);
                int colIndex = MessageForEncrypt.IndexOf(newKey[i]);
                encryptVijer.Append(CryptSystem[rowIndex][colIndex]);
            }
            return encryptVijer.ToString();
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
                if (Fraza.IndexOf(Letters[i]) != -1) continue;
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

        private void LR4_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            MessageForEncrypt = txtMessageForEncrypt.Text;
            string encryptMessage = EncryptVijer(MessageForEncrypt);
            txtAnswer.Text = encryptMessage;
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            MessageForDencrypt = txtMessageForEncrypt.Text;
            string dencryptMessage = DencryptVijer(MessageForDencrypt);
            txtAnswer.Text = dencryptMessage;
        }

        private string DencryptVijer(string messageForDencrypt)
        {
            string newKey = "";
            while (newKey.Length < MessageForDencrypt.Length)
            {
                newKey += EncryptFraza;
            }
            StringBuilder dencryptVijer = new StringBuilder();
            for (int i = 0; i < messageForDencrypt.Length; i++)
            {
                int colIndex = CryptoSystemMessage.IndexOf(newKey[i]);
                for (int j = 0; j < CryptSystem.Count; j++)
                {
                    if (messageForDencrypt[i] == CryptSystem[j][colIndex])
                    {
                        dencryptVijer.Append(CryptoSystemMessage[colIndex]);
                        break;
                    }
                }
            }
            return dencryptVijer.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveToFile(txtAnswer.Text);
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

        private void btnUpload_Click(object sender, EventArgs e)
        {
            txtMessageForEncrypt.Text = ReadFile();
        }
    }
}
