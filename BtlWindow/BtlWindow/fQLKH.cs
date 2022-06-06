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
    public partial class fQLKH : Form
    {
        QuanLyMiPhamDBcontext db = new QuanLyMiPhamDBcontext();
        KhachHang kh = new KhachHang();
        TaiKhoan user;
        string sdt = "";
        public fQLKH()
        {
            InitializeComponent();
        }
        public fQLKH(TaiKhoan x)
        {
            InitializeComponent();
            user = x;
        }
        public fQLKH(string sd, TaiKhoan x)
        {
            InitializeComponent();
            sdt = sd;
            user = x;
        }
        private bool KiemTraDT()
        {
            decimal d = 0;
            return decimal.TryParse(txt_DT.Text, out d);
        }
        private bool KiemTraTim()
        {
            decimal d = 0;
            return decimal.TryParse(txt_Tim.Text, out d);
        }
        public void HienThi()
        {
            var kh = db.KhachHangs.Select(x => new
            {
                MaKH = x.MaKH,
                TenKH = x.TenKH,
                SDT = x.SDT,
                DiaChi = x.DiaChi
            }).ToList();
            dataGridView1.DataSource = kh;
        }
        public void clear()
        {
            txt_MaKH.Text = "";
            txt_Ten.Text = "";
            txt_DT.Text = "";
            txt_DC.Text = "";
            ActiveControl = txt_MaKH;
        }
        private void fQLKH_Load(object sender, EventArgs e)
        {
            HienThi();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if(KiemTraDT())
            {
                if (txt_Ten.Text == "" || txt_DC.Text == "" || txt_DT.Text == "" || txt_MaKH.Text == "")
                {
                    MessageBox.Show("vui lòng nhập đủ thông tin", "thông báo");
                }
                else
                {
                    var dt = db.KhachHangs.FirstOrDefault(kh => kh.SDT == txt_DT.Text);
                    if(dt != null)
                    {
                        MessageBox.Show("Số điện thoại đã tồn tại");
                        txt_DT.Text = "";
                        ActiveControl = txt_DT;
                        return;
                    }
                    var khachhang = db.KhachHangs.FirstOrDefault(k => k.MaKH == txt_MaKH.Text);
                    if (khachhang != null)
                    {
                        MessageBox.Show("Mã nhân viên đã tồn tại");
                        txt_MaKH.Text = "";
                        ActiveControl = txt_MaKH;
                    }
                    if (khachhang == null)
                    {
                        khachhang = new KhachHang()
                        {
                            MaKH = txt_MaKH.Text,
                            TenKH = txt_Ten.Text,
                            DiaChi = txt_DC.Text,
                            SDT = txt_DT.Text
                        };
                        db.KhachHangs.Add(khachhang);
                        db.SaveChanges();
                        HienThi();
                        MessageBox.Show("Khách hàng đã được thêm");
                    }    
                   
                }    
            }   
            else
            {
                MessageBox.Show("Nhập số điện thoại là số", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_DT.Text = "";
                ActiveControl = txt_DT;
            }    
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            var dr = dataGridView1.CurrentRow;
            txt_MaKH.Text = dr.Cells["MaKH"].Value.ToString();
            txt_Ten.Text = dr.Cells["TenKH"].Value.ToString();
            txt_DT.Text = dr.Cells["SDT"].Value.ToString();
            txt_DC.Text = dr.Cells["DiaChi"].Value.ToString();
        }

        private void txt_Tim_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar ==  '\r')
            {
                if(KiemTraTim())
                {
                    var kh = db.KhachHangs.Select(k => new
                    {
                        MaKH = k.MaKH,
                        TenKH = k.TenKH,
                        SDT = k.SDT,
                        DiaChi = k.DiaChi
                    }).Where(n => n.SDT == txt_Tim.Text).ToList();
                    dataGridView1.DataSource = kh;
                    if(dataGridView1.Rows.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy khách hàng");
                        HienThi();
                        txt_Tim.Clear();
                        ActiveControl = txt_Tim;
                    }
                }
                else
                {
                    MessageBox.Show("Nhập số điện thoại là số", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_Tim.Text = "";
                }
            }
           
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    for(int i = 0; i< dataGridView1.Rows.Count; i++)
                    {
                        bool IsChecked = dataGridView1.Rows[i].Selected;
                        if(IsChecked)
                        {
                            string id = dataGridView1.Rows[i].Cells[0].Value.ToString();
                            var khXoa = db.KhachHangs.Find(id);
                            db.KhachHangs.Remove(khXoa);
                        }
                        db.SaveChanges();
                    }
                    HienThi();
                }    
            }
            catch(Exception ex)
            {
                MessageBox.Show("Có lỗi " + ex.Message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            clear();
            ActiveControl = txt_MaKH;
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (KiemTraDT())
            {
                if (txt_Ten.Text == "" || txt_DC.Text == "" || txt_DT.Text == "" || txt_MaKH.Text == "")
                {
                    MessageBox.Show("vui lòng nhập đủ thông tin", "thông báo");
                }
                else
                {
                    var dt = db.KhachHangs.FirstOrDefault(kh => kh.SDT == txt_DT.Text);
                    if (dt != null)
                    {
                        MessageBox.Show("Số điện thoại đã tồn tại");
                        txt_DT.Text = "";
                        ActiveControl = txt_DT;
                        return;
                    }
                    var khachhang = db.KhachHangs.FirstOrDefault(k => k.MaKH == txt_MaKH.Text);
                    if (khachhang == null)
                    {
                        MessageBox.Show("Vui lòng chọn khách hàng sửa");
                        ActiveControl = dataGridView1;
                    }
                    if(khachhang != null)
                    {
                        khachhang.MaKH = txt_MaKH.Text;
                        khachhang.TenKH = txt_Ten.Text;
                        khachhang.DiaChi = txt_DC.Text;
                        khachhang.SDT = txt_DT.Text;
                        MessageBox.Show("Thông tin khách hàng đã được sửa");
                        db.SaveChanges();
                        HienThi();
                    }    
                }
            }
            else
            {
                MessageBox.Show("Nhập số điện thoại là số", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_DT.Text = "";
                ActiveControl = txt_DT;
            }    
        }

        private void btn_LapHD_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow viewRow = dataGridView1.CurrentRow;
                string sdt = viewRow.Cells[2].Value.ToString();
                var kh = db.KhachHangs.Select(s => s).Where(s => s.SDT == sdt).FirstOrDefault();
              
                fTrangChu form = new fTrangChu((KhachHang) kh, user);
                form.ShowDialog();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fQLKH_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
