using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherObserver
{
    // Base class -- Child observers will descend from this class
    public abstract class WeatherObserver : IObserver
    {
        protected int currTemperature;
        protected int currHumidity;
        protected int currPressure;
        public double currComputedTemperature;
        public double currComputedHumidity;
        public double currComputedPressure;
        protected ListBox listBox;
        protected WeatherSubject weatherSubject;

        public abstract void Update(int currTemperature, int currHumidity, int currPressure);   

        public virtual void Display()   // Virtual because ForecastObserver needs to override
        {
            listBox.Items.Clear();
            listBox.Items.Add("Temperature:\t" + currComputedTemperature.ToString("F2"));
            listBox.Items.Add("Humidity:\t\t" + currComputedHumidity.ToString("F2"));
            listBox.Items.Add("Pressure:\t\t" + currComputedPressure.ToString("F2"));
        }

        public WeatherObserver(ListBox listBox, WeatherSubject weatherSubject)
        {
            currTemperature = 0;
            currPressure = 0;
            currHumidity = 0;

            this.listBox = listBox;
            this.weatherSubject = weatherSubject;

            weatherSubject.AddObserver(this);   
        }
    }
}
