using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assessment4A
{
    public partial class Assessment4A : Form
    {
        public Assessment4A()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Close Application
            Close();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            // get the input into an integer
            if (int.TryParse(txtInput.Text, out int value))
            {
                //switch statment to convert ASCII number to letter
                string result = string.Empty;
                switch (value)
                {
                    case 65:
                        result = "A";
                        break;
                    case 66:
                        result = "B";
                        break;
                    case 67:
                        result = "C";
                        break;
                    case 68:
                        result = "D";
                        break;
                    case 69:
                        result = "E";
                        break;
                    case 70:
                        result = "F";
                        break;
                    case 71:
                        result = "G";
                        break;
                    case 72:
                        result = "H";
                        break;
                    case 73:
                        result = "I";
                        break;
                    case 74:
                        result = "J";
                        break;
                    case 75:
                        result = "K";
                        break;
                    case 76:
                        result = "L";
                        break;
                    case 77:
                        result = "M";
                        break;
                    case 78:
                        result = "N";
                        break;
                    case 79:
                        result = "O";
                        break;
                    case 80:
                        result = "P";
                        break;
                    case 81:
                        result = "Q";
                        break;
                    case 82:
                        result = "R";
                        break;
                    case 83:
                        result = "S";
                        break;
                    case 84:
                        result = "T";
                        break;
                    case 85:
                        result = "U";
                        break;
                    case 86:
                        result = "V";
                        break;
                    case 87:
                        result = "W";
                        break;
                    case 88:
                        result = "X";
                        break;
                    case 89:
                        result = "Y";
                        break;
                    case 90:
                        result = "Z";
                        break;
                        //if a number less than 65 or greater than 90 is entered the "invalid input" will display as the answer.
                    default:
                        result = "Invalid Input";
                        break;
                }

                //Display the results in the label
                lblAnswer.Text = result;
            } 
            
            else
            
            {
                // message if a character other than a number is entered.
                MessageBox.Show("Please enter a valid number between 65 and 90.");                

            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //reset input field and answer label back to empty and focus on input field.
            txtInput.Text = string.Empty;
            lblAnswer.Text = string.Empty;
            txtInput.Focus();
        }
    }
}
