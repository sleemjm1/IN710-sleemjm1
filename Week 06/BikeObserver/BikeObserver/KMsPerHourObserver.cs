using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BikeObserver
{
    class KMsPerHourObserver : BicycleObserver
    {
        public KMsPerHourObserver(Label label, SpeedMonitorSubject bikeSubject) : base(label, bikeSubject)
        {
            // Nothing... 
        }

        public override void Update(int data)
        {
            currentComputedValue = ((data * 2.05) * 60) * 0.001;   
        }
    }
}
