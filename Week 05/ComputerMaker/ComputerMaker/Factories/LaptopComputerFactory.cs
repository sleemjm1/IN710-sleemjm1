using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerMaker
{
    class LaptopComputerFactory : IComputerFactory
    {
        public RAM makeRAM()
        {
            return new LaptopRAM();
        }

        public CPU makeCPU()
        {
            return new LaptopCPU();
        }

        public GraphicsCard makeGraphicsCard()
        {
            return new LaptopGraphicsCard();
        }

        public Monitor makeMonitor()
        {
            return new LaptopMonitor();
        }
    }
}
