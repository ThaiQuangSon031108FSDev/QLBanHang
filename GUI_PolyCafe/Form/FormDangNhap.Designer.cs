 namespace GUI_PolyCafe
{
    public partial class FormDangNhap : Form
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
            txtUsername = new TextBox();
            chkShowPassword = new CheckBox();
            btnLogin = new Button();
            txtPassword = new TextBox();
            btnExit = new Button();
            quenmk = new Button();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(110, 107);
            txtUsername.Margin = new Padding(4, 3, 4, 3);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(454, 23);
            txtUsername.TabIndex = 0;
            txtUsername.Text = "Tên đăng nhập";
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.Location = new Point(110, 208);
            chkShowPassword.Margin = new Padding(4, 3, 4, 3);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(124, 19);
            chkShowPassword.TabIndex = 1;
            chkShowPassword.Text = "Ấn/Hiện mật khẩu";
            chkShowPassword.UseVisualStyleBackColor = true;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(110, 317);
            btnLogin.Margin = new Padding(4, 3, 4, 3);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(197, 95);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(110, 163);
            txtPassword.Margin = new Padding(4, 3, 4, 3);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(454, 23);
            txtPassword.TabIndex = 4;
            txtPassword.Text = "Mật khẩu";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(385, 317);
            btnExit.Margin = new Padding(4, 3, 4, 3);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(197, 95);
            btnExit.TabIndex = 5;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // quenmk
            // 
            quenmk.Location = new Point(110, 233);
            quenmk.Name = "quenmk";
            quenmk.Size = new Size(112, 23);
            quenmk.TabIndex = 6;
            quenmk.Text = "Quên mật khẩu";
            quenmk.UseVisualStyleBackColor = true;
            quenmk.Click += quenmk_Click;
            // 
            // FormDangNhap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(quenmk);
            Controls.Add(btnExit);
            Controls.Add(txtPassword);
            Controls.Add(btnLogin);
            Controls.Add(chkShowPassword);
            Controls.Add(txtUsername);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormDangNhap";
            Text = "Đăng nhập";
            Load += FormDangNhap_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.CheckBox chkShowPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnExit;
        private Button quenmk;
    }
}

