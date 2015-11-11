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
            Remise.Instance.MedewerkersOphalen("Technicus");
        }

        private void btnReparatieLijstOpvragen_Click(object sender, EventArgs e)
        {
            Remise.Instance.ServiceBeurtenOphalen();
            VerversServicebeurten(Remise.Instance.Beurten);
        }

        private void btnAftekenenReparatie_Click(object sender, EventArgs e)
        {
            if (lbReparatie.SelectedItem != null)
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
            else
            {
                MessageBox.Show("Selecteer een servicebeurt om af te tekenen.");
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
            if (string.IsNullOrEmpty(tbTreinNummerSchoonmaak.Text) || string.IsNullOrEmpty(tbMedewerker1.Text) || string.IsNullOrEmpty(tbBeschrijving.Text))
            {
                MessageBox.Show("Voer AUB alle benodigde data in.");
            }
            else
            {
                if (rbGroot.Checked) type = 1;
                if (rbKlein.Checked) type = 0;
                if (rbNietBelangrijk.Checked) prioriteit = 0;
                if (rbNormaal.Checked) prioriteit = 1;
                if (rbSpoed.Checked) prioriteit = 2;
                if (rbGroot.Checked) prioriteit = 3;
                if (Int32.TryParse(tbTreinNummerSchoonmaak.Text, out tramnummer) || Int32.TryParse(tbMedewerker1.Text, out medewerkerid1))
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
                    bool resultaat = Remise.Instance.VoegServiceBeurtToe(tram, medewerkers, type, prioriteit, beschrijving, datumbegin);
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

        public void VerversServicebeurten(List<Beurt> beurten)
        {
            if (beurten == null) return;
            lbReparatie.Items.Clear();
            foreach (Beurt b in beurten)
            {
                lbReparatie.Items.Add(b.ToString());
            }
        }
    }
}
