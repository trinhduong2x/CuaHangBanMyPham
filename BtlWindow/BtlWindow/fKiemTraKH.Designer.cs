
namespace BtlWindow
{
    partial class fKiemTraKH
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_KiemTra = new System.Windows.Forms.Button();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập SĐT khách hàng:";
            // 
            // btn_KiemTra
            // 
            this.btn_KiemTra.Location = new System.Drawing.Point(308, 18);
            this.btn_KiemTra.Name = "btn_KiemTra";
            this.btn_KiemTra.Size = new System.Drawing.Size(75, 23);
            this.btn_KiemTra.TabIndex = 1;
            this.btn_KiemTra.Text = "Kiểm tra";
            this.btn_KiemTra.UseVisualStyleBackColor = true;
            this.btn_KiemTra.Click += new System.EventHandler(this.btn_KiemTra_Click);
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(144, 21);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(148, 20);
            this.txtSDT.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_KiemTra);
            this.panel1.Controls.Add(this.txtSDT);
            this.panel1.Location = new System.Drawing.Point(221, 184);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 67);
            this.panel1.TabIndex = 4;
            // 
            // fKiemTraKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 349);
            this.Controls.Add(this.panel1);
            this.Name = "fKiemTraKH";
            this.Text = "fKiemTraKH";
            this.Load += new System.EventHandler(this.fKiemTraKH_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_KiemTra;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Panel panel1;
    }
}