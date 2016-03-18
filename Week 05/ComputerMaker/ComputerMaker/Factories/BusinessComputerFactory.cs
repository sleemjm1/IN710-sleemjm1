using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerMaker
{
    class BusinessComputerFactory : IComputerFactory
    {
        public RAM makeRAM()
        {
            return new BusinessRAM();
        }

        public CPU makeCPU()
        {
            return new BusinessCPU();
        }

        public GraphicsCard makeGraphicsCard()
        {
            return new BusinessGraphicsCard();
        }
    }
}
