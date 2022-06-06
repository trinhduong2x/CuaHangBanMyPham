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
    public partial class fManager : Form
    {
        public TaiKhoan user;
        QuanLyMiPhamDBcontext db = new QuanLyMiPhamDBcontext();
        public fManager(TaiKhoan x)
        {
            InitializeComponent();
            user = x;
        }

        public fManager()
        {
        }

        public void checkTag(int index)
        {
            string tabName = tabControl1.TabPages[index].Name;
             if (tabName == "tabTHD")
            {
                fKiemTraKH f = new fKiemTraKH(user);
                f.TopLevel = false;
                f.Dock = DockStyle.Fill;
                f.FormBorderStyle = FormBorderStyle.None;
                f.Parent = tabControl1.SelectedTab;
                f.Show();
            }
            else if (tabName == "tabQLSP")
            {
                fQLSP f = new fQLSP();
                f.TopLevel = false;
                f.Dock = DockStyle.Fill;
                f.FormBorderStyle = FormBorderStyle.None;
                f.Parent = tabControl1.SelectedTab;
                f.Show();
            }
            else if (tabName == "tabQLNCC")
            {
                fQLNCC f = new fQLNCC();
                f.TopLevel = false;
                f.Dock = DockStyle.Fill;
                f.FormBorderStyle = FormBorderStyle.None;
                f.Parent = tabControl1.SelectedTab;
                f.Show();
            }
            else if (tabName == "tabQLHD")
            {
                fQLHD f = new fQLHD(user);
                f.TopLevel = false;
                f.Dock = DockStyle.Fill;
                f.FormBorderStyle = FormBorderStyle.None;
                f.Parent = tabControl1.SelectedTab;
                f.Show();
            }
            else if (tabName == "tabQLKH")
            {
                fQLKH f = new fQLKH(user);
                f.TopLevel = false;
                f.Dock = DockStyle.Fill;
                f.FormBorderStyle = FormBorderStyle.None;
                f.Parent = tabControl1.SelectedTab;
                
                f.Show();
            }
            else if (tabName == "tabQLTK")
            {
                fQLTK f = new fQLTK();
                f.TopLevel = false;
                f.Dock = DockStyle.Fill;
                f.FormBorderStyle = FormBorderStyle.None;
                f.Parent = tabControl1.SelectedTab;
                f.Show();
            }
            else if (tabName == "tabQLNV")
            {
                fQLNV f = new fQLNV();
                f.TopLevel = false;
                f.Dock = DockStyle.Fill;
                f.FormBorderStyle = FormBorderStyle.None;
                f.Parent = tabControl1.SelectedTab;
                f.Show();
            }
        }
        private void fManager_Load(object sender, EventArgs e)
        {
           
            string role;
            if (user.Role == true)
            {
                role = "quản lý";
            }
            else
            {
                role = "nhân viên";
                tabControl1.Controls.Remove(tabControl1.TabPages["tabQLNV"]);
                tabControl1.Controls.Remove(tabControl1.TabPages["tabQLTK"]);

            }
           
            {
                string manv = user.NhanVien.MaNV;
                var nv = db.NhanViens.Where(s => s.MaNV == manv).Select(s => s).FirstOrDefault();
                lbl_ChaoMung.Text = "Xin chào " + nv.TenNV + ", Chức vụ: " + role;
                checkTag(tabControl1.SelectedIndex);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = tabControl1.SelectedIndex;
            checkTag(index);
        }

        private void fManager_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            Close();
        }

        private void tabTHD_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://myphamthiennhien.com/");
        }
    }
}
