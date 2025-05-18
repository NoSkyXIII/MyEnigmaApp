using System.Reflection;

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
        private System.Windows.Forms.Label lblMethod;
        private System.Windows.Forms.ComboBox cmbCipherMethod;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

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
            this.lblMethod = new System.Windows.Forms.Label();
            this.cmbCipherMethod = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInput.Location = new System.Drawing.Point(15, 30);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(600, 100);
            this.txtInput.TabIndex = 0;
            // 
            // txtCipherKey
            // 
            this.txtCipherKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCipherKey.Location = new System.Drawing.Point(15, 150);
            this.txtCipherKey.Name = "txtCipherKey";
            this.txtCipherKey.Size = new System.Drawing.Size(600, 20);
            this.txtCipherKey.TabIndex = 1;
            // 
            // txtResult
            // 
            this.txtResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResult.Location = new System.Drawing.Point(15, 230);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(600, 150);
            this.txtResult.TabIndex = 2;
            this.txtResult.TextChanged += new System.EventHandler(this.txtResult_TextChanged);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEncrypt.Location = new System.Drawing.Point(15, 390);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(100, 30);
            this.btnEncrypt.TabIndex = 3;
            this.btnEncrypt.Text = "Зашифровать";
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDecrypt.Location = new System.Drawing.Point(125, 390);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(100, 30);
            this.btnDecrypt.TabIndex = 4;
            this.btnDecrypt.Text = "Дешифровать";
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(15, 10);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(86, 13);
            this.lblInput.TabIndex = 5;
            this.lblInput.Text = "Введите текст:";
            // 
            // lblCipherKey
            // 
            this.lblCipherKey.AutoSize = true;
            this.lblCipherKey.Location = new System.Drawing.Point(15, 130);
            this.lblCipherKey.Name = "lblCipherKey";
            this.lblCipherKey.Size = new System.Drawing.Size(158, 13);
            this.lblCipherKey.TabIndex = 6;
            this.lblCipherKey.Text = "Введите фразу для шифра:";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(15, 210);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(61, 13);
            this.lblResult.TabIndex = 7;
            this.lblResult.Text = "Результат:";
            // 
            // lblMethod
            // 
            this.lblMethod.AutoSize = true;
            this.lblMethod.Location = new System.Drawing.Point(15, 180);
            this.lblMethod.Name = "lblMethod";
            this.lblMethod.Size = new System.Drawing.Size(119, 13);
            this.lblMethod.TabIndex = 8;
            this.lblMethod.Text = "Метод шифрования:";
            // 
            // cmbCipherMethod
            // 
            this.cmbCipherMethod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCipherMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCipherMethod.FormattingEnabled = true;
            this.cmbCipherMethod.Location = new System.Drawing.Point(170, 177);
            this.cmbCipherMethod.Name = "cmbCipherMethod";
            this.cmbCipherMethod.Size = new System.Drawing.Size(445, 21);
            this.cmbCipherMethod.TabIndex = 9;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(634, 441);
            this.Controls.Add(this.cmbCipherMethod);
            this.Controls.Add(this.lblMethod);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblCipherKey);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtCipherKey);
            this.Controls.Add(this.txtInput);
            this.MinimumSize = new System.Drawing.Size(500, 480);
            this.Name = "Form1";
            this.Text = "Enigma Simulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
