namespace Hacking
{
    partial class Form1
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
            this.InputedText = new System.Windows.Forms.TextBox();
            this.CryptedText = new System.Windows.Forms.TextBox();
            this.txtBPublicKey = new System.Windows.Forms.Label();
            this.txtBSecretKey = new System.Windows.Forms.Label();
            this.DecryptedText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // InputedText
            // 
            this.InputedText.Location = new System.Drawing.Point(27, 69);
            this.InputedText.Multiline = true;
            this.InputedText.Name = "InputedText";
            this.InputedText.Size = new System.Drawing.Size(200, 223);
            this.InputedText.TabIndex = 1;
            this.InputedText.TextChanged += new System.EventHandler(this.InputedText_TextChanged);
            // 
            // CryptedText
            // 
            this.CryptedText.Location = new System.Drawing.Point(294, 69);
            this.CryptedText.Multiline = true;
            this.CryptedText.Name = "CryptedText";
            this.CryptedText.Size = new System.Drawing.Size(200, 223);
            this.CryptedText.TabIndex = 2;
            // 
            // txtBPublicKey
            // 
            this.txtBPublicKey.AutoSize = true;
            this.txtBPublicKey.Location = new System.Drawing.Point(121, 316);
            this.txtBPublicKey.Name = "txtBPublicKey";
            this.txtBPublicKey.Size = new System.Drawing.Size(87, 13);
            this.txtBPublicKey.TabIndex = 3;
            this.txtBPublicKey.Text = "Открытый ключ";
            // 
            // txtBSecretKey
            // 
            this.txtBSecretKey.AutoSize = true;
            this.txtBSecretKey.Location = new System.Drawing.Point(121, 351);
            this.txtBSecretKey.Name = "txtBSecretKey";
            this.txtBSecretKey.Size = new System.Drawing.Size(87, 13);
            this.txtBSecretKey.TabIndex = 4;
            this.txtBSecretKey.Text = "Закрытый ключ";
            // 
            // DecryptedText
            // 
            this.DecryptedText.Location = new System.Drawing.Point(559, 69);
            this.DecryptedText.Multiline = true;
            this.DecryptedText.Name = "DecryptedText";
            this.DecryptedText.Size = new System.Drawing.Size(200, 223);
            this.DecryptedText.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 450);
            this.Controls.Add(this.DecryptedText);
            this.Controls.Add(this.txtBSecretKey);
            this.Controls.Add(this.txtBPublicKey);
            this.Controls.Add(this.CryptedText);
            this.Controls.Add(this.InputedText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox InputedText;
        private System.Windows.Forms.TextBox CryptedText;
        private System.Windows.Forms.Label txtBPublicKey;
        private System.Windows.Forms.Label txtBSecretKey;
        private System.Windows.Forms.TextBox DecryptedText;
    }
}

