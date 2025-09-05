using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CMPExcel = Microsoft.Office.Interop.Excel;
using System.Data.Entity;
using System.Globalization;

namespace BtlWindow
{
    public partial class fTrangChu : Form
    {
        private string sdt;
        private TaiKhoan t;
        private KhachHang k;

        //SanPhamTam list = new SanPhamTam();
        List<SanPhamTam> list = new List<SanPhamTam>();

        private QuanLyMiPhamDBcontext db
        {
            get
            {
                if (!DesignMode)
                    return new QuanLyMiPhamDBcontext();
                return null;
            }
        }


        private bool KiemTraSL()
        {
            decimal d = 0;
            return decimal.TryParse(txtSoLuong.Text, out d);
        }
        private void KhoiTaoSanPham()
        {
            db.SanPhams.Load();
            cboMaHang.DataSource = db.SanPhams.Local;
            cboMaHang.DisplayMember = "MaSP";
            cboMaHang.ValueMember = "MaSP";
        }
        private void HienThi()
        {         
            var lspt = list.Select(s => new
            {
                MaSP = s.MaSP,
                TenSP = s.TenSP,
                SLMua = s.SLMua,
                DonGia = s.Gia,
                TongTien = s.SLMua * s.Gia
            }).ToList();
            
            
            dgvHDBanHang.DataSource = lspt.ToList();
        }
        public fTrangChu(KhachHang kh, TaiKhoan tk)
        {
            InitializeComponent();
            k = kh;
            t = tk;
            string manv = tk.NhanVien.MaNV;
            var nv = db.NhanViens.Where(s => s.MaNV == manv).Select(s => s).FirstOrDefault();
            txtTenNhanVien.Text = nv.TenNV;
            txtTenKhach.Text = kh.TenKH;
            txtDiaChi.Text = kh.DiaChi;
            txtDienThoai.Text = kh.SDT;
        }

