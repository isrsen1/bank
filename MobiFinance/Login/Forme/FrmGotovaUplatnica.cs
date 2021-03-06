﻿using System;
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
        /// <summary>
        /// metoda za zatvaranje aktualne forme
        /// </summary>
        public void ZatvoriFormu() {
            this.Close();
        }
        /// <summary>
        /// Upravitelj događaja za zatvaranje forme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiNatrag_Click(object sender, EventArgs e)
        {
            ZatvoriFormu();
        }
        /// <summary>
        /// metoda za ispunjavanje uplatnice podacima
        /// </summary>
        public void NapuniTablicu() {
            
            Platitelj = Environment.NewLine+Klijent.Ime + " " + Klijent.Prezime + Environment.NewLine + Klijent.Adresa;
            uiPlatiteljPodaci.Text =Platitelj.ToUpper();
            Primatelj = Environment.NewLine + Environment.NewLine + "Zagrebačka banka d.d" + Environment.NewLine + "Trg bana Josipa Jelačića 10" + Environment.NewLine + "10000 Zagreb";
            uiPrimateljPodaci.Text = Primatelj.ToUpper();
            uiPrimateljPodaci.Enabled = false;
            uiValutaPlacanja.Text = "HRK";
            uiIznosRacuna.TextAlign = HorizontalAlignment.Right;
            KamatnaStopa = Kredit.IzracunajRekurzivnuKamatnuStopu();
            double anuitet = Kredit.IzracunajAnuitet(KamatnaStopa);
            uiIznosRacuna.Text = "=" + anuitet;
            
            uiIBANPrimatelja.Text = "HR4523400091510186599";
            uiModelPlacanja.Text = "HR01";
            uiSifraNamjene.Text ="OTLC";
            uiPozivNaBrojPrimatelja.Text = "20556629-4";
            uiOpisPlacanja.Text = "Ukupan iznos za kreditnu ratu" + Environment.NewLine + "Iznos računa: " + anuitet + " kn" + Environment.NewLine + "Dospijece racuna : " + Kredit.DatumPocetka.Value.AddMonths(1).ToString("d");
            Opis = "Ukupan iznos za kreditnu ratu";
            uiRacunPlatitelja.Text = Environment.NewLine + Klijent.Ime.ToUpper() + " " + Klijent.Prezime.ToUpper();
            uiOpisPlacanjaDesno.Text= Environment.NewLine + Opis +Environment.NewLine+ "Iznos računa: " + anuitet + " kn";
            uiValutaIIznos.TextAlign = HorizontalAlignment.Right;
            uiValutaIIznos.Text = "HRK="+anuitet;
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
       

        /// <summary>
        /// metoda koja služi za generiranje barkoda prema proslijeđenome kodu/stringu
        /// </summary>
        /// <param name="kod"></param>
        public void GenerirajBarcode(string kod) {
           
            BarCode pdf417 = new BarCode();
            pdf417.Symbology = KeepAutomation.Barcode.Symbology.PDF417;
            pdf417.PDF417RowCount = 3;
            pdf417.PDF417ColumnCount = 5;
            
            pdf417.CodeToEncode = kod;
            
            pdf417.PDF417DataMode = PDF417DataMode.Auto;
            pdf417.BarcodeUnit = KeepAutomation.Barcode.BarcodeUnit.Pixel;
          //  pdf417.DPI = 100;
            pdf417.X = 1.9f;
            pdf417.Y = pdf417.X / 0.3f;
            //pdf417.Y = 2;
            pdf417.BarCodeWidth =44;
            pdf417.BarCodeHeight = 20;
            pdf417.PDF417XtoYRatio =0.2f;
            pdf417.LeftMargin =12;
            
            pdf417.RightMargin = 12;
            pdf417.TopMargin = 6;
            pdf417.BottomMargin = 6;
            pdf417.Orientation = KeepAutomation.Barcode.Orientation.Degree0;
            pdf417.ImageFormat = ImageFormat.Png;
            pdf417.PDF417ECL = PDF417ECL.ECL_1;
            Bitmap barcodeInBitmap = pdf417.generateBarcodeToBitmap();
            uiGeneriraniBarcode.Image = barcodeInBitmap ;







        }


        /// <summary>
        /// Popunjavanje uplatnice na učitavanje forme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmGotovaUplatnica_Load(object sender, EventArgs e)
        {
            NapuniTablicu();
        }

        /// <summary>
        /// metoda koja preslikava aktualno otvorenu formu u printviewdialog().
        /// </summary>
        public void PrikazDokumenta() {
            Graphics g = this.CreateGraphics();
            Slika = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics mg = Graphics.FromImage(Slika);

            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog();
        }

        /// <summary>
        /// metoda koja služi za pozivanje metode za prikaz forme u printviewDialogu()
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiIzvoz_Click(object sender, EventArgs e)
        {
            uiNatrag.Visible = false;
            uiIzvoz.Visible = false;
            PrikazDokumenta();
            uiNatrag.Visible = true;
            uiIzvoz.Visible = true;
        }

       /// <summary>
       /// Ispis forme u pdf
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            printDocument1.DefaultPageSettings.Landscape = true;
            printDocument1.DocumentName = "Uplatnica";
            e.Graphics.DrawImage(Slika, 0, 0);
        }

        private void FrmGotovaUplatnica_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F1)
            {
                System.Diagnostics.Process.Start("https://github.com/foivz/r18061/wiki/Korisni%C4%8Dka-dokumentacija#24-ispis-generirane-uplatnice");
            }
        }
    }
}
