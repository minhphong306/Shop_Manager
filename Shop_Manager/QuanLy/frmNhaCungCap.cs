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
    public partial class frmNhaCungCap : Form {
        public frmNhaCungCap() {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterParent;
            dgvDuLieu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        // Thuộc tính
        private DataTable dataTable;
        private int MODE;
        private const int EDIT = 1, ADD = 2, WAIT = 3;
        private string[] strHeader = { "Mã nhà cung cấp", "Tên nhà cung cấp" };
        private int[] size = { 30, 70 };

        private void btnThem_Click(object sender, EventArgs e) {
            txtMaDM.Text = "";
            txtTenDM.Text = "";
            MODE = ADD;
            thayDoiTrangThai();
        }

        private void btnSua_Click(object sender, EventArgs e) {
            MODE = EDIT;
            thayDoiTrangThai();
        }

        private void btnXoa_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Bạn có muốn xóa danh mục này", "Xác nhân", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes) {
                string maNCC = txtMaDM.Text;
                String sql = string.Format("UPDATE NHACUNGCAP SET DAXOA = '1'  WHERE MANHACUNGCAP = '{0}'", maNCC);
                SQLHelper.chayTruyVan(sql);
                MessageBox.Show("Xóa thành công danh mục", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmNhaCungCap_Load(null, null);
            }
        }

        private void btnDongY_Click(object sender, EventArgs e) {
            try {
                String maDM = txtMaDM.Text;
                string TenDM = txtTenDM.Text;

                string sql = "";
                switch (MODE) {
                    case EDIT:
                        sql = string.Format("UPDATE NHACUNGCAP SET TENNHACUNGCAP = N'{0}' WHERE MANHACUNGCAP = '{1}' ", TenDM, maDM);

                        break;
                    case ADD:
                        sql =
                            string.Format(
                                "INSERT INTO NHACUNGCAP (TENNHACUNGCAP, DAXOA) VALUES(N'{0}', '0')",
                                TenDM);
                        break;
                }
                SQLHelper.chayTruyVan(sql);
                MessageBox.Show("Cập nhật dữ liệu thành công");
                frmNhaCungCap_Load(null, null);
            }
            catch (Exception) {
                MessageBox.Show("Vui lòng nhập đủ các trường hoặc thử lại");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e) {
            MODE = WAIT;
            thayDoiTrangThai();
        }

        private void btnTroLai_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void dgvDuLieu_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex >= 0) {
                MODE = WAIT;
                thayDoiTrangThai();

                DataGridViewRow dr = dgvDuLieu.Rows[e.RowIndex];
                txtMaDM.Text = dr.Cells[0].Value.ToString();
                txtTenDM.Text = dr.Cells[1].Value.ToString();

            }
        }

        private void thayDoiTrangThai() {
            switch (MODE) {
                case WAIT:
                    txtTenDM.Enabled = false;

                    btnThem.Enabled = true;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;

                    btnDongY.Enabled = false;
                    btnHuy.Enabled = false;
                    break;
                case EDIT:
                    txtTenDM.Enabled = true;

                    btnThem.Enabled = false;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;

                    btnDongY.Enabled = true;
                    btnHuy.Enabled = true;
                    break;
                case ADD:
                    txtTenDM.Enabled = true;

                    btnThem.Enabled = false;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;

                    btnDongY.Enabled = true;
                    btnHuy.Enabled = true;
                    break;
            }
        }

        private void frmNhaCungCap_Load(object sender, EventArgs e) {
            dataTable = new DataTable();
            MODE = WAIT;
            thayDoiTrangThai();

            // Lấy dữ liệu từ CSDL
            string strSQL = "SELECT MANHACUNGCAP, TENNHACUNGCAP FROM NHACUNGCAP WHERE DAXOA = 0";
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
