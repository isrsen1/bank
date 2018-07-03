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
    public partial class FrmOtplatnaTablica : Template
    {

        private Kredit_ krediti = new Kredit_();
        public BindingList<Otplatna_tablica> ListaOtplate;
        public double RekurzivnaKamatnaStopa = 0;
        private double anuitet = 0;
        private Kredit_ odabraniKredit;
        public FrmOtplatnaTablica()
        {
            InitializeComponent();
        }
        public void PrikaziKredite() {
            kreditBindingSource.DataSource = null;
            kreditBindingSource.DataSource = krediti.DohvatiKredite();
        }


        private void FrmOtplatnaTablica_Load(object sender, EventArgs e)
        {
            PrikaziKredite();
        }

        private void cbPopisKredita_SelectedIndexChanged(object sender, EventArgs e)
        {
            odabraniKredit = cbPopisKredita.SelectedItem as Kredit_;
            odabraniKredit.KolekcijaZapisa.Clear();
            try {
                RekurzivnaKamatnaStopa = odabraniKredit.IzracunajRekurzivnuKamatnuStopu();
            }
            catch { }
        }
    }
}
