using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocialMedia
{
    // This class is probably not necessary, as we are just calling base constructor. However, 
    // if we wanted to add more functionality to friends, we could add it here...
    public class FriendObserver : SMObserver
    {
        public FriendObserver(ListBox listBox, SMSubject smSubject) : base(listBox, smSubject)
        {

        }
    }
}
