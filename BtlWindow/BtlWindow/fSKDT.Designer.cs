
namespace BtlWindow
{
    partial class fSKDT
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
            this.lblMaxProduct = new System.Windows.Forms.Label();
            this.lblMinProduct = new System.Windows.Forms.Label();
            this.lblToTal = new System.Windows.Forms.Label();
            this.dgvSK = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpBegin = new System.Windows.Forms.DateTimePicker();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBT = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnToDay = new System.Windows.Forms.Button();
            this.btnMAgo = new System.Windows.Forms.Button();
            this.btnExel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSK)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMaxProduct
            // 
            this.lblMaxProduct.AutoSize = true;
            this.lblMaxProduct.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxProduct.Location = new System.Drawing.Point(57, 369);
            this.lblMaxProduct.Name = "lblMaxProduct";
            this.lblMaxProduct.Size = new System.Drawing.Size(146, 15);
            this.lblMaxProduct.TabIndex = 11;
            this.lblMaxProduct.Text = "Sản phẩm bán chạy nhất";
            // 
            // lblMinProduct
            // 
            this.lblMinProduct.AutoSize = true;
            this.lblMinProduct.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinProduct.Location = new System.Drawing.Point(57, 409);
            this.lblMinProduct.Name = "lblMinProduct";
            this.lblMinProduct.Size = new System.Drawing.Size(126, 15);
            this.lblMinProduct.TabIndex = 12;
            this.lblMinProduct.Text = "Sản phẩm bán ít nhất";
            // 
            // lblToTal
            // 
            this.lblToTal.AutoSize = true;
            this.lblToTal.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToTal.Location = new System.Drawing.Point(57, 324);
            this.lblToTal.Name = "lblToTal";
            this.lblToTal.Size = new System.Drawing.Size(64, 15);
            this.lblToTal.TabIndex = 13;
            this.lblToTal.Text = "Doanh thu";
            // 
            // dgvSK
            // 
            this.dgvSK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSK.Location = new System.Drawing.Point(47, 146);
            this.dgvSK.Name = "dgvSK";
            this.dgvSK.Size = new System.Drawing.Size(641, 159);
            this.dgvSK.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "Đến ngày";
            // 
            // dtpEnd
            // 
            this.dtpEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpEnd.CustomFormat = "dd/MM/yyyy";
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnd.Location = new System.Drawing.Point(82, 9);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(101, 20);
            this.dtpEnd.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.dtpEnd);
            this.panel3.Location = new System.Drawing.Point(134, 50);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(186, 38);
            this.panel3.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 14);
            this.label3.TabIndex = 3;
            this.label3.Text = "Từ ngày";
            // 
            // dtpBegin
            // 
            this.dtpBegin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpBegin.CustomFormat = "dd/MM/yyyy";
            this.dtpBegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBegin.Location = new System.Drawing.Point(82, 9);
            this.dtpBegin.Name = "dtpBegin";
            this.dtpBegin.Size = new System.Drawing.Size(101, 20);
            this.dtpBegin.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.dtpBegin);
            this.panel4.Location = new System.Drawing.Point(134, 15);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(186, 38);
            this.panel4.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btnBT);
            this.panel2.Location = new System.Drawing.Point(362, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(326, 88);
            this.panel2.TabIndex = 9;
            // 
            // btnBT
            // 
            this.btnBT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnBT.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBT.Location = new System.Drawing.Point(17, 19);
            this.btnBT.Name = "btnBT";
            this.btnBT.Size = new System.Drawing.Size(99, 52);
            this.btnBT.TabIndex = 1;
            this.btnBT.Text = "Theo thời gian";
            this.btnBT.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnToDay);
            this.panel1.Controls.Add(this.btnMAgo);
            this.panel1.Location = new System.Drawing.Point(47, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 88);
            this.panel1.TabIndex = 8;
            // 
            // btnToDay
            // 
            this.btnToDay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnToDay.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToDay.Location = new System.Drawing.Point(13, 19);
            this.btnToDay.Name = "btnToDay";
            this.btnToDay.Size = new System.Drawing.Size(90, 52);
            this.btnToDay.TabIndex = 1;
            this.btnToDay.Text = "Ngày hiện tại";
            this.btnToDay.UseVisualStyleBackColor = false;
            // 
            // btnMAgo
            // 
            this.btnMAgo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnMAgo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMAgo.Location = new System.Drawing.Point(133, 19);
            this.btnMAgo.Name = "btnMAgo";
            this.btnMAgo.Size = new System.Drawing.Size(90, 52);
            this.btnMAgo.TabIndex = 1;
            this.btnMAgo.Text = "Tháng trước";
            this.btnMAgo.UseVisualStyleBackColor = false;
            // 
            // btnExel
            // 
            this.btnExel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnExel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExel.Location = new System.Drawing.Point(583, 356);
            this.btnExel.Name = "btnExel";
            this.btnExel.Size = new System.Drawing.Size(96, 41);
            this.btnExel.TabIndex = 7;
            this.btnExel.Text = "Xuất Exel";
            this.btnExel.UseVisualStyleBackColor = false;
            this.btnExel.Click += new System.EventHandler(this.btnExel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(241, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 34);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sao kê doanh thu";
            // 
            // fSKDT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 448);
            this.Controls.Add(this.lblMaxProduct);
            this.Controls.Add(this.lblMinProduct);
            this.Controls.Add(this.lblToTal);
            this.Controls.Add(this.dgvSK);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnExel);
            this.Controls.Add(this.label1);
            this.Name = "fSKDT";
            this.Text = "fSKDT";
            this.Load += new System.EventHandler(this.fSKDT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSK)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaxProduct;
        private System.Windows.Forms.Label lblMinProduct;
        private System.Windows.Forms.Label lblToTal;
        private System.Windows.Forms.DataGridView dgvSK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpBegin;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnBT;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnToDay;
        private System.Windows.Forms.Button btnMAgo;
        private System.Windows.Forms.Button btnExel;
        private System.Windows.Forms.Label label1;
    }
}