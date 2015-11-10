using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RemiseHavestraat
{
    public partial class TramVerwijderenForm : Form
    {
        public int TramNr;
        public bool Uitvoeren;

        public TramVerwijderenForm()
        {
            InitializeComponent();
        }

        private void btnBevestig_Click(object sender, EventArgs e)
        {
            /*
            int tramnummer;

            if (Int32.TryParse(tbTramnummer.Text, out tramnummer) == false)
            {
                MessageBox.Show("Ongeldige invoer");
            }

            if (!string.IsNullOrEmpty(tbTramnummer.Text))
            {
                Remise.Instance.TramVerwijderenSegment(tramnummer);
                Remise.Instance.SegmentenOphalen();
                tbTramnummer.Clear();
            }
             */

            if (Int32.TryParse(tbTramnummer.Text, out TramNr) == false)
            {
                MessageBox.Show("Ongeldige invoer");
            }

            Uitvoeren = true;
            Close();
            Remise.Instance.TramVerwijderenSegment(TramNr);


        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
