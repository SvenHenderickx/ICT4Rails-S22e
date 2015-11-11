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
        private List<Beurt> schoonmaakBeurten;
        private List<Medewerker> schoonmakers;

        public SchoonmaakForm()
        {
            InitializeComponent();
            schoonmakers = Remise.Instance.SchoonmakersOphalen();
            cbMedewerker.DataSource = schoonmakers;
        }

        private void btnSchoonmaakLijstOpvragen_Click(object sender, EventArgs e)
        {
            lbSchoonmaak.Items.Clear();
            schoonmaakBeurten = Remise.Instance.SchoonmaakBeurtenLijstOphalen();

            if (schoonmaakBeurten.Count == 0)
            {
                MessageBox.Show("Er zijn geen servicebeurten");
                return;
            }

            foreach (var s in schoonmaakBeurten)
            {
                lbSchoonmaak.Items.Add(s.ToString());
            }

        }

        private void btnAftekenen_Click(object sender, EventArgs e)
        {
            int i = lbSchoonmaak.SelectedIndex;

            if (i == -1)
            {
                MessageBox.Show("Kies een schoonmaakbeurt");
                return;
            }

            Beurt b = schoonmaakBeurten[i];


            if (Remise.Instance.VerwijderBeurt(b.ID) == true)
            {
                MessageBox.Show("Servicebeurt is afgetekend");
                schoonmaakBeurten = Remise.Instance.ServiceBeurtenLijstOphalen();

                foreach (var s in schoonmaakBeurten)
                {
                    lbSchoonmaak.Items.Add(s.ToString());
                }
            }
        }

    }
}
