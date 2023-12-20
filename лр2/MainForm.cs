using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ЗКИ;

namespace лр2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LR2 lR2 = new LR2();
            lR2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LR3 lR3 = new LR3();
            lR3.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LR4 lR4 = new LR4();
            lR4.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LR5 lR5 = new LR5();
            lR5.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LR6 lR6 = new LR6();
            lR6.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            LR8 lR8 = new LR8();
            lR8.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LR1 lR1 = new LR1();
            lR1.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            LR9 lR9 = new LR9();
            lR9.Show();
            this.Hide();
        }
    }
}
