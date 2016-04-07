using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressEvent
{
    public class UpDownObserver : BaseProgressObserver
    {
        // Similar to ProgressBarObserver except we also need to pass in the form so that we
        // Can call Application.DoEvents() which will update our numeric up down control
        // This is why we have another class member "form"
        NumericUpDown numericUpDown;
        Form form;
        public UpDownObserver(ProgressSubject subject, NumericUpDown numericUpDown, Form form) 
            : base(subject)
        {
            this.numericUpDown = numericUpDown;
            this.form = form;
        }

        public override void ProgressHandlerMethod(object sender, EventArgs e)
        {
            numericUpDown.Value++;
            Application.DoEvents();
        }
    }
}
