namespace _BerberApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Randevu")]
    public partial class Randevu
    {
        public int randevuID { get; set; }

        public int? musteriID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? randevuTarihi { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? kayitTarihi { get; set; }

        public int? kullaniciID { get; set; }

        public int? islemID { get; set; }

        [Column(TypeName = "money")]
        public decimal? ucret { get; set; }

        [Column(TypeName = "money")]
        public decimal? bahsis { get; set; }

        public bool? geldiMi { get; set; }

        public virtual Islem Islem { get; set; }

        public virtual Kullanici Kullanici { get; set; }

        public virtual Musteri Musteri { get; set; }
    }
}
