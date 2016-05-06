using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LightningFires
{
    public partial class Form1 : Form
    {
        LightningStrikesDBDataContext lsdbc;
        DataGridViewRowCollection resultGridRows;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lsdbc = new LightningStrikesDBDataContext();
            resultGridRows = dataGridView1.Rows;
        }


        // Average Intensity
        // Compute & display the average intensity for all strikes. 
        private void button1_Click(object sender, EventArgs e)
        {
            reset();

            var averageIntensity = lsdbc.tblStrikes.Average(s => s.strikeIntensity);
            MessageBox.Show(averageIntensity.ToString());
        }

        // Three Largest Fires
        // List the complete records of the largest three fires (in terms of area).
        private void button2_Click(object sender, EventArgs e)
        {
            reset();

            var topThreeFires = lsdbc.tblFires.Select(f => f)                       // Select whole fire object (record, whatever..)
                                              .OrderByDescending(f => f.fireArea)   // OrderByDescending (Largest => Smallest)
                                              .Take(3);                             // Just need top 3, so use this handy Take method

            // Gotta add columns before rows
            dataGridView1.Columns.Add("ID", "ID");
            dataGridView1.Columns.Add("Date", "Date");
            dataGridView1.Columns.Add("Latitude", "Latitude");
            dataGridView1.Columns.Add("Longitude", "Longitude");
            dataGridView1.Columns.Add("Area", "Area");

            foreach (var f in topThreeFires)
            {
                string[] newRowValues = { f.fireID.ToString(), f.fireDate.ToString(), f.fireLatitude.ToString(), f.fireLongitude.ToString(), f.fireArea.ToString() };
                resultGridRows.Add(newRowValues);
            }
        }

        // Pictures
        // Display the latitude, longitude, and filename for each picture.
        private void button3_Click(object sender, EventArgs e)
        {
            reset();

            var pictures = from p in lsdbc.tblPictures                                              // From Pictures
                           join s in lsdbc.tblStrikes                                               // Join Strikes
                           on p.strikeID equals s.strikeID                                          // On Picture strikeID (PK) = Strike strikeID (FK)
                           select new { s.strikeLatitude, s.strikeLongitude, p.pictureFileName };   // Create a new "record" with fields we are interested in

            dataGridView1.Columns.Add("Latitude", "Latitude");
            dataGridView1.Columns.Add("Longitude", "Longitude");
            dataGridView1.Columns.Add("File Name", "File Name");

            foreach (var f in pictures)
            {
                string[] newRowValues = { f.strikeLatitude.ToString(), f.strikeLongitude.ToString(), f.pictureFileName.ToString() };
                resultGridRows.Add(newRowValues);
            }

        }

        // Strikes that cause fires
        // You can assume that a strike causes a fire when they have the same date, latitude and longitude.
        // List all fires that were caused by a lightning strike.
        private void button4_Click(object sender, EventArgs e)
        {
            reset();

            var fireCausingStrikes = from f in lsdbc.tblFires
                                     join s in lsdbc.tblStrikes
                                     on f.fireDate equals s.strikeDate
                                     where f.fireLongitude == s.strikeLongitude && f.fireLatitude == s.strikeLatitude
                                     select f;

            dataGridView1.Columns.Add("Fire ID", "Fire ID");
            dataGridView1.Columns.Add("Fire Date", "Fire Date");
            dataGridView1.Columns.Add("Fire Latitude", "Fire Latitude");
            dataGridView1.Columns.Add("Fire Longitude", "Fire Longitude");
            dataGridView1.Columns.Add("Fire Area", "Fire Area");   
            
            foreach (var f in fireCausingStrikes)
            {
                string[] newRowValues = { f.fireID.ToString(), f.fireDate.ToString(), f.fireLatitude.ToString(), f.fireLongitude.ToString(), f.fireArea.ToString() };
                resultGridRows.Add(newRowValues);
            }
        }
        void reset()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
        }


    }
}
