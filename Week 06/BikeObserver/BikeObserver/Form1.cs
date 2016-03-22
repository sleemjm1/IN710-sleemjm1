using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BikeObserver
{
    public partial class Form1 : Form
    {
        SpeedMonitorSubject speedMonitorSubject;
        RPMObserver rpmObserver;
        CaloriesObserver caloriesObserver;
        KMsPerHourObserver kmsPerHourObserver;
        public Form1()
        {
            InitializeComponent();

            speedMonitorSubject = new SpeedMonitorSubject();    // must create SpeedMonitorSubject first - we need to pass 
                                                                // it in when we call an observer's constructor
            rpmObserver = new RPMObserver(lblRPM, speedMonitorSubject);
            caloriesObserver = new CaloriesObserver(lblCaloriesPerHour, speedMonitorSubject);
            kmsPerHourObserver = new KMsPerHourObserver(lblKMPerHour, speedMonitorSubject);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // When the button is clicked, we will call our TriggerNotifications method which will try and parse our string
            // and in turn, call our NotifyObservers method which will notify the observers 
            speedMonitorSubject.TriggerNotifications(tbChangeSpeed);
        }
    }
}
