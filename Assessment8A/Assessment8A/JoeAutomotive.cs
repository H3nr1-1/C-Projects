using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assessment8A
{
    public partial class JoeAutomotive : Form
    {

        // constants
        //$20 per hour for labor
        private const decimal LaborRate = 20m;
        // 6% tax on parts
        private const decimal TaxRate = 0.06m;
        // default rental rate
        private const decimal DefaultRentalRate = 50m;

        public JoeAutomotive()
        {
            InitializeComponent();

            // n2 gives the string 2 numbers after the decimal for currency format.
            txtRentalPrice.Text = DefaultRentalRate.ToString("n2");
            DisableRentalControls();
        }

        // method to claculate the labor charges
        private decimal CalculateLaborCharges()
        {
            try
            {
                if (decimal.TryParse(txtLabor.Text, out decimal hoursWorked))
                {
                    if (hoursWorked >= 0)
                    {
                        return hoursWorked * LaborRate;
                    }
                    else
                    {
                        MessageBox.Show("Labor hours cannot be negative.  Please enter a positive number.");
                    }
                }
                else if (!string.IsNullOrEmpty(txtLabor.Text))
                {
                    MessageBox.Show("Invalid input for labor hours.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error occured.");
            }
            return 0;
        }


        // Creating a method to calculate the parts charges.
        private decimal CalculatePartsCharges()
        {
            try
            {
                if (decimal.TryParse(txtParts.Text, out decimal partsCost))
                {
                    if (partsCost >= 0)
                    {
                        return partsCost;
                    }
                    else
                    {
                        MessageBox.Show("Parts cost cannot be negative.  Please enter parts cost.");
                    }
                }
                else if (!string.IsNullOrEmpty (txtParts.Text))
                {
                    MessageBox.Show("Invalid input for parts cost.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error occured.");
            }
            return 0;
        }


        // a method to add the tax on parts
        private decimal CalculateTax()
        {
            decimal partsCharges = CalculatePartsCharges();
            return partsCharges * TaxRate;  //adding the tax to the parts
        }

        
        //method to calculate the rental charges
        private decimal CalculateRentalCharges(int days = 1)
        {
            if (chkRental.Checked)
            {
                try
                {
                    if (string.IsNullOrWhiteSpace(txtRentalDays.Text))
                    {
                        days = 1;  //this is the minimum number of rental days
                    }
                    else if (int.TryParse(txtRentalDays.Text, out days))
                    {
                        if (days < 1 || days > 7)  //rental days can't be under 1 or more than 7
                        {
                            MessageBox.Show("Rental Days must be between 1 and 7.");
                            return 0;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid input for rental days.");
                        return 0;
                    }
                    if (decimal.TryParse(txtRentalPrice.Text, out decimal dailyRate))
                    {
                        if (dailyRate >= 25)
                        {
                            return days * dailyRate;
                        }
                        else
                        {
                            MessageBox.Show("Daily rental rate must be at least $25.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid input for rental price.");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("An error occured.");
                }
            }
            return 0;  // 0 rental charges if the rental box is not checked.
        }


        //method to calcualte all charges.
        private decimal CalculateCharges()
        {
            decimal laborCharges = CalculateLaborCharges();
            decimal partsCharges = CalculatePartsCharges();
            decimal tax = CalculateTax();
            decimal rentalCharges = CalculateRentalCharges();
            // add them all up
            return laborCharges + partsCharges + tax + rentalCharges;
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            //close the application
            Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal laborCharges = CalculateLaborCharges();
            decimal partsCharges = CalculatePartsCharges();
            decimal tax = CalculateTax();
            decimal rentalCharges = CalculateRentalCharges();
            decimal totalCharges = CalculateCharges();

            // putting all the calculations into the labels with the currency format.
            lblLaborCharges.Text = laborCharges.ToString("c");
            lblPartsCharges.Text = partsCharges.ToString("c");
            lblTax.Text = tax.ToString("c");
            lblRentalCharges.Text = rentalCharges.ToString("c");
            lblTotalCharges.Text = totalCharges.ToString("c");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            //clear all text boxes, labels, disable the rental section, set focus back to parts cost.
            txtLabor.Clear();
            txtParts.Clear();
            txtParts.Focus();
            chkRental.Checked = false;
            txtRentalPrice.Text = DefaultRentalRate.ToString("n2");
            txtRentalDays.Text = string.Empty;
            lblLaborCharges.Text = string.Empty;
            lblPartsCharges.Text = string.Empty;
            lblTax.Text = string.Empty;
            lblRentalCharges.Text = string.Empty;
            lblTotalCharges.Text = string.Empty;

            DisableRentalControls();
        }

        private void chkRental_CheckedChanged(object sender, EventArgs e)
        {
            // using a checkbox to lock or unlock the rental fields of the form.
            if (chkRental.Checked)
            {
                EnableRentalControls();
            }
            else
            {
                DisableRentalControls();
            }
        }


        //method for unlocking the rental controls
        private void EnableRentalControls()
        {
            txtRentalDays.Enabled = true;
            txtRentalPrice.Enabled = true;
        }


        //method to lock the rental controls
        private void DisableRentalControls()
        {
            txtRentalDays.Enabled = false;
            txtRentalPrice.Enabled = false;
        }

    }
}


        


