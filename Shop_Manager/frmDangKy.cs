using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop_Manager {
    public partial class frmDangKy : Form {
        public frmDangKy() {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void btnTroLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDangKy_Load(object sender, EventArgs e)
        {
            string strSQL = "SELECT * FROM BOPHAN";
            DataTable table = SQLHelper.layBangDuLieu(strSQL);

            cbMod.DataSource = table;
            cbMod.DisplayMember = "TENBOPHAN";
            cbMod.ValueMember = "MABOPHAN";
        }
    }
}
