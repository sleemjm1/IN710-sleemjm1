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
        int totalTemperature;
        int totalHumidity;
        int totalPressure;
        int totalRecords; // Amount of times we have run a simulation
        public AverageObserver(ListBox listBox, WeatherSubject weatherSubject) : base(listBox, weatherSubject)
        {
            totalTemperature = 0;
            totalHumidity = 0;
            totalPressure = 0;
            totalRecords = 0;
        }

        public override void Update(int currTemperature, int currHumidity, int currPressure)
        {
            totalTemperature += currTemperature;
            totalHumidity += currHumidity;
            totalPressure += currPressure;
            totalRecords += 1;

            currComputedTemperature = totalTemperature / totalRecords;
            currComputedHumidity = totalHumidity / totalRecords;
            currComputedPressure = totalPressure / totalRecords;
        }
    }
}
