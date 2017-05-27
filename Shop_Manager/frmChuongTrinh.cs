
using System.Windows.Forms;
using Shop_Manager.BanHang;
using Shop_Manager.QuanLy;
using Shop_Manager.QuanLy;

namespace Shop_Manager {
    public partial class frmChuongTrinh : Form {
        public frmChuongTrinh() {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            lbName.Text = SQLHelper.TENNHANVIEN;
            if (SQLHelper.BOPHAN == SQLHelper.NHANVIEN)
            {
                groupQuanLy.Enabled = false;
                groupThongKe.Enabled = false;
            }

        }

        private void llbDanhMuc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            frmDanhMuc fDanhMuc = new frmDanhMuc();
            fDanhMuc.ShowDialog();
        }

        private void llbNhanVien_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            frmNhanVien fNhanVien = new frmNhanVien();
            fNhanVien.ShowDialog();
        }

        private void llbNhaCungCap_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            frmNhaCungCap fNhaCungCap = new frmNhaCungCap();
            fNhaCungCap.ShowDialog();
        }

        private void llbThuongHieu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            frmThuongHieu fThuongHieu = new frmThuongHieu();
            fThuongHieu.ShowDialog();
        }

        private void llbBanHang_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            frmGiaoDienChinh fGiaoDienChinh = new frmGiaoDienChinh();
            fGiaoDienChinh.ShowDialog();
        }

        private void llbNhapHang_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            frmNhapHang fNhapHang = new frmNhapHang();
            fNhapHang.ShowDialog();
        }

        private void llbKhachHang_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            frmKhachHang fKhachhang = new frmKhachHang();
            fKhachhang.ShowDialog();
        }

        private void llbHoaDonBan_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            frmHoaDonXuat fHoaDonBan = new frmHoaDonXuat();
            fHoaDonBan.ShowDialog();
        }

        private void llbHoaDonNhap_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {

            frmHoaDon fHoaDonNhap = new frmHoaDon();
            fHoaDonNhap.ShowDialog();
        }

        private void lbDangXuat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            this.Close();
        }

        private void frmChuongTrinh_Load(object sender, System.EventArgs e) {

        }

        private void llbSanPham_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            frmSanPham fSanPham = new frmSanPham();
            fSanPham.ShowDialog();
        }
    }
}
