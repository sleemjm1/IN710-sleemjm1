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
        string fileName = "pubsAndClubs.xml";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            doc = XDocument.Load(fileName);
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
            string time = tbTime.Text;              // Just letting user add it in as a text field
                                                    // Would have more checks in a real application
            if (name.Equals(""))
                MessageBox.Show("Please add a name at the very least");
            else
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
            string month = DateTime.Now.ToString("MM");     // We will search on both month & year even though it is unspecified
            string year = DateTime.Now.ToString("yyyy");    // on whether or not the year matters.. Assuming it does for this task
            string thisMonth = month + year;

            foreach (XElement gig in doc.Element("Event_Guide").Elements("Gig"))
            {
                string searchString = gig.Element("Date").Attribute("month").Value.Trim();  // Match the format of "thisMonth" string above
                searchString += gig.Element("Date").Attribute("year").Value.Trim();         // so that we can compare the values       
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

        // Add a new gig to the XML file
        private void addNewGig(string name, string genre, string venue, DateTime date, string time)
        {
            string day = date.Day.ToString();                       // ToString our passed in DateTime - Not sure if required..
            string month = date.Month.ToString().PadLeft(2, '0');   // hacky way to force a leading zero 
            string year = date.Year.ToString(); 
            // Creating new XElement called newGig which will be a gig entry in our XML file
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
            // Add the new gig to our XDocument "doc" nested inside the root Element
            doc.Element("Event_Guide").Add(newGig);
            // Save and overwrite our xml file stored in fileName variable
            doc.Save(fileName);
            // Feedback to user
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
            // Do the same for Genre and Venue
            string genre = gig.Element("Band").Element("Genre").Value;

            string venue = gig.Element("Venue").Value;
            // Use our addRowToVenueGrid method which we created below
            addRowToVenueGrid(date, bandName, genre, venue);
        }

        private void searchXMLForBandMember(XElement gig)
        {
            try         // Surround with try/catch incase there are no members in the band 
            {
                foreach (XElement member in gig.Element("Band").Element("Band_Members").Elements("Member")) // null reference
                {
                    string firstName = member.Element("First_Name").Value;
                    string lastName = member.Element("Last_Name").Value;
                    // instruments - we need to loop because some artists can play multiple instruments
                    string instruments = "";
                    foreach (XElement inst in member.Element("Instruments").Elements("Instrument"))
                    {
                        instruments += inst.Value.Trim() + " ";
                    }

                    string role = "";
                    if (member.Element("Role") == null)     // Some artists don't have a role so we check for that
                        role = "Not Specified";
                    else
                        role = member.Element("Role").Value;
                    // Use addRowToBandGrid to add the found member to the data-grid-view
                    addRowToBandGrid(firstName, lastName, instruments, role);
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No members currently belong to that band");
            }
        }

        private void clearAllControls()     // Utility method used to clear controls
        {
            tbTime.Clear();
            tbBandSearch.Clear();
            tbGenre.Clear();
            tbName.Clear();
            tbVenue.Clear();
        }

    }
}
