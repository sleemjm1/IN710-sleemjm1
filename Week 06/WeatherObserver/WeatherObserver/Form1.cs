using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherObserver
{
    public partial class Form1 : Form
    {
        WeatherSubject weatherSubject;
        TemperatureObserver temperatureObserver;
        AverageObserver averageObserver;
        ForecastObserver forecastObserver;
        public Form1()
        {
            InitializeComponent();

            weatherSubject = new WeatherSubject();

            temperatureObserver = new TemperatureObserver(listTemperature, weatherSubject);
            averageObserver = new AverageObserver(listAverages, weatherSubject);
            forecastObserver = new ForecastObserver(listForecast, weatherSubject);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            weatherSubject.TriggerNotifications(tbTemperature, tbHumidity, tbPressure);
        }
    }
}
