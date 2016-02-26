using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsAndExceptionHandling
{
    class MovieDB
    {
        public List<Movie> MovieList;
        public Dictionary<int, Movie> movieTable = new Dictionary<int, Movie>();

        public MovieDB()
        {
            //movieTable.Add(movie.Year, movie);
        }

        public void AddMovieToDB(Movie movie)
        {
            movieTable.Add(movie.Year, movie);
        }

        public void DeleteMovieFromDB(Movie movie)
        {
            int key = movie.Year;
            movieTable.Remove(key);
        }

        public void ShowAllMovies()
        {

        }
    }
}
