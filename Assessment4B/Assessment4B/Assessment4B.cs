using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assessment4B
{
    public partial class Assessment4B : Form
    {
        public Assessment4B()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // close the application
            Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //reset the text box and answer back to empty and focus to the input text box.
            txtInput.Text = string.Empty;
            lblResult.Text = string.Empty;
            txtInput.Focus();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            // get the input
            string  input = txtInput.Text;

            //validate that only 1 capitol letter was entered.
            if (input.Length == 1)
            {
                char letter = input[0];

                // if else structure from A to Z
                if (letter == 'A')
                {
                    lblResult.Text = "65";
                }
                else if (letter == 'B')
                {
                    lblResult.Text = "66";
                }
                else if (letter == 'C')
                {
                    lblResult.Text = "67";
                }
                else if (letter == 'D')
                {
                    lblResult.Text = "68";
                }
                else if (letter == 'E')
                {
                    lblResult.Text = "69";
                }
                else if (letter == 'F')
                {
                    lblResult.Text = "70";
                }
                else if (letter == 'G')
                {
                    lblResult.Text = "71";
                }
                else if (letter == 'H')
                {
                    lblResult.Text = "72";
                }
                else if (letter == 'I')
                {
                    lblResult.Text = "73";
                }
                else if (letter == 'J')
                {
                    lblResult.Text = "74";
                }
                else if (letter == 'K')
                {
                    lblResult.Text = "75";
                }
                else if (letter == 'L')
                {
                    lblResult.Text = "76";
                }
                else if (letter == 'M')
                {
                    lblResult.Text = "77";
                }
                else if (letter == 'N')
                {
                    lblResult.Text = "78";
                }
                else if (letter == 'O')
                {
                    lblResult.Text = "79";
                }
                else if (letter == 'P')
                {
                    lblResult.Text = "80";
                }
                else if (letter == 'Q')
                {
                    lblResult.Text = "81";
                }
                else if (letter == 'R')
                {
                    lblResult.Text = "82";
                }
                else if (letter == 'S')
                {
                    lblResult.Text = "83";
                }
                else if (letter == 'T')
                {
                    lblResult.Text = "84";
                }
                else if (letter == 'U')
                {
                    lblResult.Text = "85";
                }
                else if (letter == 'V')
                {
                    lblResult.Text = "86";
                }
                else if (letter == 'W')
                {
                    lblResult.Text = "87";
                }
                else if (letter == 'X')
                {
                    lblResult.Text = "88";
                }
                else if (letter == 'Y')
                {
                    lblResult.Text = "89";
                }
                else if (letter == 'Z')
                {
                    lblResult.Text = "90";
                }
                else
                {
                    // validation that the input needs to be a capital letter
                    lblResult.Text = "Invalid input! Please enter a capital letter (A-Z).";
                }
            }

            else
            {
                //validation that only one letter needs to be entered.
                lblResult.Text = "Please enter one capital letter (A-Z).";
            }
        }
    }
}
