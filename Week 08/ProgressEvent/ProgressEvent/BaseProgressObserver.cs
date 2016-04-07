using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgressEvent
{
    // Our base progress observer, which all control observers will descend from
    public abstract class BaseProgressObserver
    {
        protected ProgressSubject subject;  // All observers will have a subject

        public BaseProgressObserver(ProgressSubject subject)    // Subject is handed in via constructor
        {
            this.subject = subject;                             // Assign passed in subject to class member

            // We can just use generic EventHandler because we don't need to pass any data
            EventHandler handler = new EventHandler(ProgressHandlerMethod); 

            subject.ProgressEvent += handler;
        }

        // Abstract method that will be polymorphic for all of our children
        public abstract void ProgressHandlerMethod(object sender, EventArgs e); 
    }
}
