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
    public partial class fDangNhap : Form
    {
        QuanLyMiPhamDBcontext db;
        public fDangNhap()
        {
            InitializeComponent();
            db = new QuanLyMiPhamDBcontext(); 

        }

        private void fDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "admin" && txtPassword.Text == "admin")
            {
                TaiKhoan taiKhoan = new TaiKhoan();
                fManager f = new fManager(taiKhoan);
                this.Hide();
                f.ShowDialog();
                this.Show();
                txtPassword.Text = "";
                ActiveControl = txtUser;
            }
            string username = txtUser.Text;
            using (var db = new QuanLyMiPhamDBcontext())
            {
                if (string.IsNullOrWhiteSpace(txtUser.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    MessageBox.Show("Bạn phải nhập đầy đủ các trường", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                TaiKhoan user = checkUserName(username);
                if (user == null)
                {
                    MessageBox.Show("Người dùng không tồn tại");
                    ActiveControl = txtUser;
                }
                else if (user.PassWord != txtPassword.Text)
                {
                    MessageBox.Show("Không đúng mật khẩu");
                    ActiveControl = txtPassword;
                }
                else
                {
                    fManager f = new fManager(user);
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                    txtPassword.Text = "";
                    ActiveControl = txtUser;
                }
            }
        }
        public TaiKhoan checkUserName(string username)
        {
            TaiKhoan x;
            x = db.TaiKhoans.Where(p => p.UserName == username).Select(p => p).FirstOrDefault();
            return x;
        }
        private void chkShowPW_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPW.Checked == true)
            {
                chkShowPW.Text = "Ẩn mật khẩu";
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                chkShowPW.Text = "Hiện mật khẩu";
                txtPassword.PasswordChar = '*';
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                btnLogin_Click(sender,e);
        }
    }
}
