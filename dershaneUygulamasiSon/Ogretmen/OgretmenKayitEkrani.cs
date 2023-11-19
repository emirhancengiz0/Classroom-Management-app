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
    public partial class OgretmenKayitEkrani : Form
    {
        public OgretmenKayitEkrani()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BireyselAkademi;Integrated Security=True");

        private void btnOgrenciKaydet_Click(object sender, EventArgs e)
        {
            int gelenNumara = 0;
            int.TryParse(txtOgretmenNumara.Text, out gelenNumara);
         
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                    string kayit = "insert into BilgiOgretmen(Ad,Soyad,Tc,Cinsiyet,DogumTarih,Eposta," +
                            "Adres,TelefonNumarasi,Brans,Gorev,Maas,OgretmenNumara) values (@Ad,@Soyad,@Tc,@Cinsiyet," +
                            "@DogumTarih,@Eposta,@Adres,@TelefonNumarasi,@Brans,@Gorev,@Maas,@OgretmenNumara)";
                    //string kayitIki = "insert into GiderlerTablosu(Numara,Ad,Ucret)values(@Numara,@Ad,@Ucret)";

                    SqlCommand komut = new SqlCommand(kayit, baglanti);
                    //SqlCommand komutIki = new SqlCommand(kayitIki, baglanti);
                    komut.Parameters.AddWithValue("@Ad", txtOgretmenAd.Text);
                    komut.Parameters.AddWithValue("@Soyad", txtOgretmenSoyad.Text);
                    komut.Parameters.AddWithValue("@Tc", txtOgretmenTc.Text);
                    komut.Parameters.AddWithValue("@Cinsiyet", txtOgretmenCinsiyet.Text);
                    komut.Parameters.AddWithValue("@DogumTarih", txtOgretmenDogumTarih.Text);
                    komut.Parameters.AddWithValue("@Eposta", txtOgretmenEposta.Text);
                    komut.Parameters.AddWithValue("@Adres", txtOgretmenAdres.Text);
                    komut.Parameters.AddWithValue("@TelefonNumarasi", txtOgretmenTelefonNumarasi.Text);
                    komut.Parameters.AddWithValue("@Brans", txtOgretmenBrans.Text);
                    komut.Parameters.AddWithValue("@Gorev", txtOgretmenGorev.Text);
                    komut.Parameters.AddWithValue("@Maas", txtOgretmenMaas.Text);
                    komut.Parameters.AddWithValue("@OgretmenNumara", gelenNumara.ToString());
                    //komutIki.Parameters.AddWithValue("@Numara", gelenNumara.ToString());
                    //komutIki.Parameters.AddWithValue("@Ad", txtOgretmenAd.Text);
                    //komutIki.Parameters.AddWithValue("@Ucret", txtOgretmenMaas.Text);
                    komut.ExecuteNonQuery();
                    //komutIki.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Kayıt işlemi başarılı!", " ", MessageBoxButtons.OK);
                }
            }
            catch (Exception Hata)
            {
                MessageBox.Show("İşlem Sırasında hata oluştu." + Hata.Message);
            }
        }
        private void btnOgrenciKayıtAnasayfa_Click(object sender, EventArgs e)
        {
            IslemMenusu anasayfa = new IslemMenusu();
            anasayfa.Show();
            this.Close();
        }

        private void OgretmenKayitEkrani_Load(object sender, EventArgs e)
        {
            ogretmenNumaraOlustur();
        }
        public int ogretmenNumaraOlustur()
        {
            Random rnd = new Random();
            int ogretmenId = rnd.Next();
            txtOgretmenNumara.Text = ogretmenId.ToString() ; 
            return ogretmenId;

        }
    }
}
