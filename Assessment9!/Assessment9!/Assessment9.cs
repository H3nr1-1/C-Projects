using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assessment9_
{
    public partial class Assessment9 : Form
    {

        // making an array to hold up to 100 scores
        private double[] scores;
        // counter to keep track of valid scores in the array
        private int scoreCount = 0;

        public Assessment9()
        {
            InitializeComponent();
        }

        private void Assessment9_Load(object sender, EventArgs e)
        {

        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {

            try
            {
                //set up the OpenFileDialog to let user pick a file
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    // only allow to choose .txt files
                    openFileDialog.Filter = "Text Files (*.txt | *.txt|All Files (*.*)|*.*";

                    // check if the user selected a file and clicked ok
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        //read all lines from the file
                        string[] lines = File.ReadAllLines(openFileDialog.FileName);

                        // create the scores array
                        scores = new double[Math.Min(lines.Length, 100)];
                        // reset the counter
                        scoreCount = 0;

                        // read each line from the file and put into the array
                        foreach (string line in lines)
                        {
                            //convert the lines to a double and check if its in the range of 0-100
                            if (double.TryParse(line, out double score) && score >= 0 && score <= 100)
                            {
                                // store the valid scores in the array and increment on the counter for each score counted
                                scores[scoreCount++] = score;
                            }
                        }

                        //after loading scores, display data.
                        AnalyzeScores();

                    }
                }
            }
            catch (Exception)
            {
                // display an error if something went wrong.
                MessageBox.Show("An error occured while loading the file.");
            }
        }

        // method to calculate and diplay the data about the scores
        private void AnalyzeScores()
        {
            // if there were no valid scores, diplay a message.
            if (scoreCount == 0)
            {
                txtAnalysis.Text = "No valid score found in the file.";
                return;
            }

            // add all scores, calculate average, and find the highest and lowest scores
            double total = scores.Take(scoreCount).Sum();
            double average = total / scoreCount;
            double highest = scores.Take(scoreCount).Max();
            double lowest = scores.Take(scoreCount).Min();

            // dispal the results in the analysis textbox
            txtAnalysis.Text = $"Quantity of Scores: {scoreCount}\r\n" +
                                $"Total of Scores: {total}\r\n" +
                                $"Average Score: {average:F2}\r\n" +
                                $"Highest Score: {highest}\r\n" +
                                $"Lowest Score: {lowest}";                                
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //clear the txtbox and sent focus back to the Load File button
            txtAnalysis.Clear();
            btnLoadFile.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //close the application
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            try
            {
                // check if there is anything to save
                if (string.IsNullOrEmpty(txtAnalysis.Text))
                {
                    MessageBox.Show("No data to save.  Please load a file.");
                    return;
                }

                // setup the SaveFileDialog to allow the user to save the data that is analyzed
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    // make sure to only allow .txt files to be saved.
                    saveFileDialog.Filter = "Text Files (*.txt) | *.txt|All Files (*.*)|*.*";

                    //Check if the user selected a location to save and clicked ok
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        // write the data to the selected file
                        File.WriteAllText(saveFileDialog.FileName, txtAnalysis.Text);
                        MessageBox.Show("Data saved successfully!");
                    }
                }
            }
            catch (Exception)
            {
                // show an error if something went wrong.
                MessageBox.Show("An error occurred while saving the file.");
            }
        }
    }
}
