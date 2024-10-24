using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assessment5B
{
    public partial class Assessment5B : Form
    {
        public Assessment5B()
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
            // reset label fields to empty and set focus back to text input field
            lblDistance.Text = string.Empty;
            lblSpeed.Text = string.Empty;
            txtDays.Text = string.Empty;
            txtDays.Focus();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Data validation
            if (int.TryParse(txtDays.Text, out int days) && days > 0)
            {

                // Initial speed on Day 1
                double currentSpeed = 1000;

                // Total distance in miles
                double totalDistance = 0;

                // speed at the start of the day
                double previousSpeed = 0;   

                for (int i = 1; i <= days; i++)
                {

                    // Calculate the average speed for day
                    double avgSpeed = (previousSpeed + currentSpeed) / 2;

                    // updating the total distance traveled
                    totalDistance += avgSpeed;

                    // use previousSpeed for the next day by doubling the currentSpeed
                    previousSpeed = currentSpeed;

                    // double the speed for the next day
                    currentSpeed *= 2; 
                }

                // update labels with results // previousSpeed holds the final day's speed
                lblSpeed.Text = $"Speed at the end of day {days}: {previousSpeed} MPD";  
                lblDistance.Text = $"Total distance traveled by end of day {days}: {totalDistance} miles";
            }
            else
            {
                // error message that correct input is given (no letters or negative numbers)
                MessageBox.Show("Please enter a positive number for the number of days.");
            }
        }
    }
}
