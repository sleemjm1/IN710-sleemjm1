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
    // Simple "database" to show the use of lambda expressions to search a list of objects
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
            listCities.Items.Clear();
            if (txtSearch.Text.Equals(""))
                MessageBox.Show("Please enter a country to search");
            else
            {
                listCities.Items.Add("City Name:\t Population:");
                string countryToSearchFor = txtSearch.Text;

                Func<string, string, bool> CitySearch = (a, b) => a.Equals(b);      // Delegate that uses a lambda to compare two strings

                foreach (City c in cityList)
                {
                    if (CitySearch(countryToSearchFor, c.CountryName))              // Using the delegate lambda declared above
                        listCities.Items.Add(c.ToString());
                }
                if (listCities.Items.Count == 1)
                    MessageBox.Show("No Cities for that Country are currently in our database");
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            listCities.Items.Clear();
            listCities.Items.Add("City Name:\t Population:");
            multiplyCities();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            listCities.Items.Clear();
            cityList.Clear();
            countryList.Clear();
            populateSeeds();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cityList = new List<City>();
            countryList = new List<City>();

            populateSeeds();

            foreach (City c in countryList)
                listCountries.Items.Add(c.CountryName);
        }


        // Methods

        // Multiply Cities
        // Use lambda expressions in combination with List<T>.ForEach in order to
        // multiply each cities' population by 3 and print the new population to
        // our list box
        private void multiplyCities()
        {
            // Lambda to multiply each cities' population by 3
            cityList.ForEach(c => c.Population *= 3);
            // Lambda to print each city to the screen
            cityList.ForEach(c => listCities.Items.Add(c.ToString()));
        }


        // Populate Seeds -- Hard coded
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
            // USA
            City NewYork = new City("New York", "America", 8491079);
            City LosAngeles = new City("Los Angeles", "America", 3928864);
            City Chicago = new City("Chicago", "America", 2722389);
            City Houston = new City("Houston", "America", 2239558);
            // Finland
            City Helsinki = new City("Helsinki", "Finland", 558475);
            City Espoo = new City("Espoo", "Finland", 256760);
            City Tampere = new City("Tampere", "Finland", 202687);
            City Vantaa = new City("Vantaa", "Finland", 190058);

            // Countries -- Only need one city from each country in this list
            countryList.Add(Dunedin);
            countryList.Add(Sydney);
            countryList.Add(NewYork);
            countryList.Add(Helsinki);

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

            // USA Cities
            cityList.Add(NewYork);
            cityList.Add(LosAngeles);
            cityList.Add(Chicago);
            cityList.Add(Houston);

            // FIN Cities
            cityList.Add(Helsinki);
            cityList.Add(Espoo);
            cityList.Add(Tampere);
            cityList.Add(Vantaa);
        }
    }
}
