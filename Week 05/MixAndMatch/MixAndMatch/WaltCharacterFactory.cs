using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixAndMatch
{
    public class WaltCharacterFactory : ICharacterFactory
    {
        public Head makeHead()
        {
            return new WaltHead();
        }

        public Body makeBody()
        {
            return new WaltBody();
        }

        public Legs makeLegs()
        {
            return new WaltLegs();
        }
    }
}
