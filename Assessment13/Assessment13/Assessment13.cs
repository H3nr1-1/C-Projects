using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Assessment13
{
    public partial class Assessment13 : Form
    {

        // created a list for data storage
        private List<Experiment> experiments = new List<Experiment>();

        //hold the current experiment
        private SpaceExperiment exp;

        public Assessment13()
        {
            InitializeComponent();
            // add colors to cmbResultColor on start.
            cmbResultColor.DataSource = Enum.GetValues(typeof(ResultColor));
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //close the application
            Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            // create the experiment with the input that was entered
            if (!string.IsNullOrEmpty(txtStudentName.Text))
                // experitment using the student name
                exp = new SpaceExperiment(txtStudentName.Text);
            else if (!string.IsNullOrEmpty(txtExperimentNumber.Text) && !string.IsNullOrEmpty(txtDescription.Text))
            {
                // parsing the experiment number
                int expNumber = int.Parse(txtExperimentNumber.Text);
                //experiment using the experiment number and description
                exp = new SpaceExperiment(expNumber, txtDescription.Text);
            }
            else
                // create the default experiment
                exp = new SpaceExperiment();

            MessageBox.Show("Experiment created.  Add more data if needed.");
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            if (exp == null)
            {
                // make sure there is an experiment to modify
                MessageBox.Show("Create an experiment first.");
                return;
            }

            try
            {
                //update experiment properties based on the info that was entered
                if (!string.IsNullOrEmpty(txtExperimentNumber.Text))
                    exp.ExperimentNumber = int.Parse(txtExperimentNumber.Text);

                if (!string.IsNullOrEmpty(txtDescription.Text))
                    exp.Description = txtDescription.Text;

                if (!string.IsNullOrEmpty(txtResultWeight.Text))
                    exp.ResultWeight = double.Parse(txtResultWeight.Text);

                if (cmbResultColor.SelectedIndex >= 0)
                    exp.ResultColor = (ResultColor)cmbResultColor.SelectedItem;

                if (!string.IsNullOrEmpty(txtResultVolume.Text))
                    exp.ResultVolume = double.Parse(txtResultVolume.Text);
                
                if (!string.IsNullOrEmpty(txtGravity.Text))
                    exp.Gravity = double.Parse(txtGravity.Text);

                if (!string.IsNullOrEmpty(txtVelocity.Text))
                    exp.Velocity = double.Parse(txtVelocity.Text);

                MessageBox.Show("Eperiment data set successfully.");
            }

            catch (Exception)
            {
                MessageBox.Show("Error setting data.");
            }


        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            // make sure there is an experiment to save
            if (exp == null)
            {
                MessageBox.Show("Create and set the experiment data before saving.");
                return;
            }

            // check if the experiment already exists
            if (experiments.Exists(exe => exe.ExperimentNumber == exp.ExperimentNumber))
            {
                var result = MessageBox.Show("Experiment exists already.  Would you like to overwrite?", "Confirm", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                    //exit if the user does not want to overwrite.
                    return;

            }

            //add the experiment to the list
            experiments.Add(exp);
            // add the experiment info to the listbox
            lbExperiments.Items.Add($"{exp.ExperimentNumber}\t{exp.Description}");
            //Notify the user that the experiment is saved.
            MessageBox.Show("Experiment saved.");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // clear the form
            txtStudentName.Clear();
            txtExperimentNumber.Clear();
            txtDescription.Clear();
            txtResultWeight.Clear();
            txtResultVolume.Clear();
            txtGravity.Clear();
            txtVelocity.Clear();
            txtStudentName.Focus();
        }

        // event handler for when an experiment is selected from the Assessment13 page.

        private void lbExperiments_DoubleClick(object sender, EventArgs e)
        {

            //make sure an experiment was selected
            if (lbExperiments.SelectedIndex < 0)
            {
                MessageBox.Show("Please select an experiment.");
                return;
            }

            // get experiment number from selected experiment.
            int expNumber = int.Parse(lbExperiments.SelectedItem.ToString().Split('\t')[0]);
            var selectedExperiment = experiments.Find(exe => exe.ExperimentNumber == expNumber);
            //make sure the data is there
            if (selectedExperiment == null)
            {
                MessageBox.Show("The selected experiment does not exitst.");
                return;
            }

            //open the review form and display the selected experiment.
            var reviewFrom = new ReviewForm(selectedExperiment);
            reviewFrom.ShowDialog();
        }
    }
}
