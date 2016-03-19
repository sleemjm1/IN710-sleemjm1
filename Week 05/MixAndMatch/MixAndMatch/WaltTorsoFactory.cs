using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixAndMatch
{
    class WaltTorsoFactory : ITorsoFactory
    {
        public Body makeBody()
        {
            return new WaltBody();
        }
    }
}
