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
    public partial class ReparatieForm : Form
    {
        public ReparatieForm()
        {
            InitializeComponent();
        }

        private void btnReparatieLijstOpvragen_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAftekenenReparatie_Click(object sender, EventArgs e)
        {

        }

        private void btnTakenToevoegenReparatie_Click(object sender, EventArgs e)
        {
            string tramnummer = tbTreinNummerSchoonmaak.Text;
            int medewerkerid = Convert.ToInt32(tbMedewerker.Text);
            string type = tbType.Text;
            string beschrijving = tbBeschrijving.Text;
            string prioriteit = tbPrioriteit.Text;
            DateTime datumbegin = Convert.ToDateTime(dtpBeginR);
            DateTime datumeind = Convert.ToDateTime(dtpEindR);

            /*
            bool resultaat = dk.VoegToe(tramnummer, medewerkerid, type, beschrijving, prioriteit, datumbegin, datumeind);
            if (resultaat == false)
            {
                MessageBox.Show("Er ging iets mis, er is geen nieuwe taak toegevoegd.");
            }*/
        }
    }
}
