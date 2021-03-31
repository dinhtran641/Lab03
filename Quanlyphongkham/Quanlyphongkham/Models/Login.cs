namespace Quanlyphongkham.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Login")]
    public partial class Login
    {
        [Key]
        [Column("Tài khoản")]
        [StringLength(10)]
        public string Tài_khoản { get; set; }

        [Column("Mật khẩu")]
        [StringLength(10)]
        public string Mật_khẩu { get; set; }
    }
}
