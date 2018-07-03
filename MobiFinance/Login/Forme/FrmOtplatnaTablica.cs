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
    public partial class FrmOtplatnaTablica : Template
    {

        private Kredit_ krediti = new Kredit_();
        public FrmOtplatnaTablica()
        {
            InitializeComponent();
        }
        public void PrikaziKredite() {
            kreditBindingSource.DataSource = null;
            kreditBindingSource.DataSource = krediti.DohvatiKredite();
        }

        private void FrmOtplatnaTablica_Load(object sender, EventArgs e)
        {
            PrikaziKredite();
        }
    }
}
