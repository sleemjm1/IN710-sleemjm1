using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clocks
{
    class AnalogueClock : IClock
    {
        AnalogueClock clock;
        public void On()
        {
            ShowClock();
            clock.On();
        }

        public void Off()
        {
            HideClock();
            clock.Off();
        }

        public void UpdateTimeDisplay()
        {
            clock.UpdateTimeDisplay();
        }

        public void ShowClock()
        {
            clock.ShowClock();
        }

        public void HideClock()
        {
            clock.HideClock();
        }
    }
}
