using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace Clocks
{
    class DigitalClock : IClock
    {
        Label digiLabel;
        System.Timers.Timer timer;

        public void On()
        {
            timer = new System.Timers.Timer(1000);
        }

        public void Off()
        {
            timer.Enabled = false;
            timer.Stop();
        }

        public void UpdateTimeDisplay()
        {
            digiLabel.Text = DateTime.Now.ToShortTimeString();
        }

        public void ShowClock()
        {
            digiLabel.Show();
        }

        public void HideClock()
        {
            digiLabel.Hide();
        }
    }
}
