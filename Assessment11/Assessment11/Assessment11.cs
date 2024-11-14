using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assessment11
{
    public partial class Assessment11 : Form
    {
        public Assessment11()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // close the application
            Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // clear all input and output fields, uncheck all password boxes, set focus to the Main Text textbox
            txtMainText.Clear();
            txtSearchText.Clear();
            txtReplaceText.Clear();
            lblOccurances.Text = "Occurances: 0";
            lbOccurances.Items.Clear();
            txtPassword.Clear();
            txtPassword.BackColor = Color.Red;
            cbNumbers.Checked = false;
            cbSpecialCharacters.Checked = false;
            cbUpper.Checked = false;
            cbLower.Checked = false;
            cbSpaces.Checked = false;
            
            txtMainText.Focus();
        }

        private void btnSearchReplace_Click(object sender, EventArgs e)
        {

            try
            {
                string mainText = txtMainText.Text;
                string searchText = txtSearchText.Text;
                string replaceText = txtReplaceText.Text;

                if (string.IsNullOrEmpty(searchText))
                {
                    MessageBox.Show("Please enter text to search for.");
                    return;
                }

                // using stringbuilder for text manipulation
                StringBuilder textBuilder = new StringBuilder(mainText);
                int occurances = 0;
                int startIndex = 0;

                // clear previous search results.
                lbOccurances.Items.Clear();

                // search for occurances of the word entered in the txtSearchText
                while ((startIndex = textBuilder.ToString().IndexOf(searchText, startIndex)) != -1)
                {
                    occurances++;
                    lbOccurances.Items.Add(startIndex);
                    startIndex += searchText.Length;
                }

                //update the number of occurances of the word entered.
                lblOccurances.Text = $"Occurances: {occurances}";

                // replace text if replacement text is entered
                if (!string.IsNullOrEmpty(replaceText))
                {
                    textBuilder.Replace(searchText, replaceText);
                    txtMainText.Text = textBuilder.ToString();
                }
            }

            catch (Exception)
            {
                MessageBox.Show("An error occured, please try again.");
            }
        }

        // validation for the password
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

            string password = txtPassword.Text;

            //check to see if each password parameter is met.
            // Regex.IsMatch() allows for real time update
            cbNumbers.Checked = Regex.IsMatch(password, @"\d");
            cbSpecialCharacters.Checked = Regex.IsMatch(password, @"[!@#$%^&*()<>?""{}|<>]");
            cbUpper.Checked = Regex.IsMatch(password, @"[A-Z]");
            cbLower.Checked = Regex.IsMatch(password, @"[a-z]");
            cbSpaces.Checked = password.Contains(" ");

            //change password Text Box background color if parametes are met or not
            if (cbNumbers.Checked && cbSpecialCharacters.Checked && cbUpper.Checked && cbLower.Checked && cbSpaces.Checked)
            {
                txtPassword.BackColor = Color.Green;
            }
            else
            {
                txtPassword.BackColor = Color.Red;
            }

        }
    }
}
