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
        public string KodZaBarcode;
        public Bitmap Slika;
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
            uiPrimateljPodaci.Enabled = false;
            uiValutaPlacanja.Text = "HRK";
            uiIznosRacuna.TextAlign = HorizontalAlignment.Right;
            KamatnaStopa = Kredit.IzracunajRekurzivnuKamatnuStopu();
            uiIznosRacuna.Text = "=" + Kredit.IzracunajAnuitet(KamatnaStopa);
            uiIBANPrimatelja.Text = "HR4523400091510186599";
            uiModelPlacanja.Text = "HR01";
            uiSifraNamjene.Text ="OTLC";
            uiPozivNaBrojPrimatelja.Text = "20556629-4";
            uiOpisPlacanja.Text = "Ukupan iznos za kreditnu ratu" + Environment.NewLine + "Iznos računa: " + Kredit.IzracunajAnuitet(KamatnaStopa) + " kn" + Environment.NewLine + "Dospijece racuna : " + Kredit.DatumPocetka.Value.AddMonths(1).ToString("d");
            Opis = "Ukupan iznos za kreditnu ratu";
            uiRacunPlatitelja.Text = Environment.NewLine + Klijent.Ime.ToUpper() + " " + Klijent.Prezime.ToUpper();
            uiOpisPlacanjaDesno.Text= Environment.NewLine + Opis +Environment.NewLine+ "Iznos računa: " + Kredit.IzracunajAnuitet(KamatnaStopa) + " kn";
            uiValutaIIznos.TextAlign = HorizontalAlignment.Right;
            uiValutaIIznos.Text = "HRK="+Kredit.IzracunajAnuitet(KamatnaStopa);
            KodZaBarcode = Klijent.OIB + "BARCODE";
            try
            {
                GenerirajBarcode(KodZaBarcode);
            }
            catch (Exception)
            {
                MessageBox.Show("Barcode nije moguće generirati", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void GenerirajBarcode(string kod) {
            Zen.Barcode.Code93BarcodeDraw qrcode = Zen.Barcode.BarcodeDrawFactory.Code93WithChecksum;
            uiGeneriraniBarcode.Image = qrcode.Draw(kod, 70);
        }



        private void FrmGotovaUplatnica_Load(object sender, EventArgs e)
        {
            NapuniTablicu();
        }

        public void PrikazDokumenta() {
            Graphics g = this.CreateGraphics();
            Slika = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics mg = Graphics.FromImage(Slika);

            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog();
        }
        private void uiIzvoz_Click(object sender, EventArgs e)
        {
            uiNatrag.Visible = false;
            uiIzvoz.Visible = false;
            PrikazDokumenta();
            uiNatrag.Visible = true;
            uiIzvoz.Visible = true;
        }

       
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            printDocument1.DefaultPageSettings.Landscape = true;
            printDocument1.DocumentName = "Uplatnica";
            e.Graphics.DrawImage(Slika, 0, 0);
        }
    }
}
