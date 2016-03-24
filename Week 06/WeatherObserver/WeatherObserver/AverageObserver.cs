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
        double? prevTemperatureAvg;
        double? prevHumidityAvg;
        double? prevPressureAvg;
        public AverageObserver(ListBox listBox, WeatherSubject weatherSubject) : base(listBox, weatherSubject)
        {
            prevTemperatureAvg = null;
            prevHumidityAvg = null;
            prevPressureAvg = null;
        }

        public override void Update(int currTemperature, int currHumidity, int currPressure)
        {
            if (prevTemperatureAvg != null)
            {
                currComputedTemperature = ((double)prevTemperatureAvg + currTemperature) / 2;
                currComputedHumidity = ((double)prevHumidityAvg + currHumidity) / 2;
                currComputedPressure = ((double)prevPressureAvg + currPressure) / 2;

                prevTemperatureAvg = currComputedTemperature;
                prevHumidityAvg = currComputedHumidity;
                prevPressureAvg = currComputedPressure;
            }
            else
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
