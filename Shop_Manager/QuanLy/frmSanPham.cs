using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop_Manager.QuanLy {
    public partial class frmSanPham : Form {

        // Thuộc tính
        private DataTable dataTable;
        private int MODE;
        private const int EDIT = 1, ADD = 2, WAIT = 3;
        private string[] strHeader = { "Mã nhân viên", "Tên nhân viên", "Số DT", "Email", "Địa chỉ", "Bộ phận", "Trạng thái", "Tài khoản", "Mật khẩu" };
        private int[] size = { 10, 30, 20, 30, 20, 20, 20, 20, 20 };

        public frmSanPham() {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterParent;
        }

        private void btnTroLai_Click(object sender, EventArgs e) {

        }

        private void btnHuy_Click(object sender, EventArgs e) {

        }

        private void btnDongY_Click(object sender, EventArgs e) {

        }

        private void btnXoa_Click(object sender, EventArgs e) {

        }

        private void btnSua_Click(object sender, EventArgs e) {

        }

        private void btnThem_Click(object sender, EventArgs e) {

        }

        private void frmSanPham_Load(object sender, EventArgs e) {

        }
    }
}
