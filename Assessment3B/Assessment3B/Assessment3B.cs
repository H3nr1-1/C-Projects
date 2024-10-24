using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Assessment3B
{
    public partial class Assessment3B : Form
    {
        
        public Assessment3B()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close the application.
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //Reset all Text Fields
            txtTitle.Clear();
            txtFirstName.Clear();
            txtMiddleInitial.Clear();
            txtLastName.Clear();

            //Reset all Label fields to empty and hide the labels.
            lblTitleFirstMiddleLast.Text = "";
            lblTitleFirstMiddleLast.Visible = false;
            lblLastMiddleFirst.Text = "";
            lblLastMiddleFirst.Visible = false;
            lblTitleLast.Text = "";
            lblTitleLast.Visible = false;
            lblLastFirstTitle.Text = "";
            lblLastFirstTitle.Visible = false;
            txtTitle.Focus();

        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {

            try
            {
                //Declair variables for input from user.
                string title = txtTitle.Text;
                string firstName = txtFirstName.Text;
                string middleInitial = txtMiddleInitial.Text;
                string lastName = txtLastName.Text;

                //Validation that the input is not empty. 
                if(string.IsNullOrEmpty(title) || string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(middleInitial) || string.IsNullOrEmpty(lastName))
                {
                    throw new Exception("Title, First Name, Middle Initial, and Last Name cannot be empty");
                }

                //Title First Middle Last Format
                lblTitleFirstMiddleLast.Text = $"{title} {firstName} {middleInitial} {lastName}";
                lblTitleFirstMiddleLast.Visible = true;

                //Last Middle First Format
                lblLastMiddleFirst.Text = $"{lastName} {middleInitial} {firstName}";
                lblLastMiddleFirst.Visible = true;

                //Title Last Format
                lblTitleLast.Text = $"{title} {lastName}";
                lblTitleLast.Visible = true;

                //Last First Title Format
                lblLastFirstTitle.Text = $"{lastName} {firstName} {title}";
                lblLastFirstTitle.Visible = true;
            }

            catch(Exception ex) {

                //Clear out all text boxes and focus on the title text box if after there is an exception.
                MessageBox.Show(ex.Message);
                txtTitle.Clear();
                txtFirstName.Clear();
                txtMiddleInitial.Clear();
                txtLastName.Clear();
                txtTitle.Focus();
            }            
        }
    }
}
