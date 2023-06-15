namespace Hotel_Management_System_Winforrm
{
    partial class QuenMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuenMatKhau));
            this.label3 = new System.Windows.Forms.Label();
            this.btn_RePass = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRePassWord = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(278, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 9;
            // 
            // btn_RePass
            // 
            this.btn_RePass.Location = new System.Drawing.Point(259, 278);
            this.btn_RePass.Name = "btn_RePass";
            this.btn_RePass.Size = new System.Drawing.Size(270, 36);
            this.btn_RePass.TabIndex = 8;
            this.btn_RePass.Text = "Lấy Lại Mật Khẩu";
            this.btn_RePass.UseVisualStyleBackColor = true;
            this.btn_RePass.Click += new System.EventHandler(this.btn_RePass_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Thông Tin Tài Khoản ";
            // 
            // txtRePassWord
            // 
            this.txtRePassWord.Location = new System.Drawing.Point(281, 157);
            this.txtRePassWord.Name = "txtRePassWord";
            this.txtRePassWord.Size = new System.Drawing.Size(295, 22);
            this.txtRePassWord.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Số Điện Thoại Đăng Kí";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(275, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 33);
            this.label4.TabIndex = 10;
            this.label4.Text = "Quên Mật Khẩu ";
            // 
            // QuenMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_RePass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRePassWord);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QuenMatKhau";
            this.Text = "Quên Mật Khẩu";
            this.Load += new System.EventHandler(this.QuenMatKhau_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_RePass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRePassWord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}