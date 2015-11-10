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
    public partial class SpoorBlokkadeForm : Form
    {
        public int SpoorNr;
        public int SegmentNr;
        public bool Uitvoeren = false;

        public SpoorBlokkadeForm()
        {
            InitializeComponent();
        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnToggle_Click(object sender, EventArgs e)
        {
            /*
            int segment = 0;
            int spoor = 0;
            if (Int32.TryParse(tbSpoornummer.Text, out spoor) && Int32.TryParse(tbSegmentnummer.Text, out segment))
            {
                if(Remise.Instance.SpoorBlokkeren(spoor, segment) == false)
                {
                    MessageBox.Show("Oeps, er ging iets mis, uw verzoek is niet uitgevoerd.");
                }
                else
                {
                    tbSegmentnummer.Clear();
                    tbSpoornummer.Clear();
                    MessageBox.Show("Spoor: " + spoor + " vanaf segment: " + segment + " is geblokkeerd");
                }
            }
            else
            {
                MessageBox.Show("Voer AUB overal geldige data in.");
            }
              */

            if (Int32.TryParse(tbSpoornummer.Text, out SpoorNr) == false)
            {
                MessageBox.Show("Ongeldige invoer in spoor nummer");
                return;
            }
            if (Int32.TryParse(tbSegmentnummer.Text, out SegmentNr) == false)
            {
                MessageBox.Show("Ongeldige invoer in segment nummer");
                return;
            }

            //Bekijken of segment bestaat
            if (Remise.Instance.BestaatSegment(SpoorNr, SegmentNr) == false)
            {
                MessageBox.Show("Segment betaat niet");
                return;
            }

            Uitvoeren = true;
            Close();

        }
    }
}
