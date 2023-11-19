using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dershaneUygulamasiSon
{
    public partial class IslemMenusu : Form
    {
        public IslemMenusu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UygulamayaGirisEkrani girisEkrani = new UygulamayaGirisEkrani();
            girisEkrani.Show();
            this.Close();
        }   

        private void btnOgrenciKayıt_Click(object sender, EventArgs e)
        {
            OgrenciKayitEkrani ogrenciKayit = new OgrenciKayitEkrani();
            ogrenciKayit.Show();
            this.Close();
        }

        private void btnOgrenciBilgileri_Click(object sender, EventArgs e)
        {
            OgrenciBilgiEkrani ogrenciBilgi = new OgrenciBilgiEkrani();
            ogrenciBilgi.Show();
            this.Close();
        }

        private void btnÖgretmenKayıt_Click(object sender, EventArgs e)
        {
            OgretmenKayitEkrani ogretmenKayit = new OgretmenKayitEkrani();
            ogretmenKayit.Show();
            this.Close();
        }

        private void btnOgretmenBilgileri_Click(object sender, EventArgs e)
        {
            OgretmenBilgiEkrani ogretmenBilgi = new OgretmenBilgiEkrani();
            ogretmenBilgi.Show();
            this.Close();
        }

        private void btnIslemMenusuSifreIslemleri_Click(object sender, EventArgs e)
        {
            SifreIslemleri sifreIslem = new SifreIslemleri();
            sifreIslem.Show();
            this.Close();
        }

        private void btnDersPlanlama_Click(object sender, EventArgs e)
        {
            DersPlanlama dersPlanlama = new DersPlanlama();
            dersPlanlama.Show();
            this.Close();
        }

        private void btnCariHareket_Click(object sender, EventArgs e)
        {
            CariHareketler cariHareketler = new CariHareketler();
            cariHareketler.Show();
            this.Close();
        }

        private void IslemMenusu_Load(object sender, EventArgs e)
        {
            //veriGetir();
        }

        //public void veriGetir()
        //{
        //    SqlConnection baglantiVeri = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BireyselAkademi;Integrated Security=True");
        //    string sorgu = "Select ID From GirisBilgileri";
        //    int deger;
        //    SqlCommand komut = new SqlCommand(sorgu, baglantiVeri);
        //    baglantiVeri.Open();
        //    deger = (int)komut.ExecuteScalar();
        //    baglantiVeri.Close();
        //    lblIslemMenusuId.Text = "Giriş Yapılan ID: "+deger.ToString();

        //}
    }
}
