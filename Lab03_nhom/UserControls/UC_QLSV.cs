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

        
    }
}
