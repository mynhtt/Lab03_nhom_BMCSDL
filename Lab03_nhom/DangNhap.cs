using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab03_nhom
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private bool kiemTraDangNhap()
        {
            return false;
        }
        private void buttonDangNhap_Click(object sender, EventArgs e)
        {
            if (kiemTraDangNhap())
            {
                Form1 f1 = new Form1();
                f1.Show();
            }
        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
