using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressEvent
{
    public partial class Form1 : Form
    {
        ProgressSubject subject;
        ProgressBarObserver progressBarObserver;
        TrackBarObserver trackBarObserver;
        UpDownObserver upDownObserver;
        public Form1()
        {
            InitializeComponent();
            subject = new ProgressSubject();
            progressBarObserver = new ProgressBarObserver(subject, progressBar1);
            trackBarObserver = new TrackBarObserver(subject, trackBar1);
            upDownObserver = new UpDownObserver(subject, numericUpDown1, this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            setUpControls();
            subject.SlowMethod();
        }

        private void setUpControls()
        {
            progressBar1.Maximum = 10;
            progressBar1.Value = 0;
            trackBar1.Maximum = 10;
            trackBar1.Value = 0;
            numericUpDown1.Maximum = 10;
            numericUpDown1.Value = 0;
        }
    }
}
