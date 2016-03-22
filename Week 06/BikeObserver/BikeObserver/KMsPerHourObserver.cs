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
            double kmPerHour = ((data * 2.05) * 60) * 0.001;    // 1 metre = 0.001 KM, assuming 205CM (2.05M) is one rotation of wheel
            displayLabel.Text = kmPerHour.ToString("F");        // "F" = 2 DP
        }
    }
}
