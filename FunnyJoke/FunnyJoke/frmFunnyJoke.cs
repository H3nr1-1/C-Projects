using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunnyJoke
{
    public partial class frmFunnyJoke : Form
    {
        public frmFunnyJoke()
        {
            InitializeComponent();
        }

        private void btnSetup_Click(object sender, EventArgs e)
        {

            //Changing the text in the text line with the setup of the joke.
            txtJoke.Text = "Why do C# developers prefer dark mode?";

        }

        private void btnPunchLine_Click(object sender, EventArgs e)
        {
            //Changing the text in the text line to finish the joke.
            txtJoke.Text = "Because the light attracts to many bugs!!!";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //Reset text line bask to "Ready for a joke?"
            txtJoke.Text = "Ready for a joke?";
        }

        private void btnExt_Click(object sender, EventArgs e)
        {
            //Exit the program
            Application.Exit();

        }

        private void txtJoke_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
