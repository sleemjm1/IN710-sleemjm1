﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherObserver
{
    public class WeatherSubject : ISubject
    {
        private List<IObserver> observerList;
        private int currTemperature;
        private int currHumidity;
        private int currPressure;

        public void AddObserver(IObserver o)
        {
            observerList.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            observerList.Remove(o);
        }

        public void NotifyObservers()
        {
            foreach (WeatherObserver currObserver in observerList)
            {
                currObserver.Update(currTemperature, currHumidity, currPressure);
                currObserver.Display();
            }
        }

        public WeatherSubject()
        {
            observerList = new List<IObserver>();
            currTemperature = 0;
            currHumidity = 0;
            currPressure = 0;
        }

        public void TriggerNotifications(TextBox tbTemperature, TextBox tbHumidity, TextBox tbPressure)
        {
            try
            {
                currTemperature = Int32.Parse(tbTemperature.Text);
                currPressure = Int32.Parse(tbPressure.Text);
                currHumidity = Int32.Parse(tbHumidity.Text);
                NotifyObservers();
            }
            catch(FormatException)
            {
                MessageBox.Show("Please enter numerical values in all provided fields");
            }
        }
    }
}