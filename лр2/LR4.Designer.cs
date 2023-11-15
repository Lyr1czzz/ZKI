namespace ЗКИ
{
    partial class LR4
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
            txtKeyCezar = new TextBox();
            btnApplyKeyCezar = new Button();
            label1 = new Label();
            label2 = new Label();
            btnApplyFrazaCezar = new Button();
            txtFrazaCezar = new TextBox();
            txtCryptoSchem = new RichTextBox();
            txtMessageForEncrypt = new RichTextBox();
            btnEncrypt = new Button();
            btnDecrypt = new Button();
            label3 = new Label();
            label4 = new Label();
            btnUpload = new Button();
            btnSave = new Button();
            txtAnswer = new RichTextBox();
            txtColumns = new RichTextBox();
            txtRows = new RichTextBox();
            SuspendLayout();
            // 
            // txtKeyCezar
            // 
            txtKeyCezar.Location = new Point(48, 56);
            txtKeyCezar.Name = "txtKeyCezar";
            txtKeyCezar.Size = new Size(224, 27);
            txtKeyCezar.TabIndex = 0;
            // 
            // btnApplyKeyCezar
            // 
            btnApplyKeyCezar.Location = new Point(48, 98);
            btnApplyKeyCezar.Name = "btnApplyKeyCezar";
            btnApplyKeyCezar.Size = new Size(224, 42);
            btnApplyKeyCezar.TabIndex = 1;
            btnApplyKeyCezar.Text = "Принять";
            btnApplyKeyCezar.UseVisualStyleBackColor = true;
            btnApplyKeyCezar.Click += btnApplyKeyCezar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 20);
            label1.Name = "label1";
            label1.Size = new Size(224, 20);
            label1.TabIndex = 2;
            label1.Text = "Ключ для шифрования Цезаря";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(376, 20);
            label2.Name = "label2";
            label2.Size = new Size(230, 20);
            label2.TabIndex = 5;
            label2.Text = "Фраза для шифрования Цезаря";
            // 
            // btnApplyFrazaCezar
            // 
            btnApplyFrazaCezar.Location = new Point(376, 98);
            btnApplyFrazaCezar.Name = "btnApplyFrazaCezar";
            btnApplyFrazaCezar.Size = new Size(224, 42);
            btnApplyFrazaCezar.TabIndex = 4;
            btnApplyFrazaCezar.Text = "Принять";
            btnApplyFrazaCezar.UseVisualStyleBackColor = true;
            btnApplyFrazaCezar.Click += btnApplyFrazaCezar_Click;
            // 
            // txtFrazaCezar
            // 
            txtFrazaCezar.Location = new Point(376, 56);
            txtFrazaCezar.Name = "txtFrazaCezar";
            txtFrazaCezar.Size = new Size(224, 27);
            txtFrazaCezar.TabIndex = 3;
            // 
            // txtCryptoSchem
            // 
            txtCryptoSchem.Location = new Point(106, 208);
            txtCryptoSchem.Name = "txtCryptoSchem";
            txtCryptoSchem.Size = new Size(494, 582);
            txtCryptoSchem.TabIndex = 6;
            txtCryptoSchem.Text = "";
            // 
            // txtMessageForEncrypt
            // 
            txtMessageForEncrypt.Location = new Point(682, 65);
            txtMessageForEncrypt.Name = "txtMessageForEncrypt";
            txtMessageForEncrypt.Size = new Size(500, 185);
            txtMessageForEncrypt.TabIndex = 7;
            txtMessageForEncrypt.Text = "";
            // 
            // btnEncrypt
            // 
            btnEncrypt.Location = new Point(682, 269);
            btnEncrypt.Name = "btnEncrypt";
            btnEncrypt.Size = new Size(224, 42);
            btnEncrypt.TabIndex = 8;
            btnEncrypt.Text = "Зашифровать";
            btnEncrypt.UseVisualStyleBackColor = true;
            btnEncrypt.Click += btnEncrypt_Click;
            // 
            // btnDecrypt
            // 
            btnDecrypt.Location = new Point(958, 269);
            btnDecrypt.Name = "btnDecrypt";
            btnDecrypt.Size = new Size(224, 42);
            btnDecrypt.TabIndex = 9;
            btnDecrypt.Text = "Дешифровать";
            btnDecrypt.UseVisualStyleBackColor = true;
            btnDecrypt.Click += btnDecrypt_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(676, 20);
            label3.Name = "label3";
            label3.Size = new Size(532, 20);
            label3.TabIndex = 10;
            label3.Text = "Сообщение для шифрования\\расшифрования по криптосистемее Вижена";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(676, 364);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 14;
            label4.Text = "Вывод";
            // 
            // btnUpload
            // 
            btnUpload.Location = new Point(958, 613);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(224, 42);
            btnUpload.TabIndex = 13;
            btnUpload.Text = "Загрузить";
            btnUpload.UseVisualStyleBackColor = true;
            btnUpload.Click += btnUpload_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(682, 613);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(224, 42);
            btnSave.TabIndex = 12;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtAnswer
            // 
            txtAnswer.Location = new Point(682, 409);
            txtAnswer.Name = "txtAnswer";
            txtAnswer.Size = new Size(500, 185);
            txtAnswer.TabIndex = 11;
            txtAnswer.Text = "";
            // 
            // txtColumns
            // 
            txtColumns.Location = new Point(106, 162);
            txtColumns.Name = "txtColumns";
            txtColumns.Size = new Size(494, 40);
            txtColumns.TabIndex = 15;
            txtColumns.Text = "";
            // 
            // txtRows
            // 
            txtRows.Location = new Point(53, 208);
            txtRows.Name = "txtRows";
            txtRows.Size = new Size(47, 582);
            txtRows.TabIndex = 16;
            txtRows.Text = "";
            // 
            // LR4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1231, 803);
            Controls.Add(txtRows);
            Controls.Add(txtColumns);
            Controls.Add(label4);
            Controls.Add(btnUpload);
            Controls.Add(btnSave);
            Controls.Add(txtAnswer);
            Controls.Add(label3);
            Controls.Add(btnDecrypt);
            Controls.Add(btnEncrypt);
            Controls.Add(txtMessageForEncrypt);
            Controls.Add(txtCryptoSchem);
            Controls.Add(label2);
            Controls.Add(btnApplyFrazaCezar);
            Controls.Add(txtFrazaCezar);
            Controls.Add(label1);
            Controls.Add(btnApplyKeyCezar);
            Controls.Add(txtKeyCezar);
            Name = "LR4";
            Text = "LR4";
            FormClosing += LR4_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtKeyCezar;
        private Button btnApplyKeyCezar;
        private Label label1;
        private Label label2;
        private Button btnApplyFrazaCezar;
        private TextBox txtFrazaCezar;
        private RichTextBox txtCryptoSchem;
        private RichTextBox txtMessageForEncrypt;
        private Button btnEncrypt;
        private Button btnDecrypt;
        private Label label3;
        private Label label4;
        private Button btnUpload;
        private Button btnSave;
        private RichTextBox txtAnswer;
        private RichTextBox txtColumns;
        private RichTextBox txtRows;
    }
}