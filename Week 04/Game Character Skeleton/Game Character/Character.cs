using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Character
{
    abstract class Character
    {
        String Name;
        ListBox listBox;
        public Character(ListBox myListBox, String myName)
        {
            Name = myName;
            listBox = myListBox;
        }
    }
}