        public fTrangChu(string sdt, TaiKhoan tk)
        {
            this.sdt = sdt;
            this.t = tk;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            HienThi();
            KhoiTaoSanPham();
            dtp_ngaylap.Value = DateTime.Today;
        }
        private void cboMaHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            var sp = db.SanPhams.Where(t => t.MaSP == cboMaHang.Text).Select(t => new
            {
                ten = t.TenSP,
                dongia = t.Gia,
                slco = t.SLTon
            }).FirstOrDefault();         
                if (sp != null)
            {              
                txtTenHang.Text = sp.ten;
                txtDonGiaBan.Text = Convert.ToString(sp.dongia);
                txt_SLCon.Text = Convert.ToString(sp.slco);
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].MaSP == cboMaHang.Text)
                    {
                        txt_SLCon.Text = Convert.ToString(sp.slco - list[i].SLMua);
                    }
                }
              
            }

        }
       
        private void btn_Them_Click(object sender, EventArgs e)
        {
            var sp = db.SanPhams.Where(t => t.MaSP == cboMaHang.Text).Select(t => new
            {
                masp = t.MaSP,
                tesp = t.TenSP,
                dongia = t.Gia,
                slco = t.SLTon
            }).FirstOrDefault();
            if (KiemTraSL() == false)
            {
                MessageBox.Show("Số lượng không phải số");
                return;
            }
            else
            {               
                string masp = sp.masp.ToString();
                string tensp = sp.tesp.ToString();
                float dongia = float.Parse(sp.dongia.ToString());
                int slmua = int.Parse(txtSoLuong.Text);
                if (slmua > sp.slco)
                {
                    MessageBox.Show("Không đủ hàng");
                    txtSoLuong.Text = "";
                    ActiveControl = txtSoLuong;
                    return;
                }
                int a = 0 ;
                int x = -1;
                //var spt = list.Where(s => s.MaSP == masp).Select(s => s);
                for (int i = 0; i < list.Count; i++)
                {
                   
                    if(list[i].MaSP == masp)
                    {
                        x = i;
                    }    
                     
                }    
                if(x == -1)
                {
                    a = -1;
                }    
                else
                {
                    a = x;
                }
                if (a == -1)
                {              
                    int conlai = sp.slco - slmua;
                    txt_SLCon.Text = Convert.ToString(conlai);

                    list.Add(new SanPhamTam(masp, tensp, slmua, dongia));
                    db.SaveChanges();
                    HienThi();
                }
                else
                {
                                      
                        list[a].SLMua = list[a].SLMua + slmua; 
                        if(list[a].SLMua > sp.slco)
                        {
                            MessageBox.Show("Không đủ hàng");
                        return;
                        }
                    int conlai = sp.slco - list[a].SLMua;
                    txt_SLCon.Text = Convert.ToString(conlai);
                    HienThi();
                    
                }    
            }
            txtMaHDBan.Enabled = true;
            }
      
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
           
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Thoát mọi thứ sẽ không được lưu ", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;

                
            }
        }

        private void dgvHDBanHang_DoubleClick(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                var d = dgvHDBanHang.CurrentRow;
                cboMaHang.Text = d.Cells["MaSP"].Value.ToString();
                string a = cboMaHang.Text;
                var sp = list.Where(s => s.MaSP == cboMaHang.Text).FirstOrDefault();
                list.Remove(sp);
                HienThi();

                var spc = db.SanPhams.Where(t => t.MaSP == a).Select(t => new
                {
                    ma = t.MaSP,
                    ten = t.TenSP,
                    dongia = t.Gia,
                    slco = t.SLTon
                }).FirstOrDefault();
                cboMaHang.Text = spc.ma;
                txtTenHang.Text = spc.ten;
                txtDonGiaBan.Text = Convert.ToString(spc.dongia);
                txt_SLCon.Text = Convert.ToString(spc.slco);
                txtSoLuong.Text = "";
            }

        }

        
        private void dgvHDBanHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var dr = dgvHDBanHang.CurrentRow;
            cboMaHang.Text = dr.Cells["MaSP"].Value.ToString();
            var sp = db.SanPhams.Where(s => s.MaSP == cboMaHang.Text).Select(t => new
            {
                slco = t.SLTon
            }).FirstOrDefault();
            int slMua = Convert.ToInt32(dr.Cells["SLMua"].Value);
            cboMaHang.Text = dr.Cells["MaSP"].Value.ToString();
            txtTenHang.Text = dr.Cells["TenSP"].Value.ToString();
            txtDonGiaBan.Text = Convert.ToString(dr.Cells["DonGia"].Value);
            txt_SLCon.Text = Convert.ToString(sp.slco - slMua);
            txtSoLuong.Text = Convert.ToString(slMua);
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if (txtMaHDBan.Text == "")
            {
                MessageBox.Show("Nhập mã hóa đơn");
                ActiveControl = txtMaHDBan;
                return;
            }
            else
            {
                var ma = db.HoaDons.FirstOrDefault(mahd => mahd.MaHD == txtMaHDBan.Text);
                if (ma != null)
                {
                    MessageBox.Show("Mã hóa đơn đã tồn tại");
                    txtMaHDBan.Text = "";
                    ActiveControl = txtMaHDBan;
                    return;
                }
                else
                {

                    HoaDon new_HD = new HoaDon();
                    new_HD.NgayLap = dtp_ngaylap.Value;
                    new_HD.MaKH = k.MaKH;
                    new_HD.MaNV = t.MaNV;
                    new_HD.MaHD = txtMaHDBan.Text;
                    db.HoaDons.Add(new_HD);
                    db.SaveChanges();

                    List<HoaDon> hd = db.HoaDons.Select(s => s).ToList();

                    foreach (SanPhamTam s in list)
                    {
                        ChiTietHD chiTiet = new ChiTietHD();
                        chiTiet.MaHD = txtMaHDBan.Text;
                        chiTiet.MaSP = s.MaSP;
                        chiTiet.SLBan = s.SLMua;
                        db.ChiTietHDs.Add(chiTiet);
                        var sp = db.SanPhams.FirstOrDefault(spm => spm.MaSP == s.MaSP);
                        sp.SLTon = sp.SLTon - s.SLMua;
                        db.SaveChanges();
                       
                    }
                }
                MessageBox.Show("Thêm hóa đơn thành công");
            }
        }

        private void dgvHDBanHang_DataSourceChanged(object sender, EventArgs e)
        {
            float tong = 0;
            foreach(SanPhamTam s in list)
            {
                tong += s.Gia * s.SLMua;
            }
            txtTongTien.Text = tong + " VND";
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy đơn hàng", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                foreach (DataGridViewRow row in dgvHDBanHang.Rows)
                {
                    var ma = row.Cells["MaSP"].Value.ToString();
                    var lspt = list.FirstOrDefault(sp => sp.MaSP == ma);
                    list.Remove(lspt);
                }
                HienThi();
                ActiveControl = cboMaHang;
                var s = db.SanPhams.Where(t => t.MaSP == cboMaHang.Text).Select(t => new
                {
                    ten = t.TenSP,
                    dongia = t.Gia,
                    slco = t.SLTon
                }).FirstOrDefault();
                if (s != null)
                {
                    txtTenHang.Text = s.ten;
                    txtDonGiaBan.Text = Convert.ToString(s.dongia);
                    txt_SLCon.Text = Convert.ToString(s.slco);
                }
            }
        }

        private void btn_In_Click(object sender, EventArgs e)
        {
            int rowIndex = 1;
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            excelApp.Application.Workbooks.Add(Type.Missing);

            excelApp.Cells[rowIndex, 1] = "Chi tiết hóa đơn";
            rowIndex++;
            excelApp.Cells[rowIndex, 1] = "Mã hóa đơn: ";
            excelApp.Cells[rowIndex, 2] = txtMaHDBan.Text;
            rowIndex++;
            excelApp.Cells[rowIndex, 1] = "Ngày bán: ";
            excelApp.Cells[rowIndex, 2] = dtp_ngaylap.Text;
            rowIndex++;
            excelApp.Cells[rowIndex, 1] = "Tên khách hàng: ";
            excelApp.Cells[rowIndex, 2] = txtTenKhach.Text;
            rowIndex++;
            excelApp.Cells[rowIndex, 1] = "Địa chỉ KH: ";
            excelApp.Cells[rowIndex, 2] = txtDiaChi.Text;
            rowIndex++;
            excelApp.Cells[rowIndex, 1] = "Số điện thoại KH: ";
            excelApp.Cells[rowIndex, 2] = txtDienThoai.Text;
            rowIndex++;
            excelApp.Cells[rowIndex, 1] = "Nhân viên lập HĐ: ";
            excelApp.Cells[rowIndex, 2] = txtTenNhanVien.Text;
            rowIndex++;
            //header table
            for (int i = 1; i < dgvHDBanHang.Columns.Count + 1; i++)
            {
                excelApp.Cells[rowIndex, i] = dgvHDBanHang.Columns[i - 1].HeaderText;
            }
            rowIndex++;
            //data table
            for (int i = 0; i < dgvHDBanHang.Rows.Count; i++)
            {
                for (int j = 0; j < dgvHDBanHang.Columns.Count; j++)
                {

                    excelApp.Cells[i + rowIndex, j + 1] = dgvHDBanHang.Rows[i].Cells[j].Value.ToString();
                }

            }
            excelApp.Columns.AutoFit();
            excelApp.Visible = true;
        }
    }
   


}
