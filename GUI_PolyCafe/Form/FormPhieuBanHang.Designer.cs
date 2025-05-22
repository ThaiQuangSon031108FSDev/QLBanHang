namespace GUI_PolyCafe
{
    partial class FormPhieuBanHang
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
            tabPhieu = new TabControl();
            tabPage1 = new TabPage();
            btnXoaChiTiet = new Button();
            btnSuaChiTiet = new Button();
            btnThemChiTiet = new Button();
            btnThanhToan = new Button();
            btnLamMoiPhieu = new Button();
            btnXoaPhieu = new Button();
            btnSuaPhieu = new Button();
            btnThemPhieu = new Button();
            dgvPhieu = new DataGridView();
            groupBox1 = new GroupBox();
            cboSanPham = new ComboBox();
            txtThanhTien = new TextBox();
            txtSoLuong = new TextBox();
            txtDonGia = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            groupBox2 = new GroupBox();
            cboMaNV = new ComboBox();
            cboMaThe = new ComboBox();
            rbDaThanhToan = new RadioButton();
            rbChoXacNhan = new RadioButton();
            dtpNgay = new DateTimePicker();
            txtMaPhieu = new TextBox();
            label6 = new Label();
            xxxk = new Label();
            label4 = new Label();
            label3 = new Label();
            xxx = new Label();
            label2 = new Label();
            tabPage2 = new TabPage();
            dgvChiTiet = new DataGridView();
            tabPhieu.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPhieu).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChiTiet).BeginInit();
            SuspendLayout();
            // 
            // tabPhieu
            // 
            tabPhieu.Controls.Add(tabPage1);
            tabPhieu.Controls.Add(tabPage2);
            tabPhieu.Location = new Point(1, 1);
            tabPhieu.Margin = new Padding(3, 2, 3, 2);
            tabPhieu.Name = "tabPhieu";
            tabPhieu.SelectedIndex = 0;
            tabPhieu.Size = new Size(1049, 482);
            tabPhieu.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = SystemColors.Control;
            tabPage1.Controls.Add(btnXoaChiTiet);
            tabPage1.Controls.Add(btnSuaChiTiet);
            tabPage1.Controls.Add(btnThemChiTiet);
            tabPage1.Controls.Add(btnThanhToan);
            tabPage1.Controls.Add(btnLamMoiPhieu);
            tabPage1.Controls.Add(btnXoaPhieu);
            tabPage1.Controls.Add(btnSuaPhieu);
            tabPage1.Controls.Add(btnThemPhieu);
            tabPage1.Controls.Add(dgvPhieu);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(label2);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(3, 2, 3, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 2, 3, 2);
            tabPage1.Size = new Size(1041, 454);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Phiếu Bán Hàng";
            // 
            // btnXoaChiTiet
            // 
            btnXoaChiTiet.BackColor = SystemColors.ButtonHighlight;
            btnXoaChiTiet.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoaChiTiet.ForeColor = Color.FromArgb(0, 192, 192);
            btnXoaChiTiet.Location = new Point(895, 202);
            btnXoaChiTiet.Margin = new Padding(3, 2, 3, 2);
            btnXoaChiTiet.Name = "btnXoaChiTiet";
            btnXoaChiTiet.Size = new Size(107, 22);
            btnXoaChiTiet.TabIndex = 18;
            btnXoaChiTiet.Text = "Xóa Chi Tiết";
            btnXoaChiTiet.UseVisualStyleBackColor = false;
            // 
            // btnSuaChiTiet
            // 
            btnSuaChiTiet.BackColor = Color.Snow;
            btnSuaChiTiet.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSuaChiTiet.ForeColor = Color.Red;
            btnSuaChiTiet.Location = new Point(760, 202);
            btnSuaChiTiet.Margin = new Padding(3, 2, 3, 2);
            btnSuaChiTiet.Name = "btnSuaChiTiet";
            btnSuaChiTiet.Size = new Size(109, 22);
            btnSuaChiTiet.TabIndex = 17;
            btnSuaChiTiet.Text = "Sửa Chi Tiết";
            btnSuaChiTiet.UseVisualStyleBackColor = false;
            // 
            // btnThemChiTiet
            // 
            btnThemChiTiet.BackColor = SystemColors.ButtonHighlight;
            btnThemChiTiet.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThemChiTiet.ForeColor = Color.FromArgb(255, 128, 128);
            btnThemChiTiet.Location = new Point(626, 202);
            btnThemChiTiet.Margin = new Padding(3, 2, 3, 2);
            btnThemChiTiet.Name = "btnThemChiTiet";
            btnThemChiTiet.Size = new Size(104, 22);
            btnThemChiTiet.TabIndex = 16;
            btnThemChiTiet.Text = "Thêm Chi Tiết";
            btnThemChiTiet.UseVisualStyleBackColor = false;
            // 
            // btnThanhToan
            // 
            btnThanhToan.BackColor = SystemColors.ButtonHighlight;
            btnThanhToan.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThanhToan.ForeColor = Color.Gold;
            btnThanhToan.Location = new Point(506, 202);
            btnThanhToan.Margin = new Padding(3, 2, 3, 2);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(87, 22);
            btnThanhToan.TabIndex = 15;
            btnThanhToan.Text = "Thanh Toán";
            btnThanhToan.UseVisualStyleBackColor = false;
            // 
            // btnLamMoiPhieu
            // 
            btnLamMoiPhieu.BackColor = SystemColors.ButtonHighlight;
            btnLamMoiPhieu.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLamMoiPhieu.ForeColor = Color.FromArgb(192, 0, 192);
            btnLamMoiPhieu.Location = new Point(387, 202);
            btnLamMoiPhieu.Margin = new Padding(3, 2, 3, 2);
            btnLamMoiPhieu.Name = "btnLamMoiPhieu";
            btnLamMoiPhieu.Size = new Size(87, 22);
            btnLamMoiPhieu.TabIndex = 14;
            btnLamMoiPhieu.Text = "Làm Mới";
            btnLamMoiPhieu.UseVisualStyleBackColor = false;
            // 
            // btnXoaPhieu
            // 
            btnXoaPhieu.BackColor = SystemColors.ButtonHighlight;
            btnXoaPhieu.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoaPhieu.ForeColor = Color.FromArgb(0, 192, 192);
            btnXoaPhieu.Location = new Point(269, 202);
            btnXoaPhieu.Margin = new Padding(3, 2, 3, 2);
            btnXoaPhieu.Name = "btnXoaPhieu";
            btnXoaPhieu.Size = new Size(87, 22);
            btnXoaPhieu.TabIndex = 13;
            btnXoaPhieu.Text = "Xóa Phiếu";
            btnXoaPhieu.UseVisualStyleBackColor = false;
            // 
            // btnSuaPhieu
            // 
            btnSuaPhieu.BackColor = SystemColors.ButtonHighlight;
            btnSuaPhieu.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSuaPhieu.ForeColor = Color.Red;
            btnSuaPhieu.Location = new Point(151, 202);
            btnSuaPhieu.Margin = new Padding(3, 2, 3, 2);
            btnSuaPhieu.Name = "btnSuaPhieu";
            btnSuaPhieu.Size = new Size(87, 22);
            btnSuaPhieu.TabIndex = 12;
            btnSuaPhieu.Text = "Sửa Phiếu";
            btnSuaPhieu.UseVisualStyleBackColor = false;
            // 
            // btnThemPhieu
            // 
            btnThemPhieu.BackColor = SystemColors.ButtonHighlight;
            btnThemPhieu.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThemPhieu.ForeColor = Color.FromArgb(255, 128, 128);
            btnThemPhieu.Location = new Point(36, 202);
            btnThemPhieu.Margin = new Padding(3, 2, 3, 2);
            btnThemPhieu.Name = "btnThemPhieu";
            btnThemPhieu.Size = new Size(87, 22);
            btnThemPhieu.TabIndex = 11;
            btnThemPhieu.Text = "Thêm Phiếu";
            btnThemPhieu.UseVisualStyleBackColor = false;
            // 
            // dgvPhieu
            // 
            dgvPhieu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPhieu.Location = new Point(36, 240);
            dgvPhieu.Margin = new Padding(3, 2, 3, 2);
            dgvPhieu.Name = "dgvPhieu";
            dgvPhieu.RowHeadersWidth = 51;
            dgvPhieu.Size = new Size(966, 208);
            dgvPhieu.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboSanPham);
            groupBox1.Controls.Add(txtThanhTien);
            groupBox1.Controls.Add(txtSoLuong);
            groupBox1.Controls.Add(txtDonGia);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(626, 58);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(376, 129);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chi tiết Phiếu";
            // 
            // cboSanPham
            // 
            cboSanPham.FormattingEnabled = true;
            cboSanPham.Location = new Point(129, 25);
            cboSanPham.Name = "cboSanPham";
            cboSanPham.Size = new Size(198, 23);
            cboSanPham.TabIndex = 8;
            // 
            // txtThanhTien
            // 
            txtThanhTien.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtThanhTien.Location = new Point(127, 100);
            txtThanhTien.Margin = new Padding(3, 2, 3, 2);
            txtThanhTien.Name = "txtThanhTien";
            txtThanhTien.ReadOnly = true;
            txtThanhTien.Size = new Size(200, 20);
            txtThanhTien.TabIndex = 7;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSoLuong.Location = new Point(127, 76);
            txtSoLuong.Margin = new Padding(3, 2, 3, 2);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(200, 20);
            txtSoLuong.TabIndex = 6;
            // 
            // txtDonGia
            // 
            txtDonGia.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDonGia.Location = new Point(127, 50);
            txtDonGia.Margin = new Padding(3, 2, 3, 2);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.ReadOnly = true;
            txtDonGia.Size = new Size(200, 20);
            txtDonGia.TabIndex = 5;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(18, 100);
            label10.Name = "label10";
            label10.Size = new Size(71, 15);
            label10.TabIndex = 3;
            label10.Text = "Thành Tiền:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(18, 75);
            label9.Name = "label9";
            label9.Size = new Size(63, 15);
            label9.TabIndex = 2;
            label9.Text = "Số Lượng:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(18, 50);
            label8.Name = "label8";
            label8.Size = new Size(55, 15);
            label8.TabIndex = 1;
            label8.Text = "Đơn Giá:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(18, 25);
            label7.Name = "label7";
            label7.Size = new Size(64, 15);
            label7.TabIndex = 0;
            label7.Text = "Sản Phẩm:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cboMaNV);
            groupBox2.Controls.Add(cboMaThe);
            groupBox2.Controls.Add(rbDaThanhToan);
            groupBox2.Controls.Add(rbChoXacNhan);
            groupBox2.Controls.Add(dtpNgay);
            groupBox2.Controls.Add(txtMaPhieu);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(xxxk);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(xxx);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(36, 58);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(556, 129);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin Phiếu";
            // 
            // cboMaNV
            // 
            cboMaNV.FormattingEnabled = true;
            cboMaNV.Location = new Point(130, 62);
            cboMaNV.Name = "cboMaNV";
            cboMaNV.Size = new Size(162, 23);
            cboMaNV.TabIndex = 12;
            // 
            // cboMaThe
            // 
            cboMaThe.FormattingEnabled = true;
            cboMaThe.Location = new Point(397, 24);
            cboMaThe.Name = "cboMaThe";
            cboMaThe.Size = new Size(153, 23);
            cboMaThe.TabIndex = 11;
            // 
            // rbDaThanhToan
            // 
            rbDaThanhToan.AutoSize = true;
            rbDaThanhToan.Location = new Point(275, 99);
            rbDaThanhToan.Margin = new Padding(3, 2, 3, 2);
            rbDaThanhToan.Name = "rbDaThanhToan";
            rbDaThanhToan.Size = new Size(103, 19);
            rbDaThanhToan.TabIndex = 10;
            rbDaThanhToan.TabStop = true;
            rbDaThanhToan.Text = "Đã thanh toán";
            rbDaThanhToan.UseVisualStyleBackColor = true;
            // 
            // rbChoXacNhan
            // 
            rbChoXacNhan.AutoSize = true;
            rbChoXacNhan.Location = new Point(130, 99);
            rbChoXacNhan.Margin = new Padding(3, 2, 3, 2);
            rbChoXacNhan.Name = "rbChoXacNhan";
            rbChoXacNhan.Size = new Size(99, 19);
            rbChoXacNhan.TabIndex = 9;
            rbChoXacNhan.TabStop = true;
            rbChoXacNhan.Text = "Chờ xác nhận";
            rbChoXacNhan.UseVisualStyleBackColor = true;
            // 
            // dtpNgay
            // 
            dtpNgay.Location = new Point(397, 62);
            dtpNgay.Margin = new Padding(3, 2, 3, 2);
            dtpNgay.Name = "dtpNgay";
            dtpNgay.Size = new Size(153, 23);
            dtpNgay.TabIndex = 8;
            // 
            // txtMaPhieu
            // 
            txtMaPhieu.Location = new Point(130, 25);
            txtMaPhieu.Margin = new Padding(3, 2, 3, 2);
            txtMaPhieu.Name = "txtMaPhieu";
            txtMaPhieu.Size = new Size(162, 23);
            txtMaPhieu.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(313, 62);
            label6.Name = "label6";
            label6.Size = new Size(61, 15);
            label6.TabIndex = 4;
            label6.Text = "Ngày Tạo:";
            // 
            // xxxk
            // 
            xxxk.AutoSize = true;
            xxxk.Location = new Point(313, 25);
            xxxk.Name = "xxxk";
            xxxk.Size = new Size(51, 15);
            xxxk.TabIndex = 3;
            xxxk.Text = "Mã Thẻ:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 99);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 2;
            label4.Text = "Trạng Thái:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 62);
            label3.Name = "label3";
            label3.Size = new Size(87, 15);
            label3.TabIndex = 1;
            label3.Text = "Mã Nhân Viên:";
            // 
            // xxx
            // 
            xxx.AutoSize = true;
            xxx.Location = new Point(18, 25);
            xxx.Name = "xxx";
            xxx.Size = new Size(61, 15);
            xxx.TabIndex = 0;
            xxx.Text = "Mã Phiếu:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(444, 21);
            label2.Name = "label2";
            label2.Size = new Size(163, 22);
            label2.TabIndex = 0;
            label2.Text = "PHIẾU BÁN HÀNG";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = SystemColors.Control;
            tabPage2.Controls.Add(dgvChiTiet);
            tabPage2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(3, 2, 3, 2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 2, 3, 2);
            tabPage2.Size = new Size(1041, 454);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Chi Tiết Phiếu";
            // 
            // dgvChiTiet
            // 
            dgvChiTiet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChiTiet.Location = new Point(-4, 4);
            dgvChiTiet.Margin = new Padding(3, 2, 3, 2);
            dgvChiTiet.Name = "dgvChiTiet";
            dgvChiTiet.RowHeadersWidth = 51;
            dgvChiTiet.Size = new Size(1049, 449);
            dgvChiTiet.TabIndex = 0;
            // 
            // FormPhieuBanHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1049, 480);
            Controls.Add(tabPhieu);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormPhieuBanHang";
            Text = "Phiếu bán hàng";
            Load += FormPhieuBanHang_Load;
            tabPhieu.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPhieu).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvChiTiet).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabPhieu;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label6;
        private Label xxxk;
        private Label label4;
        private Label label3;
        private Label xxx;
        private RadioButton rbDaThanhToan;
        private RadioButton rbChoXacNhan;
        private DateTimePicker dtpNgay;
        private TextBox txtMaPhieu;
        private TextBox txtThanhTien;
        private TextBox txtSoLuong;
        private TextBox txtDonGia;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Button btnXoaChiTiet;
        private Button btnSuaChiTiet;
        private Button btnThemChiTiet;
        private Button btnThanhToan;
        private Button btnLamMoiPhieu;
        private Button btnXoaPhieu;
        private Button btnSuaPhieu;
        private Button btnThemPhieu;
        private DataGridView dgvPhieu;
        private DataGridView dgvChiTiet;
        private ComboBox cboMaThe;
        private ComboBox cboMaNV;
        private ComboBox cboSanPham;
    }
}
