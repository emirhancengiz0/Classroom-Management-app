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
    public partial class DersPlanlamaDersIslemleri : Form
    {
        public DersPlanlamaDersIslemleri()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BireyselAkademi;Integrated Security=True");

        public void veriGoster(string veriler)
        {
            SqlDataAdapter da = new SqlDataAdapter(veriler, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DGVDersPlanlamaDersIslemleri.DataSource = ds.Tables[0];
        }

        private void btnDersPlanlamaDersEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if(baglanti.State == ConnectionState.Closed)
                {
                    if (varMi(txtDersPlanlamaDersKodu.Text) != 0)
                    {
                        MessageBox.Show("Bu Ders Kodu ile Daha Önce Kayıt Yapılmış. Lütfen Farklı Bir Ders Kodu Giriniz.","DERS KODU!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                    else
                    {
                        baglanti.Open();
                        string dersKayit = "insert into Dersler(Ders,ID,Sinif,Ogretmen,Gun,Saat)values(@Ders,@ID,@Sinif,@Ogretmen,@Gun,@Saat)";
                        SqlCommand komut = new SqlCommand(dersKayit, baglanti);
                        komut.Parameters.AddWithValue("@Ders", txtDersPlanlamaDersEkle.Text);
                        komut.Parameters.AddWithValue("@ID", txtDersPlanlamaDersKodu.Text.ToString());
                        komut.Parameters.AddWithValue("@Sinif", txtDersPlanlamaSinifSeviyesi.Text);
                        komut.Parameters.AddWithValue("@Ogretmen", cmbOgretmen.Text);
                        komut.Parameters.AddWithValue("@Gun", txtDersPlanlamaGun.Text);
                        komut.Parameters.AddWithValue("@Saat", txtDersPlanlamaSaat.Text);
                        komut.ExecuteNonQuery();
                        veriGoster("Select * from Dersler");
                        baglanti.Close();
                        MessageBox.Show("Ders Ekleme İşlemi Başarılı", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception hata)
            {

                MessageBox.Show("İşlem Sırasında hata oluştu." + hata.Message);
            }
        }

        private void DGVDersPlanlamaDersIslemleri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int seciliAlan = DGVDersPlanlamaDersIslemleri.SelectedCells[0].RowIndex;
            string dersAdi = DGVDersPlanlamaDersIslemleri.Rows[seciliAlan].Cells[0].Value.ToString();
            string dersKodu = DGVDersPlanlamaDersIslemleri.Rows[seciliAlan].Cells[1].Value.ToString();
            string sinifSeviyesi = DGVDersPlanlamaDersIslemleri.Rows[seciliAlan].Cells[2].Value.ToString();
            string ogretmenAdi = DGVDersPlanlamaDersIslemleri.Rows[seciliAlan].Cells[3].Value.ToString();
            string gun = DGVDersPlanlamaDersIslemleri.Rows[seciliAlan].Cells[4].Value.ToString();
            string saat = DGVDersPlanlamaDersIslemleri.Rows[seciliAlan].Cells[5].Value.ToString();

            txtDersPlanlamaDersEkle.Text = dersAdi;
            txtDersPlanlamaDersKodu.Text = dersKodu;
            txtDersPlanlamaSinifSeviyesi.Text = sinifSeviyesi;
            cmbOgretmen.Text = ogretmenAdi;
            txtDersPlanlamaGun.Text = gun;
            txtDersPlanlamaSaat.Text = saat;
        }

        private void btnDersPlanlamaSinifIslemleriGuncelle_Click(object sender, EventArgs e)
        {
           
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update Dersler set Ders='"+txtDersPlanlamaDersEkle.Text+"'" +
                ",Sinif='"+txtDersPlanlamaSinifSeviyesi.Text+"'" +
                ",Ogretmen='"+cmbOgretmen.Text+"',Gun='"+txtDersPlanlamaGun.Text+"'" +
                ",Saat='"+txtDersPlanlamaSaat.Text+"'" +
                "where ID='"+txtDersPlanlamaDersKodu.Text.ToString()+"'",baglanti);
            
            MessageBox.Show("Ders Güncelleme İşlemi Başarılı!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            komut.ExecuteNonQuery();
            veriGoster("Select * from Dersler");
            baglanti.Close();
        }

        private void btnDersPlanlamaDersListele_Click(object sender, EventArgs e)
        {
            veriGoster("Select*from Dersler");
        }

        private void btnDersPlanlamaDersSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from Dersler where ID=@ID", baglanti);
            komut.Parameters.AddWithValue("@ID", txtDersPlanlamaDersKodu.Text);
            MessageBox.Show("Kayıt Silme İşlemi Başarılı!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            komut.ExecuteNonQuery();
            veriGoster("Select*from Dersler");
            baglanti.Close();
        }

        private void btnDersPlanlamaDersArama_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from Dersler where Sinif like '%" + txtDersPlanlamaSinifSeviyesi.Text.ToString() + "%'", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DGVDersPlanlamaDersIslemleri.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void btnDersPlanlamaDersAnasayfa_Click_1(object sender, EventArgs e)
        {
            IslemMenusu anasayfa = new IslemMenusu();
            anasayfa.Show();
            this.Close();
        }

        private void btnDersPlanlamaGeri_Click(object sender, EventArgs e)
        {
            DersPlanlama dersPlanlama = new DersPlanlama();
            dersPlanlama.Show();
            this.Close();
        }

        public int varMi(string aranan)
        {
            int sonuc;
            baglanti.Open();
            string sorgu = "Select count(ID) from Dersler where ID='" + aranan + "'";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            sonuc = Convert.ToInt32(komut.ExecuteScalar());
            baglanti.Close();
            return sonuc;
        }

        private void DersPlanlamaDersIslemleri_Load(object sender, EventArgs e)
        {
            cmbVeriCekme();
            dersKodu();

        }
        public void cmbVeriCekme()
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BireyselAkademi;Integrated Security=True");
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT *FROM BilgiOgretmen";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;

            SqlDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbOgretmen.Items.Add(dr["Ad"]);
            }
            baglanti.Close();
        }
        public int dersKodu()
        {
            Random rnd = new Random();
            int dersID = rnd.Next();
            txtDersPlanlamaDersKodu.Text = dersID.ToString();
            return dersID;

        }
    }
}
