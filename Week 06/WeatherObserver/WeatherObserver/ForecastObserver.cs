using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherObserver
{
    public class ForecastObserver : WeatherObserver
    {
        string heat;
        string dryness;
        string pressure;

        public ForecastObserver(ListBox listBox, WeatherSubject weatherSubject) : base(listBox, weatherSubject)
        {

        }


        public override void Update(int currTemperature, int currHumidity, int currPressure)
        {
            if (currTemperature > 30)
                heat = "Hot";
            else if (currTemperature > 20 && currTemperature < 30)
                heat = "Warm";
            else
                heat = "Cold";

            if (currHumidity > 70)
                dryness = "Humid";
            else if (currHumidity > 50 && currHumidity < 70)
                dryness = "Average";
            else
                dryness = "Dry";

            pressure = "High";  // I don't know anything about barometric pressure -- revisit
        }

        public override void Display()
        {
            listBox.Items.Clear();
            listBox.Items.Add("You can expect a " + heat + " temperature.");
            listBox.Items.Add("Humidity should be " + dryness + ".");
            listBox.Items.Add("You can expect " + pressure + " pressure.");
        }

    }
}
