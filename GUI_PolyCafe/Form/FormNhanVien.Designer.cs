namespace GUI_PolyCafe
{
    partial class FormNhanVien
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
            tableLayoutPanelNV = new TableLayoutPanel();
            panel1 = new Panel();
            lblMaNV = new Label();
            panel2 = new Panel();
            lblHoTen = new Label();
            panel3 = new Panel();
            lblEmail = new Label();
            panel4 = new Panel();
            lblMatKhau = new Label();
            panel5 = new Panel();
            lblVaiTro = new Label();
            panel6 = new Panel();
            lblTrangThai = new Label();
            panel7 = new Panel();
            txtMaNV = new TextBox();
            panel8 = new Panel();
            txtHoTen = new TextBox();
            panel9 = new Panel();
            txtEmail = new TextBox();
            panel10 = new Panel();
            txtMatKhau = new TextBox();
            panel11 = new Panel();
            cboVaiTro = new ComboBox();
            panel12 = new Panel();
            cboTrangThai = new ComboBox();
            flowLayoutPanelNV = new FlowLayoutPanel();
            btnAddNV = new Button();
            btnUpdateNV = new Button();
            btnDeleteNV = new Button();
            btnRefreshNV = new Button();
            btnSearchNV = new Button();
            txtSearchNV = new TextBox();
            dgvNV = new DataGridView();
            label4 = new Label();
            tableLayoutPanelNV.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
            panel11.SuspendLayout();
            panel12.SuspendLayout();
            flowLayoutPanelNV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNV).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanelNV
            // 
            tableLayoutPanelNV.ColumnCount = 6;
            tableLayoutPanelNV.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666718F));
            tableLayoutPanelNV.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanelNV.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanelNV.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanelNV.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanelNV.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanelNV.Controls.Add(panel1, 0, 0);
            tableLayoutPanelNV.Controls.Add(panel2, 1, 0);
            tableLayoutPanelNV.Controls.Add(panel3, 2, 0);
            tableLayoutPanelNV.Controls.Add(panel4, 3, 0);
            tableLayoutPanelNV.Controls.Add(panel5, 4, 0);
            tableLayoutPanelNV.Controls.Add(panel6, 5, 0);
            tableLayoutPanelNV.Controls.Add(panel7, 0, 1);
            tableLayoutPanelNV.Controls.Add(panel8, 1, 1);
            tableLayoutPanelNV.Controls.Add(panel9, 2, 1);
            tableLayoutPanelNV.Controls.Add(panel10, 3, 1);
            tableLayoutPanelNV.Controls.Add(panel11, 4, 1);
            tableLayoutPanelNV.Controls.Add(panel12, 5, 1);
            tableLayoutPanelNV.Dock = DockStyle.Top;
            tableLayoutPanelNV.Location = new Point(0, 0);
            tableLayoutPanelNV.Name = "tableLayoutPanelNV";
            tableLayoutPanelNV.Padding = new Padding(10);
            tableLayoutPanelNV.RowCount = 2;
            tableLayoutPanelNV.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanelNV.RowStyles.Add(new RowStyle(SizeType.Percent, 75F));
            tableLayoutPanelNV.Size = new Size(800, 120);
            tableLayoutPanelNV.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblMaNV);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(13, 13);
            panel1.Name = "panel1";
            panel1.Size = new Size(124, 19);
            panel1.TabIndex = 0;
            // 
            // lblMaNV
            // 
            lblMaNV.AutoSize = true;
            lblMaNV.Dock = DockStyle.Top;
            lblMaNV.Location = new Point(0, 0);
            lblMaNV.Name = "lblMaNV";
            lblMaNV.Size = new Size(46, 15);
            lblMaNV.TabIndex = 0;
            lblMaNV.Text = "Mã NV:";
            // 
            // panel2
            // 
            panel2.Controls.Add(lblHoTen);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(143, 13);
            panel2.Name = "panel2";
            panel2.Size = new Size(124, 19);
            panel2.TabIndex = 1;
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Dock = DockStyle.Top;
            lblHoTen.Location = new Point(0, 0);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(48, 15);
            lblHoTen.TabIndex = 0;
            lblHoTen.Text = "Họ Tên:";
            // 
            // panel3
            // 
            panel3.Controls.Add(lblEmail);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(273, 13);
            panel3.Name = "panel3";
            panel3.Size = new Size(124, 19);
            panel3.TabIndex = 2;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Dock = DockStyle.Top;
            lblEmail.Location = new Point(0, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "Email:";
            // 
            // panel4
            // 
            panel4.Controls.Add(lblMatKhau);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(403, 13);
            panel4.Name = "panel4";
            panel4.Size = new Size(124, 19);
            panel4.TabIndex = 3;
            // 
            // lblMatKhau
            // 
            lblMatKhau.AutoSize = true;
            lblMatKhau.Dock = DockStyle.Top;
            lblMatKhau.Location = new Point(0, 0);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(60, 15);
            lblMatKhau.TabIndex = 0;
            lblMatKhau.Text = "Mật khẩu:";
            // 
            // panel5
            // 
            panel5.Controls.Add(lblVaiTro);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(533, 13);
            panel5.Name = "panel5";
            panel5.Size = new Size(124, 19);
            panel5.TabIndex = 4;
            // 
            // lblVaiTro
            // 
            lblVaiTro.AutoSize = true;
            lblVaiTro.Dock = DockStyle.Top;
            lblVaiTro.Location = new Point(0, 0);
            lblVaiTro.Name = "lblVaiTro";
            lblVaiTro.Size = new Size(45, 15);
            lblVaiTro.TabIndex = 0;
            lblVaiTro.Text = "Vai Trò:";
            // 
            // panel6
            // 
            panel6.Controls.Add(lblTrangThai);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(663, 13);
            panel6.Name = "panel6";
            panel6.Size = new Size(124, 19);
            panel6.TabIndex = 5;
            // 
            // lblTrangThai
            // 
            lblTrangThai.AutoSize = true;
            lblTrangThai.Dock = DockStyle.Top;
            lblTrangThai.Location = new Point(0, 0);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(66, 15);
            lblTrangThai.TabIndex = 0;
            lblTrangThai.Text = "Trạng Thái:";
            // 
            // panel7
            // 
            panel7.Controls.Add(txtMaNV);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(13, 38);
            panel7.Name = "panel7";
            panel7.Size = new Size(124, 69);
            panel7.TabIndex = 6;
            // 
            // txtMaNV
            // 
            txtMaNV.Dock = DockStyle.Fill;
            txtMaNV.Location = new Point(0, 0);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(124, 23);
            txtMaNV.TabIndex = 0;
            txtMaNV.TextChanged += txtMaNV_TextChanged;
            // 
            // panel8
            // 
            panel8.Controls.Add(txtHoTen);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(143, 38);
            panel8.Name = "panel8";
            panel8.Size = new Size(124, 69);
            panel8.TabIndex = 7;
            // 
            // txtHoTen
            // 
            txtHoTen.Dock = DockStyle.Fill;
            txtHoTen.Location = new Point(0, 0);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(124, 23);
            txtHoTen.TabIndex = 0;
            // 
            // panel9
            // 
            panel9.Controls.Add(txtEmail);
            panel9.Dock = DockStyle.Fill;
            panel9.Location = new Point(273, 38);
            panel9.Name = "panel9";
            panel9.Size = new Size(124, 69);
            panel9.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Dock = DockStyle.Fill;
            txtEmail.Location = new Point(0, 0);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(124, 23);
            txtEmail.TabIndex = 0;
            // 
            // panel10
            // 
            panel10.Controls.Add(txtMatKhau);
            panel10.Dock = DockStyle.Fill;
            panel10.Location = new Point(403, 38);
            panel10.Name = "panel10";
            panel10.Size = new Size(124, 69);
            panel10.TabIndex = 9;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Dock = DockStyle.Fill;
            txtMatKhau.Location = new Point(0, 0);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(124, 23);
            txtMatKhau.TabIndex = 0;
            // 
            // panel11
            // 
            panel11.Controls.Add(cboVaiTro);
            panel11.Dock = DockStyle.Fill;
            panel11.Location = new Point(533, 38);
            panel11.Name = "panel11";
            panel11.Size = new Size(124, 69);
            panel11.TabIndex = 10;
            // 
            // cboVaiTro
            // 
            cboVaiTro.Dock = DockStyle.Fill;
            cboVaiTro.FormattingEnabled = true;
            cboVaiTro.Location = new Point(0, 0);
            cboVaiTro.Name = "cboVaiTro";
            cboVaiTro.Size = new Size(124, 23);
            cboVaiTro.TabIndex = 0;
            // 
            // panel12
            // 
            panel12.Controls.Add(cboTrangThai);
            panel12.Dock = DockStyle.Fill;
            panel12.Location = new Point(663, 38);
            panel12.Name = "panel12";
            panel12.Size = new Size(124, 69);
            panel12.TabIndex = 11;
            // 
            // cboTrangThai
            // 
            cboTrangThai.Dock = DockStyle.Fill;
            cboTrangThai.FormattingEnabled = true;
            cboTrangThai.Location = new Point(0, 0);
            cboTrangThai.Name = "cboTrangThai";
            cboTrangThai.Size = new Size(124, 23);
            cboTrangThai.TabIndex = 0;
            // 
            // flowLayoutPanelNV
            // 
            flowLayoutPanelNV.Controls.Add(btnAddNV);
            flowLayoutPanelNV.Controls.Add(btnUpdateNV);
            flowLayoutPanelNV.Controls.Add(btnDeleteNV);
            flowLayoutPanelNV.Controls.Add(btnRefreshNV);
            flowLayoutPanelNV.Controls.Add(btnSearchNV);
            flowLayoutPanelNV.Controls.Add(txtSearchNV);
            flowLayoutPanelNV.Dock = DockStyle.Top;
            flowLayoutPanelNV.Location = new Point(0, 120);
            flowLayoutPanelNV.Name = "flowLayoutPanelNV";
            flowLayoutPanelNV.Padding = new Padding(10, 5, 0, 0);
            flowLayoutPanelNV.Size = new Size(800, 40);
            flowLayoutPanelNV.TabIndex = 1;
            // 
            // btnAddNV
            // 
            btnAddNV.Location = new Point(40, 8);
            btnAddNV.Margin = new Padding(30, 3, 3, 3);
            btnAddNV.Name = "btnAddNV";
            btnAddNV.Size = new Size(75, 23);
            btnAddNV.TabIndex = 0;
            btnAddNV.Text = "Thêm";
            btnAddNV.UseVisualStyleBackColor = true;
            btnAddNV.Click += btnAddNV_Click_1;
            // 
            // btnUpdateNV
            // 
            btnUpdateNV.Location = new Point(148, 8);
            btnUpdateNV.Margin = new Padding(30, 3, 3, 3);
            btnUpdateNV.Name = "btnUpdateNV";
            btnUpdateNV.Size = new Size(75, 23);
            btnUpdateNV.TabIndex = 1;
            btnUpdateNV.Text = "Sửa";
            btnUpdateNV.UseVisualStyleBackColor = true;
            btnUpdateNV.Click += btnUpdateNV_Click_1;
            // 
            // btnDeleteNV
            // 
            btnDeleteNV.Location = new Point(256, 8);
            btnDeleteNV.Margin = new Padding(30, 3, 3, 3);
            btnDeleteNV.Name = "btnDeleteNV";
            btnDeleteNV.Size = new Size(75, 23);
            btnDeleteNV.TabIndex = 2;
            btnDeleteNV.Text = "Xóa";
            btnDeleteNV.UseVisualStyleBackColor = true;
            btnDeleteNV.Click += btnDeleteNV_Click_1;
            // 
            // btnRefreshNV
            // 
            btnRefreshNV.Location = new Point(364, 8);
            btnRefreshNV.Margin = new Padding(30, 3, 3, 3);
            btnRefreshNV.Name = "btnRefreshNV";
            btnRefreshNV.Size = new Size(75, 23);
            btnRefreshNV.TabIndex = 3;
            btnRefreshNV.Text = "Làm mới";
            btnRefreshNV.UseVisualStyleBackColor = true;
            btnRefreshNV.Click += btnRefreshNV_Click_1;
            // 
            // btnSearchNV
            // 
            btnSearchNV.Location = new Point(592, 8);
            btnSearchNV.Margin = new Padding(150, 3, 3, 3);
            btnSearchNV.Name = "btnSearchNV";
            btnSearchNV.Size = new Size(75, 23);
            btnSearchNV.TabIndex = 4;
            btnSearchNV.Text = "🔍";
            btnSearchNV.UseVisualStyleBackColor = true;
            btnSearchNV.Click += btnSearchNV_Click_1;
            // 
            // txtSearchNV
            // 
            txtSearchNV.Location = new Point(675, 8);
            txtSearchNV.Margin = new Padding(5, 3, 3, 3);
            txtSearchNV.Name = "txtSearchNV";
            txtSearchNV.Size = new Size(100, 23);
            txtSearchNV.TabIndex = 5;
            txtSearchNV.TextChanged += txtSearchNV_TextChanged;
            // 
            // dgvNV
            // 
            dgvNV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNV.Dock = DockStyle.Fill;
            dgvNV.Location = new Point(0, 160);
            dgvNV.Name = "dgvNV";
            dgvNV.ReadOnly = true;
            dgvNV.Size = new Size(800, 290);
            dgvNV.TabIndex = 2;
            dgvNV.CellClick += dgvNV_CellClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Top;
            label4.Location = new Point(0, 160);
            label4.Name = "label4";
            label4.Size = new Size(117, 15);
            label4.TabIndex = 3;
            label4.Text = "Danh sách nhân viên";
            // 
            // FormNhanVien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(dgvNV);
            Controls.Add(flowLayoutPanelNV);
            Controls.Add(tableLayoutPanelNV);
            Name = "FormNhanVien";
            Text = "Quản lý Nhân Viên";
            Load += FormNhanVien_Load;
            tableLayoutPanelNV.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel11.ResumeLayout(false);
            panel12.ResumeLayout(false);
            flowLayoutPanelNV.ResumeLayout(false);
            flowLayoutPanelNV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanelNV;
        private FlowLayoutPanel flowLayoutPanelNV;
        private Button btnAddNV;
        private Button btnUpdateNV;
        private Button btnDeleteNV;
        private Button btnRefreshNV;
        private Button btnSearchNV;
        private TextBox txtSearchNV;
        private DataGridView dgvNV;
        private Label label4;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label lblMaNV;
        private Label lblHoTen;
        private Label lblEmail;
        private Label lblMatKhau;
        private Panel panel5;
        private Label lblVaiTro;
        private Panel panel6;
        private Label lblTrangThai;
        private Panel panel7;
        private Panel panel8;
        private Panel panel9;
        private Panel panel10;
        private Panel panel11;
        private Panel panel12;
        private TextBox txtMaNV;
        private TextBox txtHoTen;
        private TextBox txtEmail;
        private TextBox txtMatKhau;
        private ComboBox cboVaiTro;
        private ComboBox cboTrangThai;

    }
}