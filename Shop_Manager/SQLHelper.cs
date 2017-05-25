using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Manager
{
    class SQLHelper
    {
        // Attribute
        private static string chuoiCSDL = "Data Source=DESTRUCTION-VIR;Initial Catalog=banquanao;Persist Security Info=True;User ID=saadmin;Password=daicaphong";
        private static SqlConnection doiTuongKetNoi;

        public static void moKetNoi()
        {
            // Tao ket noi
            doiTuongKetNoi = new SqlConnection(chuoiCSDL);

            // Mo ket noi
            if (doiTuongKetNoi.State != System.Data.ConnectionState.Open)
            {
                doiTuongKetNoi.Open();
            }
        }

        public static void dongKetNoi()
        {
            doiTuongKetNoi.Close();
            doiTuongKetNoi.Dispose();
        }


        public static DataTable layBangDuLieu(string sql)
        {
            try
            {
                DataTable table = new DataTable();
                moKetNoi();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, doiTuongKetNoi);
                adapter.Fill(table);
                dongKetNoi();
                return table;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Lỗi ở lấy bảng dữ liệu : " + ex.Message);
                return null;
            }

        }

        // Hàm thực hiện lệnh Insert or Update or Delete
        public static bool chayTruyVan(string query)
        {
            try
            {
                moKetNoi();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = doiTuongKetNoi;
                sqlCommand.CommandText = query;
                sqlCommand.ExecuteNonQuery();
                dongKetNoi();
                return true;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Lỗi ở thực thi câu lệnh sql : " + ex.Message);
                return false;
            }
        }

    }
}

// DBCC CHECKIDENT (BOPHAN, RESEED, 0)
