﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Art_Database_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public List<Artist> artists;
        public List<Painting> paintings;

        private void Form1_Load(object sender, EventArgs e)
        {
            artists = new List<Artist>();
            artists.Add(new Artist { Country = "France", FirstName = "Camille", LastName = "Pissarro", YearOfBirth = 1830, YearOfDeath = 1903 });
            artists.Add(new Artist { Country = "France", FirstName = "Claude", LastName = "Monet", YearOfBirth = 1840, YearOfDeath = 1926 });
            artists.Add(new Artist { Country = "England", FirstName = "John", LastName = "Constable", YearOfBirth = 1776, YearOfDeath = 1837 });
            artists.Add(new Artist { Country = "Netherlands", FirstName = "Jan", LastName = "Vermeer", YearOfBirth = 1632, YearOfDeath = 1675 });
            artists.Add(new Artist { Country = "Italy", FirstName = "Sanzio", LastName = "Raphael", YearOfBirth = 1483, YearOfDeath = 1520 });
            artists.Add(new Artist { Country = "Spain", FirstName = "Pablo", LastName = "Picasso", YearOfBirth = 1881, YearOfDeath = 1973 });
            artists.Add(new Artist { Country = "Norway", FirstName = "Edvard", LastName = "Munch", YearOfBirth = 1863, YearOfDeath = 1944 });
            artists.Add(new Artist { Country = "Italy", FirstName = "Leonardo", LastName = "da Vinci", YearOfBirth = 1452, YearOfDeath = 1519 });
            artists.Add(new Artist { Country = "Italy", FirstName = "Sandro", LastName = "Botticelli", YearOfBirth = 1445, YearOfDeath = 1510 });
            artists.Add(new Artist { Country = "France", FirstName = "Henri", LastName = "Matisse", YearOfBirth = 1869, YearOfDeath = 1954 });
            artists.Add(new Artist { Country = "Netherlands", FirstName = "Piet", LastName = "Mondrian", YearOfBirth = 1872, YearOfDeath = 1944 });
            artists.Add(new Artist { Country = "United States", FirstName = "Jackson", LastName = "Pollock", YearOfBirth = 1912, YearOfDeath = 1956 });
            artists.Add(new Artist { Country = "Netherlands", FirstName = "Vincent", LastName = "van Gogh", YearOfBirth = 1853, YearOfDeath = 1890 });

            paintings = new List<Painting>();
            paintings.Add(new Painting { Artist = "van Gogh", Title = "The Starry Night", Method = "Oil on canvas", Year = 1889, Width = 72, Height = 92 });
            paintings.Add(new Painting { Artist = "van Gogh", Title = "Village Street in Auvers ", Method = "Oil on canvas", Year = 1890, Width = 73, Height = 92 });
            paintings.Add(new Painting { Artist = "Pissarro", Title = "Gelee Blanche", Method = "Oil on canvas", Year = 1873, Width = 65, Height = 93 });
            paintings.Add(new Painting { Artist = "Pissarro", Title = "Village Path", Method = "Oil on canvas", Year = 1875, Width = 72, Height = 92 });
            paintings.Add(new Painting { Artist = "Monet", Title = "Fishing Boats Leaving the Harbor, Le Havre ", Method = "Oil on canvas", Year = 1874, Width = 60, Height = 101 });
            paintings.Add(new Painting { Artist = "Monet", Title = "Water Lilies ", Method = "Oil on canvas", Year = 1906, Width = 88, Height = 93 });
            paintings.Add(new Painting { Artist = "Constable", Title = "The Leaping Horse", Method = "Oil on canvas", Year = 1825, Width = 142, Height = 187 });
            paintings.Add(new Painting { Artist = "Vermeer", Title = "Girl with a Pearl Earring", Method = "Oil on canvas", Year = 1665, Width = 45, Height = 40 });
            paintings.Add(new Painting { Artist = "Raphael", Title = "Madonna dell Granduca ", Method = "Oil on wood", Year = 1505, Width = 84, Height = 55 });
            paintings.Add(new Painting { Artist = "Raphael", Title = "St. George Fighting the Dragon ", Method = "Oil on wood", Year = 1825, Width = 28, Height = 21 });
            paintings.Add(new Painting { Artist = "Munch", Title = "The Scream", Method = "Tempera on paper", Year = 1893, Width = 91, Height = 74 });
            paintings.Add(new Painting { Artist = "da Vinci", Title = "The Last Supper", Method = "Tempera on plaster", Year = 1498, Width = 460, Height = 880 });
            paintings.Add(new Painting { Artist = "Botticelli", Title = "The Birth of Venus", Method = "Tempera on canvas", Year = 1485, Width = 173, Height = 280 });
            paintings.Add(new Painting { Artist = "Matisse", Title = "La Musique", Method = "Oil on canvas", Year = 1939, Width = 115, Height = 115 });
            paintings.Add(new Painting { Artist = "Mondrian", Title = "Composition with Red, Yellow and Blue", Method = "Oil on canvas", Year = 1821, Width = 40, Height = 35 });
            paintings.Add(new Painting { Artist = "Pollock", Title = "The Key", Method = "Oil on canvas", Year = 1946, Width = 84, Height = 213 });
            paintings.Add(new Painting { Artist = "Picasso", Title = "The Three Musicians", Method = "Oil on canvas", Year = 1921, Width = 200, Height = 222 });



        }

        //------------------------------------------------------
        // btnAllPaintings
        //------------------------------------------------------
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            IEnumerable<String> allPaintings;       // We return IEnumerable collection of strings
            allPaintings = from p in paintings      // Get stuff out of paintings class
                           select p.ToString();     // Select the painting's ToString() - because our IEnumerable is of type String

            foreach (String p in allPaintings)
                listBox1.Items.Add(p);
        }


        //------------------------------------------------------
        // btnArtistsFromItaly
        //------------------------------------------------------
        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            IEnumerable<String> artistsFromItaly;                   // We return IEnumerable collection of strings
            artistsFromItaly = from a in artists                    // Get stuff from artists class
                               where a.Country.Equals("Italy")      // Where the country is Italy
                               select a.ToString();                 // Select the artist's ToString()

            foreach (String a in artistsFromItaly)
                listBox1.Items.Add(a);
        }

        //------------------------------------------------------
        // btnBefore1800
        //------------------------------------------------------
        private void btnBefore1800_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            IEnumerable<String> paintingsBefore1800;        // We return IEnumerable collection of strings
            paintingsBefore1800 = from p in paintings       // Get stuff from paintings class
                                  where p.Year < 1800       // From before the year 1800
                                  select p.ToString();      // Select the painting's ToString()

            foreach (String p in paintingsBefore1800)
                listBox1.Items.Add(p);
        }

        //------------------------------------------------------
        // btnOldest
        //------------------------------------------------------
        private void btnOldest_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            //var oldestPainting = paintings.OrderBy(p => p.Year).First();                      // Look in to doing this with a predicate
            var oldestPainting = paintings.First(p => p.Year == paintings.Min(y => y.Year));    // Same result, different way to do it


            listBox1.Items.Add(oldestPainting);
        }

        //------------------------------------------------------
        // byThisArtist
        //------------------------------------------------------
        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            String searchedArtist = textBox1.Text;                                      // Pull string from text box
                                                                                        
            IEnumerable<String> searchResult = from p in paintings                      // Get stuff from paintings
                                               where p.Artist.Equals(searchedArtist)    // Where the artist is equal to the searched artist
                                               select p.ToString();                     // Select the painting's ToString()

            foreach (String p in searchResult)
                listBox1.Items.Add(p);

        }

        //------------------------------------------------------
        // btnNbyCountry
        //------------------------------------------------------
        private void btnNbyCountry_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            var groupedByCountry = artists.GroupBy(a => a.Country);                     // Here we are using LINQ method syntax

            foreach (var group in groupedByCountry)
            {
                String countryName = group.Key;                                         // We are grouping on country, so that is the key
                int paintingCount = group.Count();                                      // Count up all the paintings in our current group
                listBox1.Items.Add(paintingCount + " painting(s) from " + countryName); // Add to listbox and concat the string

        
            }

        }

        //------------------------------------------------------
        // btnArtistGroupedByCountry
        //------------------------------------------------------
        private void button8_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            var artistsGroupedByCountry = artists.GroupBy(a => a.Country);              // LINQ method syntax again

            foreach (var group in artistsGroupedByCountry)                              // Tterate through each group in our anonymous type (var)
            {
                String countryName = group.Key;                                         // Key is still country name

                listBox1.Items.Add(countryName + ":");                                  // Add the country name to our list box

                foreach (Artist artist in group)                                        // Iterate through artists in our group
                    listBox1.Items.Add("\t" + artist.FirstName + artist.LastName);      // Add the artist's first & last names to our list box
            }
        }

        //------------------------------------------------------
        // btnDutchPainters
        //------------------------------------------------------
        private void button7_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            IEnumerable<Artist> artistsWhoAreDutch = from a in artists                      
                                                     where a.Country.Equals("Netherlands")      // Only country we're interested in is Netherlands
                                                     select a;                                  // Grab the whole artist because we will need all properties, etc

            foreach (Artist artist in artistsWhoAreDutch)                                       // Iterate through our list of artists - not sure if this is right
            {                                                                                   // maybe better to do a join instead...
                IEnumerable<Painting> paintingsWithDutchArtists = from p in paintings           
                                                                  where p.Artist.Equals(artist.LastName)    // Grab paintings where the last name = the last name
                                                                  select p;                                 // of one of our Dutch artists

                foreach (Painting painting in paintingsWithDutchArtists)
                    listBox1.Items.Add(painting.ToString());
            }
        }

        //------------------------------------------------------
        // btnJoinTables
        //------------------------------------------------------
        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            var paintingAndArtist = from p in paintings                             
                                    join a in artists                                               // Joining artists
                                    on p.Artist equals a.LastName                                   // On painting artist and artist last name
                                    select new { a.Country, a.FirstName, a.LastName, p.Title };     // Create new "record" with artist country, first name
                                                                                                    // last name and painting title
            foreach (var record in paintingAndArtist)
                listBox1.Items.Add(record.FirstName + " " + record.LastName + "\t\t" + record.Country + "\t\t" + record.Title);          
        }

        //------------------------------------------------------
        // btnFrenchOrItalian
        //------------------------------------------------------
        private void button9_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            var frenchOrItalianPainters = from p in paintings
                                          join a in artists                                             // Joining artists to paintings
                                          on p.Artist equals a.LastName                                 // On painting artist and artist last name
                                          where a.Country.Equals("Italy") || a.Country.Equals("France") // where the artist's country is either France or Italy
                                          select new { a.LastName, a.Country, p.Title };                // Create new "record" with artist last name, country
                                                                                                        // and painting title
            foreach (var record in frenchOrItalianPainters)
                listBox1.Items.Add(record.LastName + "\t\t" + record.Country + "\t\t" + record.Title);
        }

 
    }
}
