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

        
        public BeheerForm()
        {
            InitializeComponent();
            bool test = Remise.Instance.MedewerkersOphalen();
            MessageBox.Show("Medewerkers Ophalen:" + test.ToString());
        }


        #region Allen buttons

        private void tramPlaatsenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var f = new TramPlaatsenForm())
            {
                f.ShowDialog();
            }
        }


        private void tramVerwijderenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var f = new TramVerwijderenForm())
            {
                f.ShowDialog();
            }
        }

        private void reserverenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var f = new TramReserveringForm())
            {
                f.ShowDialog();
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

        private void testdataSimulatieToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        #endregion;


        #region De methodes

        private void UpdateRemiseOverzicht()
        {/*
            foreach (var v in)
            {
                
            }
          * */
        }

        #endregion


        

    }
}
