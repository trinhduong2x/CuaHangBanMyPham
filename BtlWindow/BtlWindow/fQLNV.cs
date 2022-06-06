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
  

    public partial class fQLNV : Form
    {
        private QuanLyMiPhamDBcontext db = new QuanLyMiPhamDBcontext();
        public fQLNV()
        {
            InitializeComponent();
        }
        private void HienThi()
        {
            dgv_NhanVien.DataSource = db.NhanViens.Select(x => new
            {
                MaNV = x.MaNV,
                TenNV = x.TenNV,
                SDT = x.SDT,
                DiaChi = x.DiaChi,
                Luong = x.Luong
            }).ToList();
        }
        public void clear()
        {
            txt_Ma.Text = "";
            txt_Ten.Text = "";
            txt_DT.Text = "";
            txt_Luong.Text = "";
            txt_DC.Text = "";
            ActiveControl = txt_Ten;
        }
        private bool KiemTraLuong()
        {
            decimal d = 0;
            return decimal.TryParse(txt_Luong.Text, out d);
        }
        private bool KiemTraDT()
        {
            decimal d = 0;
            return decimal.TryParse(txt_DT.Text, out d);
        }
        private bool KiemTraTim()
        {
            decimal d = 0;
            return decimal.TryParse(txt_TimSDT.Text, out d);
        }
        private void btn_Thêm_Click(object sender, EventArgs e)
        {
            if (KiemTraLuong() == true && KiemTraDT() == true)
            {
                if (txt_Ma.Text == "" || txt_Ten.Text == "" || txt_DC.Text == "" || txt_DT.Text == "" || txt_Luong.Text == "")
                {
                    MessageBox.Show("vui lòng nhập đủ thông tin", "thông báo");
                }
                else
                {
                    var dt = db.NhanViens.FirstOrDefault(kh => kh.SDT == txt_DT.Text);
                    if (dt != null)
                    {
                        MessageBox.Show("Số điện thoại đã tồn tại");
                        txt_DT.Text = "";
                        ActiveControl = txt_DT;
                        return;
                    }
                    var nhanvien = db.NhanViens.FirstOrDefault(nv => nv.MaNV == txt_Ma.Text);
                    if (nhanvien == null)
                    {
                         nhanvien = new NhanVien()
                        {
                            MaNV = txt_Ma.Text,
                            TenNV = txt_Ten.Text,
                            DiaChi = txt_DC.Text,
                            SDT = txt_DT.Text,
                            Luong = Convert.ToInt32(txt_Luong.Text)
                        };
                        db.NhanViens.Add(nhanvien);

                        db.SaveChanges();
                        HienThi();
                        clear();
                        MessageBox.Show("Nhân viên đã được thêm thành công");
                    }
                    else
                    {
                        MessageBox.Show("Mã nhân viên đã tồn tại");
                        txt_Ma.Text = "";
                        ActiveControl = txt_Ma;
                    }    
                }
            }
            else if (KiemTraLuong() == false && KiemTraDT() == false)
            {
                MessageBox.Show("Nhập số điện thoại và lương là số", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_DT.Text = "";
                txt_Luong.Text = "";
                ActiveControl = txt_Luong;
            }
            else if (KiemTraLuong() == false)
            {
                MessageBox.Show("Nhập lương là số", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Luong.Text = "";
                ActiveControl = txt_Luong;
            }
            else if (KiemTraDT() == false)
            {
                MessageBox.Show("Nhập số điện thoại là số", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_DT.Text = "";
                ActiveControl = txt_DT;
            }

        }

        private void fQLNV_Load(object sender, EventArgs e)
        {
            HienThi();
        }

        private void dgv_NhanVien_SelectionChanged(object sender, EventArgs e)
        {
            var dr = dgv_NhanVien.CurrentRow;
            txt_Ma.Text = dr.Cells["MaNV"].Value.ToString();
            txt_Ten.Text = dr.Cells["TenNV"].Value.ToString();
            txt_DC.Text = dr.Cells["DiaChi"].Value.ToString();
            txt_DT.Text = dr.Cells["SDT"].Value.ToString();
            txt_Luong.Text = dr.Cells["Luong"].Value.ToString();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (KiemTraLuong() == true && KiemTraDT() == true)
            {
                var nhanvien = db.NhanViens.FirstOrDefault(nv => nv.MaNV == txt_Ma.Text);
                if (nhanvien != null)
                {
                    nhanvien.MaNV = txt_Ma.Text;
                    nhanvien.TenNV = txt_Ten.Text;
                    nhanvien.DiaChi = txt_DC.Text;
                    nhanvien.SDT = txt_DT.Text;
                    nhanvien.Luong = Convert.ToInt32(txt_Luong.Text);
                    MessageBox.Show("Nhân viên đã được sửa");
                    db.SaveChanges();
                    HienThi();
                }
                else
                {
                    MessageBox.Show("Phải có mã nhân viên");
                    return;
                }
            }
            else if (KiemTraLuong() == false && KiemTraDT() == false)
            {
                MessageBox.Show("Nhập số điện thoại và lương là số", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_DT.Text = "";
                txt_Luong.Text = "";
                ActiveControl = txt_Luong;
            }
            else if (KiemTraLuong() == false)
            {
                MessageBox.Show("Nhập lương là số", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Luong.Text = "";
                ActiveControl = txt_Luong;
            }
            else if (KiemTraDT() == false)
            {
                MessageBox.Show("Nhập số điện thoại là số", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_DT.Text = "";
                ActiveControl = txt_DT;
            }
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            HienThi();
            txt_TimSDT.Clear();
            clear();
        }

        private void txt_TimSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                if (KiemTraTim())
                {
                    var nv = db.NhanViens.Select(x => new
                    {
                        MaNV = x.MaNV,
                        TenNV = x.TenNV,
                        SDT = x.SDT,
                        DiaChi = x.DiaChi,
                        Luong = x.Luong
                    }).Where(n => n.SDT == txt_TimSDT.Text).ToList();
                    dgv_NhanVien.DataSource = nv;
                    if (dgv_NhanVien.Rows.Count == 0)
                    {
                        MessageBox.Show("Số điện thoại không được tìm thầy.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        HienThi();
                        txt_TimSDT.Clear();
                        ActiveControl = txt_TimSDT;
                    }
                }
                else
                {
                    MessageBox.Show("Nhập số điện thoại là số", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_TimSDT.Text = "";
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
                    for (int i = 0; i < dgv_NhanVien.Rows.Count; i++)
                    {
                        bool IsChecked = dgv_NhanVien.Rows[i].Selected;
                        if (IsChecked)
                        {
                            string id = dgv_NhanVien.Rows[i].Cells[0].Value.ToString();
                            var gvXoa = db.NhanViens.Find(id);
                            db.NhanViens.Remove(gvXoa);
                        }
                        db.SaveChanges();
                    }
                    HienThi();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi " + ex.Message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
