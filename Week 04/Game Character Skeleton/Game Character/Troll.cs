using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Character
{
    class Troll : Character
    {
        public Troll(ListBox listBox, String myName): base(listBox, myName)
        {
            Weapon = new Bow();
        }
        public override void Speak()
        {
            base.listBox.Items.Add("Trolls don't have time to chat!");      
        }
    }
}
