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
            var hash = ComputeSha256(pass);

            MessageBox.Show($"Email: {email}\nHash: {hash}", "Debug");

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu.", "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool ok = _auth.Login(email, pass, ComputeSha256);
            if (!ok)
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu.", "Đăng nhập thất bại",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Đăng nhập thành công
            Hide();
            using var main = new Form1();
            main.ShowDialog();
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

        }

        private void quenmk_Click(object sender, EventArgs e)
        {
            using var frm = new DoiMatKhau();
            frm.ShowDialog();  // hoặc frm.Show();
        }
    }
}
