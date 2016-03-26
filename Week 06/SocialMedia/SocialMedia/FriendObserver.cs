using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocialMedia
{
    public class FriendObserver : SMObserver
    {
        public FriendObserver(ListBox listBox, SMSubject smSubject) : base(listBox, smSubject)
        {

        }
    }
}
