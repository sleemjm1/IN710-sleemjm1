using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CityData
{
    public partial class Form1 : Form
    {
        List<City> cityList;
        List<City> countryList;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Func<string, string, bool> CitySearch = city => city.Compare;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cityList = new List<City>();
            countryList = new List<City>();

            populateSeeds();

            foreach (City c in countryList)
                listCountries.Items.Add(c.CountryName);
        }


        // Populate Seeds
        private void populateSeeds()
        {
            // New Zealand
            City Dunedin = new City("Dunedin", "New Zealand", 127500);
            City Christchurch = new City("Christchurch", "New Zealand", 366100);
            City Wellington = new City("Wellington", "New Zealand", 204000);
            City Auckland = new City("Auckland", "New Zealand", 1377000);
            //Australia
            City Sydney = new City("Sydney", "Australia", 4627345);
            City Melbourne = new City("Melbourne", "Australia", 4246375);
            City Brisbane = new City("Brisbane", "Australia", 2189878);
            City Perth = new City("Perth", "Australia", 1896548);
            
            // Countries -- Only need one city from each country in this list
            countryList.Add(Dunedin);
            countryList.Add(Sydney);

            // NZ Cities
            cityList.Add(Dunedin);
            cityList.Add(Christchurch);
            cityList.Add(Wellington);
            cityList.Add(Auckland);

            // AUS Cities
            cityList.Add(Sydney);
            cityList.Add(Melbourne);
            cityList.Add(Brisbane);
            cityList.Add(Perth);
        }
    }
}
