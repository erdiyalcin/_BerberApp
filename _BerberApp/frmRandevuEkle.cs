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
    public partial class frmRandevuEkle : Form
    {
        public int musteriID;
        public string adSoyad;
        public frmRandevuEkle()
        {
            InitializeComponent();
        }

        private void frmRandevuEkle_Load(object sender, EventArgs e)
        {
            lblMusteri.Text = adSoyad;

            // combobox ı doldur
            BerberContext db = new BerberContext();
            var liste = db.Islem.ToList();

            Islem secinizIslemi = new Islem() { islemID = 0, ad = "Seçiniz", fiyat=0 };
            liste.Insert(0, secinizIslemi);

            cbIslem.DataSource = liste;
            cbIslem.DisplayMember = "ad"; // Görünecek olan sütun adı
            cbIslem.ValueMember = "islemID"; // Value ile çekilecek sütunun adı
        }

        private void cbIslem_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Combobox değiştiği zaman tetiklenecek.
            Islem islem = cbIslem.SelectedItem as Islem;
            txtUcret.Text = $"{islem.fiyat:F2}";
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (cbIslem.SelectedIndex == 0)
            {
                MessageBox.Show("Lütfen bir işlem seçiniz.");
                return;
            }


            //TODO : aynı eposta ile eklenmeyecek.

            BerberContext db = new BerberContext();
            //veritabanına hangi nesneyi ekleyeceksem ondan bir nesne oluşturuyorum.

            Randevu randevu = new Randevu();
            randevu.musteriID = musteriID;// diğer formdan gönderildi.
            randevu.randevuTarihi = dtpRandevuTarihi.Value;
            randevu.islemID = (int)cbIslem.SelectedValue;
            randevu.ucret = Convert.ToDecimal(txtUcret.Text);
            randevu.bahsis = Convert.ToDecimal(txtBahsis.Text);
            randevu.geldiMi = chkGeldiMi.Checked;
            randevu.kullaniciID = Program.kullanici.kullaniciID;
            randevu.kayitTarihi = DateTime.Now;

            // veritabanında ilgili tabloya eklenmesi.
            db.Randevu.Add(randevu);
            // sorguyu çalıştır.
            db.SaveChanges();
            this.DialogResult = DialogResult.OK; // geriye OK dön
            this.Close(); // Bu formu kapat
        }
    }
}
