using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixAndMatch
{
    class Flynn : ModelMaker
    {
        public Flynn()
        {
            Name = "Flynn White";
            Head = headImage();
            Torso = torsoImage();
            Legs = legsImage();
        }

        public override Bitmap headImage()
        {
            return new System.Drawing.Bitmap("flynn_head.png");
        }

        public override Bitmap torsoImage()
        {
            return new System.Drawing.Bitmap("flynn_torso.png");
        }

        public override Bitmap legsImage()
        {
            return new System.Drawing.Bitmap("flynn_legs.png");
        }
    }
}
