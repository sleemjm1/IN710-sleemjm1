using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFactory
{
    class Wombat : Animal
    {
        public Wombat()
        {
            name = "Wombat";
            family = "Herbavore";
            food = "Grass";
            image = new System.Drawing.Bitmap("wombat.jpg");
        }
    }
}
