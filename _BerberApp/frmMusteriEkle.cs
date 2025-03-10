using _BerberApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _BerberApp
{
    public partial class frmMusteriEkle : Form
    {
        public frmMusteriEkle()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //TODO : aynı eposta ile eklenmeyecek.

            BerberContext db = new BerberContext();
            //veritabanına hangi nesneyi ekleyeceksem ondan bir nesne oluşturuyorum.

            int telefonSayisi = db.Musteri
                          .Where(x => x.telefon == txtTelefon.Text)
                          .Count();
            if (telefonSayisi > 0)
            {
                MessageBox.Show(txtTelefon.Text + " adlı Telefon kayıtlı");
                return;
            }

            Musteri musteri = new Musteri();

            musteri.ad = txtAd.Text;
            musteri.soyad = txtSoyad.Text;
            musteri.telefon = txtTelefon.Text;
            musteri.kayitTarihi = DateTime.Now;
            musteri.kullaniciID = Program.kullanici.kullaniciID;

            // veritabanında ilgili tabloya eklenmesi.
            db.Musteri.Add(musteri);
            // sorguyu çalıştır.
            db.SaveChanges();
            this.DialogResult = DialogResult.OK; // geriye OK dön
            this.Close(); // Bu formu kapat
        }
    }
}
