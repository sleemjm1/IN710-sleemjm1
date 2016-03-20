using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerMaker
{
    class MultimediaComputerFactory : IComputerFactory
    {
        public RAM makeRAM()
        {
            return new MultimediaRAM();
        }

        public CPU makeCPU()
        {
            return new MultimediaCPU();
        }

        public GraphicsCard makeGraphicsCard()
        {
            return new MultimediaGraphicsCard();
        }
        public Monitor makeMonitor()
        {
            return new MultimediaMonitor();
        }
    }
}
