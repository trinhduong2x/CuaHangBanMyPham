using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtlWindow
{
    class SanPhamTam
    {
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public int SLMua { get; set; }
        public float Gia { get; set; }
        public double TongTien { get; set; }
        public SanPhamTam()
        {

        }
        public SanPhamTam(string MaSP, string TenSP, int SLMua, float Gia)
        {
            this.MaSP = MaSP;
            this.TenSP = TenSP;
            this.SLMua = SLMua;
            this.Gia = Gia;

        }
    }
}
