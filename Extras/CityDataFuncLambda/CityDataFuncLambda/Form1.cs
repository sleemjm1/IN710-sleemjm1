using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.IO;

namespace CityDataFuncLambda
{
    public partial class Form1 : Form
    {
        List<City> allCitiesList;
        public Form1()
        {
            InitializeComponent();
        }

        public void ParseJSONFile(String inputFileName)
        {

            allCitiesList = new List<City>();
            StreamReader sr = new StreamReader(inputFileName);
            String rawJSON = "";
            String currentLine = "";
            while ((currentLine = sr.ReadLine()) != null)
                rawJSON += currentLine;

            JObject allCitiesObject = JObject.Parse(rawJSON);

            JToken dataArray = allCitiesObject["data"];

            foreach (var city in dataArray)
            {
                string name = (string)city["cityName"];
                string country = (string)city["countryName"];
                int population = (int)city["population"];

                City c = new City(name, country, population);

                allCitiesList.Add(c);
            }

        }

        Func<List<City>, string, List<City>> SearchByCountry = 
            (cities, searchCountry) => cities.FindAll(c => c.CountryName.Equals(searchCountry));

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            String searchKey = txtSearchKey.Text;
            List<City> filteredCities = SearchByCountry(allCitiesList, searchKey);

            foreach (City c in filteredCities)
                listBox1.Items.Add(c.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ParseJSONFile("city_data.json");
        }
    }
}
