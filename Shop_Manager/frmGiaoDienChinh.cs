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
        }

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
    }
}
