﻿using System;
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
            BackColor = Color.FromArgb(81, 189, 168);
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

        private void frmGiaoDienChinh_Load(object sender, EventArgs e) {
            if (SQLHelper.BOPHAN == SQLHelper.NHANVIEN)
            {
                mnQuanLy.Enabled = false;
            }
        }

        private void mnDangXuat_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void mniThuongHieu_Click(object sender, EventArgs e) {
            frmThuongHieu fThuongHieu = new frmThuongHieu();
            fThuongHieu.ShowDialog();
        }
    }
}
