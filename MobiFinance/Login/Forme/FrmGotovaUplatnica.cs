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

    }
}
