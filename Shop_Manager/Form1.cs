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
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llbDangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmDangKy fDangKy = new frmDangKy();
            fDangKy.ShowDialog();
            this.Show();
        }

        private void btnDangNhap_Click(object sender, EventArgs e) {
            string strTaiKhoan = txtTaiKhoan.Text.Trim().Replace("-", "");
            string strMatKhau = txtMatKhau.Text;
           
            if (strTaiKhoan == "") {
                lbStatus.Text = "Vui lòng nhập vào tên tài khoản";
                lbStatus.Visible = true;
                return;
            }
            if (strMatKhau == "") {
                lbStatus.Text = "Vui lòng nhập vào mật khẩu";
                lbStatus.Visible = true;
                return;
            }
            string strSQL = string.Format("SELECT * FROM NHANVIEN " +
                                          "where TENTAIKHOAN = '{0}' and MATKHAU = '{1}' and DAXOA = 0", strTaiKhoan, strMatKhau);
            DataTable data = SQLHelper.layBangDuLieu(strSQL);
            int a = data.Rows.Count;
            if (a == 0)
            {
                lbStatus.Text = "Sai tên đăng nhập";
                lbStatus.Visible = true;
                return;
            }
            else
            {
                long state = long.Parse(data.Rows[0]["TRANGTHAI"].ToString());
                if (state == 0)
                {
                    lbStatus.Text = "Tài khoản đã bị khóa";
                    lbStatus.Visible = true;
                    return;
                }

                lbStatus.Visible = false;
                this.Hide();
                int role = int.Parse(data.Rows[0]["MABOPHAN"].ToString());
                frmGiaoDienChinh fMain = new frmGiaoDienChinh();
                
                SQLHelper.BOPHAN = role;
                fMain.ShowDialog();
                this.Show();
            }
        }

        // Test commit

    }
}
