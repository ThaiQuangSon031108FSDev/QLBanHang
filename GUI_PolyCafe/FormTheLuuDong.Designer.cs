namespace GUI_PolyCafe
{
    partial class FormTheLuuDong
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
            tabMain = new TabControl();
            tabCapNhat = new TabPage();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnRefresh = new Button();
            groupBox1 = new GroupBox();
            chkTrangThai = new CheckBox();
            txtMaThe = new TextBox();
            txtChuSoHuu = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            lblTitle = new Label();
            tabDanhSach = new TabPage();
            dgvThe = new DataGridView();
            tabMain.SuspendLayout();
            tabCapNhat.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            tabDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvThe).BeginInit();
            SuspendLayout();
            // 
            // tabMain
            // 
            tabMain.Controls.Add(tabCapNhat);
            tabMain.Controls.Add(tabDanhSach);
            tabMain.Dock = DockStyle.Fill;
            tabMain.Location = new Point(0, 0);
            tabMain.Name = "tabMain";
            tabMain.SelectedIndex = 0;
            tabMain.Size = new Size(800, 450);
            tabMain.TabIndex = 0;
            // 
            // tabCapNhat
            // 
            tabCapNhat.Controls.Add(flowLayoutPanel1);
            tabCapNhat.Controls.Add(groupBox1);
            tabCapNhat.Controls.Add(lblTitle);
            tabCapNhat.Location = new Point(4, 24);
            tabCapNhat.Margin = new Padding(53, 3, 3, 3);
            tabCapNhat.Name = "tabCapNhat";
            tabCapNhat.Padding = new Padding(3);
            tabCapNhat.Size = new Size(792, 422);
            tabCapNhat.TabIndex = 0;
            tabCapNhat.Text = "CẬP NHẬT";
            tabCapNhat.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnAdd);
            flowLayoutPanel1.Controls.Add(btnUpdate);
            flowLayoutPanel1.Controls.Add(btnDelete);
            flowLayoutPanel1.Controls.Add(btnRefresh);
            flowLayoutPanel1.Location = new Point(6, 257);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(778, 100);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(153, 3);
            btnAdd.Margin = new Padding(153, 3, 3, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(284, 3);
            btnUpdate.Margin = new Padding(53, 3, 3, 3);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Sửa";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(415, 3);
            btnDelete.Margin = new Padding(53, 3, 3, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(546, 3);
            btnRefresh.Margin = new Padding(53, 3, 3, 3);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 23);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "Mới";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chkTrangThai);
            groupBox1.Controls.Add(txtMaThe);
            groupBox1.Controls.Add(txtChuSoHuu);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(179, 123);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(376, 129);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // chkTrangThai
            // 
            chkTrangThai.AutoSize = true;
            chkTrangThai.Location = new Point(127, 75);
            chkTrangThai.Name = "chkTrangThai";
            chkTrangThai.Size = new Size(85, 19);
            chkTrangThai.TabIndex = 10;
            chkTrangThai.Text = "Hoạt động";
            chkTrangThai.UseVisualStyleBackColor = true;
            // 
            // txtMaThe
            // 
            txtMaThe.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtMaThe.Location = new Point(127, 26);
            txtMaThe.Margin = new Padding(3, 2, 3, 2);
            txtMaThe.Name = "txtMaThe";
            txtMaThe.ReadOnly = true;
            txtMaThe.Size = new Size(200, 20);
            txtMaThe.TabIndex = 9;
            // 
            // txtChuSoHuu
            // 
            txtChuSoHuu.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtChuSoHuu.Location = new Point(127, 50);
            txtChuSoHuu.Margin = new Padding(3, 2, 3, 2);
            txtChuSoHuu.Name = "txtChuSoHuu";
            txtChuSoHuu.ReadOnly = true;
            txtChuSoHuu.Size = new Size(200, 20);
            txtChuSoHuu.TabIndex = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(18, 74);
            label9.Name = "label9";
            label9.Size = new Size(62, 15);
            label9.TabIndex = 2;
            label9.Text = "Trạng thái";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(18, 49);
            label8.Name = "label8";
            label8.Size = new Size(69, 15);
            label8.TabIndex = 1;
            label8.Text = "Chủ sở hữu";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(18, 24);
            label7.Name = "label7";
            label7.Size = new Size(46, 15);
            label7.TabIndex = 0;
            label7.Text = "Mã thẻ";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(318, 70);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(162, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "THẺ LƯU ĐỘNG";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabDanhSach
            // 
            tabDanhSach.Controls.Add(dgvThe);
            tabDanhSach.Location = new Point(4, 24);
            tabDanhSach.Name = "tabDanhSach";
            tabDanhSach.Padding = new Padding(3);
            tabDanhSach.Size = new Size(792, 422);
            tabDanhSach.TabIndex = 1;
            tabDanhSach.Text = "DANH SÁCH";
            tabDanhSach.UseVisualStyleBackColor = true;
            // 
            // dgvThe
            // 
            dgvThe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvThe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvThe.Dock = DockStyle.Fill;
            dgvThe.Location = new Point(3, 3);
            dgvThe.Name = "dgvThe";
            dgvThe.ReadOnly = true;
            dgvThe.Size = new Size(786, 416);
            dgvThe.TabIndex = 0;
            // 
            // FormTheLuuDong
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabMain);
            Name = "FormTheLuuDong";
            Text = "FormTheLuuDong";
            Load += FormTheLuuDong_Load;
            tabMain.ResumeLayout(false);
            tabCapNhat.ResumeLayout(false);
            tabCapNhat.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvThe).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabMain;
        private TabPage tabCapNhat;
        private Label lblTitle;
        private TabPage tabDanhSach;
        private DataGridView dgvThe;
        private GroupBox groupBox1;
        private ComboBox cboSanPham;
        private TextBox txtThanhTien;
        private TextBox txtSoLuong;
        private TextBox txtChuSoHuu;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private TextBox txtMaThe;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnRefresh;
        private CheckBox chkTrangThai;
    }
}