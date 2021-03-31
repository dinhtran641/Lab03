namespace Quanlyphongkham.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CV")]
    public partial class CV
    {
        [Key]
        [StringLength(50)]
        public string Chucvu { get; set; }

        public int? CMND { get; set; }

        public bool? Gioitinh { get; set; }

        public int? Sdt { get; set; }

        [StringLength(50)]
        public string Diachi { get; set; }

        [StringLength(10)]
        public string MBS { get; set; }

        public virtual Bacsi Bacsi { get; set; }
    }
}
