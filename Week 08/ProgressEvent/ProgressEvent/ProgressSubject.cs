using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgressEvent
{
    // Our subject which all observers will subscribe to
    public class ProgressSubject
    {
        // we can just use EventHandler cause no need to make our own delegate
        public event EventHandler ProgressEvent; 
        // SlowMethod will be called in the form
        public void SlowMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                System.Threading.Thread.Sleep(500); // Sleep 0.5 seconds
                OnUpDateEvent();                    // call OnUpdateEvent() below
            }
        }

        private void OnUpDateEvent()
        {
            EventArgs ea = new EventArgs();
            if (ProgressEvent != null)
                ProgressEvent(this, ea);
        }
    }
}
