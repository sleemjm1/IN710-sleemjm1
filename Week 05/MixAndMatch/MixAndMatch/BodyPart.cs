using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixAndMatch
{
    public class BodyPart
    {
        protected Bitmap image;
        public string Name;
        public Bitmap Image
        {
            get { return image; } // read only
        }
    }
}
