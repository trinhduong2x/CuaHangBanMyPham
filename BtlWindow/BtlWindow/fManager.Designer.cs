
namespace BtlWindow
{
    partial class fManager
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fManager));
            this.lbl_ChaoMung = new System.Windows.Forms.Label();
            this.tabTrangChu = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabQLNV = new System.Windows.Forms.TabPage();
            this.tabQLTK = new System.Windows.Forms.TabPage();
            this.tabQLKH = new System.Windows.Forms.TabPage();
            this.tabQLHD = new System.Windows.Forms.TabPage();
            this.tabQLNCC = new System.Windows.Forms.TabPage();
            this.tabQLSP = new System.Windows.Forms.TabPage();
            this.tabTHD = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.tabTrangChu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_ChaoMung
            // 
            this.lbl_ChaoMung.AutoSize = true;
            this.lbl_ChaoMung.Location = new System.Drawing.Point(20, 11);
            this.lbl_ChaoMung.Name = "lbl_ChaoMung";
            this.lbl_ChaoMung.Size = new System.Drawing.Size(0, 13);
            this.lbl_ChaoMung.TabIndex = 3;
            // 
            // tabTrangChu
            // 
            this.tabTrangChu.Controls.Add(this.label1);
            this.tabTrangChu.Controls.Add(this.pictureBox3);
            this.tabTrangChu.Controls.Add(this.pictureBox2);
            this.tabTrangChu.Controls.Add(this.pictureBox1);
            this.tabTrangChu.Location = new System.Drawing.Point(4, 22);
            this.tabTrangChu.Name = "tabTrangChu";
            this.tabTrangChu.Padding = new System.Windows.Forms.Padding(3);
            this.tabTrangChu.Size = new System.Drawing.Size(910, 574);
            this.tabTrangChu.TabIndex = 10;
            this.tabTrangChu.Text = "Trang chủ";
            this.tabTrangChu.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("NSimSun", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(46, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(480, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chào mừng đến với mỹ phẩm thiên nhiên";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::BtlWindow.Properties.Resources.TrangChu;
            this.pictureBox3.Location = new System.Drawing.Point(0, 92);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(914, 476);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Image = global::BtlWindow.Properties.Resources.anhlogo;
            this.pictureBox2.Location = new System.Drawing.Point(720, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(151, 54);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(904, 568);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tabQLNV
            // 
            this.tabQLNV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabQLNV.Location = new System.Drawing.Point(4, 22);
            this.tabQLNV.Margin = new System.Windows.Forms.Padding(0);
            this.tabQLNV.Name = "tabQLNV";
            this.tabQLNV.Size = new System.Drawing.Size(910, 574);
            this.tabQLNV.TabIndex = 9;
            this.tabQLNV.Text = "Quản lý nhân viên";
            this.tabQLNV.UseVisualStyleBackColor = true;
            // 
            // tabQLTK
            // 
            this.tabQLTK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabQLTK.Location = new System.Drawing.Point(4, 22);
            this.tabQLTK.Name = "tabQLTK";
            this.tabQLTK.Size = new System.Drawing.Size(910, 574);
            this.tabQLTK.TabIndex = 8;
            this.tabQLTK.Text = "Quản lý tài khoản";
            this.tabQLTK.UseVisualStyleBackColor = true;
            // 
            // tabQLKH
            // 
            this.tabQLKH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabQLKH.Location = new System.Drawing.Point(4, 22);
            this.tabQLKH.Name = "tabQLKH";
            this.tabQLKH.Padding = new System.Windows.Forms.Padding(3);
            this.tabQLKH.Size = new System.Drawing.Size(910, 574);
            this.tabQLKH.TabIndex = 7;
            this.tabQLKH.Text = "Quản lý khách hàng";
            this.tabQLKH.UseVisualStyleBackColor = true;
            // 
            // tabQLHD
            // 
            this.tabQLHD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabQLHD.Location = new System.Drawing.Point(4, 22);
            this.tabQLHD.Name = "tabQLHD";
            this.tabQLHD.Padding = new System.Windows.Forms.Padding(3);
            this.tabQLHD.Size = new System.Drawing.Size(910, 574);
            this.tabQLHD.TabIndex = 6;
            this.tabQLHD.Text = "Quản lý hóa đơn";
            this.tabQLHD.UseVisualStyleBackColor = true;
            // 
            // tabQLNCC
            // 
            this.tabQLNCC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabQLNCC.Location = new System.Drawing.Point(4, 22);
            this.tabQLNCC.Name = "tabQLNCC";
            this.tabQLNCC.Padding = new System.Windows.Forms.Padding(3);
            this.tabQLNCC.Size = new System.Drawing.Size(910, 574);
            this.tabQLNCC.TabIndex = 5;
            this.tabQLNCC.Text = "Quản lý nhà cung cấp";
            this.tabQLNCC.UseVisualStyleBackColor = true;
            // 
            // tabQLSP
            // 
            this.tabQLSP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabQLSP.Location = new System.Drawing.Point(4, 22);
            this.tabQLSP.Name = "tabQLSP";
            this.tabQLSP.Padding = new System.Windows.Forms.Padding(3);
            this.tabQLSP.Size = new System.Drawing.Size(910, 574);
            this.tabQLSP.TabIndex = 4;
            this.tabQLSP.Text = "Quản lý sản phẩm";
            this.tabQLSP.UseVisualStyleBackColor = true;
            // 
            // tabTHD
            // 
            this.tabTHD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabTHD.Location = new System.Drawing.Point(4, 22);
            this.tabTHD.Name = "tabTHD";
            this.tabTHD.Padding = new System.Windows.Forms.Padding(3);
            this.tabTHD.Size = new System.Drawing.Size(910, 574);
            this.tabTHD.TabIndex = 3;
            this.tabTHD.Text = "Tạo hóa đơn";
            this.tabTHD.UseVisualStyleBackColor = true;
            this.tabTHD.Click += new System.EventHandler(this.tabTHD_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabTrangChu);
            this.tabControl1.Controls.Add(this.tabTHD);
            this.tabControl1.Controls.Add(this.tabQLSP);
            this.tabControl1.Controls.Add(this.tabQLNCC);
            this.tabControl1.Controls.Add(this.tabQLHD);
            this.tabControl1.Controls.Add(this.tabQLKH);
            this.tabControl1.Controls.Add(this.tabQLTK);
            this.tabControl1.Controls.Add(this.tabQLNV);
            this.tabControl1.Location = new System.Drawing.Point(2, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(918, 600);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 2;
            this.tabControl1.TabStop = false;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "TrangChu.png");
            this.imageList1.Images.SetKeyName(1, "anhlogo.png");
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(776, 11);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(58, 16);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Website";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // fManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(927, 638);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lbl_ChaoMung);
            this.Name = "fManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý mĩ phẩm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fManager_FormClosed);
            this.Load += new System.EventHandler(this.fManager_Load);
            this.tabTrangChu.ResumeLayout(false);
            this.tabTrangChu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_ChaoMung;
        private System.Windows.Forms.TabPage tabTrangChu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabQLNV;
        private System.Windows.Forms.TabPage tabQLTK;
        private System.Windows.Forms.TabPage tabQLKH;
        private System.Windows.Forms.TabPage tabQLHD;
        private System.Windows.Forms.TabPage tabQLNCC;
        private System.Windows.Forms.TabPage tabQLSP;
        private System.Windows.Forms.TabPage tabTHD;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}