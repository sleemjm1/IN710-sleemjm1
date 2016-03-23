using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherObserver
{
    public abstract class WeatherObserver : IObserver
    {
        protected int currTemperature;
        protected int currHumidity;
        protected int currPressure;
        protected double currComputedValue;
        protected ListBox listBox;
        protected WeatherSubject weatherSubject;

        public abstract void Update(int data);

        public void Display()
        {
            listBox.Items.Add(currComputedValue.ToString("F2"));
        }

        public WeatherObserver(ListBox listBox, WeatherSubject weatherSubject)
        {
            this.listBox = listBox;

            currTemperature = 0;
            currPressure = 0;
            currHumidity = 0;

            this.weatherSubject = weatherSubject;

            weatherSubject.AddObserver(this);
        }
    }
}
