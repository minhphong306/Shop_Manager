using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
            

        }

        // Thuộc tính
        private DataTable dataTable, dataKhachHang, dataHoaDon;
        private DoiSangChu doiSangChu;
        private string[] strHeader = { "Mã hàng", "Tên hàng", "Đơn giá", "Số lượng tồn" };
        private int[] size = { 20, 50, 20, 30 };

        private string[] strHeader2 = { "Tên hàng", "Đơn giá", "Số lượng", "Thành tiền", "Mã SP" };
        private int[] size2 = { 40, 20, 10, 40, 0 };

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

            // Setup bảng hóa đơn
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


        private void tinhTien() {
            double tongtien = 0;

            // Duyệt vòng lặp bảng hóa đơn, tính tiền
            for (int i = 0; i < dataHoaDon.Rows.Count; i++) {
                double temp = double.Parse(dataHoaDon.Rows[i][3].ToString());
                tongtien += temp;
            }

            // In số tiền vào ô tổng tiền bằng số.
            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
            lbTongTien.Text = tongtien.ToString("#,###", cul.NumberFormat) + " VNĐ";
            if (tongtien == 0)
            {
                lbTongTien.Text = "0 VNĐ";
                rtbTongTien.Text = "";
            }
            else
            {
                // In ra số tiền bằng chữ
                doiSangChu = new DoiSangChu(tongtien);
                doiSangChu.thucHienDoiTien();
                rtbTongTien.Text = doiSangChu.ReadThis() + " đồng";
            }
               
         

        }

        private void btnThemSanPham_Click(object sender, EventArgs e) {
            // Kiểm tra số lượng có thỏa mãn
            int index = dgvDuLieu.SelectedRows[0].Index;
            if (index < 0)
                MessageBox.Show("Vui lòng chọn sản phẩm cần thêm");
            int soluonghangton = int.Parse(dataTable.Rows[index]["SOLUONGTON"].ToString());
            int soluongcantru = (int)numericSoluong.Value;
            if (soluongcantru == 0 || soluongcantru > soluonghangton) {
                MessageBox.Show("Số lượng không hợp lệ");
                return;
            }



            // Tinh so luong con lai
            int soluongconlai = soluonghangton - soluongcantru;
            dataTable.Rows[index]["SOLUONGTON"] = soluongconlai;

            // Lấy dữ liệu bên bảng sản phẩm, tính toán và đưa sang bảng hóa đơn
            string tenhang = dataTable.Rows[index]["TENSANPHAM"].ToString();
            int dongia = int.Parse(dataTable.Rows[index]["DONGIAXUAT"].ToString());
            string mahang = dataTable.Rows[index]["MASANPHAM"].ToString();
            int tongtien = dongia * soluongcantru;
            dataHoaDon.Rows.Add(tenhang, dongia, soluongcantru, tongtien, mahang);

            //Tinhs tổng tiên;
            tinhTien();
        }

        private void btnGiamSanPham_Click(object sender, EventArgs e) {
            // Kiểm tra số lượng có thỏa mãn
            try {

                int index = dgvHoaDon.SelectedRows[0].Index;
                int soluonghoadon = int.Parse(dataHoaDon.Rows[index][2].ToString());
                int soluongtru = (int)numericSoluong.Value;
                if (soluongtru == 0 || soluongtru > soluonghoadon) {
                    MessageBox.Show("Số lượng không hợp lệ");
                    return;
                }

                string mahang = dataHoaDon.Rows[index][4].ToString();
                int index2 = -1;

                // Lấy ra index cần cộng bên bảng sản phẩm
                for (int i = 0; i < dataTable.Rows.Count; i++) {
                    if (mahang.Equals(dataTable.Rows[i]["MASANPHAM"].ToString())) {
                        index2 = i;
                        break;
                    }
                }

                // Nếu số lượng giảm = số lượng bên bảng HD thì xóa luôn dòng đi
                // Còn không thì trừ đi thông thường
                if (soluongtru == soluonghoadon) {
                    dataHoaDon.Rows.RemoveAt(index);
                }
                else {
                    int soluongmoi = soluonghoadon - soluongtru;
                    int dongia = int.Parse(dataTable.Rows[index2]["DONGIAXUAT"].ToString());

                    int tongtienmoi = dongia * soluongmoi;

                    dataHoaDon.Rows[index][2] = soluongmoi;
                    dataHoaDon.Rows[index][3] = tongtienmoi;
                }




                // Cập nhật số lượng bên bảng sản phẩm
                int soluongbangsanphamcu = int.Parse(dataTable.Rows[index2]["SOLUONGTON"].ToString());
                int soluongbangsanphammoi = soluongbangsanphamcu + soluongtru;
                dataTable.Rows[index2]["SOLUONGTON"] = soluongbangsanphammoi;

                //Tinhs tổng tiên;
                tinhTien();
            }
            catch (Exception) {
                MessageBox.Show("Vui lòng chọn sản phẩm cần giảm");
            }
         
        }

        private void btnXoa_Click(object sender, EventArgs e) {
            // Kiểm tra điều kiện
            int index = -1;
            try {
                index = dgvHoaDon.SelectedRows[0].Index;
            }
            catch (Exception exception) {
                MessageBox.Show("Vui lòng chọn sản phẩm xóa");
                return;
            }


            // Lấy ra số lượng bên hóa đơn
            int soluonghoadon = int.Parse(dataHoaDon.Rows[index][2].ToString());

            int index2 = -1;
            string mahang = dataHoaDon.Rows[index][4].ToString();

            // Lấy ra index cần cộng bên bảng sản phẩm
            for (int i = 0; i < dataTable.Rows.Count; i++) {
                if (mahang.Equals(dataTable.Rows[i]["MASANPHAM"].ToString())) {
                    index2 = i;
                    break;
                }
            }

            // Cộng vào bảng sản phẩm
            int soluongbangsanphamcu = int.Parse(dataTable.Rows[index2]["SOLUONGTON"].ToString());
            int soluongbangsanphammoi = soluongbangsanphamcu + soluonghoadon;
            dataTable.Rows[index2]["SOLUONGTON"] = soluongbangsanphammoi;

            // Xóa dòng bên bảng hóa đơn
            dataHoaDon.Rows.RemoveAt(index);

            //Tinhs tổng tiên;
            tinhTien();
        }

        private void btnHuyDonHang_Click(object sender, EventArgs e) {
            frmGiaoDienChinh_Load(null, null);
        }

        private void btnThanhToan_Click(object sender, EventArgs e) {
            // Kiểm tra trước khi thanh toán
            if (dataHoaDon.Rows.Count < 1)
            {
                MessageBox.Show("Chưa có hàng trong hóa đơn");
                return;
            }

            if (MessageBox.Show("Bạn có muốn thanh toán", "Xác nhận", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information) == DialogResult.No)
            {
                return;
            }
            // Cập nhật hóa đơn xuất
            string makh = cbKhachHang.SelectedValue.ToString();
            string manv = SQLHelper.MANHANVIEN;
            string ngaynhap = dateHoaDon.Value.ToString("yyyy-MM-dd");

            String sql =
                string.Format(
                    "INSERT INTO HOADONXUAT (MANHANVIEN,  MAKHACHHANG,  NGAYNHAP, DAXOA) VALUES( '{0}', '{1}', '{2}', '{3}')",
                    manv, makh, ngaynhap, 0);
           SQLHelper.chayTruyVan(sql);
           
            // Cập nhật chi tiết HD xuất
            sql = "select max(MAHOADON) as 'MAHOADON' from HOADONXUAT";
            string mahoadon = SQLHelper.layBangDuLieu(sql).Rows[0][0].ToString();
            string masp;
            string dongia;
            string soluong;

            for (int i = 0; i < dataHoaDon.Rows.Count; i++)
            {
                masp = dataHoaDon.Rows[i][4].ToString();
                dongia = dataHoaDon.Rows[i][1].ToString();
                soluong = dataHoaDon.Rows[i][2].ToString();
                sql = string.Format("INSERT INTO CHITIETHOADONXUAT(MAHOADON, MASANPHAM, DONGIA, SOLUONG) VALUES('{0}', '{1}', '{2}', '{3}')" , mahoadon,  masp,  dongia,  soluong);
                SQLHelper.chayTruyVan(sql);
            }


            // Cập nhật sản phẩm (số lượng)
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                masp = dataTable.Rows[i]["MASANPHAM"].ToString();
                soluong = dataTable.Rows[i]["SOLUONGTON"].ToString();
                sql = string.Format("UPDATE SANPHAM SET SOLUONGTON = '{0}'  WHERE MASANPHAM = '{1}'", soluong, masp);
                SQLHelper.chayTruyVan(sql);
            }

            MessageBox.Show("Thanh toán thành công");
            frmGiaoDienChinh_Load(null, null);
        }

        private void btnTroLai_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void cbKhachHang_SelectedIndexChanged(object sender, EventArgs e) {
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
