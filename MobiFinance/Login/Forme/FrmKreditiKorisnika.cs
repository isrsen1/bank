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
        public BindingList<Klijent> ListaKorisnika;
        public BindingList<Kredit_> ListaKreditaKorsinika;
        public FrmKreditiKorisnika()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Metoda za dohvaćanje svih korisnika iz baze podataka
        /// </summary>
        public void PrikaziKorisnike()
        {
            klijentBindingSource.DataSource = null;
            ListaKorisnika = new BindingList<Klijent>();
            ListaKorisnika = Klijent.DohvatiKorisnike();
            klijentBindingSource.DataSource = Klijent.DohvatiKorisnike();
        }

        /// <summary>
        /// Metoda za dohvaćanje svih aktivnih kredita odabranog klijenta
        /// </summary>
        /// <param name="k"></param>
        public void PrikaziKrediteOdabranogKorisnika(Klijent k) {
            kreditBindingSource.DataSource = null;
            ListaKreditaKorsinika = new BindingList<Kredit_>();
            ListaKreditaKorsinika = Kredit.DohvatiKrediteKorisnika(k);
            kreditBindingSource.DataSource = ListaKreditaKorsinika;
        }
        /// <summary>
        /// Metoda za događaj učitavanja forme-prikaz svih korisnika
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmKreditiKorisnika_Load(object sender, EventArgs e)
        {
            PrikaziKorisnike();
            

        }
        /// <summary>
        /// metoda za zatvaranje aktivne forme
        /// </summary>
        public void ZatvoriFormu() {
            this.Close();
        }

        private void uiNazad_Click(object sender, EventArgs e)
        {
            ZatvoriFormu();
            
        }
        /// <summary>
        /// Metoda za mijenjanje kredita za prikazanog klijenta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvPrikazKorisnika_SelectionChanged(object sender, EventArgs e)
        {
            odabraniKlijent = klijentBindingSource.Current as Klijent;
            try
            {
                PrikaziKrediteOdabranogKorisnika(odabraniKlijent);
            }
            catch (Exception)
            {
                MessageBox.Show("Došlo je do pogreške.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Otvaranje forme za generiranje uplatnice odabranog kredita
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiUplatnicazaKredit_Click(object sender, EventArgs e)
        {
            try {
                FrmGotovaUplatnica novaUplatnica = new FrmGotovaUplatnica(klijentBindingSource.Current as Klijent, kreditBindingSource.Current as Kredit_);
                this.Hide();
                novaUplatnica.ShowDialog();
                this.Show();
            }
            catch (Exception) {
                MessageBox.Show("Došlo je do pogreške.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }
    }
}
