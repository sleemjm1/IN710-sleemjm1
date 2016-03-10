using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Character
{
    class King : Character
    {
        public King(ListBox listBox, String myName): base(listBox, myName)
        {
            Weapon = new Sword();
        }
        public override void Speak()
        {
            base.listBox.Items.Add("I am the most mighty of Kings!");      
        }
    }
}
