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
    public partial class SchoonmaakForm : Form
    {
        public SchoonmaakForm()
        {
            InitializeComponent();
        }

        private void btnSchoonmaakLijstOpvragen_Click(object sender, EventArgs e)
        {
            Remise.Instance.SchoonmaakBeurtenOphalen();
            foreach (SchoonmaakBeurt beurt in Remise.Instance.Beurten)
            {
                lbSchoonmaak.Items.Add(beurt.ToString());
            }
        }

        private void btnAftekenen_Click(object sender, EventArgs e)
        {
            DateTime eind = dtpEind.Value;
            foreach (Beurt beurt in Remise.Instance.Beurten)
            {
                if (beurt.ToString() == lbSchoonmaak.SelectedItem.ToString())
                {
                    Remise.Instance.SchoonmaakBeurtAftekenen(beurt, eind);
                }
            }
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

            if (string.IsNullOrEmpty(tbTreinNummerSchoonmaak.Text) || string.IsNullOrEmpty(tbMedewerkerS.Text) || string.IsNullOrEmpty(tbType.Text)
                || string.IsNullOrEmpty(tbBeschrijving.Text) || string.IsNullOrEmpty(tbPrioriteitS.Text))
            {

            }
            /*Nog niet klaar
            bool resultaat = dk.VoegToe(tramnummer, medewerkerid, type, beschrijving, prioriteit, datumbegin, datumeind);
            if (resultaat == false)
            {
                MessageBox.Show("Er ging iets mis, er is geen nieuwe taak toegevoegd.");
            }*/
        }
    }
}
