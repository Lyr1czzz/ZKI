using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace лр2
{
    public partial class LR3 : Form
    {
        private const string Key1 = "4321";
        private const string Key2 = "2341";

        public LR3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                string message = richTextBox1.Text;
                for (int i = 0; i < message.Length; i++)
                {
                    if ((int)message[i] < 79 && (int)message[i] > 101)
                    {
                        return;
                    }
                }
                string encryptedMessage = Encrypt(message);
                SaveToFile(encryptedMessage);
            }
            else if (radioButton2.Checked)
            {
                string encryptedMessage = ReadFile();
                string decryptedMessage = Decrypt(encryptedMessage);
                richTextBox2.Text = decryptedMessage;
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

        private string Encrypt(string message)
        {
            int numRows = 4;
            int numCols = 4;
            int messageIndex = 0;
            char[,] table = new char[numRows, numCols];
            char[,] encTable = new char[numRows, numCols];
            char[,] encencTable = new char[numRows, numCols];

            for (int col = 0; col < numCols; col++)
            {
                for (int row = 0; row < numRows; row++)
                {
                    if (messageIndex < message.Length)
                        table[row, col] = message[messageIndex++];
                    else
                        table[row, col] = ' ';
                }
            }

            for (int i = 0; i < 4; i++)
            {
                encTable[i, 0] = table[i, 3];
                encTable[i, 1] = table[i, 2];
                encTable[i, 2] = table[i, 1];
                encTable[i, 3] = table[i, 0];
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    richTextBox3.Text += encTable[j, i];
                }
            }
            for (int i = 0; i < 4; i++)
            {
                encencTable[0, i] = encTable[i, 3];
                encencTable[1, i] = encTable[i, 0];
                encencTable[2, i] = encTable[i, 1];
                encencTable[3, i] = encTable[i, 2];
            }

            string result = "";
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    result += encTable[i, j] + " ";
                }
                result += "\n";
            }
            return result;
        }


        private string Decrypt(string encryptedMessage)
        {
            int numRows = 4;
            int numCols = 4;
            int messageIndex = 0;
            char[,] table = new char[numRows, numCols];
            char[,] encTable = new char[numRows, numCols];
            char[,] encencTable = new char[numRows, numCols];

            for (int col = 0; col < numCols; col++)
            {
                for (int row = 0; row < numRows; row++)
                {
                    if (messageIndex < encryptedMessage.Length)
                        encTable[row, col] = encryptedMessage[messageIndex++];
                    else
                        encTable[row, col] = ' ';
                }
            }

            for (int i = 0; i < 4; i++)
            {
                encencTable[0, i] = encTable[i, 3];
                encencTable[1, i] = encTable[i, 0];
                encencTable[2, i] = encTable[i, 1];
                encencTable[3, i] = encTable[i, 2];
            }

            

            for (int i = 0; i < 4; i++)
            {
                table[i, 0] = encencTable[i, 3];
                table[i, 1] = encencTable[i, 2];
                table[i, 2] = encencTable[i, 1];
                table[i, 3] = encencTable[i, 0];
            }



            string result = "";
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    result += encTable[i, j] + " ";
                }
                result += "\n";
            }
            return result;
        }
    }
}
