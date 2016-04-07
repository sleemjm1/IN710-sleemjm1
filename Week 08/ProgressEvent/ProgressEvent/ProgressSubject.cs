using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgressEvent
{
    public class ProgressSubject
    {
        public event EventHandler ProgressEvent;    // we can just use EventHandler cause no need to make our own delegate
        public void SlowMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                System.Threading.Thread.Sleep(500);
                OnUpDateEvent();
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
