namespace Hotel_Management_System_Winforrm
{
    partial class FrmDoiMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoiMatKhau));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPasswordOld = new System.Windows.Forms.TextBox();
            this.txtPasswordNew = new System.Windows.Forms.TextBox();
            this.txtPassWordNewRw = new System.Windows.Forms.TextBox();
            this.btndmk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(241, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đổi Mật Khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập Tài Khoản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật Khẩu Cũ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mật Khẩu Mới";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(92, 334);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nhập Lại Mật Khẩu Mới";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(259, 100);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(273, 22);
            this.txtUsername.TabIndex = 5;
            // 
            // txtPasswordOld
            // 
            this.txtPasswordOld.Location = new System.Drawing.Point(259, 176);
            this.txtPasswordOld.Name = "txtPasswordOld";
            this.txtPasswordOld.PasswordChar = '*';
            this.txtPasswordOld.Size = new System.Drawing.Size(273, 22);
            this.txtPasswordOld.TabIndex = 6;
            // 
            // txtPasswordNew
            // 
            this.txtPasswordNew.Location = new System.Drawing.Point(259, 259);
            this.txtPasswordNew.Name = "txtPasswordNew";
            this.txtPasswordNew.PasswordChar = '*';
            this.txtPasswordNew.Size = new System.Drawing.Size(273, 22);
            this.txtPasswordNew.TabIndex = 7;
            // 
            // txtPassWordNewRw
            // 
            this.txtPassWordNewRw.Location = new System.Drawing.Point(259, 334);
            this.txtPassWordNewRw.Name = "txtPassWordNewRw";
            this.txtPassWordNewRw.PasswordChar = '*';
            this.txtPassWordNewRw.Size = new System.Drawing.Size(273, 22);
            this.txtPassWordNewRw.TabIndex = 8;
            // 
            // btndmk
            // 
            this.btndmk.Location = new System.Drawing.Point(250, 394);
            this.btndmk.Name = "btndmk";
            this.btndmk.Size = new System.Drawing.Size(192, 44);
            this.btndmk.TabIndex = 9;
            this.btndmk.Text = "Đổi Mật Khẩu";
            this.btndmk.UseVisualStyleBackColor = true;
            this.btndmk.Click += new System.EventHandler(this.btndmk_Click);
            // 
            // FrmDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btndmk);
            this.Controls.Add(this.txtPassWordNewRw);
            this.Controls.Add(this.txtPasswordNew);
            this.Controls.Add(this.txtPasswordOld);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDoiMatKhau";
            this.Text = "Đổi Mật Khẩu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPasswordOld;
        private System.Windows.Forms.TextBox txtPasswordNew;
        private System.Windows.Forms.TextBox txtPassWordNewRw;
        private System.Windows.Forms.Button btndmk;
    }
}