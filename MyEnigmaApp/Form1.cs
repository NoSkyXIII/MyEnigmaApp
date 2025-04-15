using System;
using System.Windows.Forms;

namespace MyEnigmaApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Обработчик кнопки "Зашифровать"
        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            // Получаем текст из поля для ввода и фразу для шифра
            string inputText = txtInput.Text;
            string cipherKey = txtCipherKey.Text;

            // Шифруем текст с помощью класса Cipher
            string encryptedText = Cipher.Encrypt(inputText, cipherKey);

            // Отображаем зашифрованный текст в поле для результата
            txtResult.Text = encryptedText;
        }

        // Обработчик кнопки "Дешифровать"
        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtInput.Text) || string.IsNullOrWhiteSpace(txtCipherKey.Text))
            {
                MessageBox.Show("Введите зашифрованный текст и фразу для шифра.");
                return;
            }

            txtResult.Text = Cipher.Decrypt(txtInput.Text, txtCipherKey.Text);
        }

    }
}
