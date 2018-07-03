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

        public Klijent OdabraniKlijent = new Klijent();
        public Kredit_ OdabraniKredit = new Kredit_();
        public FrmKreditiKorisnika()
        {
            InitializeComponent();
        }

        private void FrmKreditiKorisnika_Load(object sender, EventArgs e)
        {

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
