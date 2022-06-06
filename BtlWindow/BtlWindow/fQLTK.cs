using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BtlWindow
{
    public partial class fQLTK : Form
    {
        public QuanLyMiPhamDBcontext db = new QuanLyMiPhamDBcontext();
        public fQLTK()
        {
            InitializeComponent();
        }
     
        public void clear()
        {
            rdb_Admin.Checked = true;
            txt_pw.Text = txt_User.Text = "";
            ActiveControl = txt_User;
        }
        public void HienThi()
        {
            var tk = db.TaiKhoans.Select(t => new
            {
                t.UserName,t.PassWord,t.MaNV,t.Role
            }).ToList();
            dataGridView1.DataSource = tk;
           
        }
        private void KhoiToaNhanVien()
        {
            db.NhanViens.Load();
            ccb_NV.DataSource = db.NhanViens.Local;
            ccb_NV.DisplayMember = "MaNV";
            ccb_NV.ValueMember = "MaNV";
        }
        private void fQLTK_Load(object sender, EventArgs e)
        {
            KhoiToaNhanVien();
            HienThi();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            var dr = dataGridView1.CurrentRow;
            txt_User.Text = dr.Cells["UserName"].Value.ToString();
            txt_pw.Text = dr.Cells["PassWord"].Value.ToString();
            ccb_NV.Text = dr.Cells["MaNV"].Value.ToString();
            if(Convert.ToBoolean(dr.Cells["Role"].Value) == true)
            {
                rdb_Admin.Checked = true;
                rdb_Staff.Checked = false;
            }
            if (Convert.ToBoolean(dr.Cells["Role"].Value) == false)
            {
                rdb_Admin.Checked = false;
                rdb_Staff.Checked = true;
            }    

        }

        private void ccb_NV_SelectedIndexChanged(object sender, EventArgs e)
        {
            var nv = db.NhanViens.Where(t => t.MaNV == ccb_NV.Text).Select(t => new
            {
                ten = t.TenNV,
                SDT = t.SDT,
                DC = t.DiaChi
            }).FirstOrDefault();
            if(nv != null)
            {
                lblTenNV.Text = nv.ten;
                lblDT.Text = nv.SDT;
                lblDC.Text = nv.DC;
            }    
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    var taikhoan = db.TaiKhoans.FirstOrDefault(tk => tk.UserName == txt_User.Text);
                    if(taikhoan != null)
                    {
                        db.TaiKhoans.Remove(taikhoan);
                        db.SaveChanges();
                        HienThi();
                    }    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi " + ex.Message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Tao_Click(object sender, EventArgs e)
        {
          
             if(String.IsNullOrWhiteSpace(txt_User.Text))
            {
                MessageBox.Show("Nhập tên tài khoản");
                ActiveControl = txt_User;
            }
            else if (String.IsNullOrWhiteSpace(txt_pw.Text))
            {
                MessageBox.Show("Nhập mật khẩu");
                ActiveControl = txt_pw;
            }
            else if (String.IsNullOrWhiteSpace(txt_User.Text) == true && String.IsNullOrWhiteSpace(txt_pw.Text) == true)
            {
                MessageBox.Show("Nhập tên tài khoản và mật khẩu");
                ActiveControl = txt_User;
            }
          else
                 
            {

                var tk = db.TaiKhoans.Where(t => t.UserName == txt_User.Text).FirstOrDefault();
                {
                    if (tk != null)
                    {
                        MessageBox.Show("Tên tài khoản đã tồn tại");
                        ActiveControl = txt_User;
                        return;
                    }
                }
                var n = db.NhanViens.Where(t => t.MaNV == ccb_NV.Text).FirstOrDefault();
                {
                    if(n == null)
                    {
                        MessageBox.Show("Chọn đúng nhân viên");
                        ActiveControl = ccb_NV;
                        return;
                    }    
                }

                var nv = db.TaiKhoans.Where(t => t.MaNV == ccb_NV.Text).FirstOrDefault();
                    {
                        if (nv != null)
                        {
                            MessageBox.Show("Nhân viên đã có tài khoản");
                            ActiveControl = ccb_NV;
                            return;
                        }
                    }
                    bool Role = true;
                    if (rdb_Staff.Checked == true)
                    {
                        Role = false;
                    }
               
                try
                {
                    var TaiKhoanMoi = new TaiKhoan()
                    {
                        UserName = txt_User.Text,
                        PassWord = txt_pw.Text,
                        Role = Role,
                        MaNV = ccb_NV.SelectedValue.ToString()
                    };
                    db.TaiKhoans.Add(TaiKhoanMoi);
                    db.SaveChanges();
                    HienThi();
                    clear();
                    MessageBox.Show("Tài khoản đã được thêm thành công");
                }
                catch
                {
                    MessageBox.Show("Bạn đã chọn nhân viên sai. Vui lòng chạy lại chương trình để thêm được tài khoản ");
                }
               
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }
    }
}
