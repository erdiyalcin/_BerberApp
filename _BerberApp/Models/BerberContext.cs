using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace _BerberApp.Models
{
    public partial class BerberContext : DbContext
    {
        public BerberContext()
            : base("name=BerberContext")
        {
        }

        public virtual DbSet<Islem> Islem { get; set; }
        public virtual DbSet<Kullanici> Kullanici { get; set; }
        public virtual DbSet<Musteri> Musteri { get; set; }
        public virtual DbSet<Randevu> Randevu { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Yetki> Yetki { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Islem>()
                .Property(e => e.fiyat)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Randevu>()
                .Property(e => e.ucret)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Randevu>()
                .Property(e => e.bahsis)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Yetki>()
                .Property(e => e.ad)
                .IsFixedLength();
        }
    }
}
