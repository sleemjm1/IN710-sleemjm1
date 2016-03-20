using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixAndMatch
{
    public abstract class ModelMaker
    {
        public Bitmap Head;
        public Bitmap Torso;
        public Bitmap Legs;
        public string Name;

        protected ModelMaker()
        {
            
        }

        public abstract Bitmap headImage();
        public abstract Bitmap torsoImage();
        public abstract Bitmap legsImage();
    }
}
