using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollectionsAndExceptionHandling
{
    public partial class Form1 : Form
    {
        MovieDB movieDB = new MovieDB();
        int maxYear = 2016;
        int minYear = 1000;
        public Form1()
        {
            InitializeComponent();
            movieDB.PopulateMovieDB();
        }

        private void ClearAllInputControls()
        {
            tbAddDirector.Clear();
            tbAddTitle.Clear();
            tbAddYear.Clear();
            tbSearchDelete.Clear();
        }

        private bool TestForInteger(string stringToTest) //returns true if string is an integer
        {
            int outInt;
            bool result = Int32.TryParse(stringToTest, out outInt);
            return result;
            
        }

        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            string movieTitle; 
            string movieDirector; 
            int movieYear;
            if (tbAddTitle.Text != "" && tbAddDirector.Text != "") //If these two text boxes aren't empty
            {
                movieTitle = tbAddTitle.Text;
                movieDirector = tbAddDirector.Text;
                bool result = Int32.TryParse(tbAddYear.Text, out movieYear);    //use TryParse so that we don't need to catch an exception
                if (result && movieYear <= maxYear && movieYear >= minYear)     
                {
                    Movie movieToAdd = new Movie(movieYear, movieTitle, movieDirector);
                    try
                    {
                        movieDB.AddMovieToDB(movieToAdd);
                        MessageBox.Show("Movie added successfully");
                    }
                    catch (ArgumentException)   //we already have a movie with that key in our DB
                    {
                        MessageBox.Show(movieYear + " is already taken by another movie");
                    }
                    finally
                    {
                        ClearAllInputControls();
                    }
                }
                else
                {
                    MessageBox.Show("Movie year must be numeric and between " + minYear + " and " + maxYear);
                    ClearAllInputControls();
                }
            } // end text box check
            else
            {
                MessageBox.Show("Please fill out all required fields");
            }
        }

        private void btnPrintAll_Click(object sender, EventArgs e)
        {
            listAllMovies.Items.Clear();
            movieDB.ShowAllMovies(listAllMovies);
        }

        private void btnDeleteMovie_Click(object sender, EventArgs e)
        {
            if (TestForInteger(tbSearchDelete.Text))
            {
                int key = Int32.Parse(tbSearchDelete.Text);

                if (movieDB.DeleteMovieFromDB(key))
                {
                    MessageBox.Show("Movie from the year " + key + " was deleted");
                }
                else MessageBox.Show("Unable to find a movie for " + key);
                listAllMovies.Items.Clear();
                movieDB.ShowAllMovies(listAllMovies);
                
            }
            else MessageBox.Show("Please enter numeric value");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            listAllMovies.Items.Clear();
            if (TestForInteger(tbSearchDelete.Text))
            {
                int key = Int32.Parse(tbSearchDelete.Text.ToString());
                movieDB.SearchMovies(listAllMovies, key);
            }
            else MessageBox.Show("Please enter numeric value");            
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            listAllMovies.Items.Clear();
            movieDB.sortMovies(listAllMovies);
        }
    }
}
