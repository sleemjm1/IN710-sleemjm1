using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Character
{
    class Knight : Character
    {
        public Knight(ListBox listBox, String myName): base(listBox, myName)
        {
            Weapon = new Sword();
        }
        public override void Speak()
        {
            base.listBox.Items.Add("I am a Knight");      
        }
    }
}
