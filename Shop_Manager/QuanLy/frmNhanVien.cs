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
   
    public partial class frmNhanVien : Form {

        // Thuộc tính
        private DataTable dataTable;
        private int MODE;
        private const int EDIT = 1, ADD = 2, WAIT = 3;
        private string[] strHeader = { "Mã nhân viên", "Tên nhân viên", "Số DT", "Email", "Địa chỉ", "Bộ phận", "Trạng thái", "Tài khoản", "Mật khẩu" };
        private int[] size = { 10, 30, 20, 30, 20, 20, 20, 20, 20};

        public frmNhanVien() {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            dgvDuLieu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void thayDoiTrangThai() {
            switch (MODE) {
                case WAIT:
                    txtTenNV.Enabled = false;
                   
                    txtSDT.Enabled = false;
                    txtEmail.Enabled = false;

                    rtbDiaChi.Enabled = false;
                    cbBoPhan.Enabled = false;
                    rbHoatDong.Enabled = false;
                    rbKhoa.Enabled = false;
                    txtTaiKhoan.Enabled = false;
                    txtMatKhau.Enabled = false;

                    btnThem.Enabled = true;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;

                    btnDongY.Enabled = false;
                    btnHuy.Enabled = false;
                    break;
                case EDIT:
                   
                    txtTenNV.Enabled = true;
                    txtSDT.Enabled = true;
                    txtEmail.Enabled = true;

                    rtbDiaChi.Enabled = true;
                    cbBoPhan.Enabled = true;
                    rbHoatDong.Enabled = true;
                    rbKhoa.Enabled = true;

                    txtTaiKhoan.Enabled = true;
                    txtMatKhau.Enabled = true;

                    btnThem.Enabled = false;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;

                    btnDongY.Enabled = true;
                    btnHuy.Enabled = true;
                    break;
                case ADD:
                  
                    txtTenNV.Enabled = true;
                    txtSDT.Enabled = true;
                    txtEmail.Enabled = true;

                    rtbDiaChi.Enabled = true;
                    cbBoPhan.Enabled = true;
                    rbHoatDong.Enabled = true;
                    rbKhoa.Enabled = true;

                    txtTaiKhoan.Enabled = true;
                    txtMatKhau.Enabled = true;

                    btnThem.Enabled = false;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;

                    btnDongY.Enabled = true;
                    btnHuy.Enabled = true;
                    break;
            }
        }

        private void btnTroLai_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnDongY_Click(object sender, EventArgs e) {
            try {
                long MaNV = long.Parse(txtMaNV.Text);
                string TenNV = txtTenNV.Text;
                string SDT = txtSDT.Text;
                string Email = txtEmail.Text;
                string DiaChi = rtbDiaChi.Text;
                string TaiKhoan = txtTaiKhoan.Text;
                string MatKhau = txtMatKhau.Text;
                long BP = long.Parse(cbBoPhan.SelectedValue.ToString());
                int TT;
                if (rbHoatDong.Checked == true) {
                    TT = 1;
                }
                else {
                    TT = 0;
                }
                string sql = "";
                switch (MODE) {
                    case EDIT:
                        sql = string.Format("UPDATE NHANVIEN SET TENNHANVIEN = N'{0}', SODIENTHOAI = '{1}', EMAIL = '{2}', MABOPHAN = '{3}', DIACHI = N'{4}', TENTAIKHOAN = '{5}', MATKHAU = '{6}', TRANGTHAI = '{7}' WHERE MANHANVIEN = '{8}' ",
                                                                         TenNV, SDT, Email, BP, DiaChi, TaiKhoan, MatKhau, TT, MaNV);

                        break;
                    case ADD:
                        sql =
                            string.Format(
                                "INSERT INTO NHANVIEN (TENNHANVIEN, SODIENTHOAI, EMAIL, MABOPHAN, DIACHI, TAIKHOAN, MATKHAU, TRANGTHAI) VALUES({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}",
                                TenNV, SDT, Email, BP, DiaChi, TaiKhoan, MatKhau, TT);
                        break;
                }
                SQLHelper.chayTruyVan(sql);
                MessageBox.Show("Cập nhật dữ liệu thành công");
                frmNhanVien_Load(null, null);
            }
            catch (Exception) {
                MessageBox.Show("Vui lòng nhập đủ các trường hoặc thử lại");
            }
        }

        private void btnSua_Click(object sender, EventArgs e) {
            MODE = EDIT;
            thayDoiTrangThai();
        }

        private void btnHuy_Click(object sender, EventArgs e) {
            MODE = WAIT;
            thayDoiTrangThai();
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex >= 0) {
                DataGridViewRow dr = dgvDuLieu.Rows[e.RowIndex];
                txtMaNV.Text = dr.Cells[0].Value.ToString();
                txtTenNV.Text = dr.Cells[1].Value.ToString();
                txtSDT.Text = dr.Cells[2].Value.ToString();
                txtEmail.Text = dr.Cells[3].Value.ToString();


                rtbDiaChi.Text = dr.Cells[4].Value.ToString();
                cbBoPhan.SelectedValue = dr.Cells[5].Value.ToString();
               int tt = int.Parse(dr.Cells[6].Value.ToString());
                if (tt == 0)
                {
                    rbKhoa.Checked = true;
                }
                else
                {
                    rbHoatDong.Checked = true;
                }

                txtTaiKhoan.Text = dr.Cells[7].Value.ToString();
                txtMatKhau.Text = dr.Cells[8].Value.ToString();

            }
        }

        private void btnXoa_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Bạn có muốn xóa nhân viên này này", "Xác nhân", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes) {
                string maDM = txtMaNV.Text;
                String sql = string.Format("UPDATE NHANVIEN SET DAXOA = '1'  WHERE MANHANVIEN = '{0}'", maDM);
                SQLHelper.chayTruyVan(sql);
                MessageBox.Show("Xóa thành công nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmNhanVien_Load(null, null);
            }
        }

        private void btnThem_Click(object sender, EventArgs e) {
            MODE = ADD;
            thayDoiTrangThai();
        }

        private void frmNhanVien_Load(object sender, EventArgs e) {
            dataTable = new DataTable();     
            MODE = WAIT;
            thayDoiTrangThai();

            // Lấy dữ liệu từ CSDL
            string strSQL = "SELECT MABOPHAN, TENBOPHAN FROM BOPHAN where DAXOA = 0";
            DataTable d1 = SQLHelper.layBangDuLieu(strSQL);

            // Gán dl bảng vào binding, binding gán vào dgv
            cbBoPhan.DataSource = d1;
            cbBoPhan.ValueMember = "MABOPHAN";
            cbBoPhan.DisplayMember = "TENBOPHAN";

            // Lấy dữ liệu từ CSDL
             strSQL = "SELECT MANHANVIEN, TENNHANVIEN, SODIENTHOAI, EMAIL, DIACHI, MABOPHAN, TRANGTHAI, TENTAIKHOAN, MATKHAU FROM NHANVIEN where DAXOA = 0";
            dataTable = SQLHelper.layBangDuLieu(strSQL);

            // Gán dl bảng vào binding, binding gán vào dgv
            dgvDuLieu.DataSource = dataTable;

            // Set view for data grid view
            for (int i = 0; i < strHeader.Length; i++) {
                dgvDuLieu.Columns[i].Width = (dgvDuLieu.Width / 100) * size[i];
                dgvDuLieu.Columns[i].HeaderText = strHeader[i];
            }
        }
    }
}
