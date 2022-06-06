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
    public partial class fQLSP : Form
    {
        public fQLSP()
        {
            InitializeComponent();
        }
        QuanLyMiPhamDBcontext db = new QuanLyMiPhamDBcontext();
        DanhMuc dm = new DanhMuc();
        SanPham sp = new SanPham();
        private bool KiemTraSL()
        {
            decimal d = 0;
            return decimal.TryParse(txt_SL.Text, out d);
        }
        private bool KiemTraGia()
        {
            decimal d = 0;
            return decimal.TryParse(txt_Gia.Text, out d);
        }
        public void clear()
        {
            txt_MaSP.Text = "";
            txt_TenSP.Text = "";
            txt_SL.Text = "";
            txt_Gia.Text = "";
            txt_MoTa.Text = "";
            ActiveControl = txt_MaSP;
        }
       
        private void KhoiToaNCC()
        {
            db.NCCs.Load();
            cbb_NhaCC.DataSource = db.NCCs.Local;
            cbb_NhaCC.DisplayMember = "TenNCC";
            cbb_NhaCC.ValueMember = "MaNCC";
        }
        private void KhoiToaDM()
        {
            db.DanhMucs.Load();
            ccb_DM.DataSource = db.DanhMucs.Local;
            ccb_DM.DisplayMember = "TenDM";
            ccb_DM.ValueMember = "MaDM";
        }
        public void HienThiDM()
        {
            dgv_DM.DataSource = db.DanhMucs.Select(x => new
            {
                MaDM = x.MaDM,
                TenDM = x.TenDM
            }).ToList();
        }
        public void HienThiSP()
        {
            var sp = (from s in db.SanPhams
                      join d in db.DanhMucs on s.MaDM equals d.MaDM
                      join n in db.NCCs on s.MaNCC equals n.MaNCC
                      select new
                      { s.MaSP, s.TenSP, s.SLTon, Danhmuc = d.TenDM, s.Gia, NhaCC = n.TenNCC, s.Mota }).ToList();
            dgv_SanPham.DataSource = sp;
        }
        private void fQLSP_Load(object sender, EventArgs e)
        {
            HienThiDM();
            KhoiToaNCC();
            KhoiToaDM();
            HienThiSP();
        }

        private void dgv_DM_SelectionChanged(object sender, EventArgs e)
        {
            var dr = dgv_DM.CurrentRow;
            txt_MaDM.Text = dr.Cells["MaDM"].Value.ToString();
            txt_TenDM.Text = dr.Cells["TenDM"].Value.ToString();
        }

        private void dgv_SanPham_SelectionChanged(object sender, EventArgs e)
        {
            var dr = dgv_SanPham.CurrentRow;
            txt_MaSP.Text = dr.Cells["MaSP"].Value.ToString();
            txt_TenSP.Text = dr.Cells["TenSP"].Value.ToString();
            txt_SL.Text = dr.Cells["SLTon"].Value.ToString();
            ccb_DM.Text = dr.Cells["Danhmuc"].Value.ToString();
            txt_Gia.Text = dr.Cells["Gia"].Value.ToString();
            cbb_NhaCC.Text = dr.Cells["NhaCC"].Value.ToString();
            txt_MoTa.Text = dr.Cells["Mota"].Value.ToString();
        }

        private void btn_Thêm_Click(object sender, EventArgs e)
        {
            if (txt_MaDM.Text == "" || txt_TenDM.Text == "")
            {
                MessageBox.Show("vui lòng nhập đủ thông tin", "thông báo");
            }
            else
            {
                var ten = db.DanhMucs.FirstOrDefault(t => t.TenDM == txt_TenDM.Text);
                var danhmuc = db.DanhMucs.FirstOrDefault(dm => dm.MaDM == txt_MaDM.Text);
                if(danhmuc != null)
                {
                    MessageBox.Show("Mã danh mục đã tồn tại");
                    txt_MaDM.Text = "";
                    ActiveControl = txt_MaDM;
                }    
                else if (ten != null)
                {
                    MessageBox.Show("Tên danh mục đã tồn tại");
                    txt_TenDM.Text = "";
                    ActiveControl = txt_TenDM;
                }
                else
                {
                    danhmuc = new DanhMuc()
                    {
                        MaDM = txt_MaDM.Text,
                        TenDM = txt_TenDM.Text
                    };
                    db.DanhMucs.Add(danhmuc);
                    db.SaveChanges();
                    HienThiDM();
                    txt_MaSP.Text = "";
                    txt_TenDM.Text = "";
                    ActiveControl = txt_MaDM;
                    MessageBox.Show("Danh mục đã được thêm thành công");
                }
            }    
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (txt_MaDM.Text == "" || txt_TenDM.Text == "")
            {
                MessageBox.Show("vui lòng nhập đủ thông tin để sửa", "thông báo");
            }
            else
            {
                var ten = db.DanhMucs.FirstOrDefault(t => t.TenDM == txt_TenDM.Text);
                var danhmuc = db.DanhMucs.FirstOrDefault(dm => dm.MaDM == txt_MaDM.Text);
                if (danhmuc == null)
                {
                    MessageBox.Show("Nhập đúng mã danh mục để sửa");
                    txt_MaDM.Text = "";
                    ActiveControl = txt_MaDM;
                }
                else if (ten != null)
                {
                    MessageBox.Show("Tên danh mục đã tồn tại");
                    txt_TenDM.Text = "";
                    ActiveControl = txt_TenDM;
                }
                else
                {
                    {
                        danhmuc.MaDM = txt_MaDM.Text;
                        danhmuc.TenDM = txt_TenDM.Text;
                    }
                    db.SaveChanges();
                    HienThiDM();
                    clear();
                    MessageBox.Show("Nhân viên đã được thêm thành công");
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
                    for (int i = 0; i < dgv_DM.Rows.Count; i++)
                    {
                        bool IsChecked = dgv_DM.Rows[i].Selected;
                        if (IsChecked)
                        {
                            string id = dgv_DM.Rows[i].Cells[0].Value.ToString();
                            var dmXoa = db.DanhMucs.Find(id);
                            db.DanhMucs.Remove(dmXoa);
                        }
                        db.SaveChanges();
                    }
                    HienThiDM();
                }    
            }
            catch
            {
                MessageBox.Show("Không xóa được danh mục vì tồn tại sản phẩm của danh mục " , "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_ThemSP_Click(object sender, EventArgs e)
        {
            if (KiemTraGia() == true && KiemTraSL() == true)
            {
                var dm = db.DanhMucs.FirstOrDefault(t => t.TenDM == ccb_DM.Text);
                var ncc = db.NCCs.FirstOrDefault(t => t.TenNCC == cbb_NhaCC.Text);

                var ten = db.SanPhams.FirstOrDefault(t => t.TenSP == txt_TenSP.Text);
                    var sanpham = db.SanPhams.FirstOrDefault(sp => sp.MaSP == txt_MaSP.Text);
                if (sanpham != null)
                {
                    MessageBox.Show("Mã sản phẩm đã tồn tại");
                    txt_MaSP.Text = "";
                    ActiveControl = txt_MaSP;
                }
                else if (ten != null)
                {
                    MessageBox.Show("Tên sản phẩm đã tồn tại");
                    txt_TenSP.Text = "";
                    ActiveControl = txt_TenSP;
                }
                 else if (dm == null)
                {
                    MessageBox.Show("Chọn đúng danh mục có");
                    ActiveControl = ccb_DM;
                }
                else if (ncc == null)
                {
                    MessageBox.Show("Chọn đúng nhà cung cấp");
                    ActiveControl = cbb_NhaCC;
                }
                else
                {
                    try
                    {
                        sanpham = new SanPham()
                        {
                            MaSP = txt_MaSP.Text,
                            TenSP = txt_TenSP.Text,
                            SLTon = Convert.ToInt32(txt_SL.Text),
                            Gia = Convert.ToInt32(txt_Gia.Text),
                            Mota = txt_MoTa.Text,
                            MaDM = Convert.ToString(ccb_DM.SelectedValue),
                            MaNCC = Convert.ToString(cbb_NhaCC.SelectedValue)
                        };
                        db.SanPhams.Add(sanpham);
                        db.SaveChanges();
                        HienThiSP();
                        clear();
                        MessageBox.Show("Sản phẩm đã được thêm thành công");
                    }catch
                    {
                        MessageBox.Show("Chọn sai Danh mục hoặc Sản phẩm. Vui lòng chạy lại chương trình để tiếp tục thêm sản phẩm");
                       
                    }
                }   
            }
            else if (txt_MaSP.Text == "" || txt_TenSP.Text == "" || txt_SL.Text == "" || txt_Gia.Text == "" || ccb_DM.Text == "" || cbb_NhaCC.Text == "")
            {
                MessageBox.Show("vui lòng nhập đủ thông tin", "thông báo");
            }
            else if (KiemTraGia() == false && KiemTraSL() == false)
            {
                MessageBox.Show("Nhập giá và số lượng là số", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Gia.Text = "";
                txt_SL.Text = "";
                ActiveControl = txt_Gia;
            }
            else if (KiemTraGia() == false)
            {
                MessageBox.Show("Nhập giá là số", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Gia.Text = "";
                ActiveControl = txt_Gia;
            }
            else if (KiemTraSL() == false)
            {
                MessageBox.Show("Nhập số điện thoại là số", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_SL.Text = "";
                ActiveControl = txt_SL;
            }
        }

        private void btn_SuaSP_Click(object sender, EventArgs e)
        {
            if (KiemTraGia() == true && KiemTraSL() == true)
            {
                var dm = db.DanhMucs.FirstOrDefault(t => t.TenDM == ccb_DM.Text);
                var ncc = db.NCCs.FirstOrDefault(t => t.TenNCC == cbb_NhaCC.Text);
                var ten = db.SanPhams.FirstOrDefault(t => t.TenSP == txt_TenSP.Text);
                var sanpham = db.SanPhams.FirstOrDefault(sp => sp.MaSP == txt_MaSP.Text);
                if (sanpham == null)
                {
                    MessageBox.Show("Chọn sản phẩm để sửa");
                    txt_MaSP.Text = "";
                    ActiveControl = txt_MaSP;
                }
               
                else
                {
                    try
                    {
                        sanpham.MaSP = txt_MaSP.Text;
                        sanpham.TenSP = txt_TenSP.Text;
                        sanpham.SLTon = Convert.ToInt32(txt_SL.Text);
                        sanpham.Gia = Convert.ToInt32(txt_Gia.Text);
                        sanpham.Mota = txt_MoTa.Text;
                        sanpham.MaDM = Convert.ToString(ccb_DM.SelectedValue);
                        sanpham.MaNCC = Convert.ToString(cbb_NhaCC.SelectedValue);
                     
                         if (dm == null)
                        {
                            MessageBox.Show("Chọn đúng danh mục có");
                            ActiveControl = ccb_DM;
                            return;
                        }
                        else if (ncc == null)
                        {
                            MessageBox.Show("Chọn đúng nhà cung cấp");
                            ActiveControl = cbb_NhaCC;
                            return;
                        }
                        db.SaveChanges();
                        HienThiSP();
        
                        MessageBox.Show("Sản phẩm đã được sửa thành công");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Có lỗi ở Danh mục hoặc Sản phẩm. Vui lòng chạy lại chương trình" + ex.Message);
                        return;
                    }
                }
            }
            else if (txt_MaSP.Text == "" || txt_TenSP.Text == "" || txt_SL.Text == "" || txt_Gia.Text == "" || ccb_DM.Text == "" || cbb_NhaCC.Text == "")
            {
                MessageBox.Show("vui lòng nhập đủ thông tin", "thông báo");
            }
            else if (KiemTraGia() == false && KiemTraSL() == false)
            {
                MessageBox.Show("Nhập giá và số lượng là số", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Gia.Text = "";
                txt_SL.Text = "";
                ActiveControl = txt_Gia;
            }
            else if (KiemTraGia() == false)
            {
                MessageBox.Show("Nhập giá là số", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Gia.Text = "";
                ActiveControl = txt_Gia;
            }
            else if (KiemTraSL() == false)
            {
                MessageBox.Show("Nhập số điện thoại là số", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_SL.Text = "";
                ActiveControl = txt_SL;
            }
        }

        private void btn_XoaSP_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    for (int i = 0; i < dgv_SanPham.Rows.Count; i++)
                    {
                        bool IsChecked = dgv_SanPham.Rows[i].Selected;
                        if (IsChecked)
                        {
                            string id = dgv_SanPham.Rows[i].Cells[0].Value.ToString();
                            var spXoa = db.SanPhams.Find(id);
                            db.SanPhams.Remove(spXoa);
                        }
                        db.SaveChanges();
                    }
                    HienThiSP();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi " + ex.Message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_HuySP_Click(object sender, EventArgs e)
        {
            HienThiSP();
            txt_Tim.Clear();
            clear();
        }

        private void txt_Tim_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                var sp = (from s in db.SanPhams
                          join d in db.DanhMucs on s.MaDM equals d.MaDM
                          join n in db.NCCs on s.MaNCC equals n.MaNCC
                          select new
                          { s.MaSP, s.TenSP, s.SLTon, Danhmuc = d.TenDM, s.Gia, NhaCC = n.TenNCC, s.Mota }).Where(s => s.MaSP == txt_Tim.Text).ToList();
                dgv_SanPham.DataSource = sp;
                if (dgv_SanPham.Rows.Count == 0)
                {
                    MessageBox.Show("Mã sản phẩm không được tìm thầy.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    HienThiSP();
                    txt_Tim.Clear();
                    ActiveControl = txt_Tim;
                }
            }    
        }
    }
}
