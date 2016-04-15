using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityDataFuncLambda
{
    public class City
    {
        public string CityName {get; set;}
        public string CountryName { get; set;}
        public int Population { get; set; }

        public City(string city, string country, int pop)
        {
            CityName = city;
            CountryName = country;
            Population = pop;
        }

        public override string ToString()
        {
            return CityName + ", " + CountryName + ", " + Population.ToString();
        }
    }
}
