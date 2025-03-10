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
    public partial class frmYonetici : Form
    {
        public frmYonetici()
        {
            InitializeComponent();
        }

        private void frmYonetici_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void frmYonetici_Load(object sender, EventArgs e)
        {
            

            // combobox ı doldur
            BerberContext db = new BerberContext();
            var liste = db.Yetki.ToList();
            Yetki tumSecenegi = new Yetki() { yetkiID = 0, ad = "Tümü" };
            liste.Insert(0, tumSecenegi);
            cbYetki.DataSource = liste;
            cbYetki.DisplayMember = "ad"; // Görünecek olan sütun adı
            cbYetki.ValueMember = "yetkiID"; // Value ile çekilecek sütunun adı

            cbYetki.SelectedIndex = 0;

            DataGridGuncelle();
        }

        private void menuSil_Click(object sender, EventArgs e)
        {
            //Emin misiniz?

            DialogResult sonuc = MessageBox.Show("Kullanıcı silmek istediğinize emin misiniz?",
                "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(sonuc == DialogResult.Yes)
            {
                // 1. seçili satırdaki kullaniciID bilgisini al
                int kullaniciID = (int)dgvKullanicilar.SelectedRows[0].Cells["kullaniciID"].Value;
                BerberContext db = new BerberContext();
                // veritabanından bu kullaniciID ye sahip kullanıcıyı getir.
                Kullanici kullanici = db.Kullanici.Where(x => x.kullaniciID == kullaniciID)
                    .SingleOrDefault();
                db.Kullanici.Remove(kullanici); // silme sorgusunu oluştur.
                int deger = db.SaveChanges(); // oluşturulan sorguları çalıştır.
                MessageBox.Show("Kullanıcı silindi");

                DataGridGuncelle();
            }
            else // yes olmayan durumlarda 
            {
                MessageBox.Show("İptal edildi.");
            }
        }

        private void menuDuzenle_Click(object sender, EventArgs e)
        {
            int kullaniciID = (int)dgvKullanicilar.SelectedRows[0].Cells["kullaniciID"].Value;
            frmKullaniciDuzenle frmKullaniciDuzenle = new frmKullaniciDuzenle();
            // formu açmadan önce seçili olan kullanıcının id bilgisi diğer forma aktarılır.
            frmKullaniciDuzenle.kullaniciID = kullaniciID;
            // showdialog dan önce eklenmesinin sebebi bu değişkene form load da ihtiyacım var.
            DialogResult sonuc = frmKullaniciDuzenle.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                DataGridGuncelle();
            }
        }

        private void DataGridGuncelle(string arama = "")
        {
            //veritabanı işlemleri için Context sınıfından nesne üretiyoruz.
            BerberContext db = new BerberContext();
            // Tüm kullanıcıları veritabanından çekmem gerekiyor.
            //var kullanicilar = 
            // db.Kullanici
            //.Where(x=> x.ad.Contains(arama) || x.soyad.Contains(arama))
            //.Select(x => new
            //{
            //    x.kullaniciID,
            //    Ad = x.ad,
            //    Soyad = x.soyad,
            //    YetkiAdi = x.Yetki.ad
            //})
            //.ToList();
            //dgvKullanicilar.DataSource = kullanicilar;


            IQueryable<Kullanici> sorgu = db.Kullanici;
            // Arama kriterini ekleyelim // textbox like ile arama
            if (txtArama.Text.Length>2)
            {
                sorgu = sorgu
                    .Where(x => x.ad.Contains(txtArama.Text) 
                    || x.soyad.Contains(txtArama.Text)
                    || x.eposta.Contains(txtArama.Text)
                    );
            }

            // Yetki filtresini ekleyelim
            if (((Yetki)cbYetki.SelectedItem).yetkiID != 0) // 0 değeri "Tümü" seçeneği için kullanıldığını varsayıyoruz
            {
                sorgu = sorgu.Where(x => x.yetkiID == (int)cbYetki.SelectedValue);
            }

            // Son sonuç setini oluşturalım
            var sorguSon = sorgu
                .Select(x => new
                {
                    x.kullaniciID,
                    Ad = x.ad,
                    Soyad = x.soyad,
                    YetkiAdi = x.Yetki.ad
                });

            var kullanicilar = sorguSon.ToList();

            dgvKullanicilar.DataSource = kullanicilar;

        }

        private void btnKullaniciEkle_Click(object sender, EventArgs e)
        {
            frmKullaniciEkle frmKullaniciEkle = new frmKullaniciEkle();
            DialogResult sonuc = frmKullaniciEkle.ShowDialog();
            if(sonuc == DialogResult.OK)
            {
                DataGridGuncelle();
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (txtArama.Text.Length > 2)
                DataGridGuncelle(txtArama.Text);
            else
                DataGridGuncelle();
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            if (txtArama.Text.Length > 2)
                DataGridGuncelle(txtArama.Text);
            else
                DataGridGuncelle();
        }

        private void cbYetki_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataGridGuncelle();
        }
    }
}
