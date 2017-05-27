using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shop_Manager.BanHang;
using Shop_Manager.QuanLy;

namespace Shop_Manager {
    public partial class frmGiaoDienChinh : Form {

        
        public frmGiaoDienChinh() {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterParent;
            WindowState = FormWindowState.Maximized;
            dgvDuLieu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHoaDon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            txtTenNV.Text = SQLHelper.TENNHANVIEN;
            dataHoaDon = new DataTable();
            for (int i = 0; i < strHeader2.Length; i++) {
                dataHoaDon.Columns.Add(strHeader2[i]);
            }
            dgvHoaDon.DataSource = dataHoaDon;
            for (int i = 0; i < strHeader2.Length; i++) {
                dgvHoaDon.Columns[i].Width = (dgvHoaDon.Width / 100) * size2[i];
                dgvHoaDon.Columns[i].HeaderText = strHeader2[i];
            }
            
        }

        // Thuộc tính
        private DataTable dataTable, dataKhachHang, dataHoaDon;
        private string[] strHeader = { "Mã hàng", "Tên hàng", "Đơn giá", "Số lượng tồn"};
        private int[] size = { 20, 50, 20, 30};

        private string[] strHeader2 = { "Tên hàng", "Đơn giá", "Số lượng", "Thành tiền", "Mã SP" };
        private int[] size2 = { 40, 20, 10, 40, 0 };

        private void mnNhanVien_Click(object sender, EventArgs e) {
            frmNhanVien fNhanVien = new frmNhanVien();
            fNhanVien.ShowDialog();
        }

        private void mnDanhMuc_Click(object sender, EventArgs e) {
            frmDanhMuc fDanhMuc = new frmDanhMuc();
            fDanhMuc.ShowDialog();
        }

        private void mnNhaCungCap_Click(object sender, EventArgs e) {
            frmNhaCungCap fNhaCungCap = new frmNhaCungCap();
            fNhaCungCap.ShowDialog();
        }

        private void mnNhapHang_Click(object sender, EventArgs e) {
            frmNhapHang fNhapHang = new frmNhapHang();
            fNhapHang.ShowDialog();
        }

        private void mnKhachHang_Click(object sender, EventArgs e) {
            frmKhachHang fKhachHang = new frmKhachHang();
            fKhachHang.ShowDialog();
        }

        private void hóaĐơnNhậpToolStripMenuItem_Click(object sender, EventArgs e) {
            frmHoaDon fHoaDonNhap = new frmHoaDon();
            fHoaDonNhap.ShowDialog();
        }

        private void hóaĐơnXuấtToolStripMenuItem_Click(object sender, EventArgs e) {
            frmHoaDonXuat fHoaDonXuat = new frmHoaDonXuat();
            fHoaDonXuat.ShowDialog();
        }

        private void mnSanPham_Click(object sender, EventArgs e) {
            frmSanPham fSanPham = new frmSanPham();
            fSanPham.ShowDialog();
        }

        private void frmGiaoDienChinh_Load(object sender, EventArgs e) {

            // Load khách hàng vào combobox khách hàng
            string strSQL = "SELECT MAKHACHHANG, TENKHACHHANG, DIACHI, EMAIL, SODIENTHOAI FROM KHACHHANG WHERE DAXOA = 0";
            dataKhachHang = SQLHelper.layBangDuLieu(strSQL);

            // Gán dl bảng vào binding, binding gán vào dgv
            cbKhachHang.DataSource = dataKhachHang;
            cbKhachHang.ValueMember = "MAKHACHHANG";
            cbKhachHang.DisplayMember = "TENKHACHHANG";

            // Lấy dữ liệu từ CSDL
            strSQL = "SELECT MASANPHAM, TENSANPHAM, DONGIAXUAT, SOLUONGTON FROM SANPHAM WHERE SOLUONGTON > 0 AND DAXOA = 0";
            dataTable = SQLHelper.layBangDuLieu(strSQL);
            
            dgvDuLieu.DataSource = dataTable;

            for (int i = 0; i < strHeader.Length; i++) {
                dgvDuLieu.Columns[i].Width = (dgvDuLieu.Width / 100) * size[i];
                dgvDuLieu.Columns[i].HeaderText = strHeader[i];
            }
        }

