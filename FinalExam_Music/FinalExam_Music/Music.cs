using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalExam_Music
{
    public partial class Music : Form
    {
        // multidimensional array for artist and style of music
        string[,] artist =
        {
                {"Beynoce", "p" },
                {"Rob Halford", "m" },
                {"David Bowie", "p" },
                {"Lita Ford", "m" },
                {"Keith Urban", "c" },
                {"Ozzy Osborne", "m" },
                {"Lucio Pavarotti", "o" },
                {"Lemmy", "m" },
                {"Madonna", "p" },
                {"Elton John", "p" },
                {"Arlo Guthrie", "c" },
                {"Dolly Parton", "c"},
                {"Miranda Lambert", "c" },
                {"Bob Dylan", "f" },
                {"James Hetfield", "m" },
                {"SlipKnot", "m" },
                {"Korn", "m" },
                {"Bob Marley", "r" },
                {"Taylor Swift", "p" }
            };
        
        public Music()
        {
            InitializeComponent();
        }
         private void btnExit_Click(object sender, EventArgs e)
        {
            // clost the application
            Close();
        }

        //load the artist in the list box when the form loads
        private void Music_Load(object sender, EventArgs e)
        {

            lstMusicians.Items.Clear();

            for (int i = 0; i < artist.GetLength(0); i++)
            {
                lstMusicians.Items.Add(artist[i, 0]);
            }
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            // counter for each style
            int popCount = 0;
            int metalCount = 0;
            int countryCount = 0;
            int otherCount = 0;


            // loop through the array to get the counts
            for (int i = 0; i < artist.GetLength(0); i++)
            {
                string style = artist[i, 1];

                // increment the counter each time the style comes up

                if (style == "p")
                {
                    popCount++;
                }
                else if (style == "m")
                {
                    metalCount++;
                }
                else if (style == "c")
                {
                    countryCount++;
                }
                else
                {
                    otherCount++;
                }
            }

            // display the totals
            lblPopCount.Text = $"Pop Count: {popCount}";
            lblMetalCount.Text = $"Metal Count: {metalCount}";
            lblCountryCount.Text = $"Country Count: {countryCount}";
            lblOtherCount.Text = $"Other Count: {otherCount}";
        }
    }
}
