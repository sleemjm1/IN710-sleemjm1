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
