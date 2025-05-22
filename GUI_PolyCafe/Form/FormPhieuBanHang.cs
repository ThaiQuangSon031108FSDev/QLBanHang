using System;
using System.Data;
using System.Windows.Forms;
using BLL_PolyCafe.Services;
using DTO_PolyCafe.Entities;

namespace GUI_PolyCafe
{
    public partial class FormPhieuBanHang : Form
    {
        private readonly PhieuBanHangService _pbhSvc = new();
        private readonly ChiTietPhieuService _ctSvc = new();
        private readonly TheLuuDongService _theSvc = new();
        private readonly NhanVienService _nvSvc = new();
        private readonly SanPhamService _spSvc = new();

        public FormPhieuBanHang()
        {
            InitializeComponent();
            // Dock cả tabControl, v.v.
            dtpNgay.Format = DateTimePickerFormat.Short;
        }

        private void FormPhieuBanHang_Load(object sender, EventArgs e)
        {
            // Nạp dữ liệu cho ComboBox
            cboMaThe.DataSource = _theSvc.GetAll();
            cboMaThe.DisplayMember = "MaThe";
            cboMaNV.DataSource = _nvSvc.GetAll();
            cboMaNV.DisplayMember = "MaNhanVien";
            cboSanPham.DataSource = _spSvc.GetAll();
            cboSanPham.DisplayMember = "MaSanPham";
            // Load DataGrid
            LoadPhieu();
        }

        private void LoadPhieu()
        {
            dgvPhieu.DataSource = _pbhSvc.GetAll();
        }

        private void LoadChiTiet(string maPhieu)
        {
            dgvChiTiet.DataSource = _ctSvc.GetByPhieu(maPhieu);
        }

        // Khi chọn 1 phiếu ở dgvPhieu:
        private void dgvPhieu_CellClick(object s, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgvPhieu.Rows[e.RowIndex];
            txtMaPhieu.Text = row.Cells["MaPhieu"].Value.ToString();
            cboMaThe.Text = row.Cells["MaThe"].Value.ToString();
            cboMaNV.Text = row.Cells["MaNhanVien"].Value.ToString();
            dtpNgay.Value = Convert.ToDateTime(row.Cells["NgayTao"].Value);
            bool tt = Convert.ToBoolean(row.Cells["TrangThai"].Value);
            rbDaThanhToan.Checked = tt;
            rbChoXacNhan.Checked = !tt;
            // Chuyển tab sang Chi Tiết và load chi tiết
            tabPhieu.SelectedTab = tabPage2;
            LoadChiTiet(txtMaPhieu.Text);
        }

        // Thêm Phiếu:
        private void btnThemPhieu_Click(object s, EventArgs e)
        {
            var ph = new PhieuBanHang
            {
                MaPhieu = txtMaPhieu.Text.Trim(),
                MaThe = cboMaThe.Text,
                MaNhanVien = cboMaNV.Text,
                NgayTao = dtpNgay.Value,
                TrangThai = rbDaThanhToan.Checked ? "Đã thanh toán" : "Chờ xác nhận"
            };
            _pbhSvc.Add(ph);
            LoadPhieu();
        }

        // Sửa Phiếu:
        private void btnSuaPhieu_Click(object s, EventArgs e)
        {
            var ph = new PhieuBanHang
            {
                MaPhieu = txtMaPhieu.Text.Trim(),
                MaThe = cboMaThe.Text,
                MaNhanVien = cboMaNV.Text,
                NgayTao = dtpNgay.Value,
                TrangThai = rbDaThanhToan.Checked ? "Đã thanh toán" : "Chờ xác nhận"
            };
            _pbhSvc.Update(ph);
            LoadPhieu();
        }

        // Xóa Phiếu:
        private void btnXoaPhieu_Click(object s, EventArgs e)
        {
            _pbhSvc.Delete(txtMaPhieu.Text.Trim());
            LoadPhieu();
        }

        // Làm mới Phiếu (xóa text):
        private void btnLamMoiPhieu_Click(object s, EventArgs e)
        {
            txtMaPhieu.Clear();
            cboMaThe.SelectedIndex = 0;
            cboMaNV.SelectedIndex = 0;
            dtpNgay.Value = DateTime.Now;
            rbChoXacNhan.Checked = true;
        }

        // Thanh toán (đánh dấu):
        private void btnThanhToan_Click(object s, EventArgs e)
        {
            rbDaThanhToan.Checked = true;
            btnSuaPhieu_Click(s, e);
        }

        // ====================
        // Tab Chi Tiết Phiếu
        // ====================

        // Khi chọn SP để thêm chi tiết:
        private void cboSanPham_SelectedIndexChanged(object s, EventArgs e)
        {
            var maSp = cboSanPham.Text;
            var sp = _spSvc.GetById(maSp);
            txtDonGia.Text = sp.DonGia.ToString();
        }

        // Tính thành tiền khi nhập số lượng:
        private void txtSoLuong_TextChanged(object s, EventArgs e)
        {
            if (int.TryParse(txtSoLuong.Text, out int sl) &&
                decimal.TryParse(txtDonGia.Text, out decimal dg))
            {
                txtThanhTien.Text = (sl * dg).ToString();
            }
        }

        // Thêm chi tiết:
        private void btnThemChiTiet_Click(object s, EventArgs e)
        {
            var ct = new ChiTietPhieu
            {
                MaPhieu = txtMaPhieu.Text,
                MaSanPham = cboSanPham.Text,
                SoLuong = int.Parse(txtSoLuong.Text),
                DonGia = decimal.Parse(txtDonGia.Text)
            };
            _ctSvc.Add(ct);
            LoadChiTiet(txtMaPhieu.Text);
        }

        // Sửa chi tiết (chọn dòng trước rồi sửa):
        private void dgvChiTiet_CellClick(object s, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var r = dgvChiTiet.Rows[e.RowIndex];
            cboSanPham.Text = r.Cells["MaSanPham"].Value.ToString();
            txtSoLuong.Text = r.Cells["SoLuong"].Value.ToString();
            // DonGia đã tự động load qua SelectedIndexChanged
        }

        private void btnSuaChiTiet_Click(object s, EventArgs e)
        {
            var ct = new ChiTietPhieu
            {
                MaPhieu = txtMaPhieu.Text,
                MaSanPham = cboSanPham.Text,
                SoLuong = int.Parse(txtSoLuong.Text),
                DonGia = decimal.Parse(txtDonGia.Text)
            };
            _ctSvc.Update(ct);
            LoadChiTiet(txtMaPhieu.Text);
        }

        private void btnXoaChiTiet_Click(object s, EventArgs e)
        {
            _ctSvc.Delete(txtMaPhieu.Text, cboSanPham.Text);
            LoadChiTiet(txtMaPhieu.Text);
        }
    }
}
