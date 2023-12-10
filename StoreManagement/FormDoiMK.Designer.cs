
namespace StoreManagement
{
    partial class FormDoiMK
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
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.tbxXacNhanMK = new System.Windows.Forms.TextBox();
            this.tbxMatKhauMoi = new System.Windows.Forms.TextBox();
            this.tbxMatKhauCu = new System.Windows.Forms.TextBox();
            this.lblXacNhanMK = new System.Windows.Forms.Label();
            this.lblMatKhauMoi = new System.Windows.Forms.Label();
            this.lblMatkhauCu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.AutoSize = true;
            this.btnXacNhan.Location = new System.Drawing.Point(370, 207);
            this.btnXacNhan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(80, 27);
            this.btnXacNhan.TabIndex = 32;
            this.btnXacNhan.Text = "Xác Nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // tbxXacNhanMK
            // 
            this.tbxXacNhanMK.Location = new System.Drawing.Point(177, 147);
            this.tbxXacNhanMK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxXacNhanMK.Name = "tbxXacNhanMK";
            this.tbxXacNhanMK.Size = new System.Drawing.Size(516, 22);
            this.tbxXacNhanMK.TabIndex = 31;
            // 
            // tbxMatKhauMoi
            // 
            this.tbxMatKhauMoi.Location = new System.Drawing.Point(177, 105);
            this.tbxMatKhauMoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxMatKhauMoi.Name = "tbxMatKhauMoi";
            this.tbxMatKhauMoi.Size = new System.Drawing.Size(516, 22);
            this.tbxMatKhauMoi.TabIndex = 30;
            // 
            // tbxMatKhauCu
            // 
            this.tbxMatKhauCu.Location = new System.Drawing.Point(177, 68);
            this.tbxMatKhauCu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxMatKhauCu.Name = "tbxMatKhauCu";
            this.tbxMatKhauCu.Size = new System.Drawing.Size(516, 22);
            this.tbxMatKhauCu.TabIndex = 29;
            // 
            // lblXacNhanMK
            // 
            this.lblXacNhanMK.AutoSize = true;
            this.lblXacNhanMK.Location = new System.Drawing.Point(58, 150);
            this.lblXacNhanMK.Name = "lblXacNhanMK";
            this.lblXacNhanMK.Size = new System.Drawing.Size(94, 17);
            this.lblXacNhanMK.TabIndex = 27;
            this.lblXacNhanMK.Text = "Xác nhận mk:";
            // 
            // lblMatKhauMoi
            // 
            this.lblMatKhauMoi.AutoSize = true;
            this.lblMatKhauMoi.Location = new System.Drawing.Point(60, 110);
            this.lblMatKhauMoi.Name = "lblMatKhauMoi";
            this.lblMatKhauMoi.Size = new System.Drawing.Size(96, 17);
            this.lblMatKhauMoi.TabIndex = 26;
            this.lblMatKhauMoi.Text = "Mật khẩu mới:";
            // 
            // lblMatkhauCu
            // 
            this.lblMatkhauCu.AutoSize = true;
            this.lblMatkhauCu.Location = new System.Drawing.Point(63, 71);
            this.lblMatkhauCu.Name = "lblMatkhauCu";
            this.lblMatkhauCu.Size = new System.Drawing.Size(89, 17);
            this.lblMatkhauCu.TabIndex = 25;
            this.lblMatkhauCu.Text = "Mật khẩu cũ:";
            // 
            // FormDoiMK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 281);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.tbxXacNhanMK);
            this.Controls.Add(this.tbxMatKhauMoi);
            this.Controls.Add(this.tbxMatKhauCu);
            this.Controls.Add(this.lblXacNhanMK);
            this.Controls.Add(this.lblMatKhauMoi);
            this.Controls.Add(this.lblMatkhauCu);
            this.Name = "FormDoiMK";
            this.Text = "FormDoiMK";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.TextBox tbxXacNhanMK;
        private System.Windows.Forms.TextBox tbxMatKhauMoi;
        private System.Windows.Forms.TextBox tbxMatKhauCu;
        private System.Windows.Forms.Label lblXacNhanMK;
        private System.Windows.Forms.Label lblMatKhauMoi;
        private System.Windows.Forms.Label lblMatkhauCu;
    }
}