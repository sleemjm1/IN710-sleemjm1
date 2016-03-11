using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clocks
{
    class AnalogClock : IClock
    {
        AnalogClockControl.AnalogClock clock;

        public AnalogClock(AnalogClockControl.AnalogClock analogClock)
        {
            clock = analogClock;
        }
        public void On()
        {
            clock.Start();
        }

        public void Off()
        {
            clock.Stop();
        }

        public void UpdateTimeDisplay()
        {
            // He just goes
        }

        public void ShowClock()
        {
            clock.Visible = true;
        }

        public void HideClock()
        {
            clock.Visible = false;   
        }
    }
}
