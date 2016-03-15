using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFactory
{
    class Bison : Animal
    {
        public Bison()
        {
            name = "Bison";
            family = "Herbavore";
            food = "Grass";
            image = new System.Drawing.Bitmap("bison.jpg");
        }
    }
}
