namespace Quanlyphongkham.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Bacsi")]
    public partial class Bacsi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Bacsi()
        {
            CVs = new HashSet<CV>();
        }

        [Key]
        [StringLength(10)]
        public string MBS { get; set; }

        [StringLength(50)]
        public string TenBS { get; set; }

        public int? Tuoi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CV> CVs { get; set; }
    }
}
