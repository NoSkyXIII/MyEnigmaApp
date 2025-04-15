namespace MyEnigmaApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtCipherKey;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Label lblCipherKey;
        private System.Windows.Forms.Label lblResult;

        // Инициализация компонентов
        private void InitializeComponent()
        {
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtCipherKey = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.lblInput = new System.Windows.Forms.Label();
            this.lblCipherKey = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();

            // txtInput
            this.txtInput.Location = new System.Drawing.Point(15, 30);
            this.txtInput.Multiline = true;
            this.txtInput.Size = new System.Drawing.Size(400, 100);

            // txtCipherKey
            this.txtCipherKey.Location = new System.Drawing.Point(15, 150);
            this.txtCipherKey.Size = new System.Drawing.Size(400, 20);

            // txtResult
            this.txtResult.Location = new System.Drawing.Point(15, 200);
            this.txtResult.Multiline = true;
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(400, 100);

            // btnEncrypt
            this.btnEncrypt.Location = new System.Drawing.Point(15, 310);
            this.btnEncrypt.Size = new System.Drawing.Size(100, 30);
            this.btnEncrypt.Text = "Зашифровать";
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);

            // btnDecrypt
            this.btnDecrypt.Location = new System.Drawing.Point(125, 310);
            this.btnDecrypt.Size = new System.Drawing.Size(100, 30);
            this.btnDecrypt.Text = "Дешифровать";
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);

            // lblInput
            this.lblInput.Location = new System.Drawing.Point(15, 10);
            this.lblInput.Text = "Введите текст:";

            // lblCipherKey
            this.lblCipherKey.Location = new System.Drawing.Point(15, 130);
            this.lblCipherKey.Text = "Введите фразу для шифра:";

            // lblResult
            this.lblResult.Location = new System.Drawing.Point(15, 180);
            this.lblResult.Text = "Результат:";

            // Form1
            this.ClientSize = new System.Drawing.Size(450, 360);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.txtCipherKey);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.lblCipherKey);
            this.Controls.Add(this.lblResult);
            this.Text = "Шифровка Энигма";
        }
    }
}
