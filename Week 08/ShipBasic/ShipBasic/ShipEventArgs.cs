using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipBasic
{
    public class ShipEventArgs : EventArgs  // Descend from EventArgs
    {
        public Point ShipLocation; 

        public ShipEventArgs(Point shipLocation)
        {
            ShipLocation = shipLocation;
        }
    }
}
