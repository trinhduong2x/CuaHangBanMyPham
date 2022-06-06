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
    public partial class fKiemTraKH : Form
    {
        TaiKhoan tk = new TaiKhoan();
       
        public fKiemTraKH( TaiKhoan x)
        {
            InitializeComponent();
            tk = x;
        }
        public fKiemTraKH(TaiKhoan x, string sdt)
        {
            InitializeComponent();
            tk = x;
            txtSDT.Text = sdt;
        }
        private void btn_KiemTra_Click(object sender, EventArgs e)
        {
            string sdt = txtSDT.Text;
            if(string.IsNullOrWhiteSpace(sdt))
            {
                MessageBox.Show("Nhập số điện thoại");
                return;
            }    
            using (QuanLyMiPhamDBcontext db = new QuanLyMiPhamDBcontext())
            {
                var kh = db.KhachHangs.Select(s => s).Where(s => s.SDT == sdt).FirstOrDefault();
                if(kh == null)
                {
                    fQLKH form = new fQLKH(sdt, tk);
                    form.ShowDialog();
                    List<KhachHang> k = db.KhachHangs.ToList();
                    KhachHang newKH = k[k.Count - 1];
                    fTrangChu f = new fTrangChu(newKH, tk);
                    f.ShowDialog();
                    Close();
                }
                else
                {
                    fTrangChu f = new fTrangChu((KhachHang)kh, tk);
                    f.ShowDialog();
                    Close();
                }
            }    
        }

        private void fKiemTraKH_Load(object sender, EventArgs e)
        {

        }
    }
}
