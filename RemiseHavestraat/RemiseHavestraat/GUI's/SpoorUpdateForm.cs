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
    public partial class SpoorUpdateForm : Form
    {
        public SpoorUpdateForm()
        {
            InitializeComponent();
        }

        private void btnBevestig_Click(object sender, EventArgs e)
        {
            int spoornummer = Convert.ToInt32(tbSpoornummer.Text);
            if(!string.IsNullOrEmpty(tbSpoornummer.Text))
            {
                Remise.Instance.SpoorUpdate(spoornummer);
                Remise.Instance.SporenOphalen();
                tbSpoornummer.Clear();
            }
        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
