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
    public partial class LR6 : Form
    {
        public LR6()
        {
            InitializeComponent();
        }

        public string Letters = "abcdefghijklmnopqrstuvwxyz";
        public string[] Alf { get; set; }
        public string[] Alf2 { get; set; }
        public string[] Alf3 { get; set; }

        public void SetAlf(string key)
        {
            for (int i = 0; i < key.Length; i++)
            {
                if (richTextBox1.Text.IndexOf(key[i]) == -1)
                {
                    richTextBox1.Text += key[i];
                }
                else if (i % 6 == 0)
                {
                    richTextBox1.Text += '\n';
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

        public void SetAlf2(string key)
        {
            for (int i = 0; i < key.Length; i++)
            {
                if (richTextBox5.Text.IndexOf(key[i]) == -1)
                {
                    richTextBox5.Text += key[i];
                }
                else if (i % 5 == 0)
                {
                    richTextBox5.Text += '\n';
                }
            }
            int count = richTextBox5.Text.Length;
            for (int i = 0; i < Letters.Length; i++)
            {
                if (richTextBox5.Text.IndexOf(Letters[i]) == -1)
                {
                    richTextBox5.Text += Letters[i];
                    count++;
                    if (count % 5 == 0)
                    {
                        richTextBox5.Text += "\n";
                    }
                }
            }
            richTextBox5.Text += ",. -";

            Alf2 = richTextBox5.Text.Split('\n');
        }

        public void SetAlf3(string key)
        {
            for (int i = 0; i < key.Length; i++)
            {
                if (richTextBox4.Text.IndexOf(key[i]) == -1)
                {
                    richTextBox4.Text += key[i];
                }
                else if (i % 6 == 0)
                {
                    richTextBox4.Text += '\n';
                }
            }
            int count = richTextBox4.Text.Length;
            for (int i = 0; i < Letters.Length; i++)
            {
                if (richTextBox4.Text.IndexOf(Letters[i]) == -1)
                {
                    richTextBox4.Text += Letters[i];
                    count++;
                    if (count % 5 == 0)
                    {
                        richTextBox4.Text += "\n";
                    }
                }
            }
            richTextBox4.Text += ",. -";

            Alf3 = richTextBox4.Text.Split('\n');
        }

        public string EncruptPlef(string message)
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
            return encruptMessage.ToString();
        }

        public void EncruptVitson(string message)
        {
            StringBuilder encruptMessage = new StringBuilder();
            for (int i = 0; i < message.Length - 1; i += 2)
            {
                int row1 = 0, row2 = 0;
                int col1 = 0, col2 = 0;
                for (int j = 0; j < Alf2.Length; j++)
                {

                    for (int k = 0; k < Alf2[0].Length; k++)
                    {
                        if (message[i] == Alf2[j][k])
                        {
                            row1 = j;
                            col1 = k;
                        }

                    }
                }
                for (int j = 0; j < Alf3.Length; j++)
                {

                    for (int k = 0; k < Alf3[0].Length; k++)
                    {
                        if (message[i + 1] == Alf3[j][k])
                        {
                            row2 = j;
                            col2 = k;
                        }

                    }
                }
                if (row1 != row2 && col1 != col2)
                {
                    encruptMessage.Append(Alf3[row1][col2]);
                    encruptMessage.Append(Alf2[row2][col1]);
                    continue;
                }
                else
                {
                    encruptMessage.Append(Alf3[row1][col1]);
                    encruptMessage.Append(Alf2[row2][col2]);
                    continue;
                }
            }
            richTextBox3.Text += '\n' + encruptMessage.ToString();
        }

        public void DencruptVitson(string message)
        {
            StringBuilder encruptMessage = new StringBuilder();
            for (int i = 0; i < message.Length - 1; i += 2)
            {
                int row1 = 0, row2 = 0;
                int col1 = 0, col2 = 0;
                for (int j = 0; j < Alf3.Length; j++)
                {

                    for (int k = 0; k < Alf3[0].Length; k++)
                    {
                        if (message[i] == Alf3[j][k])
                        {
                            row1 = j;
                            col1 = k;
                        }

                    }
                }
                for (int j = 0; j < Alf2.Length; j++)
                {

                    for (int k = 0; k < Alf2[0].Length; k++)
                    {
                        if (message[i + 1] == Alf2[j][k])
                        {
                            row2 = j;
                            col2 = k;
                        }

                    }
                }
                if (row1 != row2 && col1 != col2)
                {
                    encruptMessage.Append(Alf2[row1][col2]);
                    encruptMessage.Append(Alf3[row2][col1]);
                    continue;
                }
                else
                {
                    encruptMessage.Append(Alf2[row1][col1]);
                    encruptMessage.Append(Alf3[row2][col2]);
                    continue;
                }
            }
            richTextBox3.Text += '\n' + encruptMessage.ToString();
        }

        private void btnApplyKeyCezar_Click(object sender, EventArgs e)
        {
            SetAlf(txtKey.Text);
        }

        private void LR6_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnApplyFraza1_Click(object sender, EventArgs e)
        {
            SetAlf2(EncruptPlef(txtMessage.Text));
        }

        private void btnAply2_Click(object sender, EventArgs e)
        {
            SetAlf3(EncruptPlef(txtMessage.Text));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EncruptVitson(richTextBox2.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DencruptVitson(richTextBox2.Text);
        }
    }
}
