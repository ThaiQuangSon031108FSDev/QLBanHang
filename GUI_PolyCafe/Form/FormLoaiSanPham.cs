using System;
using System.Data;
using System.Windows.Forms;
using BLL_PolyCafe.Services;
using DTO_PolyCafe.Entities;

namespace GUI_PolyCafe
{
    public partial class FormLoaiSanPham : Form
    {
        // Khởi tạo service
        private readonly LoaiSanPhamService _svc = new();

        public FormLoaiSanPham()
        {
            InitializeComponent();
            // Đăng ký lại event Load cho đúng tên
        }

        private void FormLoaiSanPham_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        /// <summary>
        /// Nạp dữ liệu lên DataGridView
        /// </summary>
        private void LoadData()
        {
            DataTable dt = _svc.GetAll();
            dataGridView1.DataSource = dt;
            // Nếu muốn đổi header:
            if (dataGridView1.Columns.Count >= 3)
            {
                dataGridView1.Columns[0].HeaderText = "Mã Loại";
                dataGridView1.Columns[1].HeaderText = "Tên Loại";
                dataGridView1.Columns[2].HeaderText = "Ghi Chú";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var loai = new LoaiSanPham
            {
                MaLoai = textBox1.Text.Trim(),
                TenLoai = textBox2.Text.Trim(),
                GhiChu = textBox3.Text.Trim()
            };
            int n = _svc.Add(loai);
            if (n > 0)
            {
                MessageBox.Show("Thêm thành công", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            else
                MessageBox.Show("Thêm thất bại", "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var loai = new LoaiSanPham
            {
                MaLoai = textBox1.Text.Trim(),
                TenLoai = textBox2.Text.Trim(),
                GhiChu = textBox3.Text.Trim()
            };
            int n = _svc.Update(loai);
            if (n > 0)
            {
                MessageBox.Show("Cập nhật thành công", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            else
                MessageBox.Show("Cập nhật thất bại", "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string ma = textBox1.Text.Trim();
            if (string.IsNullOrEmpty(ma))
            {
                MessageBox.Show("Chưa chọn Mã Loại để xóa", "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show($"Bạn có chắc muốn xóa loại [{ma}] không?",
                                "Xác nhận",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            int n = _svc.Delete(ma);
            if (n > 0)
            {
                MessageBox.Show("Xóa thành công", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            else
                MessageBox.Show("Xóa thất bại", "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            txtSearch.Clear();
            LoadData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string kw = txtSearch.Text.Trim();
            DataTable dt = _svc.Search(kw);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Chuyển sang CellClick để chọn dòng
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dataGridView1.Rows[e.RowIndex];
            textBox1.Text = row.Cells["MaLoai"].Value?.ToString();
            textBox2.Text = row.Cells["TenLoai"].Value?.ToString();
            textBox3.Text = row.Cells["GhiChu"].Value?.ToString();
        }
    }
}
