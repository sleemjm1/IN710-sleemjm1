using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixAndMatch
{
    class Jesse : ModelMaker
    {
        public Jesse()
        {
            Name = "Jesse Pinkman";
            Head = headImage();
            Torso = torsoImage();
            Legs = legsImage();
        }
        public override Bitmap headImage()
        {
            return new System.Drawing.Bitmap("jesse_head.png");
        }

        public override Bitmap torsoImage()
        {
            return new System.Drawing.Bitmap("jesse_torso.png");
        }

        public override Bitmap legsImage()
        {
            return new System.Drawing.Bitmap("jesse_legs.png");
        }
    }
}
