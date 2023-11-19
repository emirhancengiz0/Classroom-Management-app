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
    public partial class OgretmenBilgiEkrani : Form
    {
        public OgretmenBilgiEkrani()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BireyselAkademi;Integrated Security=True");

        public void veriGoster(string veriler)
        {
            SqlDataAdapter da = new SqlDataAdapter(veriler, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgvOgretmenBilgi.DataSource = ds.Tables[0];
        }

        private void btnAnasayfa_Click_1(object sender, EventArgs e)
        {
            IslemMenusu anasayfa = new IslemMenusu();
            anasayfa.Show();
            this.Close();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOgretmenBilgiEkraniListe_Click(object sender, EventArgs e)
        {
            veriGoster("Select*from BilgiOgretmen");
        }

        private void btnKayitSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from BilgiOgretmen where OgretmenNumara=@OgretmenNumara", baglanti);
            komut.Parameters.AddWithValue("@OgretmenNumara", txtOgretmenBilgiEkraniSilinecekNumara.Text);
            MessageBox.Show("Kayıt Silme İşlemi Başarılı!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            komut.ExecuteNonQuery();
            veriGoster("Select*from BilgiOgretmen");
            baglanti.Close();
        }

        private void btnKayitAra_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from BilgiOgretmen where OgretmenNumara like '%" + txtOgretmenBilgiEkraniAranacak.Text.ToString() + "%'", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgvOgretmenBilgi.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void dgvOgretmenBilgi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int seciliAlan = dgvOgretmenBilgi.SelectedCells[0].RowIndex;
            string ad = dgvOgretmenBilgi.Rows[seciliAlan].Cells[0].Value.ToString();
            string soyad = dgvOgretmenBilgi.Rows[seciliAlan].Cells[1].Value.ToString();
            string tcKimlikNumarasi = dgvOgretmenBilgi.Rows[seciliAlan].Cells[2].Value.ToString();
            string cinsiyet = dgvOgretmenBilgi.Rows[seciliAlan].Cells[3].Value.ToString();
            string dogumtarih = dgvOgretmenBilgi.Rows[seciliAlan].Cells[4].Value.ToString();
            string eposta = dgvOgretmenBilgi.Rows[seciliAlan].Cells[5].Value.ToString();
            string adres = dgvOgretmenBilgi.Rows[seciliAlan].Cells[6].Value.ToString();
            string telefonNumarasi = dgvOgretmenBilgi.Rows[seciliAlan].Cells[7].Value.ToString();
            string brans = dgvOgretmenBilgi.Rows[seciliAlan].Cells[8].Value.ToString();
            string gorev = dgvOgretmenBilgi.Rows[seciliAlan].Cells[9].Value.ToString();
            string maas = dgvOgretmenBilgi.Rows[seciliAlan].Cells[10].Value.ToString();
            string ogretmenNumarasi = dgvOgretmenBilgi.Rows[seciliAlan].Cells[11].Value.ToString();

            txtOgretmenBilgiEkraniAd.Text = ad;
            txtOgretmenBilgiEkraniSoyad.Text = soyad;
            txtOgretmenBilgiEkraniKimlik.Text = tcKimlikNumarasi;
            txtOgretmenBilgiEkraniCinsiyet.Text = cinsiyet;
            txtOgretmenBilgiEkraniDogumTarihi.Text = dogumtarih;
            txtOgretmenBilgiEkraniEposta.Text = eposta;
            txtOgretmenBilgiEkraniAdres.Text = adres;
            txtOgretmenBilgiEkraniTelefonNumara.Text = telefonNumarasi;
            txtOgretmenBilgiEkraniBrans.Text = brans;
            txtOgretmenBilgiEkraniGorev.Text = gorev;
            txtOgretmenBilgiEkraniMaas.Text = maas;
            txtOgretmenBilgiEkraniNumara.Text = ogretmenNumarasi.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update BilgiOgretmen set Ad='" + txtOgretmenBilgiEkraniAd.Text + "'" +
                ",Soyad='" + txtOgretmenBilgiEkraniSoyad.Text + "',Tc='" + txtOgretmenBilgiEkraniKimlik.Text + "'" +
                ",Cinsiyet='" + txtOgretmenBilgiEkraniCinsiyet.Text + "',DogumTarih='" + txtOgretmenBilgiEkraniDogumTarihi.Text + "'" +
                ",Eposta='" + txtOgretmenBilgiEkraniEposta.Text + "',Adres='" + txtOgretmenBilgiEkraniAdres.Text + "'" +
                ",TelefonNumarasi='" + txtOgretmenBilgiEkraniTelefonNumara.Text + "',Brans='" + txtOgretmenBilgiEkraniBrans.Text + "'" +
                ",Gorev='" + txtOgretmenBilgiEkraniGorev.Text + "',Maas='" + txtOgretmenBilgiEkraniMaas.Text + "'where OgretmenNumara='"+txtOgretmenBilgiEkraniNumara.Text.ToString()+"'", baglanti);
            MessageBox.Show("Kayıt Güncelleme İşlemi Başarılı!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            komut.ExecuteNonQuery();
            veriGoster("Select * from BilgiOgretmen");
            baglanti.Close();
        }
    }
}
