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
        private List<Beurt> serviceBeurten;
        private List<Medewerker> technici;
        


        public ReparatieForm()
        {
           InitializeComponent();
            technici = Remise.Instance.TechniciOphalen();
            cbMedewerker.DataSource = technici;

        }

        private void btnReparatieLijstOpvragen_Click(object sender, EventArgs e)
        {
            
            lbReparatie.Items.Clear();
            serviceBeurten = Remise.Instance.ServiceBeurtenLijstOphalen();

            if (serviceBeurten.Count == 0)
            {
                MessageBox.Show("Er zijn geen servicebeurten");
                return;
            }

            foreach (var s in serviceBeurten)
            {
                lbReparatie.Items.Add(s.ToString());
            }

        }

        private void btnAftekenenReparatie_Click(object sender, EventArgs e)
        {
            int i = lbReparatie.SelectedIndex;

            if (i == -1)
            {
                MessageBox.Show("Kies een servicebeurt");
                return;
            }

            Beurt b = serviceBeurten[i];


            if (Remise.Instance.VerwijderBeurt(b.ID) == true)
            {
                MessageBox.Show("Servicebeurt is afgetekend");
                serviceBeurten = Remise.Instance.ServiceBeurtenLijstOphalen();

                foreach (var s in serviceBeurten)
                {
                    lbReparatie.Items.Add(s.ToString());
                }
            }
        }

        private void btnTakenToevoegenReparatie_Click(object sender, EventArgs e)
        {
        }

 

    }
}
