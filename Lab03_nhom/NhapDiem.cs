using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab03_nhom
{
    public partial class NhapDiem : Form
    {
        String strConn = @"Data Source=DESKTOP-V3AEK98;Initial Catalog=QLSV_BOBA;Integrated Security=True;MultipleActiveResultSets=True";
        SqlConnection sqlconn = null;
        SqlCommand cmd;
        public static String MANV, MALOP;

        public NhapDiem(String maNV, String maLop)
        {
            InitializeComponent();
            if (sqlconn == null)
            {
                sqlconn = new SqlConnection(strConn);
            }
            MANV = "NV01";
            MALOP = "KH01";

            //MANV = maNV;
            //MALOP = maLop;
        }
        private void QLDIEM_Click(object sender, EventArgs e)
        {
            TBdiem.Text = "";
            TBmaSV.Text = "";
            TBtenSV.Text = "";

            TBmaSV.ReadOnly = true;
            TBtenSV.ReadOnly = true;
        }

        private void QLDIEM_Load(object sender, EventArgs e)
        {
            frm_load();
        }
        private void frm_load()
        {
            TBmaSV.ReadOnly = true;
            TBtenSV.ReadOnly = true;
            dataGridViewSV_List();
        }
        private void dataGridViewSV_List()
        {
            dataGridViewDiem.DataSource = FetchNhapDiem();
        }
        private DataTable FetchNhapDiem()
        {
            DataTable dt = new DataTable();
            if (sqlconn.State == ConnectionState.Closed)
            {
                sqlconn.Open();
            }
            cmd = new SqlCommand("SP_SEL_DIEM", sqlconn)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.Add("MALOP", SqlDbType.VarChar, 20).Value = MALOP;
            cmd.Parameters.Add("MANV", SqlDbType.VarChar, 20).Value = MANV;

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            sqlDataAdapter.Fill(dt);
            return dt;
        }

        private void iconButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void buttonSua_Click(object sender, EventArgs e)
        {
            var diem = TBdiem.Text.Trim();
            var maSV = TBmaSV.Text.Trim();
            if (maSV == "")
            {
                MessageBox.Show("Hãy Chọn Sinh Viên", "Thông Báo");
                return;
            }
            if (diem == "")
            {
                MessageBox.Show("Điểm Chưa Được Nhập", "Thông Báo");
                return;
            }
            cmd = new SqlCommand("SP_UPD_DIEM", sqlconn)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.Add("MALOP", SqlDbType.VarChar, 20).Value = MALOP;
            cmd.Parameters.Add("MASV", SqlDbType.VarChar, 20).Value = maSV;
            cmd.Parameters.Add("DIEM", SqlDbType.VarChar, 20).Value = diem;
            cmd.ExecuteReader();
            dataGridViewSV_List();
        }
        private void buttonHuy_Click(object sender, EventArgs e)
        {
            TBdiem.Text = "";
            TBmaSV.Text = "";
            TBtenSV.Text = "";
        }


        private void dataGridViewDiem_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1) return;
            DataGridViewRow dataGridViewRow = dataGridViewDiem.Rows[e.RowIndex];
            TBmaSV.Text = dataGridViewRow.Cells[0].Value.ToString();
            TBtenSV.Text = dataGridViewRow.Cells[1].Value.ToString();
            TBdiem.Text = dataGridViewRow.Cells[2].Value.ToString();
        }

    }
}
