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
    public partial class frmKullaniciDuzenle : Form
    {
        public int kullaniciID { get; set; }
        public frmKullaniciDuzenle()
        {
            InitializeComponent();
        }

        private void frmKullaniciDuzenle_Load(object sender, EventArgs e)
        {
            // veritabanı işlemleri yapmak için context sınıfından bir nesne oluşturduk.
            BerberContext db = new BerberContext();
            // Veritabanındaki bilgilere göre combobox dolduruldu.
            var liste = db.Yetki.ToList();
            cbYetki.DataSource = liste;
            cbYetki.DisplayMember = "ad"; // Görünecek olan sütun adı
            cbYetki.ValueMember = "yetkiID"; // Value ile çekilecek sütunun adı

            //düzenlenecek kişin bilgilerini veritabanından çek
            Kullanici kullanici = db.Kullanici
                                  .Where(x=> x.kullaniciID == kullaniciID)
                                  .SingleOrDefault();
            //kullanıcının bilgilerini ilgili alanlara doldur.
            txtAd.Text = kullanici.ad;
            txtSoyad.Text = kullanici.soyad;
            txtEposta.Text = kullanici.eposta;
            txtSifre.Text = kullanici.sifre;
            cbYetki.SelectedValue = (int)kullanici.yetkiID;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            BerberContext db = new BerberContext();
            //veritabanından ilgili kayıdı çek
            Kullanici kullanici = db.Kullanici
                                  .Where(x => x.kullaniciID == kullaniciID)
                                  .SingleOrDefault();

            // ilgili inputlardan içeriği doldurulur.
            kullanici.ad = txtAd.Text;
            kullanici.soyad = txtSoyad.Text;
            kullanici.eposta = txtEposta.Text;
            kullanici.sifre = txtSifre.Text;
            //kullanici.yetkiID = Convert.ToInt32(txtYetkiID.Text);
            kullanici.yetkiID = (int)cbYetki.SelectedValue;

            // sorguyu çalıştır.
            db.SaveChanges();
            this.DialogResult = DialogResult.OK; // geriye OK dön
            this.Close(); // Bu formu kapat
        }
    }
}
