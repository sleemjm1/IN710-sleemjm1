using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFactory
{
    class Koala : Animal
    {
        public Koala()
        {
            name = "Koala";
            family = "Herbavore";
            food = "Leaves";
            image = new System.Drawing.Bitmap("koala.jpg");
        }
    }
}
