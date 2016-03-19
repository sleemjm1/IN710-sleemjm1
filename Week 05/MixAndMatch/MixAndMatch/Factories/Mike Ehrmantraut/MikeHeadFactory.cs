using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixAndMatch
{
    class MikeHeadFactory : IHeadFactory
    {
        public Head makeHead()
        {
            return new MikeHead();
        }
    }
}
