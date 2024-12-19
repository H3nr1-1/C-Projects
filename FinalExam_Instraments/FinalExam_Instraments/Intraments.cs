using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalExam_Instraments
{
    public partial class Intraments : Form
    {

        // declare an array for the instruments
        private string[] instruments = { "Cello", "Guitar", "Violin", "Double Bass" };

        public Intraments()
        {
            InitializeComponent();
            LoadInstraments();
        }

        // creating a method to load the instraments into the first listbox
        private void LoadInstraments()
        {
            lstInstruments.Items.Clear();
            foreach (string instrument in instruments)
            {
                lstInstruments.Items.Add(instrument);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //close the application
            Close();
        }

        //method to remove the vowel from the instraments
        private void Vowelless()
        {
            // loop through the instraments and remove the vowels
            for (int i = 0; i < instruments.Length; i++)
            {
                instruments[i] = RemoveVowels(instruments[i]);
            }

            //display the updated array without vowels in the 2nd listbox
            lstIHaveNoVowels.Items.Clear();
            foreach (string instrument in instruments)
            {
                lstIHaveNoVowels.Items.Add(instrument);
            }
        }

        // helper method to remove vowels from the string
        private string RemoveVowels(string input)
        {
            string vowels = "AEIOUaeiou";
            return new string(input.Where(c => !vowels.Contains(c)).ToArray());
        }

        private void btnRemoveVowels_Click(object sender, EventArgs e)
        {
            // method to make the array work
            Vowelless();
        }
    }
}
