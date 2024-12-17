using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalExam_Counter
{
    public partial class Counter : Form
    {
        public Counter()
        {
            InitializeComponent();
        }

        //creating the method to find the amount of numbers divisible by 3 between 1 and 1000
        private void ThreeCounter()
        {
            int count = 0;

            for (int i = 1; i <= 1000; i++)
            {
                if (i % 3 == 0)
                {
                    count++;
                }
            }

            MessageBox.Show($"The amount of numbers divisible by 3, between 1 and 1000 are: {count}");
        }

        private void btnCounter_Click(object sender, EventArgs e)
        {
            //calling the method
            ThreeCounter();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
