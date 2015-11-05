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
    public partial class TramPlaatsenForm : Form
    {
        public TramPlaatsenForm()
        {
            InitializeComponent();
        }

        private void btnBevestig_Click(object sender, EventArgs e)
        {
            string tramnummer = tbTramnummer.Text;
            int spoornummer = Convert.ToInt32(tbSpoornummer.Text);
            int segmentnummer = Convert.ToInt32(tbSegmentnummer.Text);


        }
    }
}
