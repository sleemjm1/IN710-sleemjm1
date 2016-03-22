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
        public Form1()
        {
            InitializeComponent();

            speedMonitorSubject = new SpeedMonitorSubject();

            rpmObserver = new RPMObserver(lblRPM, speedMonitorSubject);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            speedMonitorSubject.TriggerNotifications(tbChangeSpeed);
        }
    }
}
