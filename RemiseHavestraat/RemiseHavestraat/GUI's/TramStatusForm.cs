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
    public partial class TramStatusForm : Form
    {
        public TramStatusForm()
        {
            InitializeComponent();
        }

        private void btnBevestig_Click(object sender, EventArgs e)
        {
            int tramnummer = Convert.ToInt32(tbTramnummer.Text);
            if (cbbTramStatus.SelectedItem.Equals("Defect"))
            {

            }
            else if (cbbTramStatus.SelectedItem.Equals("Schoonmaak"))
            {

            }
            else if (cbbTramStatus.SelectedItem.Equals("Dienst"))
            {

            }
            else if (cbbTramStatus.SelectedItem.Equals("Dienst"))
            {

            }
        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            
        }
    }
}
