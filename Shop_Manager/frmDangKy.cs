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
            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void btnTroLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDangKy_Load(object sender, EventArgs e)
        {
            string strSQL = "SELECT * FROM BOPHAN";
            DataTable table = SQLHelper.layBangDuLieu(strSQL);

            cbMod.DataSource = table;
            cbMod.DisplayMember = "TENBOPHAN";
            cbMod.ValueMember = "MABOPHAN";
        }

        private void btnDangKy_Click(object sender, EventArgs e) {
            string strTaiKhoan = txtAcc.Text.Trim().Replace("-", "");
            string strMatKhau = txtPass.Text;
            long bp = long.Parse(cbMod.SelectedValue.ToString());

            // Kiểm tra các trường bỏ trống
            if (strTaiKhoan == "") {
                MessageBox.Show("Vui lòng nhập vào tên tài khoản");
                return;
            }
            if (strMatKhau == "") {
                MessageBox.Show("Vui lòng nhập vào mật khẩu");
                return;
            }

            // Kiểm tra tên tài khoản, mật khẩu đã tồn tại
            string strSQL1 = string.Format("SELECT * FROM NHANVIEN " +
                                          "where TENTAIKHOAN = '{0}'", strTaiKhoan);
            DataTable data = SQLHelper.layBangDuLieu(strSQL1);
            int a = data.Rows.Count;
            if (a > 0) {
                MessageBox.Show("Tài khoản đã tồn tại");
                return;
            }

            // Đăng kí tài khoản
            string strSQL =
                string.Format(
                    "INSERT INTO NHANVIEN " +
                    "(TENNHANVIEN, SODIENTHOAI, EMAIL, " +
                    " DIACHI, MABOPHAN, TRANGTHAI, TENTAIKHOAN, MATKHAU) " +
                    "VALUES('{0}', '{1}', '{2}', '{3}', {4}, {5}, '{6}', '{7}')",
                    strTaiKhoan, "0", "-", "-", bp, 1, strTaiKhoan, strMatKhau);

            if (SQLHelper.chayTruyVan(strSQL)) {
                MessageBox.Show("Bạn đã đăng ký thành công. Vui lòng đăng nhập.");
                this.Close();
            }
            else {
                MessageBox.Show("Không thể đăng kí tài khoản");
            }
        }
    }
}
