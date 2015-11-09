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
        public TramPlaatsenForm()
        {
            InitializeComponent();
        }

        private void btnBevestig_Click(object sender, EventArgs e)
        {
            int tramNr;
            int spoorNr;
            int segmentNr;


            if (Int32.TryParse(tbTramnummer.Text, out tramNr) == false)
            {
                MessageBox.Show("Ongeldige invoer tramnummer");
            }

            if (Int32.TryParse(tbSpoornummer.Text, out spoorNr) == false)
            {
                MessageBox.Show("Ongeldige invoer spoornummer");
            }

            if (Int32.TryParse(tbSegmentnummer.Text, out segmentNr) == false)
            {
                MessageBox.Show("Ongeldige invoer segmentnummer");
            }
           

            //Bekijken of tram bestaat

            if (Remise.Instance.BestaatTram(tramNr) == false)
            {
                MessageBox.Show("Tramnummer betaat niet");
                return;
            }

            //Bekijken of segment bestaat
            if (Remise.Instance.BestaatSegment(spoorNr, segmentNr) == false)
            {
                MessageBox.Show("Segment betaat niet");
                return;
                
            }

            //Tram plaatsen
            Remise.Instance.PlaatsTram(tramNr,spoorNr,segmentNr);

        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
