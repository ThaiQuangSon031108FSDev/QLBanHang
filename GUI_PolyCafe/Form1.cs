namespace GUI_PolyCafe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
         //   dgv.DataSource = Service.GetAll();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuQL_LoaiSP_Click(object sender, EventArgs e)
        {
            new FormLoaiSanPham().ShowDialog();
        }

        private void menuQL_Click(object sender, EventArgs e)
        {

        }

        private void menuTK_Click(object sender, EventArgs e)
        {

        }

        private void menuHT_Click(object sender, EventArgs e)
        {

        }

        private void menuHT_DangXuat_Click(object sender, EventArgs e)
        {
            this.Close(); // hoặc quay trở lại FormLogin
        }

        private void menuHT_DoiMatKhau_Click(object sender, EventArgs e)
        {
          //  new FormChangePassword().ShowDialog();
        }

        private void menuTK_NhapNV_Click(object sender, EventArgs e)
        {
         //   new FormThongKe().Show(); // hoặc ShowDialog
        }

        private void menuTK_TonKho_Click(object sender, EventArgs e)
        {
         //   new FormThongKe().Show();
        }

        private void menuQL_ChiTietPhieu_Click(object sender, EventArgs e)
        {
        //    new FormChiTietPhieu().ShowDialog();
        }

        private void menuQL_PhieuBanHang_Click(object sender, EventArgs e)
        {
         //   new FormPhieuBanHang().ShowDialog();
        }

        private void menuQL_SanPham_Click(object sender, EventArgs e)
        {
          //  new FormSanPham().ShowDialog();
        }

        private void menuQL_NhanVien_Click(object sender, EventArgs e)
        {
            using var frm = new FormNhanVien();
            frm.ShowDialog();  // hoặc frm.Show();
        }

        private void menuQL_TheLuuDong_Click(object sender, EventArgs e)
        {
       //     new FormLoaiSanPham().ShowDialog();
        }
    }
}
