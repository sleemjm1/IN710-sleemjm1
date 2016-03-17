using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFactory
{
    class Moa : Animal
    {
        public Moa()
        {
            name = "Moa";
            family = "Herbavore";
            food = "Ferns";
            image = new System.Drawing.Bitmap("moa.jpg");
        }
    }
}
