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
            string tramstatus = "";
            int tramnummer = Convert.ToInt32(tbTramnummer.Text);
            if (!string.IsNullOrEmpty(tbTramnummer.Text) && cbbTramStatus.SelectedItem.Equals("Defect"))
            {
                tramstatus = "DEFECT";
                Remise.Instance.StatusUpdate(tramnummer, tramstatus);
                Remise.Instance.TramsOphalen();
                tbTramnummer.Clear();
            }
            else if (!string.IsNullOrEmpty(tbTramnummer.Text) && cbbTramStatus.SelectedItem.Equals("Schoonmaak"))
            {
                tramstatus = "SCHOONMAAK";
                Remise.Instance.StatusUpdate(tramnummer, tramstatus);
                Remise.Instance.TramsOphalen();
                tbTramnummer.Clear();
            }
            else if (!string.IsNullOrEmpty(tbTramnummer.Text) && cbbTramStatus.SelectedItem.Equals("Dienst"))
            {
                tramstatus = "DIENST";
                Remise.Instance.StatusUpdate(tramnummer, tramstatus);
                Remise.Instance.TramsOphalen();
                tbTramnummer.Clear();
            }
            else if (!string.IsNullOrEmpty(tbTramnummer.Text) && cbbTramStatus.SelectedItem.Equals("Remise"))
            {
                tramstatus = "REMISE";
                Remise.Instance.StatusUpdate(tramnummer, tramstatus);
                Remise.Instance.TramsOphalen();
                tbTramnummer.Clear();
            }
        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
