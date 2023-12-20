namespace ЗКИ
{
    partial class LR9
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            richTextBox1 = new RichTextBox();
            button1 = new Button();
            richTextBox2 = new RichTextBox();
            richTextBox3 = new RichTextBox();
            button2 = new Button();
            txt = new RichTextBox();
            txtM = new RichTextBox();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 12);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(305, 120);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // button1
            // 
            button1.Location = new Point(12, 138);
            button1.Name = "button1";
            button1.Size = new Size(305, 49);
            button1.TabIndex = 1;
            button1.Text = "Шифровать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(12, 347);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(470, 61);
            richTextBox2.TabIndex = 2;
            richTextBox2.Text = "";
            // 
            // richTextBox3
            // 
            richTextBox3.Location = new Point(12, 414);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new Size(470, 61);
            richTextBox3.TabIndex = 3;
            richTextBox3.Text = "";
            // 
            // button2
            // 
            button2.Location = new Point(12, 481);
            button2.Name = "button2";
            button2.Size = new Size(470, 36);
            button2.TabIndex = 4;
            button2.Text = "Дешифровать";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txt
            // 
            txt.Location = new Point(498, 12);
            txt.Name = "txt";
            txt.Size = new Size(407, 291);
            txt.TabIndex = 5;
            txt.Text = "";
            // 
            // txtM
            // 
            txtM.Location = new Point(498, 347);
            txtM.Name = "txtM";
            txtM.Size = new Size(407, 170);
            txtM.TabIndex = 6;
            txtM.Text = "";
            // 
            // LR9
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(917, 529);
            Controls.Add(txtM);
            Controls.Add(txt);
            Controls.Add(button2);
            Controls.Add(richTextBox3);
            Controls.Add(richTextBox2);
            Controls.Add(button1);
            Controls.Add(richTextBox1);
            Name = "LR9";
            Text = "LR9";
            FormClosed += LR9_FormClosed;
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button button1;
        private RichTextBox richTextBox2;
        private RichTextBox richTextBox3;
        private Button button2;
        private RichTextBox txt;
        private RichTextBox txtM;
    }
}