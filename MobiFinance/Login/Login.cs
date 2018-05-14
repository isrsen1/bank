using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Login
{
    public partial class Login : Form
    {

    //testiranje ignore postavki
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string m_strFilePath = "http://api.hnb.hr/tecajn?valuta=EUR&format=xml";

            XmlDocument myXmlDocument = new XmlDocument();
            myXmlDocument.Load(m_strFilePath);

            foreach (XmlNode RootNode in myXmlDocument.ChildNodes)
            {
                MessageBox.Show(RootNode.InnerText);
            }
        }
    }
}
