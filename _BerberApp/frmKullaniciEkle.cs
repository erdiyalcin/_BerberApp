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
    public partial class frmKullaniciEkle : Form
    {
        public frmKullaniciEkle()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //TODO : aynı eposta ile eklenmeyecek.

            BerberContext db = new BerberContext();
            //veritabanına hangi nesneyi ekleyeceksem ondan bir nesne oluşturuyorum.

            int epostaSayisi = db.Kullanici
                          .Where(x => x.eposta == txtEposta.Text)
                          .Count();
            if(epostaSayisi >0)
            {
                MessageBox.Show(txtEposta.Text + " adlı E-posta kayıtlı");
                return;
            }
            Kullanici kullanici = new Kullanici();
            // ilgili inputlardan içeriği doldurulur.
            kullanici.ad = txtAd.Text;
            kullanici.soyad = txtSoyad.Text;
            kullanici.eposta = txtEposta.Text;
            kullanici.sifre = txtSifre.Text;
            //kullanici.yetkiID = Convert.ToInt32(txtYetkiID.Text);
            kullanici.yetkiID = (int)cbYetki.SelectedValue;

            // veritabanında ilgili tabloya eklenmesi.
            db.Kullanici.Add(kullanici);
            // sorguyu çalıştır.
            db.SaveChanges();
            this.DialogResult = DialogResult.OK; // geriye OK dön
            this.Close(); // Bu formu kapat

        }

        private void frmKullaniciEkle_Load(object sender, EventArgs e)
        {
            // combobox ı doldur
            BerberContext db = new BerberContext();
            var liste = db.Yetki.ToList();
            cbYetki.DataSource = liste;
            cbYetki.DisplayMember = "ad"; // Görünecek olan sütun adı
            cbYetki.ValueMember = "yetkiID"; // Value ile çekilecek sütunun adı
        }
    }
}
