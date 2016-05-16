using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace metronome
{
    public class MetronomeObserver
    {
        protected Metronome metronome;

        public MetronomeObserver(Metronome metronome)
        {
            this.metronome = metronome;
            metronome.metronomeEvent += new Metronome.metronomeEventHandler(onMetronomeEvent);
        }

        public virtual void onMetronomeEvent(object sender, metronomeEventArgs e)
        {
            MessageBox.Show("My metronome clicked");
        }

    }

    //----------------------------------------------------------------------------
    //----------------------------------------------------------------------------
    public class Beeper : MetronomeObserver
    {
        private String soundFileName;
        private SoundPlayer soundPlayer;

        public Beeper(Metronome metronome, String soundFileName)
            : base(metronome)
        {
            this.soundFileName = soundFileName;
            soundPlayer = new SoundPlayer();
            soundPlayer.SoundLocation = soundFileName;
        }


        public override void onMetronomeEvent(object sender, metronomeEventArgs e)
        {
            soundPlayer.Play();
        }

    } // end TBeeper
    //----------------------------------------------------------------------------
    //----------------------------------------------------------------------------
    public class Counter : MetronomeObserver
    {
        private NumericUpDown spinBox;
        delegate void updateSpinBox();  // delegate to update spin box

        public Counter(Metronome metronome, NumericUpDown spinBox)
            : base(metronome)
        {
            this.spinBox = spinBox;
        }

        void incrementSpinBox()         // method which matches our delegate method signature
        {
            spinBox.Value++;
        }

        public override void onMetronomeEvent(object sender, metronomeEventArgs e)
        {
            if (spinBox.InvokeRequired) // if invoke required
            {
                updateSpinBox spinDelegate = new updateSpinBox(incrementSpinBox);
                spinBox.Invoke(spinDelegate);
                // we will use invoke to ensure the code we are calling will run on the thread
                // that the control lives on so that we are "thread safe"
            }
            else    // otherwise we are on the thread the control lives on so we can increment
                incrementSpinBox();     // from this thread
        }
    } // end TCounter

    //----------------------------------------------------------------------------
    //----------------------------------------------------------------------------
    public class TimeDisplay : MetronomeObserver
    {
        private ListBox listBox;
        delegate void updateListBox(DateTime dt);
        public TimeDisplay(Metronome metronome, ListBox listBox)
            : base(metronome)
        {
            this.listBox = listBox;
        }

        void changeDateTime(DateTime dt)
        {
            listBox.Items.Add(dt.ToString());
        }

        public override void onMetronomeEvent(object sender, metronomeEventArgs e)
        {
            //DateTime currDateTime = e.currentTime;
            //listBox.Items.Add(currDateTime.ToString());
            if (listBox.InvokeRequired)
            {
                updateListBox listDelegate = new updateListBox(changeDateTime);
                listBox.Invoke(listDelegate, e.currentTime);
            }
            else
                changeDateTime(e.currentTime);
        }
    }






            
}
