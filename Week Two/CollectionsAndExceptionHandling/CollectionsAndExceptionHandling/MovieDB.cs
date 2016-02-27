using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollectionsAndExceptionHandling
{
    class MovieDB
    {
        public List<int> MovieListKeys = new List<int>();
        public Dictionary<int, Movie> movieTable = new Dictionary<int, Movie>();
        public MovieDB()
        {
            //movieTable.Add(movie.Year, movie);
        }

        public void AddMovieToDB(Movie movie)
        {
            movieTable.Add(movie.Year, movie); //Arguement Exception
            MovieListKeys.Add(movie.Year);
        }

        public bool DeleteMovieFromDB(int key)
        {

            if (MovieListKeys.Remove(key))
            {
                movieTable.Remove(key);
                return true;
            }
            else return false;
        }

        public void SearchMovies(ListBox listBox, int key)
        {
            Movie searchedMovie;
            if (movieTable.TryGetValue(key, out searchedMovie))
            {
                listBox.Items.Add(searchedMovie);
            }
        }

        public void ShowAllMovies(ListBox listBox)
        {
            foreach (int m in MovieListKeys)
            {
                SearchMovies(listBox, m);  //Can use SearchMovies method to help us with this
            }
        }

        public void PopulateMovieDB()
        {
            Movie MovieOne = new Movie(1975, "Joe's Movie", "Joe Sleeman");
            Movie MovieTwo = new Movie(1983, "Thomas' Movie", "Thomas Weilly");
            Movie MovieThree = new Movie(1992, "Ben's Movie", "Ben Gordon Munro");
            Movie MovieFour = new Movie(1991, "Emma's Movie", "Emma Whyte");

            AddMovieToDB(MovieOne);
            AddMovieToDB(MovieTwo);
            AddMovieToDB(MovieThree);
            AddMovieToDB(MovieFour);
        }

        public void sortMovies(ListBox listBox)
        {
            var list = movieTable.Keys.ToList();
            list.Sort();            // will sort ascending, hand-out doesn't seem to specify sort order
            foreach (var key in list)
            {
                listBox.Items.Add(movieTable[key]);
            }
        }
    }
}
