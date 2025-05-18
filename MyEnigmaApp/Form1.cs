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

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            string inputText = txtInput.Text;
            string cipherKey = txtCipherKey.Text;
            Cipher.CipherMethod method;

            if (!TryGetSelectedCipherMethod(out method))
            {
                MessageBox.Show("Пожалуйста, выберите метод шифрования.");
                return;
            }

            txtResult.Text = Cipher.Encrypt(inputText, cipherKey, method);
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            string inputText = txtInput.Text;
            string cipherKey = txtCipherKey.Text;
            Cipher.CipherMethod method;

            if (!TryGetSelectedCipherMethod(out method))
            {
                MessageBox.Show("Пожалуйста, выберите метод шифрования.");
                return;
            }

            txtResult.Text = Cipher.Decrypt(inputText, cipherKey, method);
        }

        private bool TryGetSelectedCipherMethod(out Cipher.CipherMethod method)
        {
            method = Cipher.CipherMethod.VigenereRussian;

            string selected = cmbCipherMethod.SelectedItem?.ToString();
            switch (selected)
            {
                case "Ключевой сдвиг":
                    method = Cipher.CipherMethod.VigenereRussian;
                    return true;
                case "Цезарь":
                    method = Cipher.CipherMethod.Caesar;
                    return true;
                case "Обратный порядок":
                    method = Cipher.CipherMethod.Reverse;
                    return true;
                default:
                    return false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbCipherMethod.Items.AddRange(new object[]
            {
                "Ключевой сдвиг",
                "Цезарь",
                "Обратный порядок"
            });
            cmbCipherMethod.SelectedIndex = 0;
        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {
            // Можно добавить дополнительную обработку при изменении результата
        }
    }
}
