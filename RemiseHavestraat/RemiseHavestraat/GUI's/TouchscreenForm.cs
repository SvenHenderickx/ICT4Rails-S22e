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
    public partial class TouchscreenForm : Form
    {
        private string _invoer ;

        public TouchscreenForm()
        {
            InitializeComponent();
            _invoer = "";

        }



        #region Alle bedieningsknoppen


        

        private void btnNum1_Click(object sender, EventArgs e)
        {
            _invoer += 1;
            tbTramnummer.Text = _invoer;

        }

        private void btnNum2_Click(object sender, EventArgs e)
        {
            _invoer += 2;
            tbTramnummer.Text = _invoer;
        }

        private void btnNum3_Click(object sender, EventArgs e)
        {
            _invoer += 3;
            tbTramnummer.Text = _invoer;
        }

        private void btnNum4_Click(object sender, EventArgs e)
        {
            _invoer += 4;
            tbTramnummer.Text = _invoer;
        }

        private void btnNum5_Click(object sender, EventArgs e)
        {
            _invoer += 5;
            tbTramnummer.Text = _invoer;
        }

        private void btnNum6_Click(object sender, EventArgs e)
        {
            _invoer += 6;
            tbTramnummer.Text = _invoer;
        }

        private void btnNum7_Click(object sender, EventArgs e)
        {
            _invoer += 7;
            tbTramnummer.Text = _invoer;
        }

        private void btnNum8_Click(object sender, EventArgs e)
        {
            _invoer += 8;
            tbTramnummer.Text = _invoer;
        }

        private void btnNum9_Click(object sender, EventArgs e)
        {
            _invoer += 9;
            tbTramnummer.Text = _invoer;
        }

        private void btnHerstel_Click(object sender, EventArgs e)
        {
            if (_invoer.Count() < 1) return;

            _invoer = _invoer.Substring(0, _invoer.Length - 1);
            tbTramnummer.Text = _invoer;
        }

        private void btnNum0_Click(object sender, EventArgs e)
        {
            _invoer += 0;
            tbTramnummer.Text = _invoer;
        }

        private void btnBevestig_Click(object sender, EventArgs e)
        {

        }
         #endregion
    }
}
