namespace BtlWindow
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TaiKhoan")]
    public partial class TaiKhoan
    {
        public int ID { get; set; }

        [StringLength(10)]
        public string MaNV { get; set; }

        [StringLength(30)]
        public string UserName { get; set; }

        [StringLength(30)]
        public string PassWord { get; set; }

        public bool? Role { get; set; }

        public virtual NhanVien NhanVien { get; set; }
    }
}
