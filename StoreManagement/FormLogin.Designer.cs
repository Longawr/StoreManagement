namespace StoreManagement
{
    partial class FormLogin
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
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.hidebtn = new System.Windows.Forms.Button();
            this.testCbx = new System.Windows.Forms.CheckBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tbxMatKhau = new System.Windows.Forms.TextBox();
            this.tbxTaiKhoan = new System.Windows.Forms.TextBox();
            this.lblTenKH = new System.Windows.Forms.Label();
            this.lblMaPL = new System.Windows.Forms.Label();
            this.pnlLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLogin
            // 
            this.pnlLogin.Controls.Add(this.hidebtn);
            this.pnlLogin.Controls.Add(this.testCbx);
            this.pnlLogin.Controls.Add(this.btnLogin);
            this.pnlLogin.Controls.Add(this.tbxMatKhau);
            this.pnlLogin.Controls.Add(this.tbxTaiKhoan);
            this.pnlLogin.Controls.Add(this.lblTenKH);
            this.pnlLogin.Controls.Add(this.lblMaPL);
            this.pnlLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLogin.Location = new System.Drawing.Point(0, 0);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(782, 353);
            this.pnlLogin.TabIndex = 0;
            // 
            // hidebtn
            // 
            this.hidebtn.Image = global::StoreManagement.Properties.Resources.hide;
            this.hidebtn.Location = new System.Drawing.Point(511, 135);
            this.hidebtn.Name = "hidebtn";
            this.hidebtn.Size = new System.Drawing.Size(32, 32);
            this.hidebtn.TabIndex = 32;
            this.hidebtn.UseVisualStyleBackColor = true;
            this.hidebtn.Click += new System.EventHandler(this.hidebtn_Click);
            // 
            // testCbx
            // 
            this.testCbx.AutoSize = true;
            this.testCbx.Location = new System.Drawing.Point(511, 183);
            this.testCbx.Name = "testCbx";
            this.testCbx.Size = new System.Drawing.Size(77, 21);
            this.testCbx.TabIndex = 31;
            this.testCbx.Text = "Testing";
            this.testCbx.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.AutoSize = true;
            this.btnLogin.Location = new System.Drawing.Point(573, 233);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(88, 27);
            this.btnLogin.TabIndex = 30;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tbxMatKhau
            // 
            this.tbxMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMatKhau.Location = new System.Drawing.Point(541, 136);
            this.tbxMatKhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxMatKhau.Name = "tbxMatKhau";
            this.tbxMatKhau.Size = new System.Drawing.Size(204, 30);
            this.tbxMatKhau.TabIndex = 29;
            this.tbxMatKhau.UseSystemPasswordChar = true;
            // 
            // tbxTaiKhoan
            // 
            this.tbxTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTaiKhoan.Location = new System.Drawing.Point(511, 90);
            this.tbxTaiKhoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxTaiKhoan.Name = "tbxTaiKhoan";
            this.tbxTaiKhoan.Size = new System.Drawing.Size(234, 30);
            this.tbxTaiKhoan.TabIndex = 28;
            // 
            // lblTenKH
            // 
            this.lblTenKH.AutoSize = true;
            this.lblTenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenKH.Location = new System.Drawing.Point(379, 140);
            this.lblTenKH.Name = "lblTenKH";
            this.lblTenKH.Size = new System.Drawing.Size(82, 20);
            this.lblTenKH.TabIndex = 27;
            this.lblTenKH.Text = "Mật khẩu:";
            // 
            // lblMaPL
            // 
            this.lblMaPL.AutoSize = true;
            this.lblMaPL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaPL.Location = new System.Drawing.Point(375, 97);
            this.lblMaPL.Name = "lblMaPL";
            this.lblMaPL.Size = new System.Drawing.Size(86, 20);
            this.lblMaPL.TabIndex = 26;
            this.lblMaPL.Text = "Tài khoản:";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 353);
            this.Controls.Add(this.pnlLogin);
            this.Name = "FormLogin";
            this.Text = "FormLogin";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox tbxMatKhau;
        private System.Windows.Forms.TextBox tbxTaiKhoan;
        private System.Windows.Forms.Label lblTenKH;
        private System.Windows.Forms.Label lblMaPL;
        private System.Windows.Forms.CheckBox testCbx;
        private System.Windows.Forms.Button hidebtn;
    }
}