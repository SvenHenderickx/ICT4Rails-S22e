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
    public partial class AuthenticatieForm : Form
    {
        public AuthenticatieForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string inlognaam = tbUsername.Text;
            string wachtwoord = tbPassword.Text;
            if (string.IsNullOrEmpty(tbUsername.Text) || string.IsNullOrEmpty(tbPassword.Text))
            {
                MessageBox.Show("Voer een geldige inlognaam en/of wachtwoord in.");
            }
            else
            {
                Remise.Instance.InlogControle(inlognaam, wachtwoord);

                // Kijk of het inloggen is gelukt
                if (!Remise.Instance.InlogControle(inlognaam, wachtwoord))
                {
                    MessageBox.Show("Voer een geldige inlognaam en/of wachtwoord in.");
                }
            }
        }

        private void btnAfsluiten_Click(object sender, EventArgs e)
        {

        }
    }
}
