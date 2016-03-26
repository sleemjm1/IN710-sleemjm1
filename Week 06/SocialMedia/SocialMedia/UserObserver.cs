using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocialMedia
{
    public class UserObserver : SMObserver
    {
        public UserObserver(ListBox listBox, SMSubject smSubject) : base(listBox, smSubject)
        {

        }

        public override void Display()
        {
            listBox.Items.Clear();
            listBox.Items.Add(currStatus);
        }
    }
}
