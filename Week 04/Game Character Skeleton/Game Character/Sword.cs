using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Character
{
    public class Sword : IWeapon 
    {
        string IWeapon.UseWeapon()
        {
            return "I slice my sword";
        }
    }
}
