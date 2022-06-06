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
    public partial class fQLNCC : Form
    {
        QuanLyMiPhamDBcontext db = new QuanLyMiPhamDBcontext();
        public fQLNCC()
        {
            InitializeComponent();
        }
        private bool KiemTraDT()
        {
            decimal d = 0;
            return decimal.TryParse(txt_DT.Text, out d);
        }
        private void HienThi()
        {
            dataGridView1.DataSource = db.NCCs.Select(x => new
            {
                MaNCC = x.MaNCC,
                TenNCC = x.TenNCC,
                SDT = x.SDT,
                DiaChi = x.DiaChi
            }).ToList();
        }
        public void clear()
        {
            txt_MaNCC.Text = "";
            txt_Ten.Text = "";
            txt_DT.Text = "";
            txt_DC.Text = "";
            txt_TimMa.Text = "";
            ActiveControl = txt_MaNCC;
        }

        private void fQLNCC_Load(object sender, EventArgs e)
        {
            HienThi();
        }

        private void btn_Thêm_Click(object sender, EventArgs e)
        {
            if(KiemTraDT())
            {
                if (txt_Ten.Text == "" || txt_DC.Text == "" || txt_DT.Text == "" || txt_MaNCC.Text == "")
                {
                    MessageBox.Show("vui lòng nhập đủ thông tin", "thông báo");
                }
                else
                {
                    var ten = db.NCCs.FirstOrDefault(kh => kh.TenNCC == txt_Ten.Text);
                    if (ten != null)
                    {
                        MessageBox.Show("Tên nhà cung cấp đã tồn tại");
                        txt_Ten.Text = "";
                        ActiveControl = txt_Ten;
                        return;
                    }
                    var dt = db.NCCs.FirstOrDefault(kh => kh.SDT == txt_DT.Text);
                    if (dt != null)
                    {
                        MessageBox.Show("Số điện thoại đã tồn tại");
                        txt_DT.Text = "";
                        ActiveControl = txt_DT;
                        return;
                    }
                    var nhaCC = db.NCCs.FirstOrDefault(ncc => ncc.MaNCC == txt_MaNCC.Text);
                    if(nhaCC == null)
                    {
                        nhaCC = new NCC()
                        {
                            MaNCC = txt_MaNCC.Text,
                            TenNCC = txt_Ten.Text,
                            DiaChi = txt_DC.Text,
                            SDT = txt_DT.Text
                        };
                        db.NCCs.Add(nhaCC);
                        db.SaveChanges();
                        clear();
                        HienThi();
                        MessageBox.Show("Nhà cung cấp đã thêm thành công");
                    }    
                    else
                    {
                        MessageBox.Show("Mã nhà cung cấp đã tồn tại");
                        txt_MaNCC.Text = "";
                        ActiveControl = txt_MaNCC;
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
            txt_MaNCC.Text = dr.Cells["MaNCC"].Value.ToString();
            txt_Ten.Text = dr.Cells["TenNCC"].Value.ToString();
            txt_DC.Text = dr.Cells["DiaChi"].Value.ToString();
            txt_DT.Text = dr.Cells["SDT"].Value.ToString();
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            clear();
            ActiveControl = txt_MaNCC;
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (KiemTraDT())
            {
                if (txt_Ten.Text == "" || txt_DC.Text == "" || txt_DT.Text == "" || txt_MaNCC.Text == "")
                {
                    MessageBox.Show("vui lòng nhập đủ thông tin", "thông báo");
                }
                else
                {
                    var nhaCC = db.NCCs.FirstOrDefault(ncc => ncc.MaNCC == txt_MaNCC.Text);
                    if (nhaCC != null)
                    {
                        nhaCC.MaNCC = txt_MaNCC.Text;
                        nhaCC.TenNCC = txt_Ten.Text;
                        nhaCC.DiaChi = txt_DC.Text;
                        nhaCC.SDT = txt_DT.Text;
                        MessageBox.Show("Nhà cung cấp đã được sửa");
                        db.SaveChanges();
                        HienThi();
                    }    
                    else
                    {
                        MessageBox.Show("Phải có mã nhà cung cấp");
                        return;
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
                            var nccXoa = db.NCCs.Find(id);
                            db.NCCs.Remove(nccXoa);
                        }
                        db.SaveChanges();
                    }
                    HienThi();
                }    
            }
            catch(Exception ex)
            {
                MessageBox.Show("Sản phẩm của nhà cung cấp đang tồn tại " + ex.Message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void txt_TimMa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                if(txt_TimMa.Text == "")
                {
                    MessageBox.Show("Không để trống");
                }    
                else
                {
                    var ncc = db.NCCs.Select(x => new
                    {
                        MaNCC = x.MaNCC,
                        TenNCC = txt_Ten.Text,
                        DiaChi = txt_DC.Text,
                        SDT = txt_DT.Text
                    }).Where(n => n.MaNCC == txt_TimMa.Text).ToList();
                    dataGridView1.DataSource = ncc;
                    if(dataGridView1.Rows.Count == 0)
                    {
                        MessageBox.Show("Mã nhà cung cấp không được tìm thầy.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        HienThi();
                        txt_TimMa.Clear();
                        ActiveControl = txt_TimMa;
                    }    
                }    
            }    
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
