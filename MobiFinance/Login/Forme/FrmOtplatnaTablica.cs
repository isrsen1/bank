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
    public partial class FrmOtplatnaTablica : Form
    {

        private Kredit_ krediti = new Kredit_();
        private Otplatna_tablica dioOtplate = null;
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

        public void NapuniDataGridView(Kredit_ kredit)
        {
            try
            {
                RekurzivnaKamatnaStopa = odabraniKredit.IzracunajRekurzivnuKamatnuStopu();
                anuitet = kredit.IzracunajAnuitet(RekurzivnaKamatnaStopa);
                IzracunajOtplatnuTablicu(RekurzivnaKamatnaStopa,anuitet,kredit);
            }
            catch (Exception)
            {
                MessageBox.Show("Došlo je do pogreške.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void IzracunajOtplatnuTablicu(double r,double anuitet,Kredit_ pom) {

            double ostatakDuga = 0;
            ostatakDuga = pom.Glavnica;
            double otplatnaKvota = 0;
            double otplaceniDioDuga = 0;
            double kamataRazdoblja = 0;
            for (int i=1;i<=pom.RokOtplate;i++) {
                kamataRazdoblja = pom.IzracunajKamatuRazdoblja(ostatakDuga,r);
                otplatnaKvota = pom.IzracunajOtplaceniDioDuga(otplaceniDioDuga,otplatnaKvota);
                dioOtplate = new Otplatna_tablica(i,kamataRazdoblja,anuitet,otplatnaKvota,ostatakDuga,otplaceniDioDuga,i);
                pom.DodajZapisUOtplatnu(dioOtplate);
                ostatakDuga = pom.IzracunajOstatakDUga(ostatakDuga,otplatnaKvota);

            }

        }

        public void OsvjeziEkran(Kredit_ odabraniKredit) {
            otplatnatablicaBindingSource.DataSource = null;
            ListaOtplate = new BindingList<Otplatna_tablica>(odabraniKredit.KolekcijaZapisa);
            otplatnatablicaBindingSource.DataSource = ListaOtplate;
        }

        private void cbPopisKredita_SelectedIndexChanged(object sender, EventArgs e)
        {
            odabraniKredit = cbPopisKredita.SelectedItem as Kredit_;
            odabraniKredit.KolekcijaZapisa.Clear();
            try
            {
                NapuniDataGridView(odabraniKredit);
                OsvjeziEkran(odabraniKredit);
            }
            catch (Exception) {
                MessageBox.Show("Došlo je do pogreške.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
    }
}
