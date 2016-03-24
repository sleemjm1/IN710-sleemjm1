using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherObserver
{
    // Temperature Observer will take the values passed into Update and assign them to the variables in the base class
    public class TemperatureObserver : WeatherObserver
    {
        public TemperatureObserver(ListBox listBox, WeatherSubject weatherSubject) : base(listBox, weatherSubject)
        {

        }

        public override void Update(int currTemperature, int currHumidity, int currPressure)
        {
            currComputedTemperature = currTemperature;
            currComputedHumidity = currHumidity;
            currComputedPressure = currPressure;
        }
    }
}
