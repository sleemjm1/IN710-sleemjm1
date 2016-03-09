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
        IWeapon Weapon;
        public abstract void Speak();
        
        
        
    }

    
}
