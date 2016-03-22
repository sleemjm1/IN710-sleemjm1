using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BikeObserver
{
    // Base class
    public class BicycleObserver : IObserver
    {
        protected int currentRPM;
        protected double currentComputedValue;
        protected Label displayLabel;
        protected SpeedMonitorSubject bikeSubject;
        public void Update(int data);
       
        public void Display()
        {
            displayLabel.Text = currentComputedValue.ToString("F2");
        }

        public BicycleObserver(Label displayLabel, SpeedMonitorSubject bikeSubject)
        {
            this.displayLabel = displayLabel;

            currentRPM = 0;
            currentComputedValue = 0;
            this.bikeSubject = bikeSubject;

            // VERY IMPORTANT. Observers sign themselves up....
            bikeSubject.AddObserver(this);
        }
    }
}
