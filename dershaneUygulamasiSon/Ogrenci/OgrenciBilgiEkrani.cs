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
    public partial class OgrenciBilgiEkrani : Form
    {
        public OgrenciBilgiEkrani()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BireyselAkademi;Integrated Security=True");

        public void veriGoster(string veriler)
        {
            SqlDataAdapter da = new SqlDataAdapter(veriler, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DgvOgrenciBilgi.DataSource = ds.Tables[0];
        }
        public void veriKontrol()
        {
            baglanti.Open();
            SqlCommand delete = new SqlCommand("Delete From BilgiOgrenci  where KalanTaksit ='0'", baglanti);
            delete.ExecuteNonQuery();
            baglanti.Close();

        }

        private void OgrenciBilgiEkrani_Load(object sender, EventArgs e)
        {
            
        }

        private void btnOgrenciBilgiEkraniListele_Click(object sender, EventArgs e)
        {
            veriKontrol();
            veriGoster("Select*from BilgiOgrenci");
            
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOgrenciBilgiEkraniKayitSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from BilgiOgrenci where Numara=@Numara",baglanti);
            SqlCommand komutIki = new SqlCommand("delete from GelirlerTablosu where Numara=@Numara", baglanti);
            komut.Parameters.AddWithValue("@Numara", txtOgrenciBilgiEkraniSilinecekNumara.Text);
            komutIki.Parameters.AddWithValue("@Numara", txtOgrenciBilgiEkraniSilinecekNumara.Text);
            MessageBox.Show("Kayıt Silme İşlemi Başarılı!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            komut.ExecuteNonQuery();
            komutIki.ExecuteNonQuery();
            veriGoster("Select*from BilgiOgrenci");
            baglanti.Close();
        }

        private void btnOgrenciBilgiKayitAra_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from BilgiOgrenci where Soyad like '%" + txtOgrenciBilgiEkraniSoyad.Text.ToString() + "%'", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DgvOgrenciBilgi.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void DgvOgrenciBilgi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int seciliAlan = DgvOgrenciBilgi.SelectedCells[0].RowIndex;
            string ad = DgvOgrenciBilgi.Rows[seciliAlan].Cells[0].Value.ToString();
            string soyad = DgvOgrenciBilgi.Rows[seciliAlan].Cells[1].Value.ToString();
            string tcKimlikNumarasi = DgvOgrenciBilgi.Rows[seciliAlan].Cells[2].Value.ToString();
            string dogumTarih = DgvOgrenciBilgi.Rows[seciliAlan].Cells[3].Value.ToString();
            string kayitTarih = DgvOgrenciBilgi.Rows[seciliAlan].Cells[4].Value.ToString();
            string dogumYer = DgvOgrenciBilgi.Rows[seciliAlan].Cells[5].Value.ToString();
            string sinif = DgvOgrenciBilgi.Rows[seciliAlan].Cells[6].Value.ToString();
            string alan = DgvOgrenciBilgi.Rows[seciliAlan].Cells[7].Value.ToString();
            string numara = DgvOgrenciBilgi.Rows[seciliAlan].Cells[8].Value.ToString();
            string cinsiyet = DgvOgrenciBilgi.Rows[seciliAlan].Cells[9].Value.ToString();
            string telefonNumarasi = DgvOgrenciBilgi.Rows[seciliAlan].Cells[10].Value.ToString();
            string Adres = DgvOgrenciBilgi.Rows[seciliAlan].Cells[11].Value.ToString();
            string veliTcKimlikNum = DgvOgrenciBilgi.Rows[seciliAlan].Cells[12].Value.ToString();
            string veliAdi = DgvOgrenciBilgi.Rows[seciliAlan].Cells[13].Value.ToString();
            string veliTelefonNum = DgvOgrenciBilgi.Rows[seciliAlan].Cells[14].Value.ToString();
            string kayitUcret = DgvOgrenciBilgi.Rows[seciliAlan].Cells[15].Value.ToString();

            txtOgrenciBilgiEkraniAd.Text = ad;
            txtOgrenciBilgiEkraniSoyad.Text = soyad;
            txtOgrenciBilgiEkraniTC.Text = tcKimlikNumarasi;
            txtOgrenciBilgiEkraniDogumTarih.Text = dogumTarih;
            txtOgrenciBilgiEkraniKayitTarih.Text = kayitTarih;
            txtOgrenciBilgiEkraniDogumYer.Text = dogumYer;
            txtOgrenciBilgiEkraniSinif.Text = sinif;
            txtOgrenciBilgiEkraniAlan.Text = alan;
            txtOgrenciBilgiEkraniNumara.Text = numara.ToString();
            txtOgrenciBilgiEkraniSilinecekNumara.Text=numara.ToString();
            txtOgrenciBilgiEkraniCinsiyet.Text = cinsiyet;
            txtOgretmenTelefonNumara.Text = telefonNumarasi;
            txtOgrenciBilgiEkraniAdres.Text = Adres;
            txtOgrenciBilgiEkraniVeliTc.Text = veliTcKimlikNum;
            txtOgrenciBilgiEkraniVeliAdi.Text = veliAdi;
            txtOgrenciBilgiEkraniVeliTelefon.Text = veliTelefonNum;
            txtOgrenciBilgiEkraniKayitUcret.Text = kayitUcret.ToString();

        }

        private void btnOgrenciBilgiEkraniGuncelle_Click(object sender, EventArgs e)
        { 
            baglanti.Open();    
            SqlCommand komut = new SqlCommand("update BilgiOgrenci set Ad='" + txtOgrenciBilgiEkraniAd.Text + "'" +
                ",Soyad='"+txtOgrenciBilgiEkraniSoyad.Text+"',Tc='" + txtOgrenciBilgiEkraniTC.Text + "'" +
                ",DogumTarih='" + txtOgrenciBilgiEkraniDogumTarih.Text + "',KayitTarih='" + txtOgrenciBilgiEkraniKayitTarih.Text + "'" +
                ",DogumYer='" + txtOgrenciBilgiEkraniDogumYer.Text + "',Sinif='" + txtOgrenciBilgiEkraniSinif.Text + "'" +
                ",Alan='" + txtOgrenciBilgiEkraniAlan.Text + "',Cinsiyet='" + txtOgrenciBilgiEkraniCinsiyet.Text + "'" +
                ",TelefonOgrenci='" + txtOgretmenTelefonNumara.Text + "',Adres='" + txtOgrenciBilgiEkraniAdres.Text + "'" +
                ",VeliTc='" + txtOgrenciBilgiEkraniVeliTc.Text + "',VeliAdi='" + txtOgrenciBilgiEkraniVeliAdi.Text + "'" +
                ",TelefonVeli='" + txtOgrenciBilgiEkraniVeliTelefon.Text + "',KayitUcret='" + txtOgrenciBilgiEkraniKayitUcret.Text + "' " +
                "where Numara='"+txtOgrenciBilgiEkraniNumara.Text.ToString()+"'", baglanti);
            MessageBox.Show("Kayıt Güncelleme İşlemi Başarılı!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            komut.ExecuteNonQuery();
            veriGoster("Select * from BilgiOgrenci");
            baglanti.Close();

        }

        private void btnOgrenciBilgiEkraniAnasayfa_Click(object sender, EventArgs e)
        {
            IslemMenusu anasayfa = new IslemMenusu();
            anasayfa.Show();
            this.Close();
        }
    }
}
    