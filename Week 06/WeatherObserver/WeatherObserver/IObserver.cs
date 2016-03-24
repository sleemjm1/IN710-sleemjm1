using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherObserver
{
    // The interface from which our observer base class will descend from
    public interface IObserver
    {
        void Update(int temperature, int humidity, int pressure);
        void Display();
    }
}
