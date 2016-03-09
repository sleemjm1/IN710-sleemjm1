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
        public Troll(ListBox listBox, String Name)
        {
            base.Name = Name;
            base.listBox = listBox;
        }
        public override void Speak()
        {
            base.listBox.Items.Add(Name);
            base.listBox.Items.Add("I am a Knight");
        }
    }
}