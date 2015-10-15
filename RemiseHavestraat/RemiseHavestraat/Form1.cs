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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string naam = "Remise Havestraat";
            bool check = Remise.Instance.RemiseNaam(naam);
            if (check == true)
            {
                Console.WriteLine(Remise.Instance.Naam);
                Database database = new Database();
                database.OpenVerbinding();
            }
        }
        
    }
}
