namespace лр2
{
    partial class LR3
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
            button1 = new Button();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            richTextBox1 = new RichTextBox();
            richTextBox3 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(357, 163);
            button1.Name = "button1";
            button1.Size = new Size(94, 77);
            button1.TabIndex = 9;
            button1.Text = "выполнить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(478, 23);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(137, 24);
            radioButton2.TabIndex = 7;
            radioButton2.TabStop = true;
            radioButton2.Text = "дешифрование";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(3, 23);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(121, 24);
            radioButton1.TabIndex = 6;
            radioButton1.TabStop = true;
            radioButton1.Text = "шифрование";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(3, 163);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(320, 264);
            richTextBox1.TabIndex = 5;
            richTextBox1.Text = "";
            // 
            // richTextBox3
            // 
            richTextBox3.Location = new Point(268, 10);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new Size(157, 147);
            richTextBox3.TabIndex = 10;
            richTextBox3.Text = "";
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(478, 163);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(320, 264);
            richTextBox2.TabIndex = 8;
            richTextBox2.Text = "";
            // 
            // LR3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox3);
            Controls.Add(button1);
            Controls.Add(richTextBox2);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(richTextBox1);
            Name = "LR3";
            Text = "LR3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox3;
        private RichTextBox richTextBox2;
    }
}