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
        private void NhapDiem_Load(object sender, EventArgs e)
        {
            frm_load();
        }
        private void frm_load()
        {
            //tenLop.DisplayMember = "TENLOP";
            //tenLop.DataSource = FetchNameLOP();

            TBmaSV.ReadOnly = true;
            dataGridViewSV_List();
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
        private void dataGridViewSV_List()
        {
            dataGridViewDiem.DataSource = FetchNhapDiem();
        }
        private void iconButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void dataGridViewDiem_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow dataGridViewRow = dataGridViewDiem.Rows[e.RowIndex];
            //DateTime Datetime = Convert.ToDateTime(dataGridViewRow.Cells[2].Value.ToString());
            String maSV = dataGridViewRow.Cells[0].Value.ToString();
            String hoTen = dataGridViewRow.Cells[1].Value.ToString();
            String diem = dataGridViewRow.Cells[2].Value.ToString();

            TBmaSV.Text = maSV;
            TBtenSV.Text = hoTen;
            TBdiem.Text = diem;

            TBmaSV.ReadOnly = true;
            TBtenSV.ReadOnly = true;
            TBdiem.ReadOnly = true;
        }

    }
}
