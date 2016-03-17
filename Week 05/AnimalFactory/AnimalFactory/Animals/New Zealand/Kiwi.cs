using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFactory
{
    class Kiwi : Animal
    {
        public Kiwi()
        {
            name = "Kiwi";
            family = "Carnivore";
            food = "Worms";
            image = new System.Drawing.Bitmap("kiwi.jpg");
        }
    }
}
