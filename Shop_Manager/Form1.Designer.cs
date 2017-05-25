namespace Shop_Manager {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.llbDangKy = new System.Windows.Forms.LinkLabel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // llbDangKy
            // 
            this.llbDangKy.AutoSize = true;
            this.llbDangKy.BackColor = System.Drawing.Color.Transparent;
            this.llbDangKy.Location = new System.Drawing.Point(412, 361);
            this.llbDangKy.Name = "llbDangKy";
            this.llbDangKy.Size = new System.Drawing.Size(132, 20);
            this.llbDangKy.TabIndex = 15;
            this.llbDangKy.TabStop = true;
            this.llbDangKy.Text = "Đăng kí tài khoản";
            this.llbDangKy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbDangKy_LinkClicked);
            // 
            // btnThoat
            // 
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Location = new System.Drawing.Point(354, 295);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(124, 47);
            this.btnThoat.TabIndex = 13;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangNhap.Location = new System.Drawing.Point(200, 295);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(124, 47);
            this.btnDangNhap.TabIndex = 14;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.BackColor = System.Drawing.Color.White;
            this.txtMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMatKhau.Location = new System.Drawing.Point(199, 233);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = 'x';
            this.txtMatKhau.Size = new System.Drawing.Size(268, 38);
            this.txtMatKhau.TabIndex = 12;
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.BackColor = System.Drawing.Color.White;
            this.txtTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTaiKhoan.Location = new System.Drawing.Point(199, 169);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(268, 38);
            this.txtTaiKhoan.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(195, 210);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Mật khẩu";
            // 
            // lbStatus
            // 
            this.lbStatus.BackColor = System.Drawing.Color.Transparent;
            this.lbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbStatus.ForeColor = System.Drawing.Color.Red;
            this.lbStatus.Location = new System.Drawing.Point(100, 392);
            this.lbStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(491, 26);
            this.lbStatus.TabIndex = 8;
            this.lbStatus.Text = "Tài khoản đã bị khóa";
            this.lbStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbStatus.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(195, 146);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tài khoản";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::Shop_Manager.Properties.Resources.Picture2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(662, 448);
            this.Controls.Add(this.llbDangKy);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTaiKhoan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.label2);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Name = "Form1";
            this.Text = "Đăng nhập vào chương trình";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel llbDangKy;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label label2;
    }
}

