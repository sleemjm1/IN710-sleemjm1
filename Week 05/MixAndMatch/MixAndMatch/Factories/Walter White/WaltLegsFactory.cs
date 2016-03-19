using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixAndMatch
{
    class WaltLegsFactory : ILegsFactory
    {
        public Legs makeLegs()
        {
            return new WaltLegs();
        }
    }
}
