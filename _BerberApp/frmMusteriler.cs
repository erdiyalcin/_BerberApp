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
    public partial class frmMusteriler : Form
    {
        public frmMusteriler()
        {
            InitializeComponent();
        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            frmMusteriEkle frm = new frmMusteriEkle();
            DialogResult sonuc = frm.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                DataGridGuncelle();
            }
        }

        private void frmMusteriler_Load(object sender, EventArgs e)
        {
            // combobox ı doldur
            BerberContext db = new BerberContext();
            DataGridGuncelle();
        }


        private void DataGridGuncelle(string arama = "")
        {
            //veritabanı işlemleri için Context sınıfından nesne üretiyoruz.
            BerberContext db = new BerberContext();
            
            IQueryable<Musteri> sorgu = db.Musteri;
            // Arama kriterini ekleyelim // textbox like ile arama
            if (txtArama.Text.Length > 2)
            {
                sorgu = sorgu
                    .Where(x => x.ad.Contains(txtArama.Text)
                    || x.soyad.Contains(txtArama.Text)
                    || x.telefon.Contains(txtArama.Text)
                    );
            }

            // Son sonuç setini oluşturalım
            var sorguSon = sorgu
                .Select(x => new
                {
                    x.musteriID,
                    Ad = x.ad,
                    Soyad = x.soyad,
                    x.telefon
                });

            var musteriler = sorguSon.ToList();

            dgvMusteriler.DataSource = musteriler;

        }

        private void menuDuzenle_Click(object sender, EventArgs e)
        {
            int musteriID = (int)dgvMusteriler.SelectedRows[0].Cells["musteriID"].Value;
            frmMusteriDuzenle frm = new frmMusteriDuzenle();
            // formu açmadan önce seçili olan kullanıcının id bilgisi diğer forma aktarılır.
            frm.musteriID = musteriID;
            // showdialog dan önce eklenmesinin sebebi bu değişkene form load da ihtiyacım var.
            DialogResult sonuc = frm.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                DataGridGuncelle();
            }
        }

        private void menuSil_Click(object sender, EventArgs e)
        {
            //Emin misiniz?

            DialogResult sonuc = MessageBox.Show("Müşteriyi silmek istediğinize emin misiniz?",
                "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sonuc == DialogResult.Yes)
            {
                // 1. seçili satırdaki kullaniciID bilgisini al
                int musteriID = (int)dgvMusteriler.SelectedRows[0].Cells["musteriID"].Value;
                BerberContext db = new BerberContext();
                // veritabanından bu kullaniciID ye sahip kullanıcıyı getir.
                Musteri musteri = db.Musteri.Where(x => x.musteriID == musteriID)
                    .SingleOrDefault();
                db.Musteri.Remove(musteri); // silme sorgusunu oluştur.
                int deger = db.SaveChanges(); // oluşturulan sorguları çalıştır.
                MessageBox.Show("Müşteri silindi");

                DataGridGuncelle();
            }
            else // yes olmayan durumlarda 
            {
                MessageBox.Show("İptal edildi.");
            }
        }

        private void menuRandevuEkle_Click(object sender, EventArgs e)
        {
            frmRandevuEkle frm = new frmRandevuEkle();
            //seçili satırı aldık
            DataGridViewRow satir = dgvMusteriler.SelectedRows[0];
            int musteriID = (int)satir.Cells["musteriID"].Value;
            // formu açmadan önce seçili olan kullanıcının id bilgisi diğer forma aktarılır.
            frm.musteriID = musteriID;
            frm.adSoyad = satir.Cells["ad"].Value + " " + satir.Cells["soyad"].Value;
            // showdialog dan önce eklenmesinin sebebi bu değişkene form load da ihtiyacım var.
            DialogResult sonuc = frm.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                DataGridGuncelle();
            }
        }
    }
}
