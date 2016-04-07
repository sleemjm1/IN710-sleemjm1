using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipBasic
{
    public class Ship
    {
        // Fields
        int petrol;
        Random rGen;
        Graphics shipCanvas;
        Color shipColor;
        Point shipLocation;
        int shipSize;
        int shipVelocity;
        // shipState --- ENUM?????

        // Properties
        public int Petrol { get; set; }
        public Point shipLocation { get; set; }

        // Constructor
        public void Ship()  // Maybe need params not sure..
        {
            throw new NotImplementedException();
        }

        // Methods
        public void drawShip()
        {
            throw new NotImplementedException();
        }

        public void moveShip()
        {
            throw new NotImplementedException();
        }

        public void OnFullOfFuelEvent()
        {
            throw new NotImplementedException();
        }

        public void OnOutOfFuelEvent()
        {
            throw new NotImplementedException();
        }

        public void refuel()
        {
            throw new NotImplementedException();
        }

        public void ShipCycle()
        {
            throw new NotImplementedException();
        }

        public void usePetrol()
        {
            throw new NotImplementedException();
        }
        

        // Need to put events in to skeleton 


    }
}
