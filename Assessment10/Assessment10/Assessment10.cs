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

namespace Assessment10
{
    public partial class Assessment10 : Form
    {

        // hard coding the known results into a 2 dimensional array
        private static readonly string[,] knownValues =
        {
            {"Zebra", "129.5"},
            {"Unicorn", "54.9"},
            {"Platypus", "12.19"},
            {"Dragon", "999.98"},
            {"Manticore", "0.035"},
            {"Duck", "1.34"},
            {"Basilisk", "45.2"},
            {"Sphinx", "8.00"},
            {"Tiger", "3.21"},
        };


        public Assessment10()
        {
            InitializeComponent();
        }

        // create a method to compare the values from the selected files to the known values.
        private void AnalyzeData(string animalName, List<double> testScores)
        {
            // get the known value from the picked animal
            double normalValue = GetNormalValue(animalName);

            // if the animal name is not found in known values, display a message and exit.
            if (normalValue == -1)
            {
                MessageBox.Show($"No normal value found for {animalName}.");
                return;
            }
            
            //list to split test scores that are higher, lower, or equal to the normal value.
            List<double> higherValues = new List<double>();
            List<double> lowerValues = new List<double>();
            int equalCount = 0;

            // compare each score to the normal value and split
            foreach (var score in testScores)
            {
                if (score > normalValue)
                    higherValues.Add(score); // add score to the higher score list box
                else if (score < normalValue)
                    lowerValues.Add(score);  // add score to the lower score list box
                else equalCount++;   // counting the scores equal to the normal value.
            }

            DisplayResults(higherValues, lowerValues, equalCount);
        }

        // Get the value for the chosen animal
        private double GetNormalValue(string animalName)
        {
            // go through each row of the known values array
            for (int i = 0; i < knownValues.GetLength(0); i++)
            {
                if (knownValues[i, 0] == animalName)
                {
                    return double.Parse(knownValues[i, 1]);
                }
            }
            return -1;
        }

        // show results in listboxes and labels for high, low, and equal
        private void DisplayResults(List<double> higherValues, List<double> lowerValues, int equalCount)
        {
            // sort through the results
            higherValues.Sort();
            lowerValues.Sort();
            lowerValues.Reverse(); // make the order descending 

            // clear the list box if a new animal is selected
            lbHigher.Items.Clear();
            lbLower.Items.Clear();

            //add each value that is higher to the higher list box
            foreach (double value in higherValues)
            {
                lbHigher.Items.Add(value);
            }

            // add each value that is lower to the lower list box
            foreach (double value in lowerValues)
            {
                lbLower.Items.Add(value);
            }

            // display the counts in the labels for higher, lower, and equal
            lblHigherCount.Text = "Higher Count: " + higherValues.Count;
            lblLowerCount.Text = "Lower Count: " + lowerValues.Count;
            lblEqualCount.Text = "Equal Count: " + equalCount;
        }



        private void btnExit_Click(object sender, EventArgs e)
        {
            // close the application
            Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //clear out both list boxes, clear the 3 output label fields and return focus to the open file button
            lbHigher.Items.Clear();
            lbLower.Items.Clear();
            lblHigherCount.Text = "Higher Count: 0";
            lblLowerCount.Text = "Lower Count: 0";
            lblEqualCount.Text = "Equal Count: 0";
            btnLoadFile.Focus();
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {

            //setup open file dialog to select a file
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                // only allow txt files
                Filter = "Text Files (*.txt)|*.txt",
                // title for the file dialog window
                Title = "Select an Animal Data File"
            };

            try
            {
                // show the dialog and check if the user selected a file
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // read all lines from the file that was selected
                    var lines = File.ReadAllLines(openFileDialog.FileName);

                    // make sure the file has at least 2 lines.  one for animal and one for score
                    if (lines.Length < 2)
                    {
                        MessageBox.Show("Invalid file.  Make sure file contains animal name and test scores.");
                        return;
                    }

                    //first line contains the animal name
                    string animalName = lines[0].Trim();

                    //start a list to store scores for the animal
                    List<double> testScores = new List<double>();

                    // loop through each line
                    for (int i = 1; i < lines.Length; i++)
                    {
                        if (double.TryParse(lines[i], out double score))
                        {
                            testScores.Add(score);
                        }
                        else
                        {
                            MessageBox.Show("Invalid data.");
                        }
                    }

                    //analyze data using the animal name and score
                    AnalyzeData(animalName, testScores);

                }
            }

            catch (FileNotFoundException)
            {
                MessageBox.Show("The selected file was not found.  Please try again.");
            }

            catch (Exception)
            {
                MessageBox.Show("An error occured.  Please try again.");
            }
        }
    }
}
