using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalExam_Song
{
    //base class
    public class AudioVideoRecord
    {
        public string MovieName { get; set; }
        public int ReleaseYear { get; set; }
        public decimal Price { get; set; }

        // constructor
        public AudioVideoRecord(string movieName, int releaseYear, decimal price)
        {
            MovieName = movieName;
            ReleaseYear = releaseYear;
            Price = price;
        }

        //display the method
        public virtual void Diplay()
        {
            MessageBox.Show($"Movie Name: {MovieName}\nRelease Year: {ReleaseYear}\nPrice: ${Price:F2}", "AudioVideoRecord Details");
        }
    }

    // derived class
    public class SongRecord : AudioVideoRecord
    {
        public int NumberOfSongs { get; set; }

        //constructor
        public SongRecord(string movieName, int releaseYear, decimal price, int numberOfSongs) : base(movieName, releaseYear, price)
        {
            NumberOfSongs = numberOfSongs;
        }

        //override the display method
        public override void Diplay()
        {
            base.Diplay();
            MessageBox.Show($"Number of Songs: {NumberOfSongs}", "SongRecord Details");
        }
    }

    class Program
    {
        static void Test()
        {
            //create 2 song records
            SongRecord songRecord1 = new SongRecord("The Greatest Showman", 2017, 19.99m, 11);
            SongRecord songRecord2 = new SongRecord("Frozen", 2013, 14.99m, 10);

            //display the details
            songRecord1.Diplay();
            songRecord2.Diplay();
        }

        static void Main(string[] args)
        {
            Test();
        }
    }
}
