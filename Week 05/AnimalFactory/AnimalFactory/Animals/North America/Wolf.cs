using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFactory
{
    class Wolf : Animal
    {
        public Wolf()
        {
            name = "Wolf";
            family = "Carnivore";
            food = "Rabbits";
            image = new System.Drawing.Bitmap("wolf.jpg");
        }
    }
}
