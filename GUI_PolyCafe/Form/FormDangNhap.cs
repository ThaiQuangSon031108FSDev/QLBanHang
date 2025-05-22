using System;
using System.Configuration;
using System.Windows.Forms;
using BLL_PolyCafe.Services;
using DAL_PolyCafe.Repositories;
using DTO_PolyCafe.Entities;


namespace GUI_PolyCafe
{
    public partial class FormDangNhap : Form
    {
        private readonly NhanVienService _auth = new();

        public FormDangNhap()
        {
            InitializeComponent();
            // Mặc định che password
            txtPassword.UseSystemPasswordChar = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var email = txtUsername.Text.Trim();
            var pass = txtPassword.Text.Trim();

            // gỡ bỏ hoặc comment dòng sau nếu muốn bỏ kiểm tra:
            // bool ok = _auth.Login(email, pass, ComputeSha256);
            // if (!ok) return;

            // Luôn mở Form1 bất kể ok là gì
            MessageBox.Show("Đăng nhập thành công vui lòng dùng phần mềm 1 cách tinh tế.");
            Hide();
            Hide();
            new Form1().ShowDialog();
            Close();
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            // Gạt để hiện/ẩn mật khẩu
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

        // Hàm băm SHA256, giống trong FormNhanVien
        private string ComputeSha256(string raw)
        {
            using var sha = System.Security.Cryptography.SHA256.Create();
            var bytes = sha.ComputeHash(System.Text.Encoding.UTF8.GetBytes(raw));
            var sb = new System.Text.StringBuilder();
            foreach (var b in bytes) sb.Append(b.ToString("x2"));
            return sb.ToString();
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            txtUsername.Text = "NV002";
            txtPassword.Text = "password2";
        }

        private void quenmk_Click(object sender, EventArgs e)
        {
            using var frm = new DoiMatKhau();
            frm.ShowDialog();  // hoặc frm.Show();
        }
    }
}