        private void mnDangXuat_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void mniThuongHieu_Click(object sender, EventArgs e) {
            frmThuongHieu fThuongHieu = new frmThuongHieu();
            fThuongHieu.ShowDialog();
        }

        private void btnThemSanPham_Click(object sender, EventArgs e)
        {
            // Kiểm tra số lượng có thỏa mãn
            int index = dgvDuLieu.SelectedRows[0].Index;
            if (index < 0)
                MessageBox.Show("Vui lòng chọn sản phẩm cần thêm");
            int soluonghangton = int.Parse(dataTable.Rows[index]["SOLUONGTON"].ToString());
            int soluongcantru = (int) numericSoluong.Value;
            if (soluongcantru == 0 || soluongcantru > soluonghangton)
            {
                MessageBox.Show("Số lượng không hợp lệ");
                return;
            }
            
            

            // Cộng số lượng vào bảng
            int soluongconlai = soluonghangton - soluongcantru;
            dataTable.Rows[index]["SOLUONGTON"] = soluongconlai;

            // Lấy dữ liệu bên bảng sản phẩm, tính toán và đưa sang bảng hóa đơn
            string tenhang = dataTable.Rows[index]["TENSANPHAM"].ToString();
            int  dongia = int.Parse(dataTable.Rows[index]["DONGIAXUAT"].ToString());
            string mahang = dataTable.Rows[index]["MASANPHAM"].ToString();
            int tongtien = dongia * soluongcantru;
            dataHoaDon.Rows.Add(tenhang, dongia, soluongcantru, tongtien, mahang);


        }

        private void btnGiamSanPham_Click(object sender, EventArgs e) {
            // Kiểm tra số lượng có thỏa mãn
            int index = dgvHoaDon.SelectedRows[0].Index;
            if (index < 0)
                MessageBox.Show("Vui lòng chọn sản phẩm cần giảm");
            int soluonghoadon = int.Parse(dataHoaDon.Rows[index][2].ToString());
            int soluongtru = (int)numericSoluong.Value;
            if (soluongtru == 0 || soluongtru > soluonghoadon) {
                MessageBox.Show("Số lượng không hợp lệ");
                return;
            }

            string mahang = dataHoaDon.Rows[index][4].ToString();
            int index2 = -1;

            // Lấy ra index cần cộng bên bảng sản phẩm
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                if (mahang.Equals(dataTable.Rows[i]["MASANPHAM"].ToString()))
                {
                    index2 = i;
                    break;
                }
            }

            // Nếu số lượng giảm = số lượng bên bảng HD thì xóa luôn dòng đi
            // Còn không thì trừ đi thông thường
            if (soluongtru == soluonghoadon)
            {
                dataHoaDon.Rows.RemoveAt(index);
            }
            else
            {
                int soluongmoi = soluonghoadon - soluongtru;
                int dongia = int.Parse(dataTable.Rows[index2]["DONGIAXUAT"].ToString());
             
                int tongtienmoi = dongia * soluongmoi;

                dataHoaDon.Rows[index][2] = soluongmoi;
                dataHoaDon.Rows[index][3] = tongtienmoi;
            }
          
           
           

            // Cập nhật số lượng bên bảng sản phẩm
           //int soluo

            // 
        }

        private void cbKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbKhachHang.SelectedIndex;
            if (index < 0)
                return;
            txtMaKhach.Text = dataKhachHang.Rows[index]["MAKHACHHANG"].ToString();
            txtSoDT.Text = dataKhachHang.Rows[index]["SODIENTHOAI"].ToString();
            txtEmail.Text = dataKhachHang.Rows[index]["EMAIL"].ToString();
            rtbDiaChi.Text = dataKhachHang.Rows[index]["DIACHI"].ToString();
            
        }

        private void btnThemKhach_Click(object sender, EventArgs e) {
            frmKhachHang frmKhachHang = new frmKhachHang();
            frmKhachHang.ShowDialog();
            frmGiaoDienChinh_Load(null, null);
        }
    }
}
