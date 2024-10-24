using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assessment3a
{
    public partial class Assessment3a : Form
    {

        // Variable to hold click counts
        int countDie1 = 0;
        int countDie2 = 0;  
        int countDie3 = 0;  
        int countDie4 = 0;

        // Variables to hold Grand Total clicks and Grand Value Totals
        int totalCount = 0;
        int valueCount = 0;
        int grandTotal = 0;
        int grandValueTotal = 0;

        public Assessment3a()
        {
            InitializeComponent();

            lblDie1.Text = "Clicks: 0";
            lblDie2.Text = "Clicks: 0";
            lblDie3.Text = "Clicks: 0";
            lblDie4.Text = "Clicks: 0";
            lblTotalCount.Text = "Total: 0";
            lblTotalValue.Text = "Value: 0";
            lblGrandTotal.Text = "Grand Total: 0";
            lblGrandValueTotal.Text = "Grand Value: 0";
        }

        // method to update all of the labels 
        private void UpdateLabels()
        {
            //update the dice counters
            lblDie1.Text = "Clicks: " + countDie1.ToString();
            lblDie2.Text = "Clicks: " + countDie2.ToString();
            lblDie3.Text = "Clicks: " + countDie3.ToString();
            lblDie4.Text = "Clicks: " + countDie4.ToString();

            //update total and value numbers
            lblTotalCount.Text = "Total Count: " + totalCount.ToString();
            lblTotalValue.Text = "Total Value: " + valueCount.ToString();

            //update grand values of dice rolls and total numbers of pips
            lblGrandTotal.Text = "Grand Total: " + grandTotal.ToString();
            lblGrandValueTotal.Text = "Grand Value Total: " + grandValueTotal.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Close the application
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // Reset the counters
            countDie1 = 0;
            countDie2 = 0;
            countDie3 = 0;
            countDie4 = 0;

            // reset the total and value counters
            totalCount = 0;
            valueCount = 0;

            //Reset the labels
            lblDie1.Text = "Clicks: 0";
            lblDie2.Text = "Clicks: 0";
            lblDie3.Text = "Clicks: 0";
            lblDie4.Text = "Clicks: 0";
            lblTotalCount.Text = "Total Count: 0";
            lblTotalValue.Text = "Total Value: 0";
        }

        private void pbDie1_Click(object sender, EventArgs e)
        {
            //counting each click of the dice, adding each click the total and adding each pip to total values. Then updating labels.
            countDie1++;
            totalCount++;
            valueCount += 1;
            grandTotal++;
            grandValueTotal += 1;
            UpdateLabels();
        }

        private void pbDie2_Click(object sender, EventArgs e)
        {
            countDie2++;
            totalCount++;
            valueCount += 2;
            grandTotal++;
            grandValueTotal += 2;
            UpdateLabels();

        }

        private void pbDie3_Click(object sender, EventArgs e)
        {
            countDie3++;
            totalCount++;
            valueCount += 3;
            grandTotal++;
            grandValueTotal += 3;
            UpdateLabels();
        }

        private void pbDie4_Click(object sender, EventArgs e)
        {
            countDie4++;
            totalCount++;
            valueCount += 4;
            grandTotal++;
            grandValueTotal += 4;
            UpdateLabels();
        }
    }
}
