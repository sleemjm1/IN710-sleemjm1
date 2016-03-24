using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherObserver
{
    public class AverageObserver : WeatherObserver
    {
        double? prevTemperatureAvg; // We need nullable doubles so that we can set them to null
        double? prevHumidityAvg;    // when there are no previous averages to go off of
        double? prevPressureAvg;
        public AverageObserver(ListBox listBox, WeatherSubject weatherSubject) : base(listBox, weatherSubject)
        {
            prevTemperatureAvg = null;
            prevHumidityAvg = null;
            prevPressureAvg = null;
        }

        public override void Update(int currTemperature, int currHumidity, int currPressure)
        {
            if (prevTemperatureAvg != null) // if we already have a previous average in the system
            {
                currComputedTemperature = ((double)prevTemperatureAvg + currTemperature) / 2;
                currComputedHumidity = ((double)prevHumidityAvg + currHumidity) / 2;
                currComputedPressure = ((double)prevPressureAvg + currPressure) / 2;

                prevTemperatureAvg = currComputedTemperature;
                prevHumidityAvg = currComputedHumidity;
                prevPressureAvg = currComputedPressure;
            }
            else    // Else this is our first time running averages -- just return current values
            {
                currComputedTemperature = currTemperature;
                currComputedHumidity = currHumidity;
                currComputedPressure = currPressure;

                prevTemperatureAvg = currTemperature;
                prevHumidityAvg = currHumidity;
                prevPressureAvg = currHumidity;
            }
        }
    }
}
