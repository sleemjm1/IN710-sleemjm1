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
        protected ListBox listBox;
        protected String Name;
        protected IWeapon Weapon;

        protected Character(ListBox myListBox, String myName)
        {
            Name = myName;
            listBox = myListBox;
        }

        public abstract void Speak();
        
        public void SayName()
        {
            listBox.Items.Add("My name is " + Name);
            listBox.Items.Add(Weapon.UseWeapon());
        }
    }

    
}
