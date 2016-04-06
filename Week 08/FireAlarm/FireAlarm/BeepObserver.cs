using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FireAlarm
{
    public class BeepObserver : BaseFireAlarmObserver
    {
        [DllImport("kernel32.dll")]
        public static extern bool Beep(int freq, int duration);

        public BeepObserver(FireAlarmSubject subject) : base(subject)
        {

        }
        public override void FireAlarmHandlerMethod(object fireSubject, FireAlarmEventArgs fe)
        {
            int duration = 1000;
            int frequency = 0;
            switch (fe.FireCategory)
            {
                 case EFireCategory.MINOR:
                    frequency = 500;
                    break;
                case EFireCategory.SERIOUS:
                    frequency = 800;
                    break;
                case EFireCategory.INFERNO:
                    frequency = 1000;
                    break;    
            }
            Beep(frequency, duration);
        }
    }
}
