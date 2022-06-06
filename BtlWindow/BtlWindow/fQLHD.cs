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
    public partial class fQLHD : Form
    {
        HoaDon hd = new HoaDon();
        ChiTietHD ct = new ChiTietHD();
        TaiKhoan user;
        DateTime start, end;
        QuanLyMiPhamDBcontext db = new QuanLyMiPhamDBcontext();
        private object tabControl1;

        public fQLHD(TaiKhoan x)
        {
            InitializeComponent();
            user = x;
        }

        public fQLHD()
        {
            
        }

        void HienThi()
        {
            var hd = db.HoaDons.Select(s => new
            {
                MaHD = s.MaHD,
                NgayLap = s.NgayLap,
                MaKH = s.MaKH,
                MaNV = s.MaNV
            }).OrderByDescending(x => x.NgayLap);
            dataGridView1.DataSource = hd.ToList();
            var list = db.ChiTietHDs.Join(db.SanPhams, ct => ct.MaSP, sp => sp.MaSP,
                        (ct, sp) => new
                        {
                            sanpham = sp,
                            chitiet = ct
                        }).Select(p => new
                        {
                            mahd = p.chitiet.MaHD,
                            masp = p.sanpham.MaSP,
                            tensp = p.sanpham.TenSP,
                            gia = p.sanpham.Gia,
                            slban = p.chitiet.SLBan
                        }).ToList();           
            int sum = 0;          
            foreach(var s in list)
            {
                sum += s.gia * s.slban;
                
            }            
            lbl_DoanhThu.Text = "Tổng doanh thu :" + sum + " VNĐ";
        }
       

        private void fQLHD_Load(object sender, EventArgs e)
        {
            HienThi();

        }

        private void btn_Loc_Click(object sender, EventArgs e)
        {
            var bd = dtpBegin.Value;
            var kt = dtpEnd.Value;
            start = bd;
            end = kt;
            if(DateTime.Compare(bd,kt) > 0)
            {
                MessageBox.Show("Ngày bắt đầu phải nhỏ hơn ngày kết thúc!");
                return;
            }
            var hd = db.HoaDons.Select(x => new
            {
                MaHD = x.MaHD,
                NgayLap = x.NgayLap,
                MaKH = x.MaKH,
                MaNV = x.MaNV
            }).Where(c => c.NgayLap >= bd && c.NgayLap <= kt);
            dataGridView1.DataSource = hd.ToList();
            int sum = 0;
            var selectedRows = dataGridView1.Rows;
            foreach(DataGridViewRow row in selectedRows)
            {
                var ma = row.Cells["MaHD"].Value.ToString();
                var list = db.ChiTietHDs.Join(db.SanPhams, ct => ct.MaSP, sp => sp.MaSP,
                      (ct, sp) => new
                      {
                          sanpham = sp,
                          chitiet = ct
                      }).Select(p => new
                      {
                          mahd = p.chitiet.MaHD,
                          masp = p.sanpham.MaSP,
                          tensp = p.sanpham.TenSP,
                          gia = p.sanpham.Gia,
                          slban = p.chitiet.SLBan
                      }).Where(a => a.mahd == ma).ToList();
                
                foreach (var s in list)
                {
                    sum += s.gia * s.slban;
                }
                
            }
            lbl_DoanhThu.Text = "Tổng doanh thu :" + sum + " VNĐ";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow viewRow = dataGridView1.CurrentRow;
            string ma = viewRow.Cells[0].Value + "";
            fChiTietHD ss = new fChiTietHD(ma);
            ss.Show();
        }

        private void btn_TaoHD_Click(object sender, EventArgs e)
        {
            fKiemTraKH f = new fKiemTraKH(user);
            f.Show();

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
             
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            //if (dr == DialogResult.OK)
            //{
            //    var sr = dataGridView1.SelectedRows;
            //    foreach(DataGridViewRow row in sr)
            //    {
            //        List<ChiTietHD> list = new List<ChiTietHD>();
            //        var ma = row.Cells["MaHD"].Value.ToString();
            //        //var chitiet = db.ChiTietHDs.Where(a => a.MaHD == ma);
            //        foreach(var ct in list)
            //        {
            //            var chitiet = db.ChiTietHDs.Where(ct.MaHD == ma);
            //            db.HoaDons.Remove(chitiet);
            //        }
            //    }    
            //}
            var now = DateTime.Today;
            end = start = now;
            var hd = db.HoaDons.Select(x => new
            {
                MaHD = x.MaHD,
                NgayLap = x.NgayLap,
                MaKH = x.MaKH,
                MaNV = x.MaNV
            }).Where(c => c.NgayLap == now);
            dataGridView1.DataSource = hd.ToList();
            var selectedRows = dataGridView1.Rows;
            foreach (DataGridViewRow row in selectedRows)
            {
                var ma = row.Cells["MaHD"].Value.ToString();
                var list = db.ChiTietHDs.Join(db.SanPhams, ct => ct.MaSP, sp => sp.MaSP,
                      (ct, sp) => new
                      {
                          sanpham = sp,
                          chitiet = ct
                      }).Select(p => new
                      {
                          mahd = p.chitiet.MaHD,
                          masp = p.sanpham.MaSP,
                          tensp = p.sanpham.TenSP,
                          gia = p.sanpham.Gia,
                          slban = p.chitiet.SLBan
                      }).Where(a => a.mahd == ma).ToList();
                int sum = 0;
                foreach (var s in list)
                {
                    sum += s.gia * s.slban;
                }
                lbl_DoanhThu.Text = "Tổng doanh thu :" + sum + " VNĐ";
            }
        }

        private void btn_DoanhThu_Click(object sender, EventArgs e)
        {
            int rowIndex = 1;
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            excelApp.Application.Workbooks.Add(Type.Missing);

            excelApp.Cells[rowIndex, 1] = "BÁO CÁO DOANH THU";
            rowIndex++;
            if (DateTime.Compare(start, end) != 0)
            {
                excelApp.Cells[rowIndex, 1] = "Thời gian bắt đầu: ";
                excelApp.Cells[rowIndex, 2] = start.ToString();
                rowIndex++;
                excelApp.Cells[rowIndex, 1] = "Thời gian kết thúc: ";
                excelApp.Cells[rowIndex, 2] = end.ToString();
                rowIndex++;
            }
            else
            {
                excelApp.Cells[rowIndex, 1] = "Thời gian bán: ";
                excelApp.Cells[rowIndex, 2] = start.ToShortDateString();
                rowIndex++;
            }

            rowIndex++;
            //header table
            excelApp.Cells[rowIndex, 2] = "STT";
            for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
            {
                excelApp.Cells[rowIndex, i + 2] = dataGridView1.Columns[i - 1].HeaderText;
            }
            rowIndex++;
            //data table
            int count = 1;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                excelApp.Cells[i + rowIndex, 2] = count;
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    excelApp.Cells[i + rowIndex, j + 3] = dataGridView1.Rows[i].Cells[j].Value + "";
                }
                count++;

            }
            rowIndex += count + 2;
            excelApp.Cells[rowIndex, 1] = lbl_DoanhThu.Text;
            rowIndex += 2;
            excelApp.Cells[rowIndex, 1] = lbl_BanChay.Text;
           
            rowIndex++;

            excelApp.Columns.AutoFit();
            excelApp.Visible = true;
        }
    }
}
