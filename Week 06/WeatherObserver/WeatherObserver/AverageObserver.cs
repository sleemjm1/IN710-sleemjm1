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
        // We need the below variables so that we can compute averages
        int totalTemperature;
        int totalHumidity;
        int totalPressure;
        int totalRecords; // Amount of times we have run a simulation
        public AverageObserver(ListBox listBox, WeatherSubject weatherSubject) : base(listBox, weatherSubject)
        {
            // When an AverageObserver is created, values will all be set to 0
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
