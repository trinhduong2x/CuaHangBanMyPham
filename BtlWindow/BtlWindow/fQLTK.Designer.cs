
namespace BtlWindow
{
    partial class fQLTK
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_pw = new System.Windows.Forms.TextBox();
            this.txt_User = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDT = new System.Windows.Forms.Label();
            this.lblDC = new System.Windows.Forms.Label();
            this.lblTenNV = new System.Windows.Forms.Label();
            this.ccb_NV = new System.Windows.Forms.ComboBox();
            this.lbl_Ten = new System.Windows.Forms.Label();
            this.rdb_Admin = new System.Windows.Forms.RadioButton();
            this.rdb_Staff = new System.Windows.Forms.RadioButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_DT = new System.Windows.Forms.Label();
            this.lbl_DiaChi = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Tao = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PassWord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserName,
            this.PassWord,
            this.Role,
            this.MaNV});
            this.dataGridView1.Location = new System.Drawing.Point(53, 277);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(581, 160);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // txt_pw
            // 
            this.txt_pw.Location = new System.Drawing.Point(90, 58);
            this.txt_pw.Name = "txt_pw";
            this.txt_pw.Size = new System.Drawing.Size(100, 20);
            this.txt_pw.TabIndex = 1;
            // 
            // txt_User
            // 
            this.txt_User.Location = new System.Drawing.Point(90, 21);
            this.txt_User.Name = "txt_User";
            this.txt_User.Size = new System.Drawing.Size(100, 20);
            this.txt_User.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Chức vụ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật khẩu:";
            // 
            // lblDT
            // 
            this.lblDT.AutoSize = true;
            this.lblDT.Location = new System.Drawing.Point(107, 111);
            this.lblDT.Name = "lblDT";
            this.lblDT.Size = new System.Drawing.Size(0, 13);
            this.lblDT.TabIndex = 2;
            // 
            // lblDC
            // 
            this.lblDC.AutoSize = true;
            this.lblDC.Location = new System.Drawing.Point(107, 76);
            this.lblDC.Name = "lblDC";
            this.lblDC.Size = new System.Drawing.Size(0, 13);
            this.lblDC.TabIndex = 2;
            // 
            // lblTenNV
            // 
            this.lblTenNV.AutoSize = true;
            this.lblTenNV.Location = new System.Drawing.Point(107, 46);
            this.lblTenNV.Name = "lblTenNV";
            this.lblTenNV.Size = new System.Drawing.Size(0, 13);
            this.lblTenNV.TabIndex = 2;
            // 
            // ccb_NV
            // 
            this.ccb_NV.FormattingEnabled = true;
            this.ccb_NV.Location = new System.Drawing.Point(107, 18);
            this.ccb_NV.Name = "ccb_NV";
            this.ccb_NV.Size = new System.Drawing.Size(121, 21);
            this.ccb_NV.TabIndex = 1;
            this.ccb_NV.SelectedIndexChanged += new System.EventHandler(this.ccb_NV_SelectedIndexChanged);
            // 
            // lbl_Ten
            // 
            this.lbl_Ten.AutoSize = true;
            this.lbl_Ten.Location = new System.Drawing.Point(16, 48);
            this.lbl_Ten.Name = "lbl_Ten";
            this.lbl_Ten.Size = new System.Drawing.Size(79, 13);
            this.lbl_Ten.TabIndex = 0;
            this.lbl_Ten.Text = "Tên nhân viên:";
            // 
            // rdb_Admin
            // 
            this.rdb_Admin.AutoSize = true;
            this.rdb_Admin.Checked = true;
            this.rdb_Admin.Location = new System.Drawing.Point(90, 93);
            this.rdb_Admin.Name = "rdb_Admin";
            this.rdb_Admin.Size = new System.Drawing.Size(61, 17);
            this.rdb_Admin.TabIndex = 2;
            this.rdb_Admin.TabStop = true;
            this.rdb_Admin.Text = "Quản lý";
            this.rdb_Admin.UseVisualStyleBackColor = true;
            // 
            // rdb_Staff
            // 
            this.rdb_Staff.AutoSize = true;
            this.rdb_Staff.Location = new System.Drawing.Point(90, 116);
            this.rdb_Staff.Name = "rdb_Staff";
            this.rdb_Staff.Size = new System.Drawing.Size(74, 17);
            this.rdb_Staff.TabIndex = 2;
            this.rdb_Staff.Text = "Nhân viên";
            this.rdb_Staff.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.rdb_Admin);
            this.panel4.Controls.Add(this.rdb_Staff);
            this.panel4.Controls.Add(this.txt_pw);
            this.panel4.Controls.Add(this.txt_User);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(53, 48);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(249, 152);
            this.panel4.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài khoản:";
            // 
            // lbl_DT
            // 
            this.lbl_DT.AutoSize = true;
            this.lbl_DT.Location = new System.Drawing.Point(16, 111);
            this.lbl_DT.Name = "lbl_DT";
            this.lbl_DT.Size = new System.Drawing.Size(58, 13);
            this.lbl_DT.TabIndex = 0;
            this.lbl_DT.Text = "Điện thoại:";
            // 
            // lbl_DiaChi
            // 
            this.lbl_DiaChi.AutoSize = true;
            this.lbl_DiaChi.Location = new System.Drawing.Point(16, 76);
            this.lbl_DiaChi.Name = "lbl_DiaChi";
            this.lbl_DiaChi.Size = new System.Drawing.Size(43, 13);
            this.lbl_DiaChi.TabIndex = 0;
            this.lbl_DiaChi.Text = "Địa chỉ:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblDT);
            this.panel2.Controls.Add(this.lblDC);
            this.panel2.Controls.Add(this.lblTenNV);
            this.panel2.Controls.Add(this.ccb_NV);
            this.panel2.Controls.Add(this.lbl_Ten);
            this.panel2.Controls.Add(this.lbl_DT);
            this.panel2.Controls.Add(this.lbl_DiaChi);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(379, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(255, 152);
            this.panel2.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã nhân viên:";
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(116, 15);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_Xoa.TabIndex = 0;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Tao
            // 
            this.btn_Tao.Location = new System.Drawing.Point(24, 15);
            this.btn_Tao.Name = "btn_Tao";
            this.btn_Tao.Size = new System.Drawing.Size(75, 23);
            this.btn_Tao.TabIndex = 0;
            this.btn_Tao.Text = "Tạo";
            this.btn_Tao.UseVisualStyleBackColor = true;
            this.btn_Tao.Click += new System.EventHandler(this.btn_Tao_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_Xoa);
            this.panel3.Controls.Add(this.btn_Tao);
            this.panel3.Location = new System.Drawing.Point(53, 216);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 45);
            this.panel3.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(57, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(687, 484);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "Tài Khoản";
            this.UserName.Name = "UserName";
            // 
            // PassWord
            // 
            this.PassWord.DataPropertyName = "PassWord";
            this.PassWord.HeaderText = "Mật khẩu";
            this.PassWord.Name = "PassWord";
            // 
            // Role
            // 
            this.Role.DataPropertyName = "Role";
            this.Role.FalseValue = "false";
            this.Role.HeaderText = "Quản lý";
            this.Role.Name = "Role";
            this.Role.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Role.TrueValue = "true";
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.MaNV.DefaultCellStyle = dataGridViewCellStyle2;
            this.MaNV.HeaderText = "Mã NV";
            this.MaNV.Name = "MaNV";
            // 
            // fQLTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 536);
            this.Controls.Add(this.panel1);
            this.Name = "fQLTK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "fQLTK";
            this.Load += new System.EventHandler(this.fQLTK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_pw;
        private System.Windows.Forms.TextBox txt_User;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDT;
        private System.Windows.Forms.Label lblDC;
        private System.Windows.Forms.Label lblTenNV;
        private System.Windows.Forms.ComboBox ccb_NV;
        private System.Windows.Forms.Label lbl_Ten;
        private System.Windows.Forms.RadioButton rdb_Admin;
        private System.Windows.Forms.RadioButton rdb_Staff;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_DT;
        private System.Windows.Forms.Label lbl_DiaChi;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Tao;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PassWord;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Role;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
    }
}