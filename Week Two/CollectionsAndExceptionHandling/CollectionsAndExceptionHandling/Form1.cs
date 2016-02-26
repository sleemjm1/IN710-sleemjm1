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
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            int movieYear = Int32.Parse(tbAddYear.Text);
            string movieTitle = tbAddTitle.Text;
            string movieDirector = tbAddDirector.Text;

            Movie movieToAdd = new Movie(movieYear, movieTitle, movieDirector);

            MovieDB movieDB = new MovieDB();
            movieDB.AddMovieToDB(movieToAdd);
        }
    }
}
