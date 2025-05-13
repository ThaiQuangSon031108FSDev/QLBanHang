namespace GUI_PolyCafe
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
            menuStrip1 = new MenuStrip();
            menuQL = new ToolStripMenuItem();
            menuQL_LoaiSP = new ToolStripMenuItem();
            menuQL_TheLuuDong = new ToolStripMenuItem();
            menuQL_NhanVien = new ToolStripMenuItem();
            menuQL_SanPham = new ToolStripMenuItem();
            menuQL_PhieuBanHang = new ToolStripMenuItem();
            menuQL_ChiTietPhieu = new ToolStripMenuItem();
            menuTK = new ToolStripMenuItem();
            menuTK_NhapNV = new ToolStripMenuItem();
            menuTK_TonKho = new ToolStripMenuItem();
            menuHT = new ToolStripMenuItem();
            menuHT_DoiMatKhau = new ToolStripMenuItem();
            menuHT_DangXuat = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuQL, menuTK, menuHT });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuQL
            // 
            menuQL.DropDownItems.AddRange(new ToolStripItem[] { menuQL_LoaiSP, menuQL_TheLuuDong, menuQL_NhanVien, menuQL_SanPham, menuQL_PhieuBanHang, menuQL_ChiTietPhieu });
            menuQL.Name = "menuQL";
            menuQL.Size = new Size(60, 20);
            menuQL.Text = "Quản lý";
            menuQL.Click += menuQL_Click;
            // 
            // menuQL_LoaiSP
            // 
            menuQL_LoaiSP.Name = "menuQL_LoaiSP";
            menuQL_LoaiSP.Size = new Size(159, 22);
            menuQL_LoaiSP.Text = "Loại SP";
            menuQL_LoaiSP.Click += menuQL_LoaiSP_Click;
            // 
            // menuQL_TheLuuDong
            // 
            menuQL_TheLuuDong.Name = "menuQL_TheLuuDong";
            menuQL_TheLuuDong.Size = new Size(180, 22);
            menuQL_TheLuuDong.Text = "Thẻ Lưu Động";
            menuQL_TheLuuDong.Click += menuQL_TheLuuDong_Click;
            // 
            // menuQL_NhanVien
            // 
            menuQL_NhanVien.Name = "menuQL_NhanVien";
            menuQL_NhanVien.Size = new Size(180, 22);
            menuQL_NhanVien.Text = "Nhân Viên";
            menuQL_NhanVien.Click += menuQL_NhanVien_Click;
            // 
            // menuQL_SanPham
            // 
            menuQL_SanPham.Name = "menuQL_SanPham";
            menuQL_SanPham.Size = new Size(180, 22);
            menuQL_SanPham.Text = "Sản Phẩm";
            menuQL_SanPham.Click += menuQL_SanPham_Click;
            // 
            // menuQL_PhieuBanHang
            // 
            menuQL_PhieuBanHang.Name = "menuQL_PhieuBanHang";
            menuQL_PhieuBanHang.Size = new Size(180, 22);
            menuQL_PhieuBanHang.Text = "Phiếu Bán Hàng";
            menuQL_PhieuBanHang.Click += menuQL_PhieuBanHang_Click;
            // 
            // menuQL_ChiTietPhieu
            // 
            menuQL_ChiTietPhieu.Name = "menuQL_ChiTietPhieu";
            menuQL_ChiTietPhieu.Size = new Size(180, 22);
            menuQL_ChiTietPhieu.Text = "Chi Tiết Phiếu";
            menuQL_ChiTietPhieu.Click += menuQL_ChiTietPhieu_Click;
            // 
            // menuTK
            // 
            menuTK.DropDownItems.AddRange(new ToolStripItem[] { menuTK_NhapNV, menuTK_TonKho });
            menuTK.Name = "menuTK";
            menuTK.Size = new Size(69, 20);
            menuTK.Text = "Thống kê";
            menuTK.Click += menuTK_Click;
            // 
            // menuTK_NhapNV
            // 
            menuTK_NhapNV.Name = "menuTK_NhapNV";
            menuTK_NhapNV.Size = new Size(180, 22);
            menuTK_NhapNV.Text = "Nhập theo NV";
            menuTK_NhapNV.Click += menuTK_NhapNV_Click;
            // 
            // menuTK_TonKho
            // 
            menuTK_TonKho.Name = "menuTK_TonKho";
            menuTK_TonKho.Size = new Size(180, 22);
            menuTK_TonKho.Text = "Tồn kho";
            menuTK_TonKho.Click += menuTK_TonKho_Click;
            // 
            // menuHT
            // 
            menuHT.DropDownItems.AddRange(new ToolStripItem[] { menuHT_DoiMatKhau, menuHT_DangXuat });
            menuHT.Name = "menuHT";
            menuHT.Size = new Size(69, 20);
            menuHT.Text = "Hệ thống";
            menuHT.Click += menuHT_Click;
            // 
            // menuHT_DoiMatKhau
            // 
            menuHT_DoiMatKhau.Name = "menuHT_DoiMatKhau";
            menuHT_DoiMatKhau.Size = new Size(180, 22);
            menuHT_DoiMatKhau.Text = "Đổi mật khẩu";
            menuHT_DoiMatKhau.Click += menuHT_DoiMatKhau_Click;
            // 
            // menuHT_DangXuat
            // 
            menuHT_DangXuat.Name = "menuHT_DangXuat";
            menuHT_DangXuat.Size = new Size(180, 22);
            menuHT_DangXuat.Text = "Đăng xuất";
            menuHT_DangXuat.Click += menuHT_DangXuat_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuQL;
        private ToolStripMenuItem menuQL_LoaiSP;
        private ToolStripMenuItem menuTK;
        private ToolStripMenuItem menuQL_TheLuuDong;
        private ToolStripMenuItem menuQL_NhanVien;
        private ToolStripMenuItem menuQL_SanPham;
        private ToolStripMenuItem menuQL_PhieuBanHang;
        private ToolStripMenuItem menuQL_ChiTietPhieu;
        private ToolStripMenuItem menuTK_NhapNV;
        private ToolStripMenuItem menuTK_TonKho;
        private ToolStripMenuItem menuHT;
        private ToolStripMenuItem menuHT_DoiMatKhau;
        private ToolStripMenuItem menuHT_DangXuat;
    }
}
