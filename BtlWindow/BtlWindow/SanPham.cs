namespace BtlWindow
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SanPham")]
    public partial class SanPham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SanPham()
        {
            ChiTietHDs = new HashSet<ChiTietHD>();
        }

        [Key]
        [StringLength(10)]
        public string MaSP { get; set; }

        [Required]
        [StringLength(10)]
        public string MaDM { get; set; }

        [Required]
        [StringLength(10)]
        public string MaNCC { get; set; }

        [Required]
        [StringLength(30)]
        public string TenSP { get; set; }

        public int Gia { get; set; }

        public int SLTon { get; set; }

        [Column(TypeName = "ntext")]
        public string Mota { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietHD> ChiTietHDs { get; set; }

        public virtual DanhMuc DanhMuc { get; set; }

        public virtual NCC NCC { get; set; }
    }
}
