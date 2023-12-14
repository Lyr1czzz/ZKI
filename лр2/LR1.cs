using Microsoft.VisualBasic.ApplicationServices;
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

using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ЗКИ
{
    public partial class LR1 : Form
    {
        int[,] MK =
        {
            {2, 7, 6},
            {9, 5, 1},
            {4, 3, 8}
        };
        public LR1()
        {
            InitializeComponent();
            UpdateMK();
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
        void UpdateMK()
        {
            richTextBox1.Text = MK[0, 0].ToString();
            richTextBox2.Text = MK[0, 1].ToString();
            richTextBox3.Text = MK[0, 2].ToString();
            richTextBox4.Text = MK[1, 0].ToString();
            richTextBox5.Text = MK[1, 1].ToString();
            richTextBox6.Text = MK[1, 2].ToString();
            richTextBox7.Text = MK[2, 0].ToString();
            richTextBox8.Text = MK[2, 1].ToString();
            richTextBox9.Text = MK[2, 2].ToString();
        }

        void Encryption(string word)
        {
            richTextBox1.Text += word[MK[0, 0] - 1].ToString();
            richTextBox2.Text += word[MK[0, 1] - 1].ToString();
            richTextBox3.Text += word[MK[0, 2] - 1].ToString();
            richTextBox4.Text += word[MK[1, 0] - 1].ToString();
            richTextBox5.Text += word[MK[1, 1] - 1].ToString();
            richTextBox6.Text += word[MK[1, 2] - 1].ToString();
            richTextBox7.Text += word[MK[2, 0] - 1].ToString();
            richTextBox8.Text += word[MK[2, 1] - 1].ToString();
            richTextBox9.Text += word[MK[2, 2] - 1].ToString();
        }
        void Decipher(string word)
        {
            richTextBox1.Text += word[0].ToString();
            richTextBox2.Text += word[1].ToString();
            richTextBox3.Text += word[2].ToString();
            richTextBox4.Text += word[3].ToString();
            richTextBox5.Text += word[4].ToString();
            richTextBox6.Text += word[5].ToString();
            richTextBox7.Text += word[6].ToString();
            richTextBox8.Text += word[7].ToString();
            richTextBox9.Text += word[8].ToString();
        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            string word = textBox1.Text;
            UpdateMK();
            Encryption(word);
            string encrypt = richTextBox1.Text +
            richTextBox2.Text +
            richTextBox3.Text +
            richTextBox4.Text +
            richTextBox5.Text +
            richTextBox6.Text +
            richTextBox7.Text +
            richTextBox8.Text +
            richTextBox9.Text;

            SaveToFile(encrypt);
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            string word = ReadFile();
            UpdateMK();
            Decipher(word);
            textBox2.Text = richTextBox6.Text +
            richTextBox1.Text +
            richTextBox8.Text +
            richTextBox7.Text +
            richTextBox5.Text +
            richTextBox3.Text +
            richTextBox2.Text +
            richTextBox9.Text +
            richTextBox4.Text;
        }
    }
}