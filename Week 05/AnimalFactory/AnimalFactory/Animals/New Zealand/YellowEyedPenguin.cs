using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFactory
{
    class YellowEyedPenguin : Animal
    {
        public YellowEyedPenguin()
        {
            name = "Yellow Eyed Penguin";
            family = "Carnivore";
            food = "Fish";
            image = new System.Drawing.Bitmap("yellow_eyed_penguin.jpg");
        }
    }
}
