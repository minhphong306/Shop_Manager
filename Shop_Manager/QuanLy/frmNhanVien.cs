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
        private string[] strHeader = { "Mã nhân viên", "Tên nhân viên", "Ngày sinh",  "Giới tính", "Số ĐT", "Email", "Địa chỉ", "Mã bộ phận", "Trạng thái", "Tài khoản", "Mật khẩu" };
        private int[] size = { 10, 30, 20, 10, 20, 30, 20, 20, 20, 20, 20};

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
                string date = dateNgaySinh.Text;
                string gioitinh;
                if (cbNam.Checked == true)
                {
                    gioitinh = "NAM";
                }
                else
                {
                    gioitinh = "NỮ";
                }

                string Email = txtEmail.Text;
                string DiaChi = rtbDiaChi.Text;
                string TaiKhoan = txtTaiKhoan.Text;
                string MatKhau = txtMatKhau.Text;
                long BP = long.Parse(cbBoPhan.SelectedValue.ToString());
                int TT;
                if (String.IsNullOrWhiteSpace(TenNV))
                {
                    MessageBox.Show("Tên nhân viên không hợp lệ");
                    return;
                }

                if (!Email.Contains("@"))
                {
                    MessageBox.Show("Địa chỉ email không hợp lệ");
                    return;
                }
                if (!SDT.All(char.IsDigit) || String.IsNullOrWhiteSpace(SDT))
                {
                    MessageBox.Show("Số điện thoại không hợp lệ");
                    return;
                }

                if (String.IsNullOrWhiteSpace(TaiKhoan))
                {
                    MessageBox.Show("Tên tài khoản không hợp lệ");
                    return;
                }
                   

                if (rbHoatDong.Checked == true) {
                    TT = 1;
                }
                else {
                    TT = 0;
                }
                string sql = "";
                switch (MODE) {
                    case EDIT:
                        sql = string.Format("UPDATE NHANVIEN SET TENNHANVIEN = N'{0}', SODIENTHOAI = '{1}', EMAIL = '{2}', MABOPHAN = '{3}', DIACHI = N'{4}', TENTAIKHOAN = '{5}', MATKHAU = '{6}', TRANGTHAI = '{7}', NGAYSINH = '{8}', GIOITINH = N'{9}'  WHERE MANHANVIEN = '{10}'",
                                                                         TenNV, SDT, Email, BP, DiaChi, TaiKhoan, MatKhau, TT, date, gioitinh, MaNV);

                        break;
                    case ADD:
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
            frmNhanVien_Load(null, null);
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {

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
                    if (gioitinh == "NAM")
                    {
                        cbNam.Checked = true;
                    }
                    else
                    {
                        cbNu.Checked = true;
                    }
                    txtSDT.Text = dr.Cells[4].Value.ToString();
                    txtEmail.Text = dr.Cells[5].Value.ToString();


                    rtbDiaChi.Text = dr.Cells[6].Value.ToString();
                    cbBoPhan.SelectedValue = dr.Cells[7].Value.ToString();
                    int tt = int.Parse(dr.Cells[8].Value.ToString());
                    if (tt == 0) {
                        rbKhoa.Checked = true;
                    }
                    else {
                        rbHoatDong.Checked = true;
                    }

                    txtTaiKhoan.Text = dr.Cells[9].Value.ToString();
                    txtMatKhau.Text = dr.Cells[10].Value.ToString();

                }
                MODE = WAIT;
                thayDoiTrangThai();
            }
            catch (Exception)
            {
                throw;
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
            txtTenNV.Text = "";
            txtSDT.Text = "";
            txtEmail.Text = "";
            rtbDiaChi.Text = "";
            cbBoPhan.Text = "";
            txtTaiKhoan.Text = "";
            txtMatKhau.Text = "";
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
             strSQL = "SELECT MANHANVIEN, TENNHANVIEN, NGAYSINH, GIOITINH, SODIENTHOAI, EMAIL, DIACHI, MABOPHAN, TRANGTHAI, TENTAIKHOAN, MATKHAU FROM NHANVIEN where DAXOA = 0";
            dataTable = SQLHelper.layBangDuLieu(strSQL);

            // Gán dl bảng vào binding, binding gán vào dgv
            dgvDuLieu.DataSource = dataTable;
         
            for (int i = 0; i < strHeader.Length; i++) {
                dgvDuLieu.Columns[i].Width = (dgvDuLieu.Width / 100) * size[i];
                dgvDuLieu.Columns[i].HeaderText = strHeader[i];
            }

            dgvData_CellClick(null, null);
        }
    }
}
