using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BikeObserver
{
    class CaloriesObserver : BicycleObserver 
    {
        public CaloriesObserver(Label label, SpeedMonitorSubject bikeSubject) : base(label, bikeSubject)
        {
            //  nothing -- just use parent const.
        }

        public override void Update(int data)
        {
            double calories = data * 5;         // We assume 5 calories burned per 1 RPM
            displayLabel.Text = calories.ToString("F");
        }
    }
}
