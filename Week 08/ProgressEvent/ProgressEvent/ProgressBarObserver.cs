using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressEvent
{
    public class ProgressBarObserver : BaseProgressObserver
    {
        ProgressBar progressBar;
        // Send subject to base class, then assign the passed in progress bar to our class member progress bar
        public ProgressBarObserver(ProgressSubject subject, ProgressBar progressBar) : base(subject)
        {
            this.progressBar = progressBar;
        }

        // Overridden method which will update our control
        public override void ProgressHandlerMethod(object sender, EventArgs e)
        {
            progressBar.Value++;
        }
    }
}
