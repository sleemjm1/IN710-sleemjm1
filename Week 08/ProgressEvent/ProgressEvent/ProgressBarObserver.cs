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
        public ProgressBarObserver(ProgressSubject subject, ProgressBar progressBar) : base(subject)
        {
            this.progressBar = progressBar;
        }

        public override void ProgressHandlerMethod(object sender, EventArgs e)
        {
            progressBar.Value++;
        }
    }
}
