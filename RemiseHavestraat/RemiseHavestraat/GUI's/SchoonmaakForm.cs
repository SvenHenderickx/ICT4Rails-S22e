using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RemiseHavestraat.GUI_s
{
    public partial class SchoonmaakForm : Form
    {
        public SchoonmaakForm()
        {
            InitializeComponent();
        }

        private void btnSchoonmaakLijstOpvragen_Click(object sender, EventArgs e)
        {

        }

        private void btnAftekenen_Click(object sender, EventArgs e)
        {

        }

        private void btnTakenToevoegen_Click(object sender, EventArgs e)
        {
            string tramnummer = tbTreinNummerSchoonmaak.Text;
            int medewerkerid = Convert.ToInt32(tbMedewerkerS.Text);
            string type = tbType.Text;
            string beschrijving = tbBeschrijving.Text;
            string prioriteit = tbPrioriteitS.Text;
            DateTime datumbegin = Convert.ToDateTime(dtpBegin);
            DateTime datumeind = Convert.ToDateTime(dtpEind);

            /*Nog niet klaar
            bool resultaat = dk.VoegToe(tramnummer, medewerkerid, type, beschrijving, prioriteit, datumbegin, datumeind);
            if (resultaat == false)
            {
                MessageBox.Show("Er ging iets mis, er is geen nieuwe taak toegevoegd.");
            }*/
        }
    }
}
