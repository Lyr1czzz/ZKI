using System.Text;
using System.Windows.Forms;
using лр2;
namespace лр2
{
    public partial class LR2 : Form
    {
        private const string Key = "713254986";

        public LR2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                string message = richTextBox1.Text;
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
            int numRows = 10;
            int numCols = 9;
            int messageIndex = 0;
            char[,] table = new char[numRows, numCols];

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

            char[] keyArray = Key.ToCharArray();
            Array.Sort(keyArray);

            char[,] encryptedTable = new char[numRows, numCols];
            int keyIndex = 0;

            for (int i = 0; i < keyArray.Length; i++)
            {
                int col = int.Parse(keyArray[i].ToString()) - 1;

                for (int row = 0; row < numRows; row++)
                {
                    encryptedTable[row, col] = table[row, keyIndex];
                }

                keyIndex++;
            }

            StringBuilder encryptedMessage = new StringBuilder();
            for (int row = 0; row < numRows; row++)
            {
                for (int col = 0; col < numCols; col++)
                {
                    encryptedMessage.Append(encryptedTable[row, col]);
                }
            }

            return encryptedMessage.ToString();
        }

        private string Decrypt(string encryptedMessage)
        {
            int numRows = 10;
            int numCols = 9;
            int messageIndex = 0;
            char[,] encryptedTable = new char[numRows, numCols];

            for (int row = 0; row < numRows; row++)
            {
                for (int col = 0; col < numCols; col++)
                {
                    encryptedTable[row, col] = encryptedMessage[messageIndex++];
                }
            }

            char[,] table = new char[numRows, numCols];
            char[] keyArray = Key.ToCharArray();
            Array.Sort(keyArray);

            int keyIndex = 0;

            for (int i = 0; i < keyArray.Length; i++)
            {
                int col = int.Parse(keyArray[i].ToString()) - 1;

                for (int row = 0; row < numRows; row++)
                {
                    table[row, keyIndex] = encryptedTable[row, col];
                }

                keyIndex++;
            }

            StringBuilder decryptedMessage = new StringBuilder();
            for (int col = 0; col < numCols; col++)
            {
                for (int row = 0; row < numRows; row++)
                {
                    decryptedMessage.Append(table[row, col]);
                }
            }

            return decryptedMessage.ToString().TrimEnd();
        }
    }
}