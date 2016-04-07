using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipBasic
{
    public class PetrolBot
    {
        Graphics botsCanvas;
        Color botColor;

        Ship botsShip; // Implement Ship class...

        Point botCurrentLocation;
        Point botStartingLocation;
        Point shipLocation;

        // Constructor
        public PetrolBot(Ship botsShip, Graphics botsCanvas)  
        {
            this.botsShip = botsShip;
            this.botsCanvas = botsCanvas;
        }

        // Private method(s)
        public void drawBot()
        {
            throw new NotImplementedException();
        }

        // Public method(s)
        public void FullOfFuelEventHandler()
        {
            throw new NotImplementedException();
        }

        public void OutOfFuelEventHandler()
        {
            throw new NotImplementedException();
        }
    }

}
