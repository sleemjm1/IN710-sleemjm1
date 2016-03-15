using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFactory
{
    class Crocodile : Animal
    {
        public Crocodile()
        {
            name = "Crocodile";
            family = "Carnivore";
            food = "Chickens";
            image = new System.Drawing.Bitmap("crocodile.jpg");
        }
    }
}
