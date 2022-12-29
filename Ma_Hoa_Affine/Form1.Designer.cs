namespace Ma_Hoa_Affine
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
            this.tbPlainText = new System.Windows.Forms.TextBox();
            this.tbCipherText = new System.Windows.Forms.TextBox();
            this.tbKey1 = new System.Windows.Forms.TextBox();
            this.tbKey2 = new System.Windows.Forms.TextBox();
            this.Ma_Hoa_Button = new System.Windows.Forms.Button();
            this.Giai_Ma_Button = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Clear_Button = new System.Windows.Forms.Button();
            this.Exit_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbPlainText
            // 
            this.tbPlainText.Location = new System.Drawing.Point(32, 47);
            this.tbPlainText.Multiline = true;
            this.tbPlainText.Name = "tbPlainText";
            this.tbPlainText.Size = new System.Drawing.Size(392, 171);
            this.tbPlainText.TabIndex = 0;
            // 
            // tbCipherText
            // 
            this.tbCipherText.Location = new System.Drawing.Point(32, 255);
            this.tbCipherText.Multiline = true;
            this.tbCipherText.Name = "tbCipherText";
            this.tbCipherText.Size = new System.Drawing.Size(392, 171);
            this.tbCipherText.TabIndex = 3;
            // 
            // tbKey1
            // 
            this.tbKey1.Location = new System.Drawing.Point(543, 47);
            this.tbKey1.Multiline = true;
            this.tbKey1.Name = "tbKey1";
            this.tbKey1.Size = new System.Drawing.Size(199, 74);
            this.tbKey1.TabIndex = 1;
            // 
            // tbKey2
            // 
            this.tbKey2.Location = new System.Drawing.Point(543, 142);
            this.tbKey2.Multiline = true;
            this.tbKey2.Name = "tbKey2";
            this.tbKey2.Size = new System.Drawing.Size(199, 76);
            this.tbKey2.TabIndex = 2;
            // 
            // Ma_Hoa_Button
            // 
            this.Ma_Hoa_Button.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Ma_Hoa_Button.Location = new System.Drawing.Point(484, 264);
            this.Ma_Hoa_Button.Name = "Ma_Hoa_Button";
            this.Ma_Hoa_Button.Size = new System.Drawing.Size(117, 38);
            this.Ma_Hoa_Button.TabIndex = 4;
            this.Ma_Hoa_Button.Text = "Mã Hoá";
            this.Ma_Hoa_Button.UseVisualStyleBackColor = true;
            this.Ma_Hoa_Button.Click += new System.EventHandler(this.Ma_Hoa_Button_Click);
            // 
            // Giai_Ma_Button
            // 
            this.Giai_Ma_Button.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Giai_Ma_Button.Location = new System.Drawing.Point(633, 264);
            this.Giai_Ma_Button.Name = "Giai_Ma_Button";
            this.Giai_Ma_Button.Size = new System.Drawing.Size(117, 38);
            this.Giai_Ma_Button.TabIndex = 5;
            this.Giai_Ma_Button.Text = "Giải Mã";
            this.Giai_Ma_Button.UseVisualStyleBackColor = true;
            this.Giai_Ma_Button.Click += new System.EventHandler(this.Giai_Ma_Button_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(484, 329);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 38);
            this.button3.TabIndex = 6;
            this.button3.Text = "Lưu";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Clear_Button
            // 
            this.Clear_Button.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Clear_Button.Location = new System.Drawing.Point(633, 329);
            this.Clear_Button.Name = "Clear_Button";
            this.Clear_Button.Size = new System.Drawing.Size(117, 38);
            this.Clear_Button.TabIndex = 7;
            this.Clear_Button.Text = "Xoá";
            this.Clear_Button.UseVisualStyleBackColor = true;
            this.Clear_Button.Click += new System.EventHandler(this.Clear_Button_Click);
            // 
            // Exit_Button
            // 
            this.Exit_Button.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Exit_Button.Location = new System.Drawing.Point(484, 390);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(258, 36);
            this.Exit_Button.TabIndex = 8;
            this.Exit_Button.Text = "Thoát";
            this.Exit_Button.UseVisualStyleBackColor = true;
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(43, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Plain Text";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(43, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Cipher Text";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(467, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Key 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(469, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 23);
            this.label4.TabIndex = 12;
            this.label4.Text = "Key 2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Exit_Button);
            this.Controls.Add(this.Clear_Button);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Giai_Ma_Button);
            this.Controls.Add(this.Ma_Hoa_Button);
            this.Controls.Add(this.tbKey2);
            this.Controls.Add(this.tbKey1);
            this.Controls.Add(this.tbCipherText);
            this.Controls.Add(this.tbPlainText);
            this.Name = "Form1";
            this.Text = "Mã Hoá Affine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbPlainText;
        private TextBox tbCipherText;
        private TextBox tbKey1;
        private TextBox tbKey2;
        private Button Ma_Hoa_Button;
        private Button Giai_Ma_Button;
        private Button button3;
        private Button Clear_Button;
        private Button Exit_Button;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}