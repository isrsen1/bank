using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Login.Forme
{
    public partial class FrmLogin : Template
    {
        public Zaposlenik Prijava;
        public FrmLogin()
        {
            InitializeComponent();
        }

        /// <summary>
        /// metoda za provjeravanje korsiničkog unosa
        /// </summary>
        /// <returns></returns>

        public bool ProvjeriUnos() {
            if (txtUser.Text == "admin123" && txtLozinka.Text == "nozuledja123")
            {
                return true;
            }
            else return false;
        }
        /// <summary>
        /// metoda pomoću koje se na pritisak gumba prijavimo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrijaviSe_Click(object sender, EventArgs e)
        {
            if (ProvjeriUnos() == true)
            {
                Prijava = new Zaposlenik(1, "Jurica", "Orsulic", "jorsulic@mzaba.com", "Trg Palih boraca 44", "0911233218", "admin123", 1, "nozuledja123");
                Zaposlenik.PrijavljeniKorisnik = Prijava;
                this.Hide();
                FrmMain forma = new FrmMain();
                forma.ShowDialog();
                this.Close();
            }
            else {
                label1.BackColor = Color.White;
                label1.ForeColor = Color.Red;
                
                label1.Text = "Unijeli ste krive podatke !!!";
            }
           
           
        }

        /// <summary>
        /// izlazak iz forme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyData == Keys.F1) {
                System.Diagnostics.Process.Start("https://github.com/foivz/r18061/wiki/Korisni%C4%8Dka-dokumentacija#12-prijava");
            }
        }
    }
}
