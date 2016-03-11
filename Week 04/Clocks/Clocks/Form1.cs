using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AnalogClockControl;

namespace Clocks
{
    public partial class Form1 : Form
    {
        IClock mainClock;
        public Form1()
        {
            InitializeComponent();

            mainClock = new AnalogClock(analogClock1);
            mainClock.Off();

            lblDigital.Hide();

            rbAnalogue.Checked = true;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            mainClock.On();
            timer1.Start();
        }

        private void rbDigital_CheckedChanged(object sender, EventArgs e) // on click
        {
            mainClock.HideClock();
            mainClock = new DigitalClock(lblDigital, timer1);
            mainClock.UpdateTimeDisplay();
            mainClock.ShowClock();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            mainClock.UpdateTimeDisplay();
        }

        private void rbAnalogue_CheckedChanged(object sender, EventArgs e)
        {
            mainClock.HideClock();
            mainClock = new AnalogClock(analogClock1);
            mainClock.ShowClock();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            mainClock.Off();
            timer1.Stop();
        }
    }
}
