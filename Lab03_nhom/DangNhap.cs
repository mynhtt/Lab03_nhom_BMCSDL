using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Lab03_nhom.UserControls;

namespace Lab03_nhom
{
    public partial class DangNhap : Form
    {
        string strConn = @"Data Source=LAPTOP-5M61K3MD\SQLEXPRESS;Initial Catalog=QLSV_BOBA;Integrated Security=True;MultipleActiveResultSets=True";
        SqlConnection sqlconn = null;
        public DangNhap()
        {
            InitializeComponent();
        }

        private void buttonDangNhap_Click(object sender, EventArgs e)

        {
            var TaiKhoan = textBoxTaiKhoan.Text.Trim();
            var MatKhau = textBoxMatKhau.Text.Trim();

            if (sqlconn == null)
            {
                sqlconn = new SqlConnection(strConn);
            }

            SqlCommand cmd_NV = new SqlCommand("SP_CHECK_NV", sqlconn)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd_NV.Parameters.Add("@TENDN", SqlDbType.VarChar).Value = TaiKhoan;
            cmd_NV.Parameters.Add("@MATKHAU", SqlDbType.VarChar).Value = MatKhau;

            SqlCommand cmd_SV = new SqlCommand("SP_CHECK_SV", sqlconn)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd_SV.Parameters.Add("@TENDN", SqlDbType.VarChar).Value = TaiKhoan;
            cmd_SV.Parameters.Add("@MATKHAU", SqlDbType.VarChar).Value = MatKhau;
            if (sqlconn.State == ConnectionState.Closed)
            {
                sqlconn.Open();
            }
            using SqlDataReader kq_SV = cmd_SV.ExecuteReader();

            if (kq_SV.Read())
            {
                MessageBox.Show("Đăng nhập thành công tài khoản sinh viên " + kq_SV[0], "Thông Báo");
            }
            else
            {
                sqlconn.Close();

                if (sqlconn.State == ConnectionState.Closed)
                {
                    sqlconn.Open();
                }
                using SqlDataReader kq_NV = cmd_NV.ExecuteReader();
                if (kq_NV.Read())
                {
                    string MANV = kq_NV[1].ToString();
                        
                    Form1 frmManagerStudent = new Form1(); 
                    //= new frmManagerClass(MANV, MatKhau); 
                    this.Hide();
                    frmManagerStudent.ShowDialog();
                    frmManagerStudent = null;
                    this.Show();
                    textBoxTaiKhoan.Text = "";
                    textBoxMatKhau.Text = "";

                }
                else
                {
                    MessageBox.Show("Tên đăng nhập và mật khẩu không hợp lệ", "Thông Báo");
                }
                sqlconn.Close();
            }
        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

         
    }
}
