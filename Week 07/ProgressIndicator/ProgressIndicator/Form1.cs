using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressIndicator
{
    public partial class Form1 : Form
    {
        FeedbackDelegate feedbackDelegate;  // make this guy available to everybody
        public Form1()
        {
            InitializeComponent();
            setUpControls();
            rbNumericSpin.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            setUpControls();            // reset
            if (rbTrackBar.Checked)
                feedbackDelegate = new FeedbackDelegate(updateTrackBar);
            else if (rbProgressBar.Checked)
                feedbackDelegate = new FeedbackDelegate(updateProgressBar);
            else
                feedbackDelegate = new FeedbackDelegate(updateSpinBox);
           
            slowMethod(feedbackDelegate);   // call our slow method, who accepts a FeedBackDelegate
        }

        public delegate void FeedbackDelegate();

        public void slowMethod(FeedbackDelegate feedbackDelegate)
        {
            // use sleep
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(1000);
                feedbackDelegate();
            }
        }
        
        // below methods will be used with our delegate - signatures match
        public void updateSpinBox()
        {
            numericUpDown1.Value++;         
            Application.DoEvents();     // have to call this or control won't update
        }

        public void updateProgressBar()
        {
            progressBar1.Value++;
        }

        public void updateTrackBar()
        {
            trackBar1.Value++;
        }


        // method to set up controls
        public void setUpControls()
        {
            trackBar1.Maximum = 10;
            trackBar1.Value = 0;
            numericUpDown1.Value = 0;
            numericUpDown1.Maximum = 10;
            progressBar1.Value = 0;
            progressBar1.Maximum = 10;
        }

    }
}
