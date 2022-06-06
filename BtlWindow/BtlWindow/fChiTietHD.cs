using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BtlWindow
{
    public partial class fChiTietHD : Form
    {
        QuanLyMiPhamDBcontext db = new QuanLyMiPhamDBcontext();
        ChiTietHD chiTietHD = new ChiTietHD();
        public string ma { get; set; }
        public fChiTietHD(string ma)
        {
            InitializeComponent();
            this.ma = ma;
           
        }
        public void ThongTin(string ma)
        {
            var hoadon = db.HoaDons.Where(h => h.MaHD == ma).FirstOrDefault();
            lbl_NgayLap.Text = hoadon.NgayLap.ToShortDateString();
            lbl_MaHD.Text = hoadon.MaHD.ToString();
            var nv = db.NhanViens.Where(c => c.MaNV == hoadon.MaNV).FirstOrDefault();
            lbl_MaNV.Text = nv.MaNV.ToString();
            lbl_TenNV.Text = nv.TenNV.ToString();
            var kh = db.KhachHangs.Where(k => k.MaKH == hoadon.MaKH).FirstOrDefault();
            lbl_TenKH.Text = kh.TenKH;
            lbl_DiaChiKH.Text = kh.DiaChi;
            lbl_SoDT.Text = kh.SDT;
        }
        private void HienThi()
        {
            var ct = db.ChiTietHDs.Join(db.SanPhams,
               p => p.MaSP,
               c => c.MaSP,
               (p, c) => new
               {
                   hd = p,
                   sp = c
               }).Where(p => p.hd.MaHD == ma).Select(p => new
               {
                   MaSP = p.hd.MaSP,
                   TenSP = p.sp.TenSP,
                   SLMua = p.hd.SLBan,
                   Gia = p.sp.Gia,
                   TongTien = p.hd.SLBan * p.sp.Gia,
               });
            dataGridView1.DataSource = ct.ToList();
            int tong = 0;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                int t = Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value.ToString());
                //DataGridViewRow row = dataGridView1.Rows[i];
                tong += t;
            }

            lbl_Tong.Text = Convert.ToString(tong) + " VND";
        }
        private void fChiTietHD_Load(object sender, EventArgs e)
        {
            HienThi();
            ThongTin(this.ma);
        }

        private void dataGridView1_DataSourceChanged(object sender, EventArgs e)
        {
           
            
        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Xuat_Click(object sender, EventArgs e)
        {
            
            int rowIndex = 1;
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            excelApp.Application.Workbooks.Add(Type.Missing);

            excelApp.Cells[rowIndex, 1] = "Chi tiết hóa đơn";
            rowIndex++;
            excelApp.Cells[rowIndex, 1] = "Mã hóa đơn: ";
            excelApp.Cells[rowIndex, 2] = lbl_MaHD.Text;
            rowIndex++;
            excelApp.Cells[rowIndex, 1] = "Ngày bán: ";
            excelApp.Cells[rowIndex, 2] = lbl_NgayLap.Text;
            rowIndex++;
            excelApp.Cells[rowIndex, 1] = "Tên khách hàng: ";
            excelApp.Cells[rowIndex, 2] = lbl_TenKH.Text;
            rowIndex++;
            excelApp.Cells[rowIndex, 1] = "Địa chỉ KH: ";
            excelApp.Cells[rowIndex, 2] = lbl_DiaChiKH.Text;
            rowIndex++;
            excelApp.Cells[rowIndex, 1] = "Số điện thoại KH: ";
            excelApp.Cells[rowIndex, 2] = lbl_SoDT.Text;
            rowIndex++;
            excelApp.Cells[rowIndex, 1] = "Nhân viên lập HĐ: ";
            excelApp.Cells[rowIndex, 2] = lbl_TenNV.Text;
            rowIndex++;
            //header table
            for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
            {
                excelApp.Cells[rowIndex, i] = dataGridView1.Columns[i - 1].HeaderText;
            }
            rowIndex++;
            //data table
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {

                    excelApp.Cells[i + rowIndex, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                }

            }
            excelApp.Columns.AutoFit();
            excelApp.Visible = true;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
