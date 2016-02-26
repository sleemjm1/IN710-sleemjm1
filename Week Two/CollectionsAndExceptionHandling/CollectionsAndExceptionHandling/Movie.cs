using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsAndExceptionHandling
{
    class Movie
    {
        public int Year { get; set; }
        public string Title { get; set; }
        public string Director { get; set; }

        public Movie(int myYear, string myTitle, string myDirector)
        {
            Year = myYear;
            Title = myTitle;
            Director = myDirector;
        }

        public override string ToString()
        {
            return Year + "," + Title + ", " + Director;
        }
    }
}
