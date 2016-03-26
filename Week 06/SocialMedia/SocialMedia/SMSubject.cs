using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia
{
    public class SMSubject : ISubject
    {
        private List<IObserver> observerList;
        private string currStatus;
        public void AddObserver(IObserver o)
        {
            observerList.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            observerList.Remove(o);
        }

        public void NotifyObservers()
        {
            foreach (SMObserver currObserver in observerList)
            {
                currObserver.Update(currStatus);
                currObserver.Display();
            }
        }

        public void TriggerNotifications(System.Windows.Forms.TextBox tbMessage)
        {
            currStatus = tbMessage.Text;
            NotifyObservers();
        }

        public SMSubject()
        {
            observerList = new List<IObserver>();
        }
    }
}
