using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assessment16
{
    public partial class PopulationDatabase : Form
    {
        public PopulationDatabase()
        {
            InitializeComponent();
        }

        private void PopulationDatabase_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'populationDBDataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.populationDBDataSet.Table);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string city = txtCityName.Text;

                if (int.TryParse(txtCityPopulation.Text.Trim(), out int population))
                {
                    // add a new row
                    var newRow = this.populationDBDataSet.Table.NewTableRow();
                    newRow.City = city;
                    newRow.Population = population;

                    this.populationDBDataSet.Table.Rows.Add(newRow);
                    //save the changes
                    this.tableTableAdapter.Update(this.populationDBDataSet.Table);
                    MessageBox.Show("City added successfully.");

                    //clear the text fields after adding a city
                    txtCityName.Clear();
                    txtCityName.Clear();

                }
                else
                {
                    MessageBox.Show("Please enter a valid population.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show($"Error adding city to database.");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(txtCityID.Text.Trim(), out int cityId))
                {
                    //find the row the matching CityId
                    foreach (PopulationDBDataSet.TableRow row in this.populationDBDataSet.Table)
                    {
                        if (row.City_ID == cityId)
                        {
                            //update the row with the new values
                            row.City = txtCityName.Text.Trim();

                            if (int.TryParse(txtCityPopulation.Text.Trim(), out int population))
                            {
                                row.Population = population;

                                //save population changes
                                this.tableTableAdapter.Update(this.populationDBDataSet.Table);
                                MessageBox.Show("City updated successfully");

                                //clear txt fields after update.
                                txtCityID.Clear();
                                txtCityName.Clear();
                                txtCityPopulation.Clear();
                            }
                            else
                            {
                                MessageBox.Show("Please enter a valid population number.");
                            }
                            return;
                        }
                    }
                    MessageBox.Show("City ID not found, please try agian.");
                }
                else
                {
                    MessageBox.Show("Please enter a valid city ID.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show($"Error updating city.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                //check if a valid number for CityID was entered
                if (int.TryParse(txtCityID.Text.Trim(), out int cityID))
                {
                    //loop through the rows to find the match
                    foreach (var row in this.populationDBDataSet.Table)
                    {
                        //check if cityID matches
                        if (row.City_ID == cityID)
                        {
                            //delete the row
                            row.Delete();
                            //save the changes
                            this.tableTableAdapter.Update(this.populationDBDataSet.Table);
                            MessageBox.Show("City was deleted successfully.");

                            //clear the text field after city successfully deleted
                            txtCityID.Clear();

                        }
                    }
                    MessageBox.Show("City Id no found. Please try again.");
                }
                else
                {
                    MessageBox.Show("Please enter a valid number for city Id.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show($"An error occurred while deleting the city.");
            }
        }


        //listing in ascending order
        private void btnPopAsc_Click(object sender, EventArgs e)
        {
            try
            {
                //using a query to sort the data from Largest population to smallest
                this.tableTableAdapter.FillByPopulationDesc(this.populationDBDataSet.Table);

                dgvPopulation.ClearSelection();
            }
            catch (Exception)
            {
                MessageBox.Show($"Error sorting the table.");
            }
        }

        //listing in descending order
        private void btnPopDesc_Click(object sender, EventArgs e)
        {
            try
            {
                //using a query to sort the data from smallest population to largest
                this.tableTableAdapter.FillByPopulationAsc(this.populationDBDataSet.Table);

                dgvPopulation.ClearSelection();
            }
            catch (Exception)
            {
                MessageBox.Show($"Error sorting the table.");
            }
        }

        // listing in alphabetical order
        private void btnName_Click(object sender, EventArgs e)
        {
            try
            {
                //using a query to sort the data in alphabetical order
                this.tableTableAdapter.FillByCityAsc(this.populationDBDataSet.Table);

                dgvPopulation.ClearSelection();
            }
            catch (Exception)
            {
                MessageBox.Show($"Error sorting the table.");
            }
        }

        // listing the total population
        private void btnTotalPop_Click(object sender, EventArgs e)
        {
            int totalPopulation = this.populationDBDataSet.Table.Sum(row => row.Population);
            MessageBox.Show($"Total Population: {totalPopulation}");
        }

        // listing the average population
        private void btnAvgPop_Click(object sender, EventArgs e)
        {
            double averagePopulation = this.populationDBDataSet.Table.Average(row => row.Population);
            MessageBox.Show($"Average Population: {averagePopulation}");
        }

        //showing the highest population
        private void btnHighestPop_Click(object sender, EventArgs e)
        {
            int highestPopulation = this.populationDBDataSet.Table.Max(row => row.Population);
            MessageBox.Show($"Highest Population: {highestPopulation}");
        }

        //display the lowest population
        private void btnLowestPop_Click(object sender, EventArgs e)
        {
            int lowestPopulation = this.populationDBDataSet.Table.Min(row => row.Population);
            MessageBox.Show($"Lowest Population: {lowestPopulation}");
        }

        
        //reset the data grid view and the text fields
        private void btnReset_Click(object sender, EventArgs e)
        {
            this.tableTableAdapter.Fill(this.populationDBDataSet.Table);
            txtCityID.Clear();
            txtCityName.Clear();
            txtCityPopulation.Clear();
            btnPopAsc.Focus();
        }
    }
}
