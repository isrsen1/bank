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
    public partial class FrmMain : Template
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            
        }

        private void btnOtplatnaTablica_Click(object sender, EventArgs e)
        {
            FrmOtplatnaTablica otplatna = new FrmOtplatnaTablica();
            this.Hide();
            otplatna.ShowDialog();
            this.Show();
        }

        private void btnPregledKorisnika_Click(object sender, EventArgs e)
        {
            FrmPregledKlijenata pregledKorisnika = new FrmPregledKlijenata();
            this.Hide();
            pregledKorisnika.ShowDialog();
            this.Show();
        }

        private void btnUsluge_Click(object sender, EventArgs e)
        {
            FrmUsluge usluge = new FrmUsluge();
            usluge.ShowDialog();
            this.Close();
        }

        private void btnOtvaranjeUsluga_Click(object sender, EventArgs e)
        {
            FrmOtvaranjeUsluga otvaranjeUsluga = new FrmOtvaranjeUsluga();
            otvaranjeUsluga.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Confirm exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Zaposlenik.PrijavljeniKorisnik = null;
                this.Close();
                FrmLogin login = new FrmLogin();
                login.ShowDialog();
              
            }
            else
            {

            }
        }

        private void btnUplatnica_Click(object sender, EventArgs e)
        {

            MobiFinance.Forme.FrmKreditiKorisnika formaPopisKredita = new MobiFinance.Forme.FrmKreditiKorisnika();
            this.Hide();
            formaPopisKredita.ShowDialog();
            this.Show();


        }

        private void FrmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F1)
            {
                System.Diagnostics.Process.Start("https://github.com/foivz/r18061/wiki/Korisni%C4%8Dka-dokumentacija#13-po%C4%8Detni-prikaz");
            }
        }
    }
}
