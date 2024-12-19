using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assessment13
{
    public class SpaceExperiment: Experiment
    {
        private double _gravity;
        private double _velocity;

        //property for gravity
        public double Gravity
        {
            get => _gravity; 
            set => _gravity = value;
        }


        //property for velocity
        public double Velocity
        {
            get => _velocity;
            set => _velocity = value;
        }

        // override resultvolume to account for expansion
        public override double ResultVolume
        {
            get => base.ResultVolume;
            set => base.ResultVolume = value * 1.25; // multiply by 1.25
        }


        // constructors
        public SpaceExperiment() : base() { }

        public SpaceExperiment(string studentName) : base(studentName) { }

        public SpaceExperiment(int experimentNumber, string description) : base(experimentNumber, description) { }


        // method to display the message
        public void OpenThePodBayDoors()
        {
            MessageBox.Show("I am sorry Dave, I can't do that.");
        }
    }
}
