using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MobiFinance;
using Login;

namespace MobiFinance.Forme
{
    public partial class FrmKreditiKorisnika : Login.Template
    {

        private Klijent odabraniKlijent = null;
        private Kredit_ odabraniKredit = null;
        public Klijent Klijent = new Klijent();
        public Kredit_ Kredit = new Kredit_();
        public FrmKreditiKorisnika()
        {
            InitializeComponent();
        }

        public void PrikaziKorisnike()
        {
            klijentBindingSource.DataSource = null;
            klijentBindingSource.DataSource = Klijent.DohvatiKorisnike();
        }


        private void FrmKreditiKorisnika_Load(object sender, EventArgs e)
        {
            PrikaziKorisnike();

        }

        public void ZatvoriFormu() {
            this.Close();
        }

        private void uiNazad_Click(object sender, EventArgs e)
        {
            ZatvoriFormu();
            
        }
    }
}
