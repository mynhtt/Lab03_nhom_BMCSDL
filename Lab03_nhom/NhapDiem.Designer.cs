namespace Lab03_nhom
{
    partial class NhapDiem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconButtonExit = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.labelMaSV = new System.Windows.Forms.Label();
            this.labelSinhVien = new System.Windows.Forms.Label();
            this.labelDiem = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.buttonThem = new System.Windows.Forms.Button();
            this.buttonSua = new System.Windows.Forms.Button();
            this.buttonLưu = new System.Windows.Forms.Button();
            this.buttonHuy = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(103)))));
            this.panel1.Controls.Add(this.iconButtonExit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(716, 52);
            this.panel1.TabIndex = 0;
            // 
            // iconButtonExit
            // 
            this.iconButtonExit.FlatAppearance.BorderSize = 0;
            this.iconButtonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonExit.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.iconButtonExit.IconColor = System.Drawing.Color.White;
            this.iconButtonExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonExit.Location = new System.Drawing.Point(643, 10);
            this.iconButtonExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.iconButtonExit.Name = "iconButtonExit";
            this.iconButtonExit.Size = new System.Drawing.Size(70, 33);
            this.iconButtonExit.TabIndex = 4;
            this.iconButtonExit.UseVisualStyleBackColor = true;
            this.iconButtonExit.Click += new System.EventHandler(this.iconButtonExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(309, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập điểm";
            // 
            // labelMaSV
            // 
            this.labelMaSV.AutoSize = true;
            this.labelMaSV.Location = new System.Drawing.Point(65, 64);
            this.labelMaSV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMaSV.Name = "labelMaSV";
            this.labelMaSV.Size = new System.Drawing.Size(77, 15);
            this.labelMaSV.TabIndex = 1;
            this.labelMaSV.Text = "Mã sinh viên:";
            // 
            // labelSinhVien
            // 
            this.labelSinhVien.AutoSize = true;
            this.labelSinhVien.Location = new System.Drawing.Point(65, 100);
            this.labelSinhVien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSinhVien.Name = "labelSinhVien";
            this.labelSinhVien.Size = new System.Drawing.Size(58, 15);
            this.labelSinhVien.TabIndex = 2;
            this.labelSinhVien.Text = "Sinh viên:";
            // 
            // labelDiem
            // 
            this.labelDiem.AutoSize = true;
            this.labelDiem.Location = new System.Drawing.Point(65, 132);
            this.labelDiem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDiem.Name = "labelDiem";
            this.labelDiem.Size = new System.Drawing.Size(38, 15);
            this.labelDiem.TabIndex = 3;
            this.labelDiem.Text = "Điểm:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(156, 62);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(174, 23);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(156, 95);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(174, 23);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(156, 127);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(174, 23);
            this.textBox3.TabIndex = 6;
            // 
            // buttonThem
            // 
            this.buttonThem.Location = new System.Drawing.Point(440, 72);
            this.buttonThem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(73, 19);
            this.buttonThem.TabIndex = 7;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = true;
            // 
            // buttonSua
            // 
            this.buttonSua.Location = new System.Drawing.Point(569, 72);
            this.buttonSua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(73, 19);
            this.buttonSua.TabIndex = 8;
            this.buttonSua.Text = "Sửa";
            this.buttonSua.UseVisualStyleBackColor = true;
            // 
            // buttonLưu
            // 
            this.buttonLưu.Location = new System.Drawing.Point(440, 123);
            this.buttonLưu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonLưu.Name = "buttonLưu";
            this.buttonLưu.Size = new System.Drawing.Size(73, 19);
            this.buttonLưu.TabIndex = 9;
            this.buttonLưu.Text = "Lưu";
            this.buttonLưu.UseVisualStyleBackColor = true;
            // 
            // buttonHuy
            // 
            this.buttonHuy.Location = new System.Drawing.Point(569, 123);
            this.buttonHuy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonHuy.Name = "buttonHuy";
            this.buttonHuy.Size = new System.Drawing.Size(73, 19);
            this.buttonHuy.TabIndex = 10;
            this.buttonHuy.Text = "Hủy";
            this.buttonHuy.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSV,
            this.HoTen,
            this.Diem});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 168);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 32;
            this.dataGridView1.Size = new System.Drawing.Size(716, 199);
            this.dataGridView1.TabIndex = 11;
            // 
            // MaSV
            // 
            this.MaSV.HeaderText = "Mã sinh viên";
            this.MaSV.MinimumWidth = 6;
            this.MaSV.Name = "MaSV";
            // 
            // HoTen
            // 
            this.HoTen.HeaderText = "Họ tên";
            this.HoTen.MinimumWidth = 6;
            this.HoTen.Name = "HoTen";
            // 
            // Diem
            // 
            this.Diem.HeaderText = "Điểm";
            this.Diem.MinimumWidth = 6;
            this.Diem.Name = "Diem";
            // 
            // NhapDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 367);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonHuy);
            this.Controls.Add(this.buttonLưu);
            this.Controls.Add(this.buttonSua);
            this.Controls.Add(this.buttonThem);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelDiem);
            this.Controls.Add(this.labelSinhVien);
            this.Controls.Add(this.labelMaSV);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "NhapDiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NhapDiem";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton iconButtonExit;
        private System.Windows.Forms.Label labelMaSV;
        private System.Windows.Forms.Label labelSinhVien;
        private System.Windows.Forms.Label labelDiem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.Button buttonSua;
        private System.Windows.Forms.Button buttonLưu;
        private System.Windows.Forms.Button buttonHuy;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diem;
    }
}