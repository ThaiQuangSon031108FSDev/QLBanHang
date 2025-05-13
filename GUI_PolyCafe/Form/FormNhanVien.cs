using System;
using System.Data;
using System.Windows.Forms;
using BLL_PolyCafe.Services;
using DTO_PolyCafe.Entities;

namespace GUI_PolyCafe
{
    public partial class FormNhanVien : Form
    {
        private readonly NhanVienService _sv = new();

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            // Load combobox
            cboVaiTro.Items.AddRange(new[] { "QuanTri", "NhanVien" });
            cboTrangThai.Items.AddRange(new[] { "Đang hoạt động", "Đã nghỉ" });
            // Load grid
            dgvNV.DataSource = _sv.GetAll();
        }

        public FormNhanVien()
        {
            InitializeComponent();   // <— BẮT BUỘC phải có
                                     // Nếu muốn load data ngay, bạn có thể gọi LoadData() ở đây
                                     // LoadData();
        }

        private void LoadData()
        {
            dgvNV.DataSource = _sv.GetAll();
        }

        private void btnAddNV_Click(object sender, EventArgs e)
        {
            var nv = new NhanVien
            {
                MaNhanVien = txtMaNV.Text.Trim(),
                HoTen = txtHoTen.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                MatKhau = ComputeSha256(txtMatKhau.Text.Trim()),
                VaiTro = cboVaiTro.Text,
                TrangThai = cboTrangThai.Text
            };
            _sv.Add(nv);
            LoadData();
        }

        private void btnUpdateNV_Click(object sender, EventArgs e)
        {
            var nv = new NhanVien
            {
                MaNhanVien = txtMaNV.Text.Trim(),
                HoTen = txtHoTen.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                MatKhau = ComputeSha256(txtMatKhau.Text.Trim()),
                VaiTro = cboVaiTro.Text,
                TrangThai = cboTrangThai.Text
            };
            _sv.Update(nv);
            LoadData();
        }

        private void btnDeleteNV_Click(object sender, EventArgs e)
        {
            _sv.Delete(txtMaNV.Text.Trim());
            LoadData();
        }

        private void btnSearchNV_Click(object sender, EventArgs e)
        {
            dgvNV.DataSource = _sv.Search(txtSearchNV.Text.Trim());
        }

        private void btnRefreshNV_Click(object sender, EventArgs e)
        {
            txtSearchNV.Clear();
            LoadData();
        }

        private void dgvNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var r = dgvNV.Rows[e.RowIndex];
            txtMaNV.Text = r.Cells["MaNhanVien"].Value.ToString();
            txtHoTen.Text = r.Cells["HoTen"].Value.ToString();
            txtEmail.Text = r.Cells["Email"].Value.ToString();
            // mật khẩu không hiển thị
            cboVaiTro.Text = r.Cells["VaiTro"].Value.ToString();
            cboTrangThai.Text = r.Cells["TrangThai"].Value.ToString();
        }

        private string ComputeSha256(string raw)
        {
            using var sha = System.Security.Cryptography.SHA256.Create();
            var bytes = sha.ComputeHash(System.Text.Encoding.UTF8.GetBytes(raw));
            var sb = new System.Text.StringBuilder();
            foreach (var b in bytes) sb.Append(b.ToString("x2"));
            return sb.ToString();
        }
        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {
            // ví dụ: validate format, hoặc tự động sinh mã...
        }

        private void btnAddNV_Click_1(object sender, EventArgs e)
        {
            var nv = new NhanVien
            {
                MaNhanVien = txtMaNV.Text.Trim(),
                HoTen = txtHoTen.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                MatKhau = ComputeSha256(txtMatKhau.Text.Trim()),
                VaiTro = cboVaiTro.Text,
                TrangThai = cboTrangThai.Text
            };
            _sv.Add(nv);
            LoadData();
        }

        private void btnUpdateNV_Click_1(object sender, EventArgs e)
        {
            var nv = new NhanVien
            {
                MaNhanVien = txtMaNV.Text.Trim(),
                HoTen = txtHoTen.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                MatKhau = ComputeSha256(txtMatKhau.Text.Trim()),
                VaiTro = cboVaiTro.Text,
                TrangThai = cboTrangThai.Text
            };
            _sv.Update(nv);
            LoadData();
        }

        private void btnDeleteNV_Click_1(object sender, EventArgs e)
        {
            _sv.Delete(txtMaNV.Text.Trim());
            LoadData();
        }

        private void btnRefreshNV_Click_1(object sender, EventArgs e)
        {
            txtSearchNV.Clear();
            LoadData();
        }

        private void btnSearchNV_Click_1(object sender, EventArgs e)
        {
            dgvNV.DataSource = _sv.Search(txtSearchNV.Text.Trim());

        }

        private void txtSearchNV_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
