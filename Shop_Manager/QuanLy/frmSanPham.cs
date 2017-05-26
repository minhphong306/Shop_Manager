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
        private String tenAnh = "macdinh.jpg";
        private String localPath = System.IO.Directory.GetCurrentDirectory();
        private DataTable dataTable;
        private int MODE;
        private const int EDIT = 1, ADD = 2, WAIT = 3;
        private string[] strHeader = { "Mã sản phẩm", "Tên sản phẩm", "Danh mục", "Thương hiệu", "Giá nhập", "Giá xuất", "Số lượng tồn", "Mô tả", "Hình ảnh" };
        private int[] size = { 10, 30, 20, 30, 20, 20, 10, 20, 0 };

        public frmSanPham() {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            dgvDuLieu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void thayDoiTrangThai() {
            switch (MODE) {
                case WAIT:
                    txtTenSP.Enabled = false;
                    txtGiaNhap.Enabled = false;
                    txtGiaXuat.Enabled = false;

                    cbDanhMuc.Enabled = false;
                    cbThuongHieu.Enabled = false;

                    btnThem.Enabled = true;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;

                    btnDongY.Enabled = false;
                    btnHuy.Enabled = false;
                    break;
                case EDIT:

                    txtTenSP.Enabled = true;
                    txtGiaNhap.Enabled = true;
                    txtGiaXuat.Enabled = true;

                    cbDanhMuc.Enabled = true;
                    cbThuongHieu.Enabled = true;


                    btnThem.Enabled = false;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;

                    btnDongY.Enabled = true;
                    btnHuy.Enabled = true;
                    break;
                case ADD:

                    txtTenSP.Enabled = true;
                    txtGiaNhap.Enabled = true;
                    txtGiaXuat.Enabled = true;

                    cbDanhMuc.Enabled = true;
                    cbThuongHieu.Enabled = true;

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

        private void btnHuy_Click(object sender, EventArgs e) {
            MODE = WAIT;
            thayDoiTrangThai();
        }

        private void btnDongY_Click(object sender, EventArgs e) {
            try {
                long maSP = long.Parse(txtMaSP.Text);
                string tenSP = txtTenSP.Text;
                string giaNhap = txtGiaNhap.Text;
                string giaXuat = txtGiaXuat.Text;
                long TH = long.Parse(cbThuongHieu.SelectedValue.ToString());
                long DM = long.Parse(cbDanhMuc.SelectedValue.ToString());
                string mota = rtbMoTa.Text;

                string[] imgs = tenAnh.Split('\\');
                string duong_dan_goc = tenAnh;
                tenAnh = imgs[imgs.Length - 1];
                if (imgs.Length > 1) {
                    if (!System.IO.File.Exists(localPath + @"\IMG\" + tenAnh))
                    {
                        System.IO.File.Copy(duong_dan_goc, localPath + @"\IMG\" + imgs[imgs.Length - 1]);
                    }
                   
                }
                string sql = "";
                switch (MODE) {
                    case EDIT:
                        sql =
                            string.Format(
                                "UPDATE SANPHAM SET TENSANPHAM = N'{0}',  DONGIANHAP = '{1}',  DONGIAXUAT = '{2}',  MATHUONGHIEU = '{3}',  MADANHMUC = '{4}',  MOTA = N'{5}',  HINHANH = '{6}'  WHERE MASANPHAM = '{7}'",
                                tenSP, giaNhap, giaXuat, TH, DM, mota, tenAnh, maSP);

                        break;
                    case ADD:
                        sql =
                            string.Format(
                                "INSERT INTO SANPHAM (TENSANPHAM,  DONGIANHAP,  DONGIAXUAT,  MATHUONGHIEU,  MADANHMUC,  MOTA,  HINHANH) VALUES( N'{0}', '{1}', '{2}', '{3}', '{4}', N'{5}', '{6}')",
                                tenSP, giaNhap, giaXuat, TH, DM, mota, tenAnh);
                        break;
                }

                SQLHelper.chayTruyVan(sql);
                MessageBox.Show("Cập nhật dữ liệu thành công");
                frmSanPham_Load(null, null);
            }
            catch (Exception)
            {
                //throw;
                MessageBox.Show("Vui lòng nhập đủ các trường hoặc thử lại");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Bạn có muốn xóa sản phẩm này", "Xác nhân", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes) {
                string maDM = txtMaSP.Text;
                String sql = string.Format("UPDATE SANPHAM SET DAXOA = '1'  WHERE MANHANVIEN = '{0}'", maDM);
                SQLHelper.chayTruyVan(sql);
                MessageBox.Show("Xóa thành công sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmSanPham_Load(null, null);
            }
        }

        private void btnSua_Click(object sender, EventArgs e) {
            MODE = EDIT;
            thayDoiTrangThai();
        }

        private void dgvDuLieu_CellClick(object sender, DataGridViewCellEventArgs e) {
            try {
                int index;
                MODE = WAIT;
                thayDoiTrangThai();
                tenAnh = "macdinh.jpg";
                if (e == null) {
                    index = 0;
                }
                else {
                    index = e.RowIndex;
                }

                if (index >= 0) {
                    //"SELECT MASANPHAM, TENSANPHAM, TENDANHMUC, TENTHUONGHIEU, DONGIANHAP," +
                    //    " DONGIAXUAT, SOLUONGTON, MOTA, HINHANH   " +
                    //    "FROM SANPHAM join danhmuc on DANHMUC.MADANHMUC = SANPHAM.MADANHMUC  join THUONGHIEU on THUONGHIEU.MATHUONGHIEU = SANPHAM.MATHUONGHIEU where sanpham.DAXOA = 0";
                    DataGridViewRow dr = dgvDuLieu.Rows[index];
                    txtMaSP.Text = dr.Cells[0].Value.ToString();
                    txtTenSP.Text = dr.Cells[1].Value.ToString();
                    cbDanhMuc.SelectedIndex = cbDanhMuc.FindStringExact(dr.Cells[2].Value.ToString());
                    cbThuongHieu.SelectedIndex = cbThuongHieu.FindString(dr.Cells[3].Value.ToString());
                    txtGiaNhap.Value = Convert.ToDecimal(dr.Cells[4].Value.ToString());
                    txtGiaXuat.Value = Convert.ToDecimal(dr.Cells[5].Value.ToString());
                    rtbMoTa.Text = dr.Cells[7].Value.ToString();
                    string path = dr.Cells[8].Value.ToString();
                    ptbHinhAnh.Image = Image.FromFile(@"IMG\" + path);
                }
            }
            catch (Exception) {

            }

        }

        private void ptbHinhAnh_Click(object sender, EventArgs e) {
            if (MODE == EDIT || MODE == ADD) {
                OpenFileDialog openFile = new OpenFileDialog();
                openFile.Filter = "Hình ảnh sản phẩm (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
                if (openFile.ShowDialog() == DialogResult.OK) {
                    tenAnh = openFile.FileName;
                    ptbHinhAnh.Image = Image.FromFile(tenAnh);
                }



            }
        }

        private void btnThem_Click(object sender, EventArgs e) {
            MODE = ADD;
            thayDoiTrangThai(); 
            txtTenSP.Text = "";
            txtGiaNhap.Value = 1000;
            txtGiaXuat.Value =1000;
            rtbMoTa.Text = ""; 
        }

        private void frmSanPham_Load(object sender, EventArgs e) {
            dataTable = new DataTable();
            MODE = WAIT;
            thayDoiTrangThai();

            // Lấy dữ liệu từ CSDL
            string strSQL = "SELECT MADANHMUC, TENDANHMUC FROM DANHMUC where DAXOA = 0";
            DataTable d1 = SQLHelper.layBangDuLieu(strSQL);


            cbDanhMuc.DataSource = d1;
            cbDanhMuc.ValueMember = "MADANHMUC";
            cbDanhMuc.DisplayMember = "TENDANHMUC";

            // Lấy dữ liệu từ CSDL
            strSQL = "SELECT MATHUONGHIEU, TENTHUONGHIEU FROM THUONGHIEU where DAXOA = 0";
            DataTable d2 = SQLHelper.layBangDuLieu(strSQL);


            cbThuongHieu.DataSource = d2;
            cbThuongHieu.ValueMember = "MATHUONGHIEU";
            cbThuongHieu.DisplayMember = "TENTHUONGHIEU";

            // Lấy dữ liệu từ CSDL
            strSQL = "SELECT MASANPHAM, TENSANPHAM, TENDANHMUC,TENTHUONGHIEU,  DONGIANHAP, DONGIAXUAT, SOLUONGTON,  MOTA, HINHANH   FROM SANPHAM join danhmuc on DANHMUC.MADANHMUC = SANPHAM.MADANHMUC  join THUONGHIEU on THUONGHIEU.MATHUONGHIEU = SANPHAM.MATHUONGHIEU where sanpham.DAXOA = 0";
            dataTable = SQLHelper.layBangDuLieu(strSQL);

            // Gán dl bảng vào binding, binding gán vào dgv
            dgvDuLieu.DataSource = dataTable;

            // Set view for data grid view
            for (int i = 0; i < strHeader.Length; i++) {
                dgvDuLieu.Columns[i].Width = (dgvDuLieu.Width / 100) * size[i];
                dgvDuLieu.Columns[i].HeaderText = strHeader[i];
            }
            dgvDuLieu.CurrentCell = dgvDuLieu.Rows[0].Cells[0];
            dgvDuLieu_CellClick(null, null);
        }
    }
}
