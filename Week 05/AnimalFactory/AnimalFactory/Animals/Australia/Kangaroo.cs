using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFactory
{
    class Kangaroo : Animal
    {
        public Kangaroo()
        {
            name = "Kangaroo";
            family = "Herbavore";
            food = "Grass";
            image = new System.Drawing.Bitmap("kangaroo.jpg");
        }
    }
}
