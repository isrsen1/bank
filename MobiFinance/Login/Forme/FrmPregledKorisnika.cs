using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.Forme
{
    public partial class FrmPregledKorisnika : Template
    {
        public FrmPregledKorisnika()
        {
            InitializeComponent();
        }

        private void FrmPregledKorisnika_Load(object sender, EventArgs e)
        {

        }

        private void btnDodajPrivatnog_Click(object sender, EventArgs e)
        {
            FrmDodajKorisnikaPrivatni privatniKorisnik = new FrmDodajKorisnikaPrivatni();
            privatniKorisnik.ShowDialog();
            this.Close();
        }

        private void btnDodajPoslovnog_Click(object sender, EventArgs e)
        {
            FrmDodajKorisnikaPoslovni poslovniKorisnik = new FrmDodajKorisnikaPoslovni();
            poslovniKorisnik.ShowDialog();
            this.Close();
        }
    }
}
