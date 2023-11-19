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
    public partial class UygulamayaGirisEkrani : Form
    {
        public UygulamayaGirisEkrani()
        {
            InitializeComponent();

        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BireyselAkademi;Integrated Security=True");

        private void btnGiris_Click_1(object sender, EventArgs e)
        {

            try
            {
                baglanti.Open();
                string sql = "Select * From GirisBilgileri where k_adi=@sqladi AND sifre=@sqlsifresi";
                SqlParameter prm1 = new SqlParameter("sqladi", txtKullaniciAdi.Text);
                SqlParameter prm2 = new SqlParameter("sqlsifresi", txtSifre.Text);
                SqlCommand komut = new SqlCommand(sql, baglanti);
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    IslemMenusu menuIslem = new IslemMenusu();
                    menuIslem.Show();
                    menuIslem.lblHosgeldin.Text = "Bireysel Akademi Yönetim Uygulamasına Hoşgeldiniz.\nGiriş Yapılan Kullanıcı Adı : " + txtKullaniciAdi.Text;
                    this.Hide();
                }
                    
            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı giriş!", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Restart();
            }

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
