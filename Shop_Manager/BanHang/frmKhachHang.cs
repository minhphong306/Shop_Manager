using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop_Manager.BanHang {
    public partial class frmKhachHang : Form {
        public frmKhachHang() {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            dgvDuLieu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }
        // Thuộc tính
        private DataTable dataTable;
        private int MODE;
        private const int EDIT = 1, ADD = 2, WAIT = 3;
        private string[] strHeader = { "Mã khách hàng", "Tên khách hàng", "Ngày sinh", "Giới tính", "Số ĐT", "Email", "Địa chỉ" };
        private int[] size = { 10, 30, 20, 10, 20, 30, 20 };

        private void btnTroLai_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e) {
            txtTenNV.Text = "";
            txtSDT.Text = "";
            txtEmail.Text = "";
            rtbDiaChi.Text = "";

            MODE = ADD;
            thayDoiTrangThai();
        }

        private void btnSua_Click(object sender, EventArgs e) {
            MODE = EDIT;
            thayDoiTrangThai();
        }

        private void btnXoa_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Bạn có muốn xóa khách hàng này", "Xác nhân", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes) {
                string maDM = txtMaNV.Text;
                String sql = string.Format("UPDATE KHACHHANG SET DAXOA = '1'  WHERE MAKHACHHANG = '{0}'", maDM);
                SQLHelper.chayTruyVan(sql);
                MessageBox.Show("Xóa thành công khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmKhachHang_Load(null, null);
            }
        }

        private void btnDongY_Click(object sender, EventArgs e) {

            long MaNV = long.Parse(txtMaNV.Text);
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

            if (String.IsNullOrWhiteSpace(TenNV)) {
                MessageBox.Show("Tên khách hàng không hợp lệ");
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


            string sql = "";
            switch (MODE) {
                case EDIT:
                    sql = string.Format("UPDATE KHACHHANG SET TENKHACHHANG = N'{0}', SODIENTHOAI = '{1}', EMAIL = '{2}', DIACHI = N'{3}', NGAYSINH = '{4}', GIOITINH = N'{5}'  WHERE MAKHACHHANG = '{6}'",
                                                                     TenNV, SDT, Email, DiaChi, date, gioitinh, MaNV);

                    break;
                case ADD:

                    sql =
                        string.Format(
                            "INSERT INTO KHACHHANG (TENKHACHHANG, SODIENTHOAI, EMAIL, DIACHI, NGAYSINH, GIOITINH) VALUES(N'{0}', '{1}', '{2}', N'{3}', '{4}', N'{5}')",
                            TenNV, SDT, Email, DiaChi, date, gioitinh);
                    break;
            }
            SQLHelper.chayTruyVan(sql);
            MessageBox.Show("Cập nhật dữ liệu thành công");
            frmKhachHang_Load(null, null);
        }

        private void dgvDuLieu_CellClick(object sender, DataGridViewCellEventArgs e) {
            int index;
            try {
                if (e == null)
                    index = 0;
                else
                    index = e.RowIndex;
                if (index >= 0) {
                    DataGridViewRow dr = dgvDuLieu.Rows[index];
                    txtMaNV.Text = dr.Cells[0].Value.ToString();
                    txtTenNV.Text = dr.Cells[1].Value.ToString();
                    string ngaysinh = dr.Cells[2].Value.ToString();
                    DateTime dd = DateTime.Parse(ngaysinh);
                    dateNgaySinh.Value = dd;
                    string gioitinh = dr.Cells[3].Value.ToString();
                    if (gioitinh == "NAM") {
                        cbNam.Checked = true;
                    }
                    else {
                        cbNu.Checked = true;
                    }
                    txtSDT.Text = dr.Cells[4].Value.ToString();
                    txtEmail.Text = dr.Cells[5].Value.ToString();


                    rtbDiaChi.Text = dr.Cells[6].Value.ToString();


                }
                MODE = WAIT;
                thayDoiTrangThai();
            }
            catch (Exception) {
                throw;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            frmKhachHang_Load(null, null);
        }

        private void thayDoiTrangThai() {
            switch (MODE) {
                case WAIT:
                    txtTenNV.Enabled = false;

                    txtSDT.Enabled = false;
                    txtEmail.Enabled = false;

                    rtbDiaChi.Enabled = false;

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

                    btnThem.Enabled = false;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;

                    btnDongY.Enabled = true;
                    btnHuy.Enabled = true;
                    break;
            }
        }

        private void frmKhachHang_Load(object sender, EventArgs e) {
            dataTable = new DataTable();
            MODE = WAIT;
            thayDoiTrangThai();

            // Lấy dữ liệu từ CSDL
            String strSQL = "SELECT MAKHACHHANG, TENKHACHHANG, NGAYSINH, GIOITINH, SODIENTHOAI, EMAIL, DIACHI FROM KHACHHANG where DAXOA = 0";
            dataTable = SQLHelper.layBangDuLieu(strSQL);


            dgvDuLieu.DataSource = dataTable;

            for (int i = 0; i < strHeader.Length; i++) {
                dgvDuLieu.Columns[i].Width = (dgvDuLieu.Width / 100) * size[i];
                dgvDuLieu.Columns[i].HeaderText = strHeader[i];
            }
            dgvDuLieu_CellClick(null, null);
        }
    }
}
