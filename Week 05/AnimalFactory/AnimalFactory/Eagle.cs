using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFactory
{
    class Eagle : Animal
    {
        public Eagle()
        {
            name = "Eagle";
            family = "Carnivore";
            food = "Fish";
            image = new System.Drawing.Bitmap("eagle.jpg");
        }
    }
}
