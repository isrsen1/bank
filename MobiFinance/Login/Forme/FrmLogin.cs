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
        public FrmLogin()
        {
            InitializeComponent();
        }

       

        private void btnPrijaviSe_Click(object sender, EventArgs e)
        {
            FrmMain forma = new FrmMain();
            forma.ShowDialog();
            this.Close();
        }
    }
}
