using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab03_nhom.UserControls
{
    public partial class UC_QLSV : UserControl
    {
        String strConn = @"Data Source=LAPTOP-5M61K3MD\SQLEXPRESS;Initial Catalog=QLSV_BOBA;Integrated Security=True;MultipleActiveResultSets=True";
        SqlConnection sqlconn = null;
        SqlCommand cmd;
        public UC_QLSV()
        {
            InitializeComponent();
            if (sqlconn == null)
            {
                sqlconn = new SqlConnection(strConn);
            }
        }
        private void UC_QLSV_Load(object sender, EventArgs e)
        {
            frm_load();
        }
        private void frm_load()
        {
            dataGridViewSV_List(); 
            tenLop.DisplayMember = "TENLOP";
            tenLop.DataSource = FetchNameLOP();
            SoluongSV.Text = FetchSoLuongSinhVien(MALOP).ToString();
            SoluongSV.ReadOnly = true;
            TbMaSV.ReadOnly = true; 
        }
        private DataTable FetchSinhVien()
        {
            DataTable dt = new DataTable();
            if (sqlconn.State == ConnectionState.Closed)
            {
                sqlconn.Open();
            }
            cmd = new SqlCommand("SP_SEL_SINHVIEN", sqlconn)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.Add("MALOP", SqlDbType.VarChar, 20).Value = MALOP;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            sqlDataAdapter.Fill(dt);
            return dt;
        }
        private void dataGridViewSV_List()
        {
            dataGridViewSV.DataSource = FetchSinhVien();
        }

        private void dgvSinhVien_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow dataGridViewRow = dataGridViewSV.Rows[e.RowIndex];
            DateTime Datetime = Convert.ToDateTime(dataGridViewRow.Cells[2].Value.ToString());
            String MaSV = dataGridViewRow.Cells[0].Value.ToString();
            String HoTen = dataGridViewRow.Cells[1].Value.ToString();
            String DiaChi = dataGridViewRow.Cells[3].Value.ToString();
            String TenDN = dataGridViewRow.Cells[4].Value.ToString();

            TbMaSV.Text = MaSV;
            TbHoTen.Text = HoTen;
            dateTimePicker1.Value = Datetime;
            TbDiaChi.Text = DiaChi;
            TbTenDN.Text = TenDN;


            TbHoTen.ReadOnly = true;
            TbDiaChi.ReadOnly = true;
            TbTenDN.ReadOnly = true;
            TbMatKhau.ReadOnly = true;
        }
        private DataTable FetchNameNV()
        {
            DataTable dt = new DataTable();
            if (sqlconn.State == ConnectionState.Closed)
            {
                sqlconn.Open();
            }
            cmd = new SqlCommand("SP_SEL_NAME_NV", sqlconn)
            {
                CommandType = CommandType.StoredProcedure
            };
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);

            sqlDataAdapter.Fill(dt);
            return dt;
        }
        private DataTable FetchNameLOP()
        {
            DataTable dt = new DataTable();
            if (sqlconn.State == ConnectionState.Closed)
            {
                sqlconn.Open();
            }
            cmd = new SqlCommand("SP_SEL_NAME_LOP", sqlconn)
            {
                CommandType = CommandType.StoredProcedure
            };
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            sqlDataAdapter.Fill(dt);
            return dt;
        } 
        private void buttonNhapDiem_Click(object sender, EventArgs e)
        {
            NhapDiem fNhapDiem = new NhapDiem();
            fNhapDiem.Show();
        }

        private void buttonTaiLai_Click(object sender, EventArgs e)
        {
            frm_load();
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            TbHoTen.ReadOnly = false;
            TbDiaChi.ReadOnly = false;
            TbTenDN.ReadOnly = false;
            TbMatKhau.ReadOnly = false;
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            if (sqlconn.State == ConnectionState.Closed)
            {
                sqlconn.Open();
            }
            String MaSV = TbMaSV.Text;
            String HoTen = TbHoTen.Text;
            String DiaChi = TbDiaChi.Text;
            String TenDN = TbTenDN.Text;
            String MatKhau = TbMatKhau.Text;
            DateTime NgaySinh = dateTimePicker1.Value;

            if (MatKhau == "")
            {
                cmd = new SqlCommand("SP_UPD_SV_NO_PASSWORD", sqlconn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add("MASV", SqlDbType.VarChar, 50).Value = MaSV;
                cmd.Parameters.Add("HOTEN", SqlDbType.NVarChar, 50).Value = HoTen;
                cmd.Parameters.Add("NGAYSINH", SqlDbType.DateTime).Value = NgaySinh;
                cmd.Parameters.Add("DIACHI", SqlDbType.NVarChar, 100).Value = DiaChi;
                cmd.Parameters.Add("MALOP", SqlDbType.VarChar, 50).Value = MALOP;
                cmd.Parameters.Add("TENDN", SqlDbType.VarChar, 50).Value = TenDN;
                cmd.ExecuteReader();
                frm_load();
            }
            else
            {
                cmd = new SqlCommand("SP_UPD_SV_PASSWORD", sqlconn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add("MASV", SqlDbType.VarChar, 50).Value = MaSV;
                cmd.Parameters.Add("HOTEN", SqlDbType.NVarChar, 50).Value = HoTen;
                cmd.Parameters.Add("NGAYSINH", SqlDbType.DateTime).Value = NgaySinh;
                cmd.Parameters.Add("DIACHI", SqlDbType.NVarChar, 100).Value = DiaChi;
                cmd.Parameters.Add("MALOP", SqlDbType.VarChar, 50).Value = MALOP;
                cmd.Parameters.Add("TENDN", SqlDbType.VarChar, 50).Value = TenDN;
                cmd.Parameters.Add("MATKHAU", SqlDbType.VarChar, 50).Value = MatKhau;
                cmd.ExecuteReader();
                frm_load();
            }
        }
        private int FetchSoLuongSinhVien(string Malop)
        {
            if (sqlconn.State == ConnectionState.Closed)
            {
                sqlconn.Open();
            }
            cmd = new SqlCommand("SP_CNT_SV_LOP", sqlconn)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.Add("MALOP", SqlDbType.VarChar, 50).Value = Malop;
            SqlDataReader kq = cmd.ExecuteReader();
            if (kq.Read())
            {
                return kq.GetInt32(0);
            }
            else
            {
                return 0;
            }
        }
        private void UC_QLSV_MouseClick(object sender, MouseEventArgs e)
        {
            TbHoTen.ReadOnly = false;
            TbDiaChi.ReadOnly = false;
            TbTenDN.ReadOnly = false;
            TbMatKhau.ReadOnly = false;
            TbMaSV.ReadOnly = false;

            TbMaSV.Text = "";
            TbHoTen.Text = "";
            dateTimePicker1.Value = DateTime.Today;
            TbDiaChi.Text = "";
            TbTenDN.Text = "";
            TbMatKhau.Text = "";
        }

    }
    
}
