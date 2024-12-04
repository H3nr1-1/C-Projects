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
        
        // creating a dictionary to store the known values
        private Dictionary<string, double> knownValues = new Dictionary<string, double>();


        public Assessment10()
        {
            InitializeComponent();
            //automatically load the knownFiles.txt file
            LoadKnownValues("knownvalues.txt");
        }

        // making a method to show load the knownValues file
        private void LoadKnownValues(string filePath)
        {
            try
            {
                //make sure the file is there before trying to load it.
                if (!File.Exists(filePath))
                {
                    MessageBox.Show($"File not found: {filePath}");
                    return;
                }

                knownValues.Clear();

                // skip the first line in knownvalues.txt and then read all lines after
                var lines = File.ReadAllLines(filePath).Skip(1);

                foreach (string line in lines)
                {
                    // tokenize the line using the comma delimiter
                    var tokens = line.Split(',');

                    if (tokens.Length == 2 && double.TryParse(tokens[1], out double normalValue))
                    {
                        string animalName = tokens[0].Trim();
                        //add to the dictionary
                        knownValues[animalName] = normalValue;
                    }
                    else
                    {
                        MessageBox.Show($"Invalid data in line: {line}");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show($"Error loading file.");
            }
        }

        // create a method to compare the values from the selected files to the known values.
        private void AnalyzeData(string animalName, List<double> testScores)
        {
            // get the known value from the picked animal
            double normalValue = GetNormalValue(animalName);

            if (normalValue == -1)
            {
                MessageBox.Show("Animal not found in known values.");
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

        // updating the method to get normal value for animal that was chosen.
        private double GetNormalValue(string animalName)
        {
            return knownValues.TryGetValue(animalName, out double normalValue) ? normalValue : -1;
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
                            return;
                        }
                    }

                    //analyze data using the animal name and score
                    AnalyzeData(animalName, testScores);

                }
            }

            catch (Exception)
            {
                MessageBox.Show("An error occured.  Please try again.");
            }
        }

        private void btnLoadComparisonFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Text Files (*.txt|*.txt",
                Title = "Select a File to Compare."
            };

            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // get the file path
                    string filePath = openFileDialog.FileName;

                    //clear the current known values dictionary
                    knownValues.Clear();

                    //read all lines from the selected file
                    string[] lines = File.ReadAllLines(filePath);

                    // make sure file isnt empty
                    if (lines.Length == 0)
                    {
                        MessageBox.Show("The selected file is empty.");
                        return;
                    }

                    // make sure the file isnt empty and start with the second line
                    for (int i = 1; i < lines.Length; i++)
                    {
                        string line = lines[i].Trim();

                        if (string.IsNullOrWhiteSpace(line))
                        {
                            continue;
                        }

                        //seperate lines using into 1 column
                        string[] parts = line.Split(',');

                        if (parts.Length != 1)
                        {
                            MessageBox.Show($"Invalid line format.");
                            continue;
                        }

                        // seperate the animal names and values
                        string valueNumber = parts[0].Trim();

                        //change the value to a number
                        if (double.TryParse(valueNumber, out double normalValue))
                        {
                            // add the animal and value to dictionary
                            knownValues[valueNumber] = normalValue;
                        }
                        else
                        {
                            MessageBox.Show($"Invalid value for animal.");
                            return;
                        }
                    }
                    MessageBox.Show("File loaded successfully.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show($"Error loading file.");
            }
        }
    }
}
