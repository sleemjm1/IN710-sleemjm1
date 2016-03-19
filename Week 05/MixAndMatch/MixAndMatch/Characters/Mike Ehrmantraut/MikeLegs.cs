using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixAndMatch
{
    class MikeLegs : Legs
    {
        public MikeLegs()
        {
            Name = "Mike Ehrmantraut";
            image = new System.Drawing.Bitmap("mike_legs.png");
        }
    }
}
