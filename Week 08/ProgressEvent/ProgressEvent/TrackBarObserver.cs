using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressEvent
{
    public class TrackBarObserver : BaseProgressObserver
    {
        TrackBar trackBar;
        // Almost exactly the same as ProgressBarObserver except with a track bar instead
        public TrackBarObserver(ProgressSubject subject, TrackBar trackBar) : base(subject)
        {
            this.trackBar = trackBar;
        }

        public override void ProgressHandlerMethod(object sender, EventArgs e)
        {
            trackBar.Value++;
        }
    }
}
