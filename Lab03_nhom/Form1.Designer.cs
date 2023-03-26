namespace Lab03_nhom
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconButtonExit = new FontAwesome.Sharp.IconButton();
            this.buttonTrangChu = new System.Windows.Forms.Button();
            this.buttonQLSV = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonQLLH = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(103)))));
            this.panel1.Controls.Add(this.iconButtonExit);
            this.panel1.Controls.Add(this.buttonTrangChu);
            this.panel1.Controls.Add(this.buttonQLSV);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonQLLH);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1131, 71);
            this.panel1.TabIndex = 0;
            // 
            // iconButtonExit
            // 
            this.iconButtonExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.iconButtonExit.FlatAppearance.BorderSize = 0;
            this.iconButtonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonExit.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.iconButtonExit.IconColor = System.Drawing.Color.White;
            this.iconButtonExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonExit.Location = new System.Drawing.Point(1041, 0);
            this.iconButtonExit.Name = "iconButtonExit";
            this.iconButtonExit.Size = new System.Drawing.Size(90, 71);
            this.iconButtonExit.TabIndex = 3;
            this.iconButtonExit.UseVisualStyleBackColor = true;
            this.iconButtonExit.Click += new System.EventHandler(this.iconButtonExit_Click);
            // 
            // buttonTrangChu
            // 
            this.buttonTrangChu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(103)))));
            this.buttonTrangChu.FlatAppearance.BorderSize = 0;
            this.buttonTrangChu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTrangChu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonTrangChu.ForeColor = System.Drawing.Color.White;
            this.buttonTrangChu.Location = new System.Drawing.Point(197, 0);
            this.buttonTrangChu.Name = "buttonTrangChu";
            this.buttonTrangChu.Size = new System.Drawing.Size(196, 71);
            this.buttonTrangChu.TabIndex = 2;
            this.buttonTrangChu.Text = "Trang chủ";
            this.buttonTrangChu.UseVisualStyleBackColor = false;
            this.buttonTrangChu.Click += new System.EventHandler(this.buttonTrangChu_Click);
            // 
            // buttonQLSV
            // 
            this.buttonQLSV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(103)))));
            this.buttonQLSV.FlatAppearance.BorderSize = 0;
            this.buttonQLSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonQLSV.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonQLSV.ForeColor = System.Drawing.Color.White;
            this.buttonQLSV.Location = new System.Drawing.Point(601, 0);
            this.buttonQLSV.Name = "buttonQLSV";
            this.buttonQLSV.Size = new System.Drawing.Size(196, 71);
            this.buttonQLSV.TabIndex = 1;
            this.buttonQLSV.Text = "Quản lý sinh viên";
            this.buttonQLSV.UseVisualStyleBackColor = false;
            this.buttonQLSV.Click += new System.EventHandler(this.buttonQLSV_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(53, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "BOBA";
            // 
            // buttonQLLH
            // 
            this.buttonQLLH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(103)))));
            this.buttonQLLH.FlatAppearance.BorderSize = 0;
            this.buttonQLLH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonQLLH.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonQLLH.ForeColor = System.Drawing.Color.White;
            this.buttonQLLH.Location = new System.Drawing.Point(399, 0);
            this.buttonQLLH.Name = "buttonQLLH";
            this.buttonQLLH.Size = new System.Drawing.Size(196, 71);
            this.buttonQLLH.TabIndex = 0;
            this.buttonQLLH.Text = "Quản lý lớp học";
            this.buttonQLLH.UseVisualStyleBackColor = false;
            this.buttonQLLH.Click += new System.EventHandler(this.buttonQLLH_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 71);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1131, 671);
            this.panelContainer.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 742);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Button buttonQLSV;
        private System.Windows.Forms.Button buttonQLLH;
        private System.Windows.Forms.Button buttonTrangChu;
        private FontAwesome.Sharp.IconButton iconButtonExit;
    }
}
