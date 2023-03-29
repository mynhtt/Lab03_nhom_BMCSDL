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
        }

        private void buttonNhapDiem_Click(object sender, EventArgs e)
        {
            NhapDiem fNhapDiem = new NhapDiem();
            fNhapDiem.Show();
        }

        
    }
}
