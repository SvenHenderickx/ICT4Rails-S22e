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
    public partial class TouchscreenForm : Form
    {
        private string invoer ;

        public int TramNr;
        public int SpoorNr;
        public Beurt Schoonmaak;
        public Beurt Reparatie;

        public TouchscreenForm()
        {
            InitializeComponent();
            invoer = "";

        }



        #region Alle bedieningsknoppen


        

        private void btnNum1_Click(object sender, EventArgs e)
        {
            invoer += 1;
            tbTramnummer.Text = invoer;

        }

        private void btnNum2_Click(object sender, EventArgs e)
        {
            invoer += 2;
            tbTramnummer.Text = invoer;
        }

        private void btnNum3_Click(object sender, EventArgs e)
        {
            invoer += 3;
            tbTramnummer.Text = invoer;
        }

        private void btnNum4_Click(object sender, EventArgs e)
        {
            invoer += 4;
            tbTramnummer.Text = invoer;
        }

        private void btnNum5_Click(object sender, EventArgs e)
        {
            invoer += 5;
            tbTramnummer.Text = invoer;
        }

        private void btnNum6_Click(object sender, EventArgs e)
        {
            invoer += 6;
            tbTramnummer.Text = invoer;
        }

        private void btnNum7_Click(object sender, EventArgs e)
        {
            invoer += 7;
            tbTramnummer.Text = invoer;
        }

        private void btnNum8_Click(object sender, EventArgs e)
        {
            invoer += 8;
            tbTramnummer.Text = invoer;
        }

        private void btnNum9_Click(object sender, EventArgs e)
        {
            invoer += 9;
            tbTramnummer.Text = invoer;
        }

        private void btnHerstel_Click(object sender, EventArgs e)
        {
            if (invoer.Count() < 1) return;

            invoer = invoer.Substring(0, invoer.Length - 1);
            tbTramnummer.Text = invoer;
        }

        private void btnNum0_Click(object sender, EventArgs e)
        {
            invoer += 0;
            tbTramnummer.Text = invoer;
        }

        private void btnBevestig_Click(object sender, EventArgs e)
        {
            bool serviceNodig = (cbDefectNodig.Checked);
            bool schoonmaakNodig = (cbSchoonmaaknodig.Checked);


            string omschrijvingDefect = tbDefect.Text;
            string omschrijvingSchoonmaak = tbSchoonmaak.Text;

            int tramNr = 100;
            Tram tram = Remise.Instance.GeefTram(tramNr);

            if (serviceNodig)
            {
                // schoonmaak toevoegen
                Remise.Instance.NieuweBeurt(new DateTime(1, 1, 1, 1, 1, 1), new DateTime(1, 1, 1, 1, 1, 1), omschrijvingSchoonmaak, tram,
                    EnumTypeBeurt.KleineSchoonmaak);

                // nog implementeren
            }

            if (schoonmaakNodig)
            {
                //Reparatie toevoegen
                Remise.Instance.NieuweBeurt(new DateTime(1, 1, 1, 1, 1, 1), new DateTime(1, 1, 1, 1, 1, 1), omschrijvingDefect, tram,
                   EnumTypeBeurt.KleineService);

                // onderhoudsbeurt toevoegen

                // nog implementeren
            }

        }
         #endregion
    }
}
