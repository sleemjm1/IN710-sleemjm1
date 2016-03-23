using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherObserver
{
    interface ISubject
    {
        void AddObserver(IObserver o);
        void RemoveObserver(IObserver o);
        void NotifyObservers();
        void TriggerNotifications(TextBox tbTemperature, TextBox tbHumidity, TextBox tbPressure);
    }
}
