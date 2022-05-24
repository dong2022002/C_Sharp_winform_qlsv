namespace Lab05_Demo
{
    partial class frmSinhVien
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
            this.lblMSSV = new System.Windows.Forms.Label();
            this.lblHoTenLot = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblCMND = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblMHDangKy = new System.Windows.Forms.Label();
            this.mtxtMSSV = new System.Windows.Forms.MaskedTextBox();
            this.txtHoTenLot = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.mtxtCMND = new System.Windows.Forms.MaskedTextBox();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.lblLop = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.mtxtSDT = new System.Windows.Forms.MaskedTextBox();
            this.clbMHDK = new System.Windows.Forms.CheckedListBox();
            this.ctmnMonHoc = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.themMonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xoaMonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnThoát = new System.Windows.Forms.Button();
            this.gbDSSV = new System.Windows.Forms.GroupBox();
            this.lvDSSV = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ctmnEdit = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctmnMonHoc.SuspendLayout();
            this.gbDSSV.SuspendLayout();
            this.ctmnEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMSSV
            // 
            this.lblMSSV.AutoSize = true;
            this.lblMSSV.Location = new System.Drawing.Point(24, 18);
            this.lblMSSV.Name = "lblMSSV";
            this.lblMSSV.Size = new System.Drawing.Size(48, 16);
            this.lblMSSV.TabIndex = 0;
            this.lblMSSV.Text = "MSSV:";
            // 
            // lblHoTenLot
            // 
            this.lblHoTenLot.AutoSize = true;
            this.lblHoTenLot.Location = new System.Drawing.Point(24, 50);
            this.lblHoTenLot.Name = "lblHoTenLot";
            this.lblHoTenLot.Size = new System.Drawing.Size(88, 16);
            this.lblHoTenLot.TabIndex = 0;
            this.lblHoTenLot.Text = "Họ và tên Lót:";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(24, 89);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(72, 16);
            this.lblNgaySinh.TabIndex = 0;
            this.lblNgaySinh.Text = "Ngày Sinh:";
            // 
            // lblCMND
            // 
            this.lblCMND.AutoSize = true;
            this.lblCMND.Location = new System.Drawing.Point(24, 126);
            this.lblCMND.Name = "lblCMND";
            this.lblCMND.Size = new System.Drawing.Size(70, 16);
            this.lblCMND.TabIndex = 0;
            this.lblCMND.Text = "Số CMND:";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(24, 160);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(95, 16);
            this.lblDiaChi.TabIndex = 0;
            this.lblDiaChi.Text = "Địa chỉ liên lạc:";
            // 
            // lblMHDangKy
            // 
            this.lblMHDangKy.AutoSize = true;
            this.lblMHDangKy.Location = new System.Drawing.Point(12, 224);
            this.lblMHDangKy.Name = "lblMHDangKy";
            this.lblMHDangKy.Size = new System.Drawing.Size(112, 16);
            this.lblMHDangKy.TabIndex = 0;
            this.lblMHDangKy.Text = "Môn học đăng ký:";
            // 
            // mtxtMSSV
            // 
            this.mtxtMSSV.Location = new System.Drawing.Point(147, 12);
            this.mtxtMSSV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mtxtMSSV.Mask = "0000000";
            this.mtxtMSSV.Name = "mtxtMSSV";
            this.mtxtMSSV.Size = new System.Drawing.Size(211, 22);
            this.mtxtMSSV.TabIndex = 1;
            // 
            // txtHoTenLot
            // 
            this.txtHoTenLot.Location = new System.Drawing.Point(147, 48);
            this.txtHoTenLot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHoTenLot.Name = "txtHoTenLot";
            this.txtHoTenLot.Size = new System.Drawing.Size(211, 22);
            this.txtHoTenLot.TabIndex = 2;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(147, 154);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(599, 22);
            this.txtDiaChi.TabIndex = 2;
            // 
            // mtxtCMND
            // 
            this.mtxtCMND.Location = new System.Drawing.Point(147, 121);
            this.mtxtCMND.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mtxtCMND.Mask = "000000000";
            this.mtxtCMND.Name = "mtxtCMND";
            this.mtxtCMND.Size = new System.Drawing.Size(211, 22);
            this.mtxtCMND.TabIndex = 1;
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Location = new System.Drawing.Point(443, 18);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(63, 16);
            this.lblGioiTinh.TabIndex = 0;
            this.lblGioiTinh.Text = "Giới Tính:";
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(443, 50);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(34, 16);
            this.lblTen.TabIndex = 0;
            this.lblTen.Text = "Tên:";
            // 
            // lblLop
            // 
            this.lblLop.AutoSize = true;
            this.lblLop.Location = new System.Drawing.Point(443, 89);
            this.lblLop.Name = "lblLop";
            this.lblLop.Size = new System.Drawing.Size(33, 16);
            this.lblLop.TabIndex = 0;
            this.lblLop.Text = "Lớp:";
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Location = new System.Drawing.Point(443, 126);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(48, 16);
            this.lblSDT.TabIndex = 0;
            this.lblSDT.Text = "Số ĐT:";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(147, 82);
            this.dtpNgaySinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(211, 22);
            this.dtpNgaySinh.TabIndex = 3;
            // 
            // rdNu
            // 
            this.rdNu.AutoSize = true;
            this.rdNu.Location = new System.Drawing.Point(660, 16);
            this.rdNu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(45, 20);
            this.rdNu.TabIndex = 4;
            this.rdNu.Text = "Nữ";
            this.rdNu.UseVisualStyleBackColor = true;
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.Checked = true;
            this.rdNam.Location = new System.Drawing.Point(535, 16);
            this.rdNam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(57, 20);
            this.rdNam.TabIndex = 4;
            this.rdNam.TabStop = true;
            this.rdNam.Text = "Nam";
            this.rdNam.UseVisualStyleBackColor = true;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(535, 48);
            this.txtTen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(211, 22);
            this.txtTen.TabIndex = 2;
            // 
            // cboLop
            // 
            this.cboLop.FormattingEnabled = true;
            this.cboLop.Items.AddRange(new object[] {
            "CTK45",
            "CTK44",
            "CTK43",
            "CTK42"});
            this.cboLop.Location = new System.Drawing.Point(535, 85);
            this.cboLop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(211, 24);
            this.cboLop.TabIndex = 5;
            // 
            // mtxtSDT
            // 
            this.mtxtSDT.Location = new System.Drawing.Point(535, 123);
            this.mtxtSDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mtxtSDT.Mask = "000000000";
            this.mtxtSDT.Name = "mtxtSDT";
            this.mtxtSDT.Size = new System.Drawing.Size(211, 22);
            this.mtxtSDT.TabIndex = 1;
            // 
            // clbMHDK
            // 
            this.clbMHDK.ColumnWidth = 220;
            this.clbMHDK.ContextMenuStrip = this.ctmnMonHoc;
            this.clbMHDK.FormattingEnabled = true;
            this.clbMHDK.Items.AddRange(new object[] {
            "An toàn và bảo mật hệ thống",
            "Đồ án cơ sở",
            "Hệ điều hành",
            "Lập trình CSDL",
            "Lập trình mạng",
            "Lập trình trên thiết bị di động",
            "Mạng máy tính",
            "Phương pháp NCKH"});
            this.clbMHDK.Location = new System.Drawing.Point(147, 193);
            this.clbMHDK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clbMHDK.MultiColumn = true;
            this.clbMHDK.Name = "clbMHDK";
            this.clbMHDK.Size = new System.Drawing.Size(603, 89);
            this.clbMHDK.TabIndex = 6;
            this.clbMHDK.SelectedIndexChanged += new System.EventHandler(this.clbMHDK_SelectedIndexChanged);
            // 
            // ctmnMonHoc
            // 
            this.ctmnMonHoc.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctmnMonHoc.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.themMonToolStripMenuItem,
            this.xoaMonToolStripMenuItem});
            this.ctmnMonHoc.Name = "ctmnMonHoc";
            this.ctmnMonHoc.Size = new System.Drawing.Size(150, 52);
            // 
            // themMonToolStripMenuItem
            // 
            this.themMonToolStripMenuItem.Name = "themMonToolStripMenuItem";
            this.themMonToolStripMenuItem.Size = new System.Drawing.Size(149, 24);
            this.themMonToolStripMenuItem.Text = "Thêm môn";
            this.themMonToolStripMenuItem.Click += new System.EventHandler(this.thêmMônToolStripMenuItem_Click);
            // 
            // xoaMonToolStripMenuItem
            // 
            this.xoaMonToolStripMenuItem.Name = "xoaMonToolStripMenuItem";
            this.xoaMonToolStripMenuItem.Size = new System.Drawing.Size(149, 24);
            this.xoaMonToolStripMenuItem.Text = "Xóa môn";
            this.xoaMonToolStripMenuItem.Click += new System.EventHandler(this.xóaMônToolStripMenuItem_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(256, 292);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 32);
            this.btnTimKiem.TabIndex = 7;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Location = new System.Drawing.Point(364, 292);
            this.btnThemMoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(117, 32);
            this.btnThemMoi.TabIndex = 7;
            this.btnThemMoi.Text = "Thêm mới";
            this.btnThemMoi.UseVisualStyleBackColor = false;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(513, 292);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(109, 32);
            this.btnCapNhat.TabIndex = 7;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnThoát
            // 
            this.btnThoát.Location = new System.Drawing.Point(672, 292);
            this.btnThoát.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThoát.Name = "btnThoát";
            this.btnThoát.Size = new System.Drawing.Size(75, 32);
            this.btnThoát.TabIndex = 7;
            this.btnThoát.Text = "Thoát";
            this.btnThoát.UseVisualStyleBackColor = false;
            this.btnThoát.Click += new System.EventHandler(this.btnThoát_Click);
            // 
            // gbDSSV
            // 
            this.gbDSSV.Controls.Add(this.lvDSSV);
            this.gbDSSV.Location = new System.Drawing.Point(13, 341);
            this.gbDSSV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbDSSV.Name = "gbDSSV";
            this.gbDSSV.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbDSSV.Size = new System.Drawing.Size(843, 160);
            this.gbDSSV.TabIndex = 8;
            this.gbDSSV.TabStop = false;
            this.gbDSSV.Text = "Danh sách sinh viên";
            // 
            // lvDSSV
            // 
            this.lvDSSV.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvDSSV.CheckBoxes = true;
            this.lvDSSV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader9,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader10});
            this.lvDSSV.ContextMenuStrip = this.ctmnEdit;
            this.lvDSSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvDSSV.FullRowSelect = true;
            this.lvDSSV.GridLines = true;
            this.lvDSSV.HideSelection = false;
            this.lvDSSV.Location = new System.Drawing.Point(3, 17);
            this.lvDSSV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvDSSV.Name = "lvDSSV";
            this.lvDSSV.Size = new System.Drawing.Size(837, 141);
            this.lvDSSV.TabIndex = 0;
            this.lvDSSV.UseCompatibleStateImageBehavior = false;
            this.lvDSSV.View = System.Windows.Forms.View.Details;
            this.lvDSSV.SelectedIndexChanged += new System.EventHandler(this.lvDSSV_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "MSSV";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Họ và tên lót";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tên";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Giới Tính";
            this.columnHeader9.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ngày sinh";
            this.columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Lớp";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Số CMND";
            this.columnHeader6.Width = 80;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Số điện thoại";
            this.columnHeader7.Width = 120;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Địa chỉ liên lạc";
            this.columnHeader8.Width = 200;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Môn học đăng ký";
            this.columnHeader10.Width = 300;
            // 
            // ctmnEdit
            // 
            this.ctmnEdit.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctmnEdit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xoaToolStripMenuItem});
            this.ctmnEdit.Name = "ctmnEdit";
            this.ctmnEdit.Size = new System.Drawing.Size(211, 56);
            // 
            // xoaToolStripMenuItem
            // 
            this.xoaToolStripMenuItem.Name = "xoaToolStripMenuItem";
            this.xoaToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.xoaToolStripMenuItem.Text = "xóa ";
            this.xoaToolStripMenuItem.Click += new System.EventHandler(this.xóaToolStripMenuItem_Click);
            // 
            // frmSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(871, 512);
            this.Controls.Add(this.gbDSSV);
            this.Controls.Add(this.btnThoát);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.clbMHDK);
            this.Controls.Add(this.cboLop);
            this.Controls.Add(this.rdNam);
            this.Controls.Add(this.rdNu);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtHoTenLot);
            this.Controls.Add(this.mtxtSDT);
            this.Controls.Add(this.mtxtCMND);
            this.Controls.Add(this.mtxtMSSV);
            this.Controls.Add(this.lblMHDangKy);
            this.Controls.Add(this.lblDiaChi);
            this.Controls.Add(this.lblCMND);
            this.Controls.Add(this.lblNgaySinh);
            this.Controls.Add(this.lblHoTenLot);
            this.Controls.Add(this.lblSDT);
            this.Controls.Add(this.lblLop);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.lblGioiTinh);
            this.Controls.Add(this.lblMSSV);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmSinhVien";
            this.Text = "frmSinhVien";
            this.Load += new System.EventHandler(this.frmSinhVien_Load);
            this.ctmnMonHoc.ResumeLayout(false);
            this.gbDSSV.ResumeLayout(false);
            this.ctmnEdit.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMSSV;
        private System.Windows.Forms.Label lblHoTenLot;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblCMND;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblMHDangKy;
        private System.Windows.Forms.MaskedTextBox mtxtMSSV;
        private System.Windows.Forms.TextBox txtHoTenLot;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.MaskedTextBox mtxtCMND;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Label lblLop;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.RadioButton rdNu;
        private System.Windows.Forms.RadioButton rdNam;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.MaskedTextBox mtxtSDT;
        private System.Windows.Forms.CheckedListBox clbMHDK;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnThoát;
        private System.Windows.Forms.GroupBox gbDSSV;
        private System.Windows.Forms.ListView lvDSSV;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ContextMenuStrip ctmnMonHoc;
        private System.Windows.Forms.ToolStripMenuItem themMonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xoaMonToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip ctmnEdit;
        private System.Windows.Forms.ToolStripMenuItem xoaToolStripMenuItem;
    }
}