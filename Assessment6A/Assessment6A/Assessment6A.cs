using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assessment6A
{
    public partial class Assessment6A : Form
    {
        public Assessment6A()
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
            // reset all text boxes to empty and put focus back to start range text box
            txtRangeStart.Text = "";
            txtRangeEnd.Text = "";
            txtQuantity.Text = "";
            txtRangeStart.Focus();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            // making variables
            int startRange;
            int endRange;
            int quantity;


            // taking the user input and validating the input for start and end range and quantity
            if (!int.TryParse(txtRangeStart.Text, out startRange) || !int.TryParse(txtRangeEnd.Text, out endRange))
            {
                MessageBox.Show("Please enter a valid number for the range.");
                return;
            }
            if (startRange >= endRange)
            {
                MessageBox.Show("Starting range must be lower than ending range.");
                return;
            }
            if (!int.TryParse(txtQuantity.Text, out quantity) || quantity <= 0)
            {
                MessageBox.Show("Enter a valid quantity greater than 0.");
                return;
            }

            //open the save file dialog to ask user where to save the file
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                // start with the C drive
                InitialDirectory = @"C:\",
                // save as a .txt file
                Filter = "Text files (*.txt)|*.txt",
                //title on top of file menu
                Title = "Save Random Numbers File."
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // getting the random numbers to save to the file.
                //random number generator
                Random random = new Random();
                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                {
                    //using the for loop to iterate through the quantity of numbers requested.
                    for (int i = 1; i <= quantity; i++)
                    {
                        // get random number in the range selected
                        int randomNumber = random.Next(startRange, endRange +1);
                        // writing to the file the number index and the random number.
                        writer.WriteLine($"{i}\t{randomNumber}");
                    }
                }
                MessageBox.Show("File saved successfully.");
            }
            else
            {
                // tell user that there was an error saving the file, clear all text fields and return focus to Range Start text box.
                MessageBox.Show("Error saving the file.");
                txtRangeStart.Text = "";
                txtRangeEnd.Text = "";
                txtQuantity.Text = "";
                txtRangeStart.Focus();
            }
        }
    }
}
