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
    public partial class TramReserveringForm : Form
    {
        public int TramNr;
        public int SpoorNr;
        public int SegmentNr;

        public bool Uitvoeren = false;

        public TramReserveringForm()
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

            //Bekijken of tram bestaat

            if (Remise.Instance.BestaatTram(TramNr) == false)
            {
                MessageBox.Show("Tramnummer betaat niet");
                return;
            }

            //Bekijken of spoor bestaat
            if (Remise.Instance.BestaatSpoor(SpoorNr) == false)
            {
                MessageBox.Show("Segment betaat niet");
                return;
            }

            //Bekijken of reservering al bestaat
            if (Remise.Instance.BestaatReservering(TramNr, SpoorNr) == false)
            {
                MessageBox.Show("Reservering betaat al");
                return;
            }

            //Close form
            Uitvoeren = true;
            Close();

        }
    }
}
