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
    public partial class frmGiris : Form
    {
        int sayi1;
        int sayi2;
        public frmGiris()
        {
            InitializeComponent();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            //matematik doğru mu?
            if(txtMatematik.Text != (sayi1 + sayi2).ToString())
            {
                MessageBox.Show("Matematik çalışmalısın !!");
                MatematikSorusuOlustur();
                return;
            }



            // Giriş yaparken ne yapıyoruz?
            // veritabanı işlemleri için context sınıfından bir nesne oluşturuyoruz.
            BerberContext db = new BerberContext();
            // veritabanında böyle bir kullanıcı var mı diye kontrol ediyoruz?
            // epostası ve şifresi girilen ile aynı olan

            //veritabanından tek bir kayıt dönülecekse .SingleOrDefault()
            //veritabanından liste çekeceksek .ToList()
            Kullanici kullanici = db.Kullanici
                .Where(x => x.eposta == txtEposta.Text && x.sifre == txtSifre.Text)
                .SingleOrDefault();

            //List<Kullanici> kullanicilar = db.Kullanici.ToList();

            if (kullanici == null) // Kullanıcı yoksa
            {
                MessageBox.Show("Kullanıcı bulunamadı");
                return; // fonksiyondan çık, aşağıdaki kodların çalışmasına gerek yok 
            }
            else // Kullanıcı varsa
            {
                //Program.cs içerisindeki static değişken içerisine atıyorum.
                Program.kullanici = kullanici;
                if(kullanici.yetkiID == 1)
                {
                  frmYonetici frmYonetici = new frmYonetici();
                  frmYonetici.Show();
                }
                else if (kullanici.yetkiID == 2)
                {
                    new frmPersonel().Show();
                }
                this.Hide(); // Bu formu gizle dedik Close ile kapatırsak proje kapanır.
                //MessageBox.Show("Merhaba " + kullanici.ad + " " + kullanici.soyad);
            }




        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmGiris_Load(object sender, EventArgs e)
        {
            MatematikSorusuOlustur();
            //Task.Delay(1000); // 1 saniye bekleme ekler.
            //btnGirisYap.PerformClick();
        }

        private void MatematikSorusuOlustur()
        {
            Random random = new Random();
            sayi1 = random.Next(50);
            sayi2 = random.Next(50);
            lblMatematik.Text = sayi1 + "+" + sayi2 + " = ";
            txtMatematik.Text = (sayi1 + sayi2).ToString();
        }
    }
}
