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

namespace Assessment6B
{
    public partial class Assessment6B : Form
    {
        public Assessment6B()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close the app
            Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //clear the listbox on reset and shift the focus to the Open button
            lstFileContents.Items.Clear();
            btnOpen.Focus();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {

            //start at the C drive
            openFileDialog1.InitialDirectory = @"C:\";
            // only show .txt files
            openFileDialog1.Filter = "Text Files (*.txt)|*.txt";
            // select a text file
            openFileDialog1.Title = "Select a text file.";

            //Show the open file dialog to user and check to see if the chose a txt file.
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // get file path from open file dialog
                    string filePath = openFileDialog1.FileName;

                    //read the lines from the file and display in list box
                    string[] fileLines = File.ReadAllLines(filePath);

                    //clear the list before adding a new item.
                    lstFileContents.Items.Clear();

                    //go through each line in the file and add to list box.
                    foreach (string line in fileLines) 
                    { 
                        lstFileContents.Items.Add(line);
                    }
                }

                catch(Exception)
                {
                    //show an error if something went wrong.
                    MessageBox.Show("An Error Occured.  Please try again.");
                    btnOpen.Focus();
                }
            }
        }
    }
}
