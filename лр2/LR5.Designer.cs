namespace ЗКИ
{
    partial class LR5
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
            txtRows = new RichTextBox();
            txtColumns = new RichTextBox();
            txtCryptoSchem = new RichTextBox();
            label2 = new Label();
            btnApplyFrazaCezar = new Button();
            txtMessage = new TextBox();
            label1 = new Label();
            btnApplyKeyCezar = new Button();
            txtKey = new TextBox();
            richTextBox1 = new RichTextBox();
            button1 = new Button();
            richTextBox2 = new RichTextBox();
            button2 = new Button();
            richTextBox3 = new RichTextBox();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // txtRows
            // 
            txtRows.Location = new Point(26, 198);
            txtRows.Name = "txtRows";
            txtRows.Size = new Size(47, 582);
            txtRows.TabIndex = 25;
            txtRows.Text = "";
            // 
            // txtColumns
            // 
            txtColumns.Location = new Point(79, 152);
            txtColumns.Name = "txtColumns";
            txtColumns.Size = new Size(494, 40);
            txtColumns.TabIndex = 24;
            txtColumns.Text = "";
            // 
            // txtCryptoSchem
            // 
            txtCryptoSchem.Location = new Point(79, 198);
            txtCryptoSchem.Name = "txtCryptoSchem";
            txtCryptoSchem.Size = new Size(494, 582);
            txtCryptoSchem.TabIndex = 23;
            txtCryptoSchem.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(349, 10);
            label2.Name = "label2";
            label2.Size = new Size(233, 20);
            label2.TabIndex = 22;
            label2.Text = "Сообщение ключ для Виженера";
            // 
            // btnApplyFrazaCezar
            // 
            btnApplyFrazaCezar.Location = new Point(349, 88);
            btnApplyFrazaCezar.Name = "btnApplyFrazaCezar";
            btnApplyFrazaCezar.Size = new Size(224, 42);
            btnApplyFrazaCezar.TabIndex = 21;
            btnApplyFrazaCezar.Text = "Принять";
            btnApplyFrazaCezar.UseVisualStyleBackColor = true;
            btnApplyFrazaCezar.Click += btnApplyFrazaCezar_Click;
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(349, 46);
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(224, 27);
            txtMessage.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 10);
            label1.Name = "label1";
            label1.Size = new Size(244, 20);
            label1.TabIndex = 19;
            label1.Text = "Ключ для шифрования Виженера";
            // 
            // btnApplyKeyCezar
            // 
            btnApplyKeyCezar.Location = new Point(21, 88);
            btnApplyKeyCezar.Name = "btnApplyKeyCezar";
            btnApplyKeyCezar.Size = new Size(224, 42);
            btnApplyKeyCezar.TabIndex = 18;
            btnApplyKeyCezar.Text = "Принять";
            btnApplyKeyCezar.UseVisualStyleBackColor = true;
            btnApplyKeyCezar.Click += btnApplyKeyCezar_Click;
            // 
            // txtKey
            // 
            txtKey.Location = new Point(21, 46);
            txtKey.Name = "txtKey";
            txtKey.Size = new Size(224, 27);
            txtKey.TabIndex = 17;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(653, 12);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(231, 231);
            richTextBox1.TabIndex = 26;
            richTextBox1.Text = "";
            // 
            // button1
            // 
            button1.Location = new Point(920, 165);
            button1.Name = "button1";
            button1.Size = new Size(165, 78);
            button1.TabIndex = 28;
            button1.Text = "Шифровать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(920, 12);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(405, 147);
            richTextBox2.TabIndex = 29;
            richTextBox2.Text = "";
            // 
            // button2
            // 
            button2.Location = new Point(1160, 165);
            button2.Name = "button2";
            button2.Size = new Size(165, 78);
            button2.TabIndex = 30;
            button2.Text = "Расшифровать";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // richTextBox3
            // 
            richTextBox3.Location = new Point(920, 331);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new Size(405, 147);
            richTextBox3.TabIndex = 31;
            richTextBox3.Text = "";
            // 
            // button3
            // 
            button3.Location = new Point(1160, 524);
            button3.Name = "button3";
            button3.Size = new Size(165, 78);
            button3.TabIndex = 33;
            button3.Text = "Загрузить";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(920, 524);
            button4.Name = "button4";
            button4.Size = new Size(165, 78);
            button4.TabIndex = 32;
            button4.Text = "Сохранить";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // LR5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1383, 792);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(richTextBox3);
            Controls.Add(button2);
            Controls.Add(richTextBox2);
            Controls.Add(button1);
            Controls.Add(richTextBox1);
            Controls.Add(txtRows);
            Controls.Add(txtColumns);
            Controls.Add(txtCryptoSchem);
            Controls.Add(label2);
            Controls.Add(btnApplyFrazaCezar);
            Controls.Add(txtMessage);
            Controls.Add(label1);
            Controls.Add(btnApplyKeyCezar);
            Controls.Add(txtKey);
            Name = "LR5";
            Text = "LR5";
            FormClosed += LR5_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox txtRows;
        private RichTextBox txtColumns;
        private RichTextBox txtCryptoSchem;
        private Label label2;
        private Button btnApplyFrazaCezar;
        private TextBox txtMessage;
        private Label label1;
        private Button btnApplyKeyCezar;
        private TextBox txtKey;
        private RichTextBox richTextBox1;
        private Button button1;
        private RichTextBox richTextBox2;
        private Button button2;
        private RichTextBox richTextBox3;
        private Button button3;
        private Button button4;
    }
}