using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dershaneUygulamasiSon
{
    public partial class DersPlanlama : Form
    {
        public DersPlanlama()
        {
            InitializeComponent();
        }

        private void btnDersPlanlamaDersIslemleri_Click(object sender, EventArgs e)
        {
            DersPlanlamaDersIslemleri dersIslemleri = new DersPlanlamaDersIslemleri();
            dersIslemleri.Show();
            this.Close();
        }


        private void btnDersPlanlamaDersProgrami_Click(object sender, EventArgs e)
        {
            DersPlanlamaDersProgramı dersProgramı = new DersPlanlamaDersProgramı();
            dersProgramı.Show();
            this.Close();
        }

        private void btnDersPlanlamaAnasayfa_Click(object sender, EventArgs e)
        {
            IslemMenusu islemMenusu = new IslemMenusu();
            islemMenusu.Show();
            this.Close();
        }
    }
}
