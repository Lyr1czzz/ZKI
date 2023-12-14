namespace ЗКИ
{
    partial class LR8
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
            components = new System.ComponentModel.Container();
            label2 = new Label();
            btnApplyFrazaCezar = new Button();
            txtFrazaCezar = new TextBox();
            label1 = new Label();
            btnApplyKeyCezar = new Button();
            txtKeyCezar = new TextBox();
            btnStop = new Button();
            label3 = new Label();
            txtGamma = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            txtResult = new RichTextBox();
            label4 = new Label();
            txtMessage = new TextBox();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(340, 16);
            label2.Name = "label2";
            label2.Size = new Size(230, 20);
            label2.TabIndex = 11;
            label2.Text = "Фраза для шифрования Цезаря";
            // 
            // btnApplyFrazaCezar
            // 
            btnApplyFrazaCezar.Location = new Point(340, 94);
            btnApplyFrazaCezar.Name = "btnApplyFrazaCezar";
            btnApplyFrazaCezar.Size = new Size(224, 42);
            btnApplyFrazaCezar.TabIndex = 10;
            btnApplyFrazaCezar.Text = "Принять";
            btnApplyFrazaCezar.UseVisualStyleBackColor = true;
            btnApplyFrazaCezar.Click += btnApplyFrazaCezar_Click;
            // 
            // txtFrazaCezar
            // 
            txtFrazaCezar.Location = new Point(340, 52);
            txtFrazaCezar.Name = "txtFrazaCezar";
            txtFrazaCezar.Size = new Size(224, 27);
            txtFrazaCezar.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 16);
            label1.Name = "label1";
            label1.Size = new Size(224, 20);
            label1.TabIndex = 8;
            label1.Text = "Ключ для шифрования Цезаря";
            // 
            // btnApplyKeyCezar
            // 
            btnApplyKeyCezar.Location = new Point(12, 94);
            btnApplyKeyCezar.Name = "btnApplyKeyCezar";
            btnApplyKeyCezar.Size = new Size(224, 42);
            btnApplyKeyCezar.TabIndex = 7;
            btnApplyKeyCezar.Text = "Принять";
            btnApplyKeyCezar.UseVisualStyleBackColor = true;
            btnApplyKeyCezar.Click += btnApplyKeyCezar_Click;
            // 
            // txtKeyCezar
            // 
            txtKeyCezar.Location = new Point(12, 52);
            txtKeyCezar.Name = "txtKeyCezar";
            txtKeyCezar.Size = new Size(224, 27);
            txtKeyCezar.TabIndex = 6;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(12, 261);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(224, 42);
            btnStop.TabIndex = 12;
            btnStop.Text = "Стоп";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 183);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 13;
            label3.Text = "Гамма";
            // 
            // txtGamma
            // 
            txtGamma.Location = new Point(12, 219);
            txtGamma.Name = "txtGamma";
            txtGamma.Size = new Size(224, 27);
            txtGamma.TabIndex = 14;
            // 
            // timer1
            // 
            timer1.Interval = 500;
            timer1.Tick += timer1_Tick;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(12, 522);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(558, 101);
            txtResult.TabIndex = 15;
            txtResult.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 499);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 16;
            label4.Text = "Результат";
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(340, 219);
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(224, 27);
            txtMessage.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(340, 183);
            label5.Name = "label5";
            label5.Size = new Size(91, 20);
            label5.TabIndex = 18;
            label5.Text = "Сообщение";
            // 
            // button1
            // 
            button1.Location = new Point(340, 261);
            button1.Name = "button1";
            button1.Size = new Size(224, 42);
            button1.TabIndex = 17;
            button1.Text = "шифровать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(697, 219);
            button2.Name = "button2";
            button2.Size = new Size(224, 126);
            button2.TabIndex = 20;
            button2.Text = "разшифровать";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(697, 176);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(224, 27);
            textBox1.TabIndex = 21;
            // 
            // LR8
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1109, 688);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(txtMessage);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(txtResult);
            Controls.Add(txtGamma);
            Controls.Add(label3);
            Controls.Add(btnStop);
            Controls.Add(label2);
            Controls.Add(btnApplyFrazaCezar);
            Controls.Add(txtFrazaCezar);
            Controls.Add(label1);
            Controls.Add(btnApplyKeyCezar);
            Controls.Add(txtKeyCezar);
            Name = "LR8";
            Text = "LR8";
            FormClosed += LR8_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button btnApplyFrazaCezar;
        private TextBox txtFrazaCezar;
        private Label label1;
        private Button btnApplyKeyCezar;
        private TextBox txtKeyCezar;
        private Button btnStop;
        private Label label3;
        private TextBox txtGamma;
        private System.Windows.Forms.Timer timer1;
        private RichTextBox txtResult;
        private Label label4;
        private TextBox txtMessage;
        private Label label5;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
    }
}