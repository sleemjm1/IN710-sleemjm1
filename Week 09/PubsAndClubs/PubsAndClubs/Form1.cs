using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PubsAndClubs
{
    public partial class Form1 : Form
    {
        XDocument doc;
        DataGridViewRowCollection VenueGridRows;
        DataGridViewRowCollection BandGridRows;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            doc = XDocument.Load("pubsAndClubs.xml");
            VenueGridRows = dataGridView1.Rows;
            BandGridRows = dgShowBandMembers.Rows;
            rbShowAll.Checked = true;
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            if (rbShowAll.Checked)
                showAllGigs();
            else if (rbShowHardRock.Checked)
                showHardRockGigs();
            else
                showThisMonthsGigs();
        }

        private void btnListBandMembers_Click(object sender, EventArgs e)
        {
            searchForBandMembers();
            clearAllControls();
        }

        private void btnAddGig_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;
            string genre = tbGenre.Text;
            string venue = tbVenue.Text;
            DateTime date = dateTimePicker1.Value;
            string time = tbTime.Text;              // Just letting them add it in as a text field

            addNewGig(name, genre, venue, date, time);

            clearAllControls();
        }

        private void addRowToVenueGrid(string date, string bandName, string genre, string venue)
        {
            
            string[] newRowValues = { date, bandName, genre, venue };
            VenueGridRows.Add(newRowValues);
        }
        // could maybe use the same method for both data grids and pass in grid as well as four strings
        // however I have chosen not to because the strings represent different things, and I cannot ensure
        // that a datagrid or search will only have four strings in the future - so this code looks repetitive
        private void addRowToBandGrid(string firstName, string lastName, string instrument, string role)
        {
            string[] newRowValues = { firstName, lastName, instrument, role };
            BandGridRows.Add(newRowValues);
        }

        private void showAllGigs()
        {
            VenueGridRows.Clear();

            foreach (XElement gig in doc.Element("Event_Guide").Elements("Gig"))
            {
                searchXMLForBand(gig);
            }
        }

        private void showHardRockGigs()
        {
            VenueGridRows.Clear();

            foreach (XElement gig in doc.Element("Event_Guide").Elements("Gig"))
            {
                if (gig.Element("Band").Element("Genre").Value.Trim().Equals("Hard Rock"))
                {
                    searchXMLForBand(gig);
                }
            }
        }

        private void showThisMonthsGigs()
        {
            VenueGridRows.Clear();
            string month = DateTime.Now.ToString("MM");
            string year = DateTime.Now.ToString("yyyy");
            string thisMonth = month + year;

            foreach (XElement gig in doc.Element("Event_Guide").Elements("Gig"))
            {
                string searchString = gig.Element("Date").Attribute("month").Value.Trim();
                searchString += gig.Element("Date").Attribute("year").Value.Trim();
                if (searchString.Equals(thisMonth))
                {
                    searchXMLForBand(gig);
                }
            }
        }

        private void searchForBandMembers()
        {
            string bandToSearchFor = tbBandSearch.Text;
            bool foundABand = false;
            foreach (XElement gig in doc.Element("Event_Guide").Elements("Gig"))
            {
                string bandString = gig.Element("Band").Element("Name").Value.Trim();

                if (bandString.Equals(bandToSearchFor))
                {
                    searchXMLForBandMember(gig);
                    foundABand = true;
                }
            }

            if (!foundABand)
                MessageBox.Show("No band found with that name");                
        }

        private void addNewGig(string name, string genre, string venue, DateTime date, string time)
        {
            string day = date.Day.ToString();
            string month = date.Month.ToString();
            string year = date.Year.ToString();
            XElement newGig = new XElement("Gig",
                                                new XElement("Venue", venue),
                                                new XElement("Date",
                                                    new XAttribute("day", day),
                                                    new XAttribute("month", month),
                                                    new XAttribute("year", year)),
                                                new XElement("Time", time),
                                                new XElement("Band",
                                                    new XElement("Name", name),
                                                    new XElement("Genre", genre))
                                           );
            doc.Element("Event_Guide").Add(newGig);
            doc.Save("pubsAndClubs.xml");
            MessageBox.Show("New entry added for: " + name + ".\n" + "At " + venue);
        }

        private void searchXMLForBand(XElement gig)
        {
            // go through and get date information which is an attribute of Date element in our XML
            string day = gig.Element("Date").Attribute("day").Value;
            string month = gig.Element("Date").Attribute("month").Value;
            string year = gig.Element("Date").Attribute("year").Value;
            // concat. to the date variable
            string date = day + "/" + month + "/" + year;
            // Name is an element within the Band element
            string bandName = gig.Element("Band").Element("Name").Value;

            string genre = gig.Element("Band").Element("Genre").Value;

            string venue = gig.Element("Venue").Value;

            addRowToVenueGrid(date, bandName, genre, venue);
        }

        private void searchXMLForBandMember(XElement gig)
        {
            try
            {
                foreach (XElement member in gig.Element("Band").Element("Band_Members").Elements("Member")) // null reference
                {
                    string firstName = member.Element("First_Name").Value;
                    string lastName = member.Element("Last_Name").Value;
                    // instruments
                    string instruments = "";
                    foreach (XElement inst in member.Element("Instruments").Elements("Instrument"))
                    {
                        instruments += inst.Value.Trim() + " ";
                    }

                    string role = "";
                    if (member.Element("Role") == null)
                        role = "Not Specified";
                    else
                        role = member.Element("Role").Value;

                    addRowToBandGrid(firstName, lastName, instruments, role);
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No members currently belong to that band");
            }
        }

        private void clearAllControls()
        {
            tbTime.Clear();
            tbBandSearch.Clear();
            tbGenre.Clear();
            tbName.Clear();
            tbVenue.Clear();
        }

    }
}
