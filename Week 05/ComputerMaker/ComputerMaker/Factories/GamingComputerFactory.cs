using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerMaker
{
    class GamingComputerFactory : IComputerFactory
    {
        public RAM makeRAM()
        {
            return new GamingRAM();
        }

        public CPU makeCPU()
        {
            return new GamingCPU();
        }

        public GraphicsCard makeGraphicsCard()
        {
            return new GamingGraphicsCard();
        }
    }
}
