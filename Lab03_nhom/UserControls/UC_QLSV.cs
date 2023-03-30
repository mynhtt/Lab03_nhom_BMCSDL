using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab03_nhom.UserControls
{
    public partial class UC_QLSV : UserControl
    {
        public UC_QLSV()
        {
            InitializeComponent();
        }

        private void buttonNhapDiem_Click(object sender, EventArgs e)
        {
            NhapDiem fNhapDiem = new NhapDiem();
            fNhapDiem.Show();
        }

<<<<<<< Updated upstream
        
=======
        private void buttonTaiLai_Click(object sender, EventArgs e)
        {

            TbMaSV.Text = "";
            TbHoTen.Text = "";
            dateTimePicker1.Value = DateTime.Today;
            TbDiaChi.Text = "";
            TbTenDN.Text = "";
            TbMatKhau.Text = "";

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
                cmd = new SqlCommand("SP_UPDATESV_NOPASSWORD", sqlconn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add("@MASV", SqlDbType.VarChar, 50).Value = MaSV;
                cmd.Parameters.Add("@HOTEN", SqlDbType.NVarChar, 50).Value = HoTen;
                cmd.Parameters.Add("@NGAYSINH", SqlDbType.DateTime).Value = NgaySinh;
                cmd.Parameters.Add("@DIACHI", SqlDbType.NVarChar, 100).Value = DiaChi;
                cmd.Parameters.Add("@MALOP", SqlDbType.VarChar, 50).Value = MALOP;
                cmd.Parameters.Add("@TENDN", SqlDbType.VarChar, 50).Value = TenDN;
                cmd.ExecuteReader();
                MessageBox.Show("Lưu Thành Công !", "Thông Báo");
                dataGridViewSV_List();
            }
            else
            {
                cmd = new SqlCommand("SP_UPDATESV_PASSWORD", sqlconn)
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
                MessageBox.Show("Lưu Thành Công !", "Thông Báo");
                dataGridViewSV_List();
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

        private void tenLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            /////// 
            var ClassName = tenLop.Text.Trim();
            SqlCommand cmd_check = new SqlCommand("SP_DSLOP", sqlconn)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd_check.Parameters.Add("@TENLOP", SqlDbType.NVarChar,100).Value = ClassName;
            SqlDataReader check_MLop = cmd_check.ExecuteReader();  
            if (check_MLop.Read())
            {
                UC_QLSV.MALOP = check_MLop[0].ToString();
                dataGridViewSV_List();
                SoluongSV.Text = FetchSoLuongSinhVien(MALOP).ToString();
                SoluongSV.ReadOnly = true;
            }
            
            ////////////
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

>>>>>>> Stashed changes
    }
}
