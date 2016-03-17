using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFactory
{
    class RoyalAlbatross : Animal
    {
        public RoyalAlbatross()
        {
            name = "Royal Albatross";
            family = "Carnivore";
            food = "Squid";
            image = new System.Drawing.Bitmap("royal_albatross.jpg");
        }
    }
}
