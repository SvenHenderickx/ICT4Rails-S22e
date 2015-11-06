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
    public partial class TramVerwijderenForm : Form
    {
        public TramVerwijderenForm()
        {
            InitializeComponent();
        }

        private void btnBevestig_Click(object sender, EventArgs e)
        {
            int tramnummer = Convert.ToInt32(tbTramnummer.Text);
            if (!string.IsNullOrEmpty(tbTramnummer.Text))
            {
                Remise.Instance.TramVerwijderenSegment(tramnummer);
                Remise.Instance.SegmentenOphalen();
                tbTramnummer.Clear();
            }
        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
