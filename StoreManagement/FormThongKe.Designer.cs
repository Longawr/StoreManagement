namespace StoreManagement
{
    partial class FormThongKe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThongKe));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.gbxThongKe = new System.Windows.Forms.GroupBox();
            this.pnlPrint = new System.Windows.Forms.Panel();
            this.btnXemChiTiet = new System.Windows.Forms.Button();
            this.dgvBaoCao = new System.Windows.Forms.DataGridView();
            this.printDocumentDoanhThu = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialogBaoCao = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocumentTonKho = new System.Drawing.Printing.PrintDocument();
            this.printDocumentDaBan = new System.Drawing.Printing.PrintDocument();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxBaoCao = new System.Windows.Forms.ComboBox();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnlPage = new System.Windows.Forms.Panel();
            this.lblPageview = new System.Windows.Forms.Label();
            this.btnEPg = new System.Windows.Forms.Button();
            this.btnFwd = new System.Windows.Forms.Button();
            this.btnBck = new System.Windows.Forms.Button();
            this.btnDauTrang = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chrtDoanhThu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblHoaDon = new System.Windows.Forms.Label();
            this.tbxHoaDon = new System.Windows.Forms.TextBox();
            this.lblSLKH = new System.Windows.Forms.Label();
            this.tbxSLKH = new System.Windows.Forms.TextBox();
            this.lblSLPL = new System.Windows.Forms.Label();
            this.tbxSLPL = new System.Windows.Forms.TextBox();
            this.lblSLSP = new System.Windows.Forms.Label();
            this.tbxSLSP = new System.Windows.Forms.TextBox();
            this.gbxThongKe.SuspendLayout();
            this.pnlPrint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCao)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.pnlPage.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrtDoanhThu)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxThongKe
            // 
            this.gbxThongKe.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbxThongKe.Controls.Add(this.panel1);
            this.gbxThongKe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxThongKe.Location = new System.Drawing.Point(0, 0);
            this.gbxThongKe.Name = "gbxThongKe";
            this.gbxThongKe.Size = new System.Drawing.Size(1283, 812);
            this.gbxThongKe.TabIndex = 1;
            this.gbxThongKe.TabStop = false;
            this.gbxThongKe.Text = "Thống Kê";
            // 
            // pnlPrint
            // 
            this.pnlPrint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPrint.Controls.Add(this.pnlPage);
            this.pnlPrint.Controls.Add(this.btnXemChiTiet);
            this.pnlPrint.Controls.Add(this.dgvBaoCao);
            this.pnlPrint.Location = new System.Drawing.Point(587, 6);
            this.pnlPrint.Name = "pnlPrint";
            this.pnlPrint.Size = new System.Drawing.Size(684, 470);
            this.pnlPrint.TabIndex = 52;
            // 
            // btnXemChiTiet
            // 
            this.btnXemChiTiet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXemChiTiet.AutoSize = true;
            this.btnXemChiTiet.Location = new System.Drawing.Point(529, 5);
            this.btnXemChiTiet.Name = "btnXemChiTiet";
            this.btnXemChiTiet.Size = new System.Drawing.Size(102, 56);
            this.btnXemChiTiet.TabIndex = 45;
            this.btnXemChiTiet.Text = "Xem chi tiết";
            this.btnXemChiTiet.UseVisualStyleBackColor = true;
            this.btnXemChiTiet.Click += new System.EventHandler(this.btnXemChiTiet_Click);
            // 
            // dgvBaoCao
            // 
            this.dgvBaoCao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaoCao.Location = new System.Drawing.Point(19, 67);
            this.dgvBaoCao.Name = "dgvBaoCao";
            this.dgvBaoCao.RowHeadersWidth = 62;
            this.dgvBaoCao.RowTemplate.Height = 28;
            this.dgvBaoCao.Size = new System.Drawing.Size(647, 315);
            this.dgvBaoCao.TabIndex = 44;
            // 
            // printDocumentDoanhThu
            // 
            this.printDocumentDoanhThu.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocumentDoanhThu_PrintPage);
            // 
            // printPreviewDialogBaoCao
            // 
            this.printPreviewDialogBaoCao.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialogBaoCao.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialogBaoCao.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialogBaoCao.Enabled = true;
            this.printPreviewDialogBaoCao.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialogBaoCao.Icon")));
            this.printPreviewDialogBaoCao.Name = "printPreviewDialogBaoCao";
            this.printPreviewDialogBaoCao.Visible = false;
            // 
            // printDocumentTonKho
            // 
            this.printDocumentTonKho.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocumentTonKho_PrintPage);
            // 
            // printDocumentDaBan
            // 
            this.printDocumentDaBan.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocumentDaBan_PrintPage);
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.AutoSize = true;
            this.btnBaoCao.Location = new System.Drawing.Point(321, 337);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(119, 51);
            this.btnBaoCao.TabIndex = 46;
            this.btnBaoCao.Text = "Báo Cáo";
            this.btnBaoCao.UseVisualStyleBackColor = true;
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 32);
            this.label3.TabIndex = 51;
            this.label3.Text = "Loại ";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 32);
            this.label1.TabIndex = 49;
            this.label1.Text = "Từ";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 32);
            this.label2.TabIndex = 50;
            this.label2.Text = "Đến";
            // 
            // cbxBaoCao
            // 
            this.cbxBaoCao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbxBaoCao.FormattingEnabled = true;
            this.cbxBaoCao.Items.AddRange(new object[] {
            "Sản phẩm tồn kho",
            "Sản phẩm tiêu thụ",
            "Chi tiết doanh thu"});
            this.cbxBaoCao.Location = new System.Drawing.Point(125, 265);
            this.cbxBaoCao.Name = "cbxBaoCao";
            this.cbxBaoCao.Size = new System.Drawing.Size(315, 28);
            this.cbxBaoCao.TabIndex = 45;
            // 
            // dtpStart
            // 
            this.dtpStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpStart.Location = new System.Drawing.Point(125, 73);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(315, 26);
            this.dtpStart.TabIndex = 47;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpEnd.Location = new System.Drawing.Point(125, 169);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(315, 26);
            this.dtpEnd.TabIndex = 48;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.pnlPrint);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpEnd);
            this.groupBox1.Controls.Add(this.btnBaoCao);
            this.groupBox1.Controls.Add(this.dtpStart);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbxBaoCao);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 324);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1271, 482);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lập báo cáo";
            // 
            // pnlPage
            // 
            this.pnlPage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPage.Controls.Add(this.lblPageview);
            this.pnlPage.Controls.Add(this.btnEPg);
            this.pnlPage.Controls.Add(this.btnFwd);
            this.pnlPage.Controls.Add(this.btnBck);
            this.pnlPage.Controls.Add(this.btnDauTrang);
            this.pnlPage.Location = new System.Drawing.Point(64, 389);
            this.pnlPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlPage.Name = "pnlPage";
            this.pnlPage.Size = new System.Drawing.Size(567, 72);
            this.pnlPage.TabIndex = 54;
            // 
            // lblPageview
            // 
            this.lblPageview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPageview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPageview.Location = new System.Drawing.Point(243, 23);
            this.lblPageview.Name = "lblPageview";
            this.lblPageview.Size = new System.Drawing.Size(84, 38);
            this.lblPageview.TabIndex = 4;
            this.lblPageview.Text = " ";
            this.lblPageview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEPg
            // 
            this.btnEPg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEPg.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEPg.Location = new System.Drawing.Point(459, 22);
            this.btnEPg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEPg.Name = "btnEPg";
            this.btnEPg.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnEPg.Size = new System.Drawing.Size(47, 40);
            this.btnEPg.TabIndex = 3;
            this.btnEPg.Text = ">|";
            this.btnEPg.UseVisualStyleBackColor = true;
            this.btnEPg.Click += new System.EventHandler(this.btnEPg_Click);
            // 
            // btnFwd
            // 
            this.btnFwd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFwd.Location = new System.Drawing.Point(366, 22);
            this.btnFwd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFwd.Name = "btnFwd";
            this.btnFwd.Size = new System.Drawing.Size(48, 40);
            this.btnFwd.TabIndex = 2;
            this.btnFwd.Text = ">>";
            this.btnFwd.UseVisualStyleBackColor = true;
            this.btnFwd.Click += new System.EventHandler(this.btnFwd_Click);
            // 
            // btnBck
            // 
            this.btnBck.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBck.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBck.Location = new System.Drawing.Point(146, 20);
            this.btnBck.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBck.Name = "btnBck";
            this.btnBck.Size = new System.Drawing.Size(52, 40);
            this.btnBck.TabIndex = 1;
            this.btnBck.Text = "<<";
            this.btnBck.UseVisualStyleBackColor = true;
            this.btnBck.Click += new System.EventHandler(this.btnBck_Click);
            // 
            // btnDauTrang
            // 
            this.btnDauTrang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDauTrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDauTrang.Location = new System.Drawing.Point(38, 21);
            this.btnDauTrang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDauTrang.Name = "btnDauTrang";
            this.btnDauTrang.Size = new System.Drawing.Size(60, 39);
            this.btnDauTrang.TabIndex = 0;
            this.btnDauTrang.Text = "|<";
            this.btnDauTrang.UseVisualStyleBackColor = true;
            this.btnDauTrang.Click += new System.EventHandler(this.btnDauTrang_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.chrtDoanhThu);
            this.panel1.Controls.Add(this.lblHoaDon);
            this.panel1.Controls.Add(this.tbxHoaDon);
            this.panel1.Controls.Add(this.lblSLKH);
            this.panel1.Controls.Add(this.tbxSLKH);
            this.panel1.Controls.Add(this.lblSLPL);
            this.panel1.Controls.Add(this.tbxSLPL);
            this.panel1.Controls.Add(this.lblSLSP);
            this.panel1.Controls.Add(this.tbxSLSP);
            this.panel1.Location = new System.Drawing.Point(6, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1271, 442);
            this.panel1.TabIndex = 43;
            // 
            // chrtDoanhThu
            // 
            this.chrtDoanhThu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            chartArea4.Name = "ChartArea1";
            this.chrtDoanhThu.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chrtDoanhThu.Legends.Add(legend4);
            this.chrtDoanhThu.Location = new System.Drawing.Point(628, 13);
            this.chrtDoanhThu.Name = "chrtDoanhThu";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Doanh Thu";
            this.chrtDoanhThu.Series.Add(series4);
            this.chrtDoanhThu.Size = new System.Drawing.Size(618, 239);
            this.chrtDoanhThu.TabIndex = 51;
            this.chrtDoanhThu.Text = "Biểu đồ doanh thu";
            title4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title4.Name = "Title1";
            title4.Text = "BIỂU ĐỒ DOANH THU";
            this.chrtDoanhThu.Titles.Add(title4);
            // 
            // lblHoaDon
            // 
            this.lblHoaDon.AutoSize = true;
            this.lblHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoaDon.Location = new System.Drawing.Point(13, 192);
            this.lblHoaDon.Name = "lblHoaDon";
            this.lblHoaDon.Size = new System.Drawing.Size(237, 25);
            this.lblHoaDon.TabIndex = 49;
            this.lblHoaDon.Text = "Hóa đơn tạo tháng này:";
            // 
            // tbxHoaDon
            // 
            this.tbxHoaDon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxHoaDon.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbxHoaDon.Enabled = false;
            this.tbxHoaDon.Location = new System.Drawing.Point(469, 192);
            this.tbxHoaDon.Name = "tbxHoaDon";
            this.tbxHoaDon.ReadOnly = true;
            this.tbxHoaDon.Size = new System.Drawing.Size(153, 26);
            this.tbxHoaDon.TabIndex = 50;
            // 
            // lblSLKH
            // 
            this.lblSLKH.AutoSize = true;
            this.lblSLKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSLKH.Location = new System.Drawing.Point(12, 137);
            this.lblSLKH.Name = "lblSLKH";
            this.lblSLKH.Size = new System.Drawing.Size(216, 25);
            this.lblSLKH.TabIndex = 47;
            this.lblSLKH.Text = "Tổng số khách hàng:";
            // 
            // tbxSLKH
            // 
            this.tbxSLKH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbxSLKH.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbxSLKH.Enabled = false;
            this.tbxSLKH.Location = new System.Drawing.Point(327, 136);
            this.tbxSLKH.Name = "tbxSLKH";
            this.tbxSLKH.ReadOnly = true;
            this.tbxSLKH.Size = new System.Drawing.Size(153, 26);
            this.tbxSLKH.TabIndex = 48;
            // 
            // lblSLPL
            // 
            this.lblSLPL.AutoSize = true;
            this.lblSLPL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSLPL.Location = new System.Drawing.Point(12, 82);
            this.lblSLPL.Name = "lblSLPL";
            this.lblSLPL.Size = new System.Drawing.Size(192, 25);
            this.lblSLPL.TabIndex = 45;
            this.lblSLPL.Text = "Tổng số phân loại:";
            // 
            // tbxSLPL
            // 
            this.tbxSLPL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbxSLPL.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbxSLPL.Enabled = false;
            this.tbxSLPL.Location = new System.Drawing.Point(327, 83);
            this.tbxSLPL.Name = "tbxSLPL";
            this.tbxSLPL.ReadOnly = true;
            this.tbxSLPL.Size = new System.Drawing.Size(153, 26);
            this.tbxSLPL.TabIndex = 46;
            // 
            // lblSLSP
            // 
            this.lblSLSP.AutoSize = true;
            this.lblSLSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSLSP.Location = new System.Drawing.Point(12, 30);
            this.lblSLSP.Name = "lblSLSP";
            this.lblSLSP.Size = new System.Drawing.Size(198, 25);
            this.lblSLSP.TabIndex = 43;
            this.lblSLSP.Text = "Tổng số sản phẩm:";
            // 
            // tbxSLSP
            // 
            this.tbxSLSP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbxSLSP.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbxSLSP.Enabled = false;
            this.tbxSLSP.Location = new System.Drawing.Point(327, 31);
            this.tbxSLSP.Name = "tbxSLSP";
            this.tbxSLSP.ReadOnly = true;
            this.tbxSLSP.Size = new System.Drawing.Size(153, 26);
            this.tbxSLSP.TabIndex = 44;
            // 
            // FormThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 812);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxThongKe);
            this.Name = "FormThongKe";
            this.Text = "FormThongKe";
            this.Load += new System.EventHandler(this.FormThongKe_Load);
            this.gbxThongKe.ResumeLayout(false);
            this.pnlPrint.ResumeLayout(false);
            this.pnlPrint.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCao)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlPage.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrtDoanhThu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbxThongKe;
        private System.Drawing.Printing.PrintDocument printDocumentDoanhThu;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialogBaoCao;
        private System.Drawing.Printing.PrintDocument printDocumentTonKho;
        private System.Drawing.Printing.PrintDocument printDocumentDaBan;
        private System.Windows.Forms.Panel pnlPrint;
        private System.Windows.Forms.Button btnXemChiTiet;
        private System.Windows.Forms.DataGridView dgvBaoCao;
        private System.Windows.Forms.Button btnBaoCao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxBaoCao;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel pnlPage;
        private System.Windows.Forms.Label lblPageview;
        private System.Windows.Forms.Button btnEPg;
        private System.Windows.Forms.Button btnFwd;
        private System.Windows.Forms.Button btnBck;
        private System.Windows.Forms.Button btnDauTrang;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtDoanhThu;
        private System.Windows.Forms.Label lblHoaDon;
        private System.Windows.Forms.TextBox tbxHoaDon;
        private System.Windows.Forms.Label lblSLKH;
        private System.Windows.Forms.TextBox tbxSLKH;
        private System.Windows.Forms.Label lblSLPL;
        private System.Windows.Forms.TextBox tbxSLPL;
        private System.Windows.Forms.Label lblSLSP;
        private System.Windows.Forms.TextBox tbxSLSP;
    }
}