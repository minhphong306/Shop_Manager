using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop_Manager {
    public partial class frmDangKy : Form {
        public frmDangKy() {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            //this.BackColor = Color.FromArgb(236, 240, 241);
        }

        private void btnTroLai_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void frmDangKy_Load(object sender, EventArgs e) {
           
        }

        private void btnDangKy_Click(object sender, EventArgs e) {

            string TenNV = txtTenNV.Text;
            string SDT = txtSDT.Text;
            string date = dateNgaySinh.Text;
            string gioitinh;
            if (cbNam.Checked == true) {
                gioitinh = "NAM";
            }
            else {
                gioitinh = "NỮ";
            }

            string Email = txtEmail.Text;
            string DiaChi = rtbDiaChi.Text;
            string TaiKhoan = txtTaiKhoan.Text;
            string MatKhau = txtMatKhau.Text;
            string repass = txtRePass.Text;

            if (!repass.Equals(MatKhau))
            {
                MessageBox.Show("Mật khẩu nhập lại không trùng");
                return;
            }

            long BP = 2;
            int TT = 1;
            if (String.IsNullOrWhiteSpace(TenNV)) {
                MessageBox.Show("Tên nhân viên không hợp lệ");
                return;
            }

            if (!Email.Contains("@")) {
                MessageBox.Show("Địa chỉ email không hợp lệ");
                return;
            }
            if (!SDT.All(char.IsDigit) || String.IsNullOrWhiteSpace(SDT)) {
                MessageBox.Show("Số điện thoại không hợp lệ");
                return;
            }

            if (String.IsNullOrWhiteSpace(TaiKhoan)) {
                MessageBox.Show("Tên tài khoản không hợp lệ");
                return;
            }
            
            string sql = "";

            // Kiểm tra tên tài khoản, mật khẩu đã tồn tại
            string strSQL1 = string.Format("SELECT * FROM NHANVIEN " +
                                          "where TENTAIKHOAN = '{0}'", TaiKhoan);
            DataTable data = SQLHelper.layBangDuLieu(strSQL1);
            int a = data.Rows.Count;
            if (a > 0) {
                MessageBox.Show("Tài khoản đã tồn tại");
                return;
            }
            sql =
                string.Format(
                    "INSERT INTO NHANVIEN (TENNHANVIEN, SODIENTHOAI, EMAIL, MABOPHAN, DIACHI, TENTAIKHOAN, MATKHAU, TRANGTHAI, NGAYSINH, GIOITINH) VALUES(N'{0}', '{1}', '{2}', '{3}', N'{4}', '{5}', '{6}', '{7}', '{8}', '{9}')",
                    TenNV, SDT, Email, BP, DiaChi, TaiKhoan, MatKhau, TT, date, gioitinh);
            SQLHelper.chayTruyVan(sql);
            MessageBox.Show("Bạn đã đăng kí thành công tài khoản " + TaiKhoan + "\nHãy đăng nhập để sử dụng hệ thống");
            this.Close();
        }
    }
}
