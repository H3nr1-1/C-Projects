using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assessment5A
{
    public partial class Assessment5A : Form
    {

        // constant for the psi to bar conversion.
        const double Bar_Psi = 1.0 / 14.5037738;


        public Assessment5A()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // close application
            Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // reset input field and focus to the input field
            txtPsi.Clear();
            lblPSI.Text = "PSI Value: ";
            lblBar.Text = "Bar Value: ";
            txtPsi.Focus();
        }

        private void Assessment5A_Load(object sender, EventArgs e)
        {
            //for loop to iterate through the psi to bar conversion 100 times.
            lbChart.Items.Add("PSI\tBar");
            for (int psi = 0; psi <= 100; psi++)
            {
                //display psi and bar values on load (:F6 gives the 6 decimal places on bar numbers)
                double barValue = psi * Bar_Psi;
                lbChart.Items.Add($"{psi}\t{barValue:F6}");
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate, convert user input to a double
                if (double.TryParse(txtPsi.Text, out double psiValue))
                {
                    //psi value must be 0 or greater and 100 or less
                    if (psiValue >= 0 && psiValue <= 100) 
                    {
                        // calculate  bar value
                        double barValue = psiValue * Bar_Psi;

                        // display the psi value
                        lblPSI.Text = $"PSI Value: {psiValue}";

                        // display the calculated bar value with 6 decimal places (:F6)
                        lblBar.Text = $"Bar Value: {barValue:F6}";
                    }
                    else
                    {
                        // error message if input is not in the required range.
                        MessageBox.Show("Please enter a value between 1 and 100 PSI.");
                    }
                }
                else
                {
                    //display invalid input if anything but a number is entered
                    MessageBox.Show("Invalid input. Please enter a numeric value.");
                }
            }
            catch (Exception ex)
            {
                // Display excetion message.
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
