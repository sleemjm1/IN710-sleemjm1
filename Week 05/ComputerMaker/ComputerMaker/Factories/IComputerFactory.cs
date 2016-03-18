using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerMaker
{
    public interface IComputerFactory
    {
        RAM makeRAM();
        CPU makeCPU();
        GraphicsCard makeGraphicsCard();
    }
}
