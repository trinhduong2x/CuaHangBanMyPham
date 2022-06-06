using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtlWindow
{
    class SanPhamTonTam
    {
        public string masp { get; set; }
        public string tensp { get; set; }
        public int slton { get; set; }
        public float gia { get; set; }
       

        public SanPhamTonTam()
        {

        }

        public SanPhamTonTam(string masp, string tensp, int slton, float gia)
        {
            this.masp = masp;
            this.tensp = tensp;
            this.slton = slton;
            this.gia = gia;
           
        }
    }
}
