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
    public partial class SpoorInfoForm : Form
    {
        public SpoorInfoForm()
        {
            InitializeComponent();
        }

        private void tbSpoornummer_TextChanged(object sender, EventArgs e)
        {
            int spoor = 0;

            if (Int32.TryParse(tbSpoornummer.Text, out spoor))
            {
                List<Tram> trams = Remise.Instance.SpoorInfo(spoor);
                foreach (Tram tram in trams)
                {
                    lbTramlijst.Items.Add(tram.ToString());
                }
            }
        }
    }
}
