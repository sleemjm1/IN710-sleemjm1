using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Character
{
    class Queen : Character
    {
        // We have descended from our parent abstract class, Character.
        // We use : base to execute the base class' (Character's) code, and give her a weapon.
        public Queen(ListBox listBox, String myName): base(listBox, myName)
        {
            Weapon = new Bow();
        }
        public override void Speak()
        {
            base.listBox.Items.Add("I am a Queen");      
        }
    }
}
