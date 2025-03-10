namespace _BerberApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Islem")]
    public partial class Islem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Islem()
        {
            Randevu = new HashSet<Randevu>();
        }

        public int islemID { get; set; }

        [StringLength(50)]
        public string ad { get; set; }

        [Column(TypeName = "money")]
        public decimal? fiyat { get; set; }

        public int? sure { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Randevu> Randevu { get; set; }
    }
}
