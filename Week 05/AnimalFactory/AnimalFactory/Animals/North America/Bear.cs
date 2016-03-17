using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFactory 
{
    class Bear : Animal
    {
        public Bear()
        {
            name = "Bear";
            family = "Carnivore";
            food = "Fish";
            image = new System.Drawing.Bitmap("bear.jpg");
        }
    }
}
