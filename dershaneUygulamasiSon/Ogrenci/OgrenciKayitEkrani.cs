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
    public partial class OgrenciKayitEkrani : Form
    {
        public OgrenciKayitEkrani()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BireyselAkademi;Integrated Security=True");

        private void Form3_Load(object sender, EventArgs e)
        {
            ogrenciNumara();
        }
        private void btnOgrenciKaydet_Click(object sender, EventArgs e)
        {
            int gelenNumara = 0;
            int.TryParse(txtOgrenciNumara.Text, out gelenNumara);
            int gelenUcret = 0;
            int.TryParse(txtKayitUcret.Text, out gelenUcret);
            int Taksit = 0;
            int.TryParse(txtTaksit.Text, out Taksit);
            try
            {   
                if (baglanti.State==ConnectionState.Closed)
                {
                    baglanti.Open();
                    string kayit = "insert into BilgiOgrenci(Ad,Soyad,Tc,DogumTarih,KayitTarih,DogumYer,Sinif,Alan,Numara,Cinsiyet,TelefonOgrenci,Adres" +
                        ",VeliTc,VeliAdi,TelefonVeli,KayitUcret,TaksitSayi,KalanTaksit) values (@Ad,@Soyad,@Tc,@DogumTarih,@KayitTarih,@DogumYer,@Sinif,@Alan,@Numara,@Cinsiyet," +
                        "@TelefonOgrenci,@Adres,@VeliTc,@VeliAdi,@TelefonVeli,@KayitUcret,@TaksitSayi,@KalanTaksit)";
                    string kayitIki = "insert into GelirlerTablosu(Numara,Ad,Soyad,Ucret,Taksit,KalanTaksit)values(@Numara,@Ad,@Soyad,@Ucret,@Taksit,@KalanTaksit)";
                    string kayitUc = "insert into TaksitBilgi(Numara,Ad,Soyad,KayitUcret,TaksitSayi,Tc,KalanTaksit)values(@Numara,@Ad,@Soyad,@KayitUcret,@TaksitSayi,@Tc,@KalanTaksit)";

                    SqlCommand komut = new SqlCommand(kayit, baglanti);
                    SqlCommand komutIki = new SqlCommand(kayitIki, baglanti);
                    SqlCommand komutUc = new SqlCommand(kayitUc, baglanti);

                    komut.Parameters.AddWithValue("@Ad", txtOgrenciAdi.Text);                   
                    komut.Parameters.AddWithValue("@Soyad", txtOgrenciSoyAdi.Text);
                    komut.Parameters.AddWithValue("@Tc", txtOgrenciKimlikNumarasi.Text);
                    komut.Parameters.AddWithValue("@DogumTarih", txtOgrenciDogumTarihi.Text);
                    komut.Parameters.AddWithValue("@KayitTarih", txtOgrenciKayıtTarihi.Text);
                    komut.Parameters.AddWithValue("@DogumYer", txtOgrenciDogumYeri.Text);
                    komut.Parameters.AddWithValue("@Sinif", txtOgrenciSinif.Text);
                    komut.Parameters.AddWithValue("@Alan", txtOgrenciAlan.Text);
                    komut.Parameters.AddWithValue("@Numara", gelenNumara.ToString());
                    komut.Parameters.AddWithValue("@Cinsiyet", txtOgrenciCinsiyet.Text);
                    komut.Parameters.AddWithValue("@TelefonOgrenci", txtOgrenciTelefon.Text);
                    komut.Parameters.AddWithValue("@Adres", txtAdres.Text);
                    komut.Parameters.AddWithValue("@VeliTc", txtVeliKimlikNumarasi.Text);
                    komut.Parameters.AddWithValue("@VeliAdi", txtVeliAdi.Text);
                    komut.Parameters.AddWithValue("@TelefonVeli", txtVeliTelefon.Text);
                    komut.Parameters.AddWithValue("@KayitUcret", gelenUcret.ToString());
                    komut.Parameters.AddWithValue("@TaksitSayi", Taksit.ToString());
                    komut.Parameters.AddWithValue("@KalanTaksit", Taksit.ToString());
                    komutIki.Parameters.AddWithValue("@Numara", gelenNumara.ToString());
                    komutIki.Parameters.AddWithValue("@Ad", txtOgrenciAdi.Text);
                    komutIki.Parameters.AddWithValue("@Soyad", txtOgrenciSoyAdi.Text);
                    komutIki.Parameters.AddWithValue("@Ucret", gelenUcret.ToString());
                    komutIki.Parameters.AddWithValue("@Taksit", Taksit.ToString());
                    komutIki.Parameters.AddWithValue("@KalanTaksit", Taksit.ToString());
                    komutUc.Parameters.AddWithValue("@Numara", gelenNumara.ToString());
                    komutUc.Parameters.AddWithValue("@Ad", txtOgrenciAdi.Text);
                    komutUc.Parameters.AddWithValue("@Soyad", txtOgrenciSoyAdi.Text);
                    komutUc.Parameters.AddWithValue("@Tc", txtOgrenciKimlikNumarasi.Text);
                    komutUc.Parameters.AddWithValue("@KayitUcret", gelenUcret.ToString());
                    komutUc.Parameters.AddWithValue("@TaksitSayi", Taksit.ToString());
                    komutUc.Parameters.AddWithValue("@KalanTaksit", Taksit.ToString());

                    komut.ExecuteNonQuery();
                    komutIki.ExecuteNonQuery();
                    komutUc.ExecuteNonQuery();
                    MessageBox.Show("Kayıt işlemi başarılı!"," ",MessageBoxButtons.OK);
                    baglanti.Close();
                }
            }
            catch (Exception hata)
            {

                MessageBox.Show("İşlem Sırasında hata oluştu." + hata.Message);
            }
        }
        private void btnOgrenciKayıtAnasayfa_Click(object sender, EventArgs e)
        {
            IslemMenusu anasayfa = new IslemMenusu();
            anasayfa.Show();
            this.Close();
        }
        public int ogrenciNumara()
        {
            Random rnd = new Random();
            int ogrenciId = rnd.Next();
            txtOgrenciNumara.Text = ogrenciId.ToString();
            return ogrenciId;

        }

    }
}
