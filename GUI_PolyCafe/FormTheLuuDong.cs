using System;
using System.Data;
using System.Windows.Forms;
using BLL_PolyCafe.Services;
using DTO_PolyCafe.Entities;

namespace GUI_PolyCafe
{
    public partial class FormTheLuuDong : Form
    {
        private readonly TheLuuDongService _svc = new();

        public FormTheLuuDong()
        {
            InitializeComponent();
        }

        private void FormTheLuuDong_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            dgvThe.DataSource = _svc.GetAll();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var the = new TheLuuDong
            {
                MaThe = txtMaThe.Text.Trim(),
                ChuSoHuu = txtChuSoHuu.Text.Trim(),
                TrangThai = chkTrangThai.Checked
            };

            _svc.Add(the);
            LoadData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var the = new TheLuuDong
            {
                MaThe = txtMaThe.Text.Trim(),
                ChuSoHuu = txtChuSoHuu.Text.Trim(),
                TrangThai = chkTrangThai.Checked
            };

            _svc.Update(the);
            LoadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ma = txtMaThe.Text.Trim();
            if (!string.IsNullOrEmpty(ma))
            {
                _svc.Delete(ma);
                LoadData();
            }
        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
            txtMaThe.Clear();
            txtChuSoHuu.Clear();
            chkTrangThai.Checked = false;
        }

        private void dgvThe_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvThe.Rows[e.RowIndex];
                txtMaThe.Text = row.Cells["MaThe"].Value?.ToString();
                txtChuSoHuu.Text = row.Cells["ChuSoHuu"].Value?.ToString();
                chkTrangThai.Checked = Convert.ToBoolean(row.Cells["TrangThai"].Value);
            }
        }
    }
}
