namespace StoreManagement
{
    partial class FormHome
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
            this.components = new System.ComponentModel.Container();
            this.pnlTittle = new System.Windows.Forms.Panel();
            this.lblTittle = new System.Windows.Forms.Label();
            this.pnlForm = new System.Windows.Forms.Panel();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.panelTaiKhoan = new System.Windows.Forms.Panel();
            this.btnTenNV = new System.Windows.Forms.Button();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnThongTin = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnSanPham = new System.Windows.Forms.Button();
            this.btnPhanloai = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnDSHoaDon = new System.Windows.Forms.Button();
            this.btnKhachHang = new System.Windows.Forms.Button();
            this.timerSildeAnimation = new System.Windows.Forms.Timer(this.components);
            this.pnlTittle.SuspendLayout();
            this.flowLayoutPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.panelTaiKhoan.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTittle
            // 
            this.pnlTittle.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pnlTittle.Controls.Add(this.lblTittle);
            this.pnlTittle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTittle.Location = new System.Drawing.Point(181, 0);
            this.pnlTittle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlTittle.Name = "pnlTittle";
            this.pnlTittle.Size = new System.Drawing.Size(968, 80);
            this.pnlTittle.TabIndex = 1;
            // 
            // lblTittle
            // 
            this.lblTittle.AutoSize = true;
            this.lblTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTittle.Location = new System.Drawing.Point(5, 18);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(112, 39);
            this.lblTittle.TabIndex = 0;
            this.lblTittle.Text = "Home";
            // 
            // pnlForm
            // 
            this.pnlForm.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlForm.Location = new System.Drawing.Point(181, 80);
            this.pnlForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(968, 475);
            this.pnlForm.TabIndex = 2;
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.flowLayoutPanel.Controls.Add(this.panel2);
            this.flowLayoutPanel.Controls.Add(this.panelTaiKhoan);
            this.flowLayoutPanel.Controls.Add(this.btnThanhToan);
            this.flowLayoutPanel.Controls.Add(this.btnSanPham);
            this.flowLayoutPanel.Controls.Add(this.btnPhanloai);
            this.flowLayoutPanel.Controls.Add(this.btnThongKe);
            this.flowLayoutPanel.Controls.Add(this.btnDSHoaDon);
            this.flowLayoutPanel.Controls.Add(this.btnKhachHang);
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(181, 555);
            this.flowLayoutPanel.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pbxLogo);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(178, 152);
            this.panel2.TabIndex = 6;
            // 
            // pbxLogo
            // 
            this.pbxLogo.Image = global::StoreManagement.Properties.Resources.OIP_removebg_preview;
            this.pbxLogo.Location = new System.Drawing.Point(0, 3);
            this.pbxLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(178, 147);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLogo.TabIndex = 0;
            this.pbxLogo.TabStop = false;
            // 
            // panelTaiKhoan
            // 
            this.panelTaiKhoan.Controls.Add(this.btnTenNV);
            this.panelTaiKhoan.Controls.Add(this.btnDangXuat);
            this.panelTaiKhoan.Controls.Add(this.btnThongTin);
            this.panelTaiKhoan.Location = new System.Drawing.Point(3, 161);
            this.panelTaiKhoan.MaximumSize = new System.Drawing.Size(178, 90);
            this.panelTaiKhoan.MinimumSize = new System.Drawing.Size(178, 30);
            this.panelTaiKhoan.Name = "panelTaiKhoan";
            this.panelTaiKhoan.Size = new System.Drawing.Size(178, 30);
            this.panelTaiKhoan.TabIndex = 3;
            // 
            // btnTenNV
            // 
            this.btnTenNV.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnTenNV.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTenNV.Location = new System.Drawing.Point(0, 1);
            this.btnTenNV.Name = "btnTenNV";
            this.btnTenNV.Size = new System.Drawing.Size(178, 27);
            this.btnTenNV.TabIndex = 5;
            this.btnTenNV.Text = "TenNV";
            this.btnTenNV.UseVisualStyleBackColor = false;
            this.btnTenNV.Click += new System.EventHandler(this.btnTenNV_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnDangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDangXuat.Location = new System.Drawing.Point(0, 62);
            this.btnDangXuat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(178, 26);
            this.btnDangXuat.TabIndex = 4;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnThongTin
            // 
            this.btnThongTin.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongTin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThongTin.Location = new System.Drawing.Point(0, 32);
            this.btnThongTin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThongTin.Name = "btnThongTin";
            this.btnThongTin.Size = new System.Drawing.Size(178, 26);
            this.btnThongTin.TabIndex = 3;
            this.btnThongTin.Text = "Thông tin";
            this.btnThongTin.UseVisualStyleBackColor = false;
            this.btnThongTin.Click += new System.EventHandler(this.btnThongTin_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThanhToan.Location = new System.Drawing.Point(3, 196);
            this.btnThanhToan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(178, 40);
            this.btnThanhToan.TabIndex = 3;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnSanPham
            // 
            this.btnSanPham.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSanPham.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSanPham.Location = new System.Drawing.Point(3, 240);
            this.btnSanPham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSanPham.Name = "btnSanPham";
            this.btnSanPham.Size = new System.Drawing.Size(178, 40);
            this.btnSanPham.TabIndex = 0;
            this.btnSanPham.Text = "Sản Phẩm";
            this.btnSanPham.UseVisualStyleBackColor = false;
            this.btnSanPham.Click += new System.EventHandler(this.btnSanPham_Click);
            // 
            // btnPhanloai
            // 
            this.btnPhanloai.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnPhanloai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhanloai.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPhanloai.Location = new System.Drawing.Point(3, 284);
            this.btnPhanloai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPhanloai.Name = "btnPhanloai";
            this.btnPhanloai.Size = new System.Drawing.Size(178, 40);
            this.btnPhanloai.TabIndex = 2;
            this.btnPhanloai.Text = "Phân Loại";
            this.btnPhanloai.UseVisualStyleBackColor = false;
            this.btnPhanloai.Click += new System.EventHandler(this.btnNCC_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThongKe.Location = new System.Drawing.Point(3, 328);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(178, 40);
            this.btnThongKe.TabIndex = 4;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnDSHoaDon
            // 
            this.btnDSHoaDon.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnDSHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDSHoaDon.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDSHoaDon.Location = new System.Drawing.Point(3, 372);
            this.btnDSHoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDSHoaDon.Name = "btnDSHoaDon";
            this.btnDSHoaDon.Size = new System.Drawing.Size(178, 40);
            this.btnDSHoaDon.TabIndex = 5;
            this.btnDSHoaDon.Text = "Hóa Đơn";
            this.btnDSHoaDon.UseVisualStyleBackColor = false;
            this.btnDSHoaDon.Click += new System.EventHandler(this.btnDSHoaDon_Click);
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhachHang.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnKhachHang.Location = new System.Drawing.Point(3, 416);
            this.btnKhachHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Size = new System.Drawing.Size(178, 40);
            this.btnKhachHang.TabIndex = 1;
            this.btnKhachHang.Text = "Khách Hàng";
            this.btnKhachHang.UseVisualStyleBackColor = false;
            this.btnKhachHang.Click += new System.EventHandler(this.btnKhachHang_Click);
            // 
            // timerSildeAnimation
            // 
            this.timerSildeAnimation.Tick += new System.EventHandler(this.timerSildeAnimation_Tick);
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 555);
            this.Controls.Add(this.pnlForm);
            this.Controls.Add(this.pnlTittle);
            this.Controls.Add(this.flowLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1167, 602);
            this.Name = "FormHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Store";
            this.Load += new System.EventHandler(this.FormHome_Load);
            this.pnlTittle.ResumeLayout(false);
            this.pnlTittle.PerformLayout();
            this.flowLayoutPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.panelTaiKhoan.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlTittle;
        private System.Windows.Forms.Label lblTittle;
        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Panel panelTaiKhoan;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Button btnThongTin;
        private System.Windows.Forms.Button btnSanPham;
        private System.Windows.Forms.Button btnPhanloai;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnDSHoaDon;
        private System.Windows.Forms.Button btnKhachHang;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Timer timerSildeAnimation;
        private System.Windows.Forms.Button btnTenNV;
    }
}

