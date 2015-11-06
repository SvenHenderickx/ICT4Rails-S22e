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
            tbUsername.TabIndex = 0;
            tbPassword.TabIndex = 1;
            btnLogin.TabIndex = 2;
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
                // Kijk of het inloggen is gelukt
                if (!Remise.Instance.InlogControle(inlognaam, wachtwoord))
                {
                    MessageBox.Show("Voer een geldige inlognaam en/of wachtwoord in.");
                }
                else
                {
                    tbUsername.Text = "";
                    tbPassword.Text = "";
                    Hide();
                    if (Remise.Instance.account.MedewerkerRol == EnumMedewerkerRol.Beheerder || Remise.Instance.account.MedewerkerRol == EnumMedewerkerRol.WagenparkBeheerder)
                    {
                        using(BeheerForm bf = new BeheerForm())
                        {
                            bf.ShowDialog();
                        }
                        Show();                        
                    }
                    else if (Remise.Instance.account.MedewerkerRol == EnumMedewerkerRol.Technicus)
                    {
                        using (ReparatieForm rf = new ReparatieForm())
                        {
                            rf.ShowDialog();
                        }
                        Show(); 
                    }
                    else if (Remise.Instance.account.MedewerkerRol == EnumMedewerkerRol.Schoonmaker)
                    {
                        using (SchoonmaakForm sf = new SchoonmaakForm())
                        {
                            sf.ShowDialog();
                        }
                        Show(); 
                    }
                }
            }
        }

        private void btnAfsluiten_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PressEnterLogin(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
