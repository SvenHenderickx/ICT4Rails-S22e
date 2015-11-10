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
    public partial class TramPlaatsenForm : Form
    {
       public int TramNr;
       public int SpoorNr;
       public int SegmentNr;

        public bool Uitvoeren = false;

        public TramPlaatsenForm()
        {
            InitializeComponent();
        }

        private void btnBevestig_Click(object sender, EventArgs e)
        {

            if (Int32.TryParse(tbTramnummer.Text, out TramNr) == false)
            {
                MessageBox.Show("Ongeldige invoer tramnummer");
            }

            if (Int32.TryParse(tbSpoornummer.Text, out SpoorNr) == false)
            {
                MessageBox.Show("Ongeldige invoer spoornummer");
            }

            if (Int32.TryParse(tbSegmentnummer.Text, out SegmentNr) == false)
            {
                MessageBox.Show("Ongeldige invoer segmentnummer");
            }
           

            //Bekijken of tram bestaat

            if (Remise.Instance.BestaatTram(TramNr) == false)
            {
                MessageBox.Show("Tramnummer betaat niet");
                return;
            }

            //Bekijken of segment bestaat
            if (Remise.Instance.BestaatSegment(SpoorNr, SegmentNr) == false)
            {
                MessageBox.Show("Segment betaat niet");
                return;
            }

            //Close form
            Uitvoeren = true;
            Close();
           }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
