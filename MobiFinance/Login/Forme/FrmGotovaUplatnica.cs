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
    public partial class FrmGotovaUplatnica : Form
    {
        public Kredit_ Kredit;
        public Klijent Klijent;
        public double KamatnaStopa;
        public string Platitelj;
        public string Primatelj;
        public string Opis;
        public FrmGotovaUplatnica()
        {
            InitializeComponent();
        }
        public FrmGotovaUplatnica(Klijent _klijent, Kredit_ _kredit)
        {
            InitializeComponent();
            Kredit = _kredit;
            Klijent = _klijent;
        }
        public void ZatvoriFormu() {
            this.Close();
        }

        private void uiNatrag_Click(object sender, EventArgs e)
        {
            ZatvoriFormu();
        }
        public void NapuniTablicu() {
            Platitelj = Environment.NewLine+Klijent.Ime + " " + Klijent.Prezime + Environment.NewLine + Klijent.Adresa;
            uiPlatiteljPodaci.Text =Platitelj.ToUpper();
            Primatelj = Environment.NewLine + Environment.NewLine + "Zagrebačka banka d.d" + Environment.NewLine + "Trg bana Josipa Jelačića 10" + Environment.NewLine + "10000 Zagreb";
            uiPrimateljPodaci.Text = Primatelj.ToUpper();
            uiValutaPlacanja.Text = "HRK";
            uiIznosRacuna.TextAlign = HorizontalAlignment.Right;
            KamatnaStopa = Kredit.IzracunajRekurzivnuKamatnuStopu();
            uiIznosRacuna.Text = "=" + Kredit.IzracunajAnuitet(KamatnaStopa);

        }

        private void FrmGotovaUplatnica_Load(object sender, EventArgs e)
        {
            NapuniTablicu();
        }
    }
}
