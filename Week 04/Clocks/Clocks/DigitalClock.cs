using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clocks
{
    class DigitalClock : IClock
    {
        Label label;
        Timer timer;

        public DigitalClock(Label digiLabel, Timer digiTimer)
        {
            label = digiLabel;
            timer = digiTimer;
        }

        public void On()
        {
            timer.Enabled = true;
            timer.Start();           
        }

        public void Off()
        {
            timer.Enabled = false;
            timer.Stop();
        }

        public void UpdateTimeDisplay()
        {
            label.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        public void ShowClock()
        {
            label.Show();
        }

        public void HideClock()
        {
            label.Hide();
        }
    }
}
