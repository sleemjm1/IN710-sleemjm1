using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgressEvent
{
    public abstract class BaseProgressObserver
    {
        protected ProgressSubject subject;

        public BaseProgressObserver(ProgressSubject subject)
        {
            this.subject = subject;

            EventHandler handler = new EventHandler(ProgressHandlerMethod);

            subject.ProgressEvent += handler;
        }

        public abstract void ProgressHandlerMethod(object sender, EventArgs e);
    }
}
