﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BikeObserver
{
    public class SpeedMonitorSubject : ISubject
    {
        private List<IObserver> observerList;
        private int currentRPM;
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
            foreach (BicycleObserver currentObserver in observerList)
                currentObserver.Update(currentRPM);
        }

        public SpeedMonitorSubject()
        {
            observerList = new List<IObserver>();
            currentRPM = 0;
        }


        public void TriggerNotifications(TextBox textBox)
        {
            try
            {
                currentRPM = Int32.Parse(textBox.Text);
                NotifyObservers();
            }
            catch(FormatException)
            {
                MessageBox.Show("Only numerical values supported");
            }
        }

    }
}