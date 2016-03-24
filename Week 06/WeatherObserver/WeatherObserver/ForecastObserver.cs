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
                heat = "Very Hot";
            else if (currTemperature > 20 && currTemperature < 30)
                heat = "Warm";
            else
                heat = "Cold";

            if (currHumidity > 70)
                dryness = "Quite Humid";
            else if (currHumidity > 50 && currHumidity < 70)
                dryness = "Humid";
            else
                dryness = "Dry";

            pressure = "High";
        }

        public override void Display()
        {
            listBox.Items.Clear();
            listBox.Items.Add("Today's weather forecast is a " + heat + "Temperature.");
            listBox.Items.Add("Humidity is " + dryness + ".");
            listBox.Items.Add("You can expect " + pressure + " pressure.");
        }

    }
}
