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
    public partial class DersPlanlamaDersProgramı : Form
    {
        public DersPlanlamaDersProgramı()
        {
            InitializeComponent();
            veriGoster("Select * from Dersler");
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BireyselAkademi;Integrated Security=True");

        public void veriGoster(string veriler)
        {
            SqlDataAdapter da = new SqlDataAdapter(veriler, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgvDersProgramı.DataSource = ds.Tables[0];
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            DersPlanlamaDersIslemleri dersIslemleri = new DersPlanlamaDersIslemleri();
            dersIslemleri.Show();
            this.Close();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            DersPlanlama planlama = new DersPlanlama();
            planlama.Show();
            this.Close();
        }

        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            IslemMenusu islemMenusu = new IslemMenusu();
            islemMenusu.Show();
            this.Close();
        }

        private void btnArama_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from Dersler where ID like '%" + txtDersPlanlamaDersKodu.Text.ToString() + "%'", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgvDersProgramı.DataSource = ds.Tables[0];
            baglanti.Close();
        }
    }
}
