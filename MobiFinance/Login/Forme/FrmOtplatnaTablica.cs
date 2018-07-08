using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DGVPrinterHelper;

namespace Login.Forme
{
    public partial class FrmOtplatnaTablica : Template
    {
        private DGVPrinter printanjeTablice = new DGVPrinter();
        private Kredit_ krediti = new Kredit_();
        private Otplatna_tablica dioOtplate = null;
        public BindingList<Otplatna_tablica> ListaOtplate;
        public double RekurzivnaKamatnaStopa = 0;
        private double anuitet = 0;
        private Kredit_ odabraniKredit;
        public BindingList<Kredit_> PohranaKredita = null;
        public FrmOtplatnaTablica()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Metoda za dohvaćanje i prikaz kredita iz baze podataka
        /// </summary>
     
        public void PrikaziKredite() {
            kreditBindingSource.DataSource = null;
            PohranaKredita = new BindingList<Kredit_>();
            PohranaKredita = krediti.DohvatiKredite();
            kreditBindingSource.DataSource = PohranaKredita;
        }
        /// <summary>
        /// Prilikom učitavanja prikazuju se krediti te se prema odabranome kreditu izrađuje otplatna tablica
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void FrmOtplatnaTablica_Load(object sender, EventArgs e)
        {
            PrikaziKredite();
            odabraniKredit = cbPopisKredita.SelectedItem as Kredit_;
            odabraniKredit.KolekcijaZapisa.Clear();
            try
            {
                NapuniDataGridView(odabraniKredit);
                OsvjeziEkran(odabraniKredit);

            }
            catch (Exception)
            {
                MessageBox.Show("Došlo je do pogreške.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        /// <summary>
        /// metoda za dohvaćanje podataka otplatne tablice
        /// </summary>
        /// <param name="kredit"></param>

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

        /// <summary>
        ///  metoda u kojoj se računaju podaci za samu otplatnu tablicu 
        /// </summary>
        /// <param name="r"></param>
        /// <param name="anuitet"></param>
        /// <param name="pom"></param>

        public void IzracunajOtplatnuTablicu(double r,double anuitet,Kredit_ pom) {

            double ostatakDuga = 0;
            ostatakDuga = pom.Glavnica;
            double otplatnaKvota = 0;
            double otplaceniDioDuga = 0;
            double kamataRazdoblja = 0;
            for (int i=1;i<=pom.RokOtplate;i++) {
                kamataRazdoblja = pom.IzracunajKamatuRazdoblja(ostatakDuga,r);

                otplatnaKvota = pom.IzracunajOtplatnuKvotu(anuitet,kamataRazdoblja);
                otplaceniDioDuga = pom.IzracunajOtplaceniDioDuga(otplaceniDioDuga,otplatnaKvota);
                dioOtplate = new Otplatna_tablica(i,kamataRazdoblja,anuitet,otplatnaKvota,ostatakDuga,otplaceniDioDuga,i);
                pom.DodajZapisUOtplatnu(dioOtplate);
                ostatakDuga = pom.IzracunajOstatakDUga(ostatakDuga,otplatnaKvota);

            }

        }
        /// <summary>
        /// metoda koja dodaje izvor BindingSourcu za prikaz izračunate otplatne tablice
        /// </summary>
        /// <param name="odabraniKredit"></param>

        public void OsvjeziEkran(Kredit_ odabraniKredit) {
            otplatnatablicaBindingSource.DataSource = null;
            ListaOtplate = new BindingList<Otplatna_tablica>(odabraniKredit.KolekcijaZapisa);
            otplatnatablicaBindingSource.DataSource = ListaOtplate;
        }
        /// <summary>
        ///   metoda koja služi za ispis otplatne tablice
        /// </summary>
        /// <param name="printer"></param>

        public void Printanje(DGVPrinter printer) {
            printer.Title = "Otplatna tablica ";
            printer.SubTitle = string.Format("{0}", DateTime.Now.Date)+" "+Environment.NewLine+"Tablicu izdao: "+Zaposlenik.PrijavljeniKorisnik.Ime+" "+Zaposlenik.PrijavljeniKorisnik.Prezime;
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;

            printer.PageNumberAlignment = StringAlignment.Far;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Zagrebačka banka";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dgvOtplatnaTablica);
        }
        /// <summary>
        /// metoda koja reagira na promjenu comboboxa te prema odabranome kreditu izračunava otplatnu tablicu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //metoda koja reagira na promjenu comboboxa te prema odabranome kreditu izračunava otplatnu tablicu
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

        private void btnPrintanje_Click(object sender, EventArgs e)
        {
           
                try
                {
                    Printanje(printanjeTablice);
                 
                }
                catch (Exception)
                {
                    MessageBox.Show("Došlo je do pogreške.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
        }
        public void ZatvoriFormu() {
            this.Close();
        }
        private void btnVratiNazad_Click(object sender, EventArgs e)
        {
            ZatvoriFormu();
        }
    }
}
