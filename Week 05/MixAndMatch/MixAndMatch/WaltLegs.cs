using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixAndMatch
{
    public class WaltLegs : Legs
    {
        public WaltLegs()
        {
            Name = "Walter White";
            image = new System.Drawing.Bitmap("walt_legs.png");
        }
    }
}
