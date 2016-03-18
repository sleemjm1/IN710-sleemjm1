using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerMaker
{
    // This is the base class from which all computer parts will descend -- Ram, CPU, Graphics Card, etc
    // Just have name and price for now, but could have more in the future -- Brand, Weight, Size, etc
    public abstract class Part
    {
        public string Name;
        public double Price;

        public string ToString()
        {
            return Price + "\t" + Name;
        }
    }
}
