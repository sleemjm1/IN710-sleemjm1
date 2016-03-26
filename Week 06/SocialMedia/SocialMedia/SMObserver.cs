using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocialMedia
{
    public abstract class SMObserver : IObserver 
    {
        protected string currStatus;
        protected ListBox listBox;
        protected SMSubject smSubject;

        public SMObserver(ListBox listBox, SMSubject smSubject)
        {
            currStatus = null;

            this.listBox = listBox;
            this.smSubject = smSubject;

            smSubject.AddObserver(this);
        }

        public void Update(string statusUpdate)
        {
            currStatus = statusUpdate;
        }

        public virtual void Display()
        {
            DateTime now = DateTime.Now;
            listBox.Items.Add(now.ToString("ddd dd MMM, yyyy hh:mm")); // Sat 26 Mar, 2016 22:56
            listBox.Items.Add(currStatus);
        }             
    }
}
