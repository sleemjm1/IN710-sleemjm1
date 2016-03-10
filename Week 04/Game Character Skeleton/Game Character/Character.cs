using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Character
{
    abstract class Character
    // Our parent class from which Characters will descend from (Queen, Troll, Knight, King)
    // Will control all of the things which Characters MUST have -- Constructor, SayName, UseWeapon...
    {
        protected ListBox listBox;
        public String Name;
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
        }

        public void Attack()
        {
            listBox.Items.Add(Weapon.UseWeapon());
            listBox.Items.Add("");
        }

        public void ChangeWeapon(IWeapon newWeapon)
        {
            Weapon = newWeapon;
        }

    }

    
}
