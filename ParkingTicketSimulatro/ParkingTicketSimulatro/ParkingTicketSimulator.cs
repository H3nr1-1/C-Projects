using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingTicketSimulatro
{

    public partial class ParkingTicketSimulator : Form
    {
        public ParkingTicketSimulator()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnExamineCar_Click(object sender, EventArgs e)
        {
            // making the parked car object
            ParkedCar car = new ParkedCar
            {
                Make = txtMake.Text,
                Model = txtModel.Text,
                Color = txtColor.Text,
                LicenseNumber = txtLicensePlate.Text,
                MinutesParked = int.Parse(txtMinutesParked.Text),
            };

            //making the parking meter
            ParkingMeter meter = new ParkingMeter
            {
                MinutesPurchased = int.Parse(txtMinutesPurchased.Text),
            };

            // making police officer
            PoliceOfficer officer = new PoliceOfficer
            {
                Name = txtOfficerName.Text,
                BadgeNumber = txtBadgeNumber.Text,
            };

            //making the ticket
            ParkingTicket ticket = officer.IssueTicket(car, meter);

            // show the results
            if (ticket != null)
            {
                txtDisplayTickets.Text = ticket.ToString();
            }
            else
            {
                txtDisplayTickets.Text = "No ticket issued.";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // clear all fields and reset the focus to the car make
            txtMake.Clear();
            txtModel.Clear();
            txtColor.Clear();
            txtLicensePlate.Clear();
            txtMinutesParked.Clear();
            txtMinutesPurchased.Clear();
            txtOfficerName.Clear();
            txtBadgeNumber.Clear();
            txtDisplayTickets.Clear();
            txtMake.Focus();
        }
    }

    // creating the parked car class
    public class ParkedCar
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public string LicenseNumber { get; set; }
        public int MinutesParked { get; set; }
    }

    //creating ParkingMeter class
    public class ParkingMeter
    {
        public int MinutesPurchased { get; set; }
    }

    //creating the ParkingTicket class 
    public class ParkingTicket
    {
        public string Make { get; private set; }
        public string Model { get; private set; }
        public string Color { get; private set; }
        public string LicenseNumber { get; private set; }
        public decimal Fine { get; private set; }
        public string OfficerName { get; private set; }
        public string BadgeNumber { get; private set; }

        public ParkingTicket(string make, string model, string color, string licenseNumber, decimal fine, string officerName, string badgeNumber)
        {
            Make = make;
            Model = model;
            Color = color;
            LicenseNumber = licenseNumber;
            Fine = fine;
            OfficerName = officerName;
            BadgeNumber = badgeNumber;
        }

        public override string ToString()
        {
            return $"Ticket for: {Make} {Model} ({Color}) - {LicenseNumber} " +
                   $" Fine: ${Fine} " +
                   $" Issued by: Officer {OfficerName}, Badge # {BadgeNumber}";
        }
    }


    //create the police officer class
    public class PoliceOfficer
    {
        public string Name { get; set; }
        public string BadgeNumber { get; set; }

        public ParkingTicket IssueTicket(ParkedCar car, ParkingMeter meter)
        {
            if (car.MinutesParked > meter.MinutesPurchased)
            {
                int overtimeMinutes = car.MinutesParked - meter.MinutesPurchased;
                int overtimeHours = (int)Math.Ceiling(overtimeMinutes / 60.0);
                decimal fine = 25 + (overtimeHours - 1) * 10;

                return new ParkingTicket(car.Make, car.Model, car.Color, car.LicenseNumber, fine, Name, BadgeNumber);
            }

            return null;
        }
    }
}
