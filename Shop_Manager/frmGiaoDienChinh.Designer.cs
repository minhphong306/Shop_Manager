namespace Shop_Manager {
    partial class frmGiaoDienChinh {
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
            this.rtbTongTien = new System.Windows.Forms.RichTextBox();
            this.cbKhachHang = new System.Windows.Forms.ComboBox();
            this.dateHoaDon = new System.Windows.Forms.DateTimePicker();
            this.numericSoluong = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDuLieu = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.btnHuyDonHang = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnGiamSanPham = new System.Windows.Forms.Button();
            this.btnThemSanPham = new System.Windows.Forms.Button();
            this.txtMaKhach = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSoDT = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.rtbDiaChi = new System.Windows.Forms.RichTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnThemKhach = new System.Windows.Forms.Button();
            this.lbTongTien = new System.Windows.Forms.Label();
            this.btnTroLai = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericSoluong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDuLieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbTongTien
            // 
            this.rtbTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rtbTongTien.Location = new System.Drawing.Point(1025, 592);
            this.rtbTongTien.Name = "rtbTongTien";
            this.rtbTongTien.Size = new System.Drawing.Size(219, 75);
            this.rtbTongTien.TabIndex = 29;
            this.rtbTongTien.Text = "";
            // 
            // cbKhachHang
            // 
            this.cbKhachHang.FormattingEnabled = true;
            this.cbKhachHang.Location = new System.Drawing.Point(872, 102);
            this.cbKhachHang.Name = "cbKhachHang";
            this.cbKhachHang.Size = new System.Drawing.Size(188, 24);
            this.cbKhachHang.TabIndex = 27;
            this.cbKhachHang.SelectedIndexChanged += new System.EventHandler(this.cbKhachHang_SelectedIndexChanged);
            // 
            // dateHoaDon
            // 
            this.dateHoaDon.CustomFormat = "dd/MM/yyyy";
            this.dateHoaDon.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateHoaDon.Location = new System.Drawing.Point(1146, 75);
            this.dateHoaDon.Name = "dateHoaDon";
            this.dateHoaDon.Size = new System.Drawing.Size(174, 23);
            this.dateHoaDon.TabIndex = 26;
            // 
            // numericSoluong
            // 
            this.numericSoluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.numericSoluong.Location = new System.Drawing.Point(659, 201);
            this.numericSoluong.Name = "numericSoluong";
            this.numericSoluong.Size = new System.Drawing.Size(57, 38);
            this.numericSoluong.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(147)))));
            this.label2.Location = new System.Drawing.Point(171, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(282, 26);
            this.label2.TabIndex = 18;
            this.label2.Text = "DANH SÁCH MẶT HÀNG";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(147)))));
            this.label4.Location = new System.Drawing.Point(1092, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Ngày";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(147)))));
            this.label6.Location = new System.Drawing.Point(939, 584);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Bằng chữ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(147)))));
            this.label5.Location = new System.Drawing.Point(939, 556);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Tổng tiền";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(147)))));
            this.label3.Location = new System.Drawing.Point(768, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Khách hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(147)))));
            this.label1.Location = new System.Drawing.Point(646, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "Số lượng";
            // 
            // dgvDuLieu
            // 
            this.dgvDuLieu.AllowUserToAddRows = false;
            this.dgvDuLieu.AllowUserToDeleteRows = false;
            this.dgvDuLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDuLieu.Location = new System.Drawing.Point(12, 115);
            this.dgvDuLieu.Name = "dgvDuLieu";
            this.dgvDuLieu.ReadOnly = true;
            this.dgvDuLieu.Size = new System.Drawing.Size(593, 552);
            this.dgvDuLieu.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(147)))));
            this.label7.Location = new System.Drawing.Point(909, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(270, 26);
            this.label7.TabIndex = 19;
            this.label7.Text = "HÓA ĐƠN NHẬP HÀNG";
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.AllowUserToAddRows = false;
            this.dgvHoaDon.AllowUserToDeleteRows = false;
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Location = new System.Drawing.Point(785, 245);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.ReadOnly = true;
            this.dgvHoaDon.RowHeadersVisible = false;
            this.dgvHoaDon.Size = new System.Drawing.Size(535, 294);
            this.dgvHoaDon.TabIndex = 11;
            // 
            // btnHuyDonHang
            // 
            this.btnHuyDonHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuyDonHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(147)))));
            this.btnHuyDonHang.Image = global::Shop_Manager.Properties.Resources.history_clear;
            this.btnHuyDonHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuyDonHang.Location = new System.Drawing.Point(624, 521);
            this.btnHuyDonHang.Name = "btnHuyDonHang";
            this.btnHuyDonHang.Size = new System.Drawing.Size(140, 52);
            this.btnHuyDonHang.TabIndex = 24;
            this.btnHuyDonHang.Text = "Hủy đơn hàng";
            this.btnHuyDonHang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuyDonHang.UseVisualStyleBackColor = true;
            this.btnHuyDonHang.Click += new System.EventHandler(this.btnHuyDonHang_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThanhToan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(147)))));
            this.btnThanhToan.Image = global::Shop_Manager.Properties.Resources.paperbag_32;
            this.btnThanhToan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThanhToan.Location = new System.Drawing.Point(624, 449);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(140, 57);
            this.btnThanhToan.TabIndex = 23;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(147)))));
            this.btnXoa.Image = global::Shop_Manager.Properties.Resources.knotes_delete_knotes_32;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(624, 381);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(140, 51);
            this.btnXoa.TabIndex = 22;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnGiamSanPham
            // 
            this.btnGiamSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiamSanPham.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(147)))));
            this.btnGiamSanPham.Image = global::Shop_Manager.Properties.Resources.bookmark_remove_32;
            this.btnGiamSanPham.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGiamSanPham.Location = new System.Drawing.Point(624, 313);
            this.btnGiamSanPham.Name = "btnGiamSanPham";
            this.btnGiamSanPham.Size = new System.Drawing.Size(140, 51);
            this.btnGiamSanPham.TabIndex = 21;
            this.btnGiamSanPham.Text = "Giảm";
            this.btnGiamSanPham.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGiamSanPham.UseVisualStyleBackColor = true;
            this.btnGiamSanPham.Click += new System.EventHandler(this.btnGiamSanPham_Click);
            // 
            // btnThemSanPham
            // 
            this.btnThemSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemSanPham.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(147)))));
            this.btnThemSanPham.Image = global::Shop_Manager.Properties.Resources.bookmark_new_32;
            this.btnThemSanPham.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemSanPham.Location = new System.Drawing.Point(624, 245);
            this.btnThemSanPham.Name = "btnThemSanPham";
            this.btnThemSanPham.Size = new System.Drawing.Size(140, 51);
            this.btnThemSanPham.TabIndex = 25;
            this.btnThemSanPham.Text = "Thêm";
            this.btnThemSanPham.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemSanPham.UseVisualStyleBackColor = true;
            this.btnThemSanPham.Click += new System.EventHandler(this.btnThemSanPham_Click);
            // 
            // txtMaKhach
            // 
            this.txtMaKhach.Enabled = false;
            this.txtMaKhach.Location = new System.Drawing.Point(872, 132);
            this.txtMaKhach.Name = "txtMaKhach";
            this.txtMaKhach.Size = new System.Drawing.Size(188, 23);
            this.txtMaKhach.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(147)))));
            this.label8.Location = new System.Drawing.Point(768, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Mã khách";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(147)))));
            this.label9.Location = new System.Drawing.Point(768, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "Số ĐT";
            // 
            // txtSoDT
            // 
            this.txtSoDT.Enabled = false;
            this.txtSoDT.Location = new System.Drawing.Point(872, 161);
            this.txtSoDT.Name = "txtSoDT";
            this.txtSoDT.Size = new System.Drawing.Size(188, 23);
            this.txtSoDT.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(147)))));
            this.label10.Location = new System.Drawing.Point(1092, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 17);
            this.label10.TabIndex = 14;
            this.label10.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(1146, 106);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(174, 23);
            this.txtEmail.TabIndex = 30;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(147)))));
            this.label12.Location = new System.Drawing.Point(768, 75);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 17);
            this.label12.TabIndex = 14;
            this.label12.Text = "Nhân viên";
            // 
            // txtTenNV
            // 
            this.txtTenNV.Enabled = false;
            this.txtTenNV.Location = new System.Drawing.Point(872, 69);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(188, 23);
            this.txtTenNV.TabIndex = 30;
            // 
            // rtbDiaChi
            // 
            this.rtbDiaChi.Enabled = false;
            this.rtbDiaChi.Location = new System.Drawing.Point(1146, 135);
            this.rtbDiaChi.Name = "rtbDiaChi";
            this.rtbDiaChi.Size = new System.Drawing.Size(174, 69);
            this.rtbDiaChi.TabIndex = 32;
            this.rtbDiaChi.Text = "";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(147)))));
            this.label13.Location = new System.Drawing.Point(1092, 138);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 17);
            this.label13.TabIndex = 14;
            this.label13.Text = "Địa chỉ";
            // 
            // btnThemKhach
            // 
            this.btnThemKhach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemKhach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(147)))));
            this.btnThemKhach.Image = global::Shop_Manager.Properties.Resources.customer_32;
            this.btnThemKhach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemKhach.Location = new System.Drawing.Point(892, 197);
            this.btnThemKhach.Name = "btnThemKhach";
            this.btnThemKhach.Size = new System.Drawing.Size(168, 35);
            this.btnThemKhach.TabIndex = 25;
            this.btnThemKhach.Text = "Thêm khách hàng";
            this.btnThemKhach.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemKhach.UseVisualStyleBackColor = true;
            this.btnThemKhach.Click += new System.EventHandler(this.btnThemKhach_Click);
            // 
            // lbTongTien
            // 
            this.lbTongTien.AutoSize = true;
            this.lbTongTien.BackColor = System.Drawing.Color.Transparent;
            this.lbTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTongTien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(147)))));
            this.lbTongTien.Location = new System.Drawing.Point(1022, 556);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(99, 24);
            this.lbTongTien.TabIndex = 15;
            this.lbTongTien.Text = "Tổng tiền";
            // 
            // btnTroLai
            // 
            this.btnTroLai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(147)))));
            this.btnTroLai.Image = global::Shop_Manager.Properties.Resources.backward_32;
            this.btnTroLai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTroLai.Location = new System.Drawing.Point(624, 592);
            this.btnTroLai.Name = "btnTroLai";
            this.btnTroLai.Size = new System.Drawing.Size(140, 49);
            this.btnTroLai.TabIndex = 33;
            this.btnTroLai.Text = "Trở lại";
            this.btnTroLai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTroLai.UseVisualStyleBackColor = true;
            this.btnTroLai.Click += new System.EventHandler(this.btnTroLai_Click);
            // 
            // frmGiaoDienChinh
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(1341, 680);
            this.Controls.Add(this.btnTroLai);
            this.Controls.Add(this.rtbDiaChi);
            this.Controls.Add(this.txtTenNV);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSoDT);
            this.Controls.Add(this.txtMaKhach);
            this.Controls.Add(this.rtbTongTien);
            this.Controls.Add(this.btnHuyDonHang);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.cbKhachHang);
            this.Controls.Add(this.dateHoaDon);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnGiamSanPham);
            this.Controls.Add(this.btnThemKhach);
            this.Controls.Add(this.btnThemSanPham);
            this.Controls.Add(this.numericSoluong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbTongTien);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDuLieu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvHoaDon);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Name = "frmGiaoDienChinh";
            this.Text = "Quản lý bán hàng";
            this.Load += new System.EventHandler(this.frmGiaoDienChinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericSoluong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDuLieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox rtbTongTien;
        private System.Windows.Forms.Button btnHuyDonHang;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.ComboBox cbKhachHang;
        private System.Windows.Forms.DateTimePicker dateHoaDon;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnGiamSanPham;
        private System.Windows.Forms.Button btnThemSanPham;
        private System.Windows.Forms.NumericUpDown numericSoluong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDuLieu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.TextBox txtMaKhach;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSoDT;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.RichTextBox rtbDiaChi;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnThemKhach;
        private System.Windows.Forms.Label lbTongTien;
        private System.Windows.Forms.Button btnTroLai;
    }
}