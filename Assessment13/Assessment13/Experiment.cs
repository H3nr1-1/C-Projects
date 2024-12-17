using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Assessment13
{

    //enum for the colors that are able to be selected on the main form.
    public enum ResultColor
    {
        Crimson, Azure, Taupe, Mauve, Vermillion, Chartreuse
    }


    // class to hold the experiment data
    public abstract class Experiment
    {
        //experiment properties
        private string _studentName;
        private int _experimentNumber;
        private string _description;
        private double _resultWeight;
        private ResultColor _resultColor;
        private double _resultVolume;


        //property for the students name
        public string StudentName
        {
            get => _studentName;
            set => _studentName = value;
        }


        //property for the experiment number
        public int ExperimentNumber
        {
            get => _experimentNumber;
            set
            {
                if (value < 1 || value > 50)
                    throw new ArgumentException("Experiment Number must be between 1 and 50.");
                _experimentNumber = value;
            }
        }

        //property for description
        public string Description
        {
            get => _description;
            set
            {
                if (value.Length > 500)
                    throw new ArgumentException("Decription must be 500 characters or less.");
                _description = value;
            }
        }

        
        // property for the result weight
        public double ResultWeight
        {
            get => _resultWeight;   
            set => _resultWeight = value;
        }


        // property for result color
        public ResultColor ResultColor
        {
            get => _resultColor;
            set => _resultColor = value;
        }


        // property for result volume
        public virtual double ResultVolume
        {
            get => _resultVolume;
            set => _resultVolume = value;
        }

        // abstract classes 
        protected Experiment() { }

        // constructor to initialize with student name
        protected Experiment(string studentName) => StudentName = studentName;

        // constructor to initialize with experiment number and description
        protected Experiment(int experimentNumber, string description)
        {
            ExperimentNumber = experimentNumber;
            Description = description;
        }

    }
}
