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
    public partial class ReparatieForm : Form
    {
        public ReparatieForm()
        {
            InitializeComponent();
        }

        private void btnReparatieLijstOpvragen_Click(object sender, EventArgs e)
        {
            Remise.Instance.ServiceBeurtenOphalen();
            foreach (Beurt beurt in Remise.Instance.Beurten)
            {
                lbReparatie.Items.Add(beurt.ToString());
            }
        }

        private void btnAftekenenReparatie_Click(object sender, EventArgs e)
        {
            DateTime eind = dtpEindR.Value;
            foreach (Beurt beurt in Remise.Instance.Beurten)
            {
                if (beurt.ToString() == lbReparatie.SelectedItem.ToString())
                {
                    Remise.Instance.SchoonmaakBeurtAftekenen(beurt, eind);
                }
            }
        }

        private void btnTakenToevoegenReparatie_Click(object sender, EventArgs e)
        {
            Tram tram = null;
            List<int> medewerkersid = new List<int>();
            int tramnummer;
            int medewerkerid1 = 0;
            int medewerkerid2 = 0;
            int medewerkerid3 = 0;
            int medewerkerid4 = 0;
            int medewerkerid5 = 0;
            int type = 0;
            int prioriteit = 0;
            string beschrijving = tbBeschrijving.Text;
            DateTime datumbegin = dtpBeginR.Value;
            if (string.IsNullOrEmpty(tbTreinNummerSchoonmaak.Text) || string.IsNullOrEmpty(tbMedewerker1.Text) || string.IsNullOrEmpty(tbType.Text) || string.IsNullOrEmpty(tbBeschrijving.Text) || string.IsNullOrEmpty(tbPrioriteit.Text))
            {
                MessageBox.Show("Voer AUB alle benodigde data in.");
            }
            else
            {
                if (Int32.TryParse(tbTreinNummerSchoonmaak.Text, out tramnummer) || Int32.TryParse(tbMedewerker1.Text, out medewerkerid1) || Int32.TryParse(tbType.Text, out type) || Int32.TryParse(tbPrioriteit.Text, out prioriteit))
                {
                    medewerkersid.Add(medewerkerid1);
                    if (Int32.TryParse(tbMedewerker2.Text, out medewerkerid2))
                    {
                        medewerkersid.Add(medewerkerid2);
                        if (Int32.TryParse(tbMedewerker3.Text, out medewerkerid3))
                        {
                            medewerkersid.Add(medewerkerid3);
                            if (Int32.TryParse(tbMedewerker4.Text, out medewerkerid4))
                            {
                                medewerkersid.Add(medewerkerid4);
                                if (Int32.TryParse(tbMedewerker5.Text, out medewerkerid5))
                                {
                                    medewerkersid.Add(medewerkerid5);
                                }
                            }
                        }
                    }
                    tram = Remise.Instance.GeefTram(tramnummer);
                    List<Medewerker> medewerkers = Remise.Instance.MedewerkersZoeken(medewerkersid);
                    bool resultaat = Remise.Instance.VoegSchoonmaakBeurtToe(tram, medewerkers, type, prioriteit, beschrijving, datumbegin);
                    if (resultaat == false)
                    {
                        MessageBox.Show("Er ging iets mis, er is geen nieuwe taak toegevoegd.");
                    }
                }
                else
                {
                    MessageBox.Show("Voer AUB nummers in, waar om nummer word gevraagd.");
                }
            }
        }
    }
}
