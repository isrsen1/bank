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

        }

        private void btnPregledKorisnika_Click(object sender, EventArgs e)
        {
            FrmPregledKorisnika pregledKorisnika = new FrmPregledKorisnika();
            pregledKorisnika.ShowDialog();
            this.Close();
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
            if (MessageBox.Show("Are you sure you want to exit?", "Confirm exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                Login login = new Login();
                login.ShowDialog();
                this.Close();
            }
            else
            {

            }
        }
    }
}
