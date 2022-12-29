namespace Bai1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Upload = new System.Windows.Forms.Button();
            this.txb_File = new System.Windows.Forms.TextBox();
            this.btn_Encrypt = new System.Windows.Forms.Button();
            this.btn_Decrypt = new System.Windows.Forms.Button();
            this.txb_Encrypt = new System.Windows.Forms.TextBox();
            this.txb_Decrypt = new System.Windows.Forms.TextBox();
            this.txb_Message = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Upload
            // 
            this.btn_Upload.Location = new System.Drawing.Point(39, 22);
            this.btn_Upload.Name = "btn_Upload";
            this.btn_Upload.Size = new System.Drawing.Size(103, 50);
            this.btn_Upload.TabIndex = 1;
            this.btn_Upload.Text = "Tải lên";
            this.btn_Upload.UseVisualStyleBackColor = true;
            this.btn_Upload.Click += new System.EventHandler(this.btn_Upload_Click);
            // 
            // txb_File
            // 
            this.txb_File.Location = new System.Drawing.Point(162, 34);
            this.txb_File.Name = "txb_File";
            this.txb_File.Size = new System.Drawing.Size(467, 27);
            this.txb_File.TabIndex = 2;
            // 
            // btn_Encrypt
            // 
            this.btn_Encrypt.Location = new System.Drawing.Point(39, 212);
            this.btn_Encrypt.Name = "btn_Encrypt";
            this.btn_Encrypt.Size = new System.Drawing.Size(103, 54);
            this.btn_Encrypt.TabIndex = 3;
            this.btn_Encrypt.Text = "Encrypt";
            this.btn_Encrypt.UseVisualStyleBackColor = true;
            this.btn_Encrypt.Click += new System.EventHandler(this.btn_Encrypt_Click);
            // 
            // btn_Decrypt
            // 
            this.btn_Decrypt.Location = new System.Drawing.Point(39, 338);
            this.btn_Decrypt.Name = "btn_Decrypt";
            this.btn_Decrypt.Size = new System.Drawing.Size(103, 54);
            this.btn_Decrypt.TabIndex = 4;
            this.btn_Decrypt.Text = "Decrypt";
            this.btn_Decrypt.UseVisualStyleBackColor = true;
            this.btn_Decrypt.Click += new System.EventHandler(this.btn_Decrypt_Click);
            // 
            // txb_Encrypt
            // 
            this.txb_Encrypt.Location = new System.Drawing.Point(162, 197);
            this.txb_Encrypt.Multiline = true;
            this.txb_Encrypt.Name = "txb_Encrypt";
            this.txb_Encrypt.Size = new System.Drawing.Size(467, 83);
            this.txb_Encrypt.TabIndex = 5;
            // 
            // txb_Decrypt
            // 
            this.txb_Decrypt.Location = new System.Drawing.Point(162, 316);
            this.txb_Decrypt.Multiline = true;
            this.txb_Decrypt.Name = "txb_Decrypt";
            this.txb_Decrypt.Size = new System.Drawing.Size(467, 83);
            this.txb_Decrypt.TabIndex = 6;
            // 
            // txb_Message
            // 
            this.txb_Message.Location = new System.Drawing.Point(162, 86);
            this.txb_Message.Multiline = true;
            this.txb_Message.Name = "txb_Message";
            this.txb_Message.Size = new System.Drawing.Size(467, 83);
            this.txb_Message.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(39, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Thông điệp";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 429);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txb_Message);
            this.Controls.Add(this.txb_Decrypt);
            this.Controls.Add(this.txb_Encrypt);
            this.Controls.Add(this.btn_Decrypt);
            this.Controls.Add(this.btn_Encrypt);
            this.Controls.Add(this.txb_File);
            this.Controls.Add(this.btn_Upload);
            this.Name = "Form1";
            this.Text = "Mã Hóa RSA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btn_Upload;
        private TextBox txb_File;
        private Button btn_Encrypt;
        private Button btn_Decrypt;
        private TextBox txb_Encrypt;
        private TextBox txb_Decrypt;
        private TextBox txb_Message;
        private Label label1;
    }
}