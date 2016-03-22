using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BikeObserver
{
    public class RPMObserver : BicycleObserver // descend from our base class
    {
        public RPMObserver(Label label, SpeedMonitorSubject bikeSubject) : base(label, bikeSubject)
        {
        }

        public override void Update(int data)
        {
            double rpm = data;
            displayLabel.Text = rpm.ToString("F");  // "F" so that 2 DP even with whole numbers     
        }
    }
}
