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
using KeepAutomation.Barcode.Bean;
using KeepAutomation.Barcode.Windows;
using KeepAutomation;
using System.Drawing.Imaging;
using KeepAutomation.Barcode;

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
            string novaCijena = Klijent.UrediCijenu(Kredit.IzracunajAnuitet(KamatnaStopa));

            KodZaBarcode = Klijent.GenerirajPodatkeZaBarKod(novaCijena);
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
           
            BarCode pdf417 = new BarCode();
            pdf417.Symbology = KeepAutomation.Barcode.Symbology.PDF417;
            pdf417.PDF417RowCount = 1;
            pdf417.PDF417ColumnCount = 1;
            
            pdf417.CodeToEncode = kod;
            pdf417.DataMatrixDataMode = DataMatrixDataMode.ASCII;
            pdf417.PDF417DataMode = PDF417DataMode.Auto;
            pdf417.BarcodeUnit = KeepAutomation.Barcode.BarcodeUnit.Pixel;
            pdf417.DPI = 72;
            pdf417.X = 2;
            pdf417.Y = 113;
            pdf417.BarCodeWidth =20;
            pdf417.BarCodeHeight = 80;
            pdf417.PDF417XtoYRatio =0.3f;
            pdf417.LeftMargin = 6;
            pdf417.RightMargin = 6;
            pdf417.TopMargin = 6;
            pdf417.BottomMargin = 6;
            pdf417.Orientation = KeepAutomation.Barcode.Orientation.Degree0;
            pdf417.ImageFormat = ImageFormat.Png;
            pdf417.PDF417ECL = PDF417ECL.ECL_1;
            Bitmap barcodeInBitmap = pdf417.generateBarcodeToBitmap();
            uiGeneriraniBarcode.Image = barcodeInBitmap ;







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
