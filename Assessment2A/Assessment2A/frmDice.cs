using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assessment2A
{
    public partial class frmDice : Form
    {
        public frmDice()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //Reset all picture boxes back to invisible.
            pbDieOne.Visible = false; 
            pbDieThree.Visible = false;
            pbDieFour.Visible = false;
            pbDieSix.Visible = false;
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            //On-click die 4 will become visible.
            pbDieFour.Visible = true;
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            //On-click die 6 will become visible.
            pbDieSix.Visible = true;
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            //On-click die 3 will become visible.
            pbDieThree.Visible = true;
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            //On-click die 1 will become visible.
            pbDieOne.Visible = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
