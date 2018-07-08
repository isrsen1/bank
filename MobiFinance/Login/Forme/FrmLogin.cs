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

        public bool ProvjeriUnos() {
            if (txtUser.Text == "admin123" && txtLozinka.Text == "nozuledja123")
            {
                return true;
            }
            else return false;
        }

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
    }
}
