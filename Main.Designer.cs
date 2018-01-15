namespace AESTOOL
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.encrypt = new System.Windows.Forms.Button();
            this.inputText = new System.Windows.Forms.RichTextBox();
            this.outputText = new System.Windows.Forms.RichTextBox();
            this.decrypt = new System.Windows.Forms.Button();
            this.encryptBase64 = new System.Windows.Forms.Button();
            this.decryptBase64 = new System.Windows.Forms.Button();
            this.formatJson = new System.Windows.Forms.Button();
            this.encryptSHA256 = new System.Windows.Forms.Button();
            this.aesKey = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // encrypt
            // 
            this.encrypt.Font = new System.Drawing.Font("等线", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.encrypt.Location = new System.Drawing.Point(10, 141);
            this.encrypt.Name = "encrypt";
            this.encrypt.Size = new System.Drawing.Size(80, 80);
            this.encrypt.TabIndex = 0;
            this.encrypt.Text = "↑\r\n加密\r\nTo\r\nHex";
            this.encrypt.UseVisualStyleBackColor = true;
            this.encrypt.Click += new System.EventHandler(this.encrypt_Click);
            // 
            // inputText
            // 
            this.inputText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputText.Location = new System.Drawing.Point(10, 227);
            this.inputText.Name = "inputText";
            this.inputText.Size = new System.Drawing.Size(511, 123);
            this.inputText.TabIndex = 11;
            this.inputText.Text = "";
            // 
            // outputText
            // 
            this.outputText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputText.Location = new System.Drawing.Point(10, 12);
            this.outputText.Name = "outputText";
            this.outputText.Size = new System.Drawing.Size(511, 123);
            this.outputText.TabIndex = 10;
            this.outputText.Text = "";
            // 
            // decrypt
            // 
            this.decrypt.Font = new System.Drawing.Font("等线", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.decrypt.Location = new System.Drawing.Point(268, 141);
            this.decrypt.Name = "decrypt";
            this.decrypt.Size = new System.Drawing.Size(80, 80);
            this.decrypt.TabIndex = 2;
            this.decrypt.Text = "解密\r\nFrom\r\nHex\r\n↓";
            this.decrypt.UseVisualStyleBackColor = true;
            this.decrypt.Click += new System.EventHandler(this.decrypt_Click);
            // 
            // encryptBase64
            // 
            this.encryptBase64.Font = new System.Drawing.Font("等线", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.encryptBase64.Location = new System.Drawing.Point(96, 141);
            this.encryptBase64.Name = "encryptBase64";
            this.encryptBase64.Size = new System.Drawing.Size(80, 80);
            this.encryptBase64.TabIndex = 1;
            this.encryptBase64.Text = "↑\r\n加密\r\nTo\r\nBase64";
            this.encryptBase64.UseVisualStyleBackColor = true;
            this.encryptBase64.Click += new System.EventHandler(this.encryptBase64_Click);
            // 
            // decryptBase64
            // 
            this.decryptBase64.Font = new System.Drawing.Font("等线", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.decryptBase64.Location = new System.Drawing.Point(354, 141);
            this.decryptBase64.Name = "decryptBase64";
            this.decryptBase64.Size = new System.Drawing.Size(80, 80);
            this.decryptBase64.TabIndex = 3;
            this.decryptBase64.Text = "解密\r\nFrom\r\nBase64\r\n↓";
            this.decryptBase64.UseVisualStyleBackColor = true;
            this.decryptBase64.Click += new System.EventHandler(this.decryptBase64_Click);
            // 
            // formatJson
            // 
            this.formatJson.Font = new System.Drawing.Font("等线", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.formatJson.Location = new System.Drawing.Point(440, 141);
            this.formatJson.Name = "formatJson";
            this.formatJson.Size = new System.Drawing.Size(80, 80);
            this.formatJson.TabIndex = 5;
            this.formatJson.Text = "格式化\r\nto\r\nJson\r\n↓";
            this.formatJson.UseVisualStyleBackColor = true;
            this.formatJson.Click += new System.EventHandler(this.formatJson_Click);
            // 
            // encryptSHA256
            // 
            this.encryptSHA256.Font = new System.Drawing.Font("等线", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.encryptSHA256.Location = new System.Drawing.Point(182, 141);
            this.encryptSHA256.Name = "encryptSHA256";
            this.encryptSHA256.Size = new System.Drawing.Size(80, 80);
            this.encryptSHA256.TabIndex = 7;
            this.encryptSHA256.Text = "↑\r\n加密\r\nto\r\nSHA256";
            this.encryptSHA256.UseVisualStyleBackColor = true;
            this.encryptSHA256.Click += new System.EventHandler(this.encryptSHA256_Click);
            // 
            // aesKey
            // 
            this.aesKey.Location = new System.Drawing.Point(6, 20);
            this.aesKey.Name = "aesKey";
            this.aesKey.Size = new System.Drawing.Size(191, 21);
            this.aesKey.TabIndex = 12;
            this.aesKey.Text = "0123456789abcdef";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.aesKey);
            this.groupBox1.Location = new System.Drawing.Point(545, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(203, 50);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "AES加密Key(16个字符)";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 362);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.encryptSHA256);
            this.Controls.Add(this.formatJson);
            this.Controls.Add(this.encrypt);
            this.Controls.Add(this.encryptBase64);
            this.Controls.Add(this.decryptBase64);
            this.Controls.Add(this.decrypt);
            this.Controls.Add(this.inputText);
            this.Controls.Add(this.outputText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(547, 401);
            this.Name = "Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AESTOOL";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button encrypt;
        private System.Windows.Forms.RichTextBox inputText;
        private System.Windows.Forms.RichTextBox outputText;
        private System.Windows.Forms.Button decrypt;
        private System.Windows.Forms.Button encryptBase64;
        private System.Windows.Forms.Button decryptBase64;
        private System.Windows.Forms.Button formatJson;
        private System.Windows.Forms.Button encryptSHA256;
        private System.Windows.Forms.TextBox aesKey;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

