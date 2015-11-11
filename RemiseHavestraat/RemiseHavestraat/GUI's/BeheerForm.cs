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
    public partial class BeheerForm : Form
    {
        private List<Segment> segmentenSimulatie;
        private int indexSimulatie;

        public BeheerForm()
        {
            indexSimulatie = 0;
            InitializeComponent();
            UpdateRemiseOverzicht();
            UpdateReserveringen();
        }


        #region Allen buttons

        private void tramPlaatsenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var f = new TramPlaatsenForm())
            {
                f.ShowDialog();
                if (f.Uitvoeren)
                {
                    if (Remise.Instance.PlaatsTram(f.TramNr, f.SpoorNr, f.SegmentNr) == false)
                    {
                        MessageBox.Show("Niet gelukt");
                        return;
                    }
                }
            }
        }


        private void tramVerwijderenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var f = new TramVerwijderenForm())
            {
                f.ShowDialog();
                if (f.Uitvoeren)
                {
                    if (Remise.Instance.TramVerwijderenSegment(f.TramNr) == false)
                    {
                        MessageBox.Show("Niet gelukt");
                        return;
                    }
                    UpdateRemiseOverzicht();
                }
            }
        }

        private void reserverenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var f = new TramReserveringForm())
            {
                f.ShowDialog();
                if (f.Uitvoeren)
                {
                    if (Remise.Instance.MaakReservering(f.TramNr,f.SpoorNr) == false)
                    {
                        MessageBox.Show("Het reserveren is niet gelukt");
                        return;
                    }
                    UpdateReserveringen();
                }
            }
        }

        private void statusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var f = new TramStatusForm())
            {
                f.ShowDialog();
            }
        }

        private void infoTramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var f = new TramInfoForm())
            {
                f.ShowDialog();
            }
        }

        private void blokerenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (var f = new SpoorBlokkadeForm())
            {
                f.ShowDialog();

                if (f.Uitvoeren)
                {
                    if (Remise.Instance.BlokkeerSegment(f.SpoorNr, f.SegmentNr) == false)
                    {
                        MessageBox.Show("Niet gelukt");
                        return;
                    }
                    UpdateRemiseOverzicht();
                }
            }
        }

        private void infoSpoorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (var f = new SpoorInfoForm())
            {
                f.ShowDialog();
            }
        }

        private void uitloggenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void reparatieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var f = new ReparatieForm())
            {
                f.ShowDialog();
            }
        }

        private void schoonmaakToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var f = new SchoonmaakForm())
            {
                f.ShowDialog();
            }
        }

        private void touchscreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var f = new TouchscreenForm())
            {
                f.ShowDialog();
            }
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var f = new SpoorUpdateForm())
            {
                f.ShowDialog();
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void testdataSimulatieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Remise.Instance.ResetOverzicht();
            UpdateRemiseOverzicht();

            //Simulatie uitvoeren
            Remise.Instance.Simulatie();

            segmentenSimulatie = Remise.Instance.HaalSegmentenRandomOp();

            //Timer starten om trams in textboxen te plaatsen
            timerSimulatie.Start();
        }

        #endregion;


        #region De methodes

        /// <summary>
        /// Methode update het remise overzicht. Plaatst tramnummer in de textboxen
        /// </summary>
        private void UpdateRemiseOverzicht()
        {
            Remise.Instance.RefreshSegmenten();

            List<Segment> segmenten = Remise.Instance.GeefSegmenten();

            foreach (var s in segmenten)
            {
                string tramNr = Remise.Instance.GeefTramNr(s.Tram_ID);
                int spoorNr = Remise.Instance.GeefSpoorNr(s.SpoorID);
                int segmentNr = s.Nummer;

                TextBox tb = GeefRemiseTB(spoorNr, segmentNr);                
                tb.Text = tramNr;

                if(s.Blokkade == 1) tb.BackColor = Color.DarkGray;
                if (s.Beschikbaar == 0 && s.Tram_ID == -1) tb.BackColor = Color.LightGray;

                if (s.Beschikbaar == 1 && s.Blokkade == 0 || s.Beschikbaar == 0 && s.Tram_ID != -1)
                {
                    tb.BackColor = Color.White;
                }
            }
        }


        /// <summary>
        /// Methode geeft een 'Remise' textbox terug.
        /// </summary>
        /// <param name="spoorNR">Spoornummer van de textbox</param>
        /// <param name="segmentNR">Segmentnummer van de textox</param>
        /// <returns></returns>
        private TextBox GeefRemiseTB(int spoorNR, int segmentNR)
        {
            string textBoxNaam = "tb" + spoorNR + "segment" + segmentNR;
            TextBox tbx = Controls.Find(textBoxNaam, true).FirstOrDefault() as TextBox;
            return tbx;
        }

      
        #endregion

        private void resetDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timerSimulatie.Stop();
            Remise.Instance.ResetOverzicht();
            UpdateRemiseOverzicht();
        }

        private void timerSimulatie_Tick(object sender, EventArgs e)
        {
            Segment s = segmentenSimulatie[indexSimulatie];
            
                string tramNr = Remise.Instance.GeefTramNr(s.Tram_ID);
                int spoorNr = Remise.Instance.GeefSpoorNr(s.SpoorID);
                int segmentNr = s.Nummer;

                TextBox tb = GeefRemiseTB(spoorNr, segmentNr);
                tb.Text = tramNr;

                if (s.Blokkade == 1) tb.BackColor = Color.DarkGray;
                if (s.Beschikbaar == 0 && s.Tram_ID == -1) tb.BackColor = Color.LightGray;

                if (s.Beschikbaar == 1 && s.Blokkade == 0 || s.Beschikbaar == 0 && s.Tram_ID != -1)
                {
                    tb.BackColor = Color.White;
                }

            indexSimulatie++;

            if (indexSimulatie == segmentenSimulatie.Count)
            {
                timerSimulatie.Stop();
                indexSimulatie = 0;
            }
        }

        private void UpdateReserveringen()
        {
            List<Reservering> reserveringen = Remise.Instance.Reserveringen;
            lbReserveringen.Items.Clear();

            foreach (var r in reserveringen)
            {
                lbReserveringen.Items.Add(r.ToString());
            }

        }

       
    }
}
