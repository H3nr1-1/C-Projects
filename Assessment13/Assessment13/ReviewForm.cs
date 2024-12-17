using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assessment13
{
    public partial class ReviewForm : Form
    {

        // holds the selected spaceExperiment
        private SpaceExperiment _spaceExperiment;

        // constructor to initialize ReviewForm and show the experiment details from the experiment that was selected.
        public ReviewForm(Experiment experiment)
        {
            InitializeComponent();

            // if the experiment isnt empty, display results.
            if (experiment != null )
            {
                lblStudentName.Text = $"Student Name: {experiment.StudentName}";
                lblExperimentNumber.Text = $"Experiment Number: {experiment.ExperimentNumber}";
                lbDescription.Items.Add($"{experiment.Description}");
                lblResultWeight.Text = $"Result Weight: {experiment.ResultWeight}";
                lblResultColor.Text = $"Result Color: {experiment.ResultColor}";
                lblResultVolume.Text = $"Result Volume: {experiment.ResultVolume}";

                if (experiment is SpaceExperiment spaceExp)
                {
                    _spaceExperiment = spaceExp;
                    lblGravity.Text = $"Gravity: {_spaceExperiment.Gravity}";
                    lblVelocity.Text = $"Velocity: {_spaceExperiment.Velocity}";
                }
            }

        }

        // constructor initialize the default components on the form
        public ReviewForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close the app
            Close();
        }

        private void btnOpenThePodBayDoors_Click(object sender, EventArgs e)
        {
            //calls method if spaceExperiment is not null
            _spaceExperiment?.OpenThePodBayDoors();
        }
    }
}
