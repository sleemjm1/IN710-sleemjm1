﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityData
{
    public class City
    {
        public string CityName { get; set; }
        public string CountryName { get; set; }
        public int Population { get; set; }

        public City(string cityName, string countryName, int population)
        {
            CityName = cityName;
            CountryName = countryName;
            Population = population;
        }

        public override string ToString()
        {
            return CityName + "       \t" + Population.ToString();
        }
    }
}
