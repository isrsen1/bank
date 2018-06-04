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
    public partial class FrmDodajKlijentaPrivatni : Template
    {
        public FrmDodajKlijentaPrivatni()
        {
            InitializeComponent();
        }

        private void FrmDodajKorisnikaPrivatni_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPrethodna_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPocetna_Click(object sender, EventArgs e)
        {
            FrmMain glavnaForma = new FrmMain();
            glavnaForma.Show();
        }
    }
}
