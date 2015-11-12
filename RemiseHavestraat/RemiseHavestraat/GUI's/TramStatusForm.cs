using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RemiseHavestraat.Klassen;

namespace RemiseHavestraat
{
    public partial class TramStatusForm : Form
    {
        public StatusEnum Status;
        public int TramID;
        public bool Uitvoeren;

        public TramStatusForm()
        {
            InitializeComponent();
            cbbTramStatus.DataSource = Enum.GetValues(typeof(StatusEnum));
        }

        private void btnBevestig_Click(object sender, EventArgs e)
        {
            int tramNr;

            if(cbbTramStatus.Text == StatusEnum.Remise.ToString()) Status = StatusEnum.Remise;
            else if(cbbTramStatus.Text == StatusEnum.Defect.ToString()) Status = StatusEnum.Defect;
            else if(cbbTramStatus.Text == StatusEnum.Dienst.ToString()) Status = StatusEnum.Dienst;
            else if(cbbTramStatus.Text == StatusEnum.Schoonmaak.ToString()) Status = StatusEnum.Schoonmaak;

            if (Int32.TryParse(tbTramnummer.Text, out tramNr) == false)
            {
                MessageBox.Show("Ongeldige invoer in tramnummer textbox");
                return;
            }

            //controleren of de tram bestaat
            if (Remise.Instance.BestaatTram(tramNr) == false)
            {
                MessageBox.Show("De ingevoerde tram bestaat niet");
                return;
            }

            //controleren of de status anders is
            Tram t = Remise.Instance.GeefTram(tramNr);
            TramID = t.TramID;

            if (t.StatusEnum == Status)
            {
                MessageBox.Show("De tram heeft al de gewenste status");
                return;
            }


            //form sluiten
            Uitvoeren = true;
            Close();

        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
