using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipBasic
{
    public enum EShipState { wandering, refueling };
    public class Ship
    {
        // Fields
        int petrol;
        Graphics shipCanvas;
        Color shipColor;
        Point shipLocation;
        EShipState shipState;
        int shipSize;
        Point shipVelocity;
        Rectangle boundsRectangle;

        // Properties
        public int Petrol { get; set; }
        public Point ShipLocation { get; set; }

        // Events & delegates
        public delegate void OutOfFuelEventHandler(object o, ShipEventArgs sea);
        public event OutOfFuelEventHandler OutOfFuelEvent;  // need to use our custom delegate cause passing data
        public event EventHandler FullOfFuelEvent;          // can just use EventHandler

        // Constructor
        public Ship(int shipSize, Rectangle boundsRectangle, Graphics shipCanvas, Random rGen)  
        {
            this.shipSize = shipSize;
            this.boundsRectangle = boundsRectangle;
            this.shipCanvas = shipCanvas;
            shipColor = Color.Red;  // could perhaps change this to be passed in -- leave for now
            shipVelocity = new Point(5,5);

            // We will randomly generate the ship's starting location

            int x = rGen.Next(boundsRectangle.Width - shipSize);    // x needs to be within the width of our bounds rectangle
            int y = rGen.Next(boundsRectangle.Height - shipSize);   // and y needs to be within the height of it. We will 
                                                                    // then minus shipSize so that it cannot overlap bounds
            // Then, we generate a point based on our two random numbers
            shipLocation = new Point(x, y);
        }

        // private methods
        private void drawShip()
        {
            SolidBrush brush = new SolidBrush(shipColor);   // Create a new brush that is the color of our ship
            // Pass the brush to shipCanvas' FillRectangle method, followed by X and Y location of ship, as well
            // as the width & height of the rectangle we wish to fill - can use shipSize as we are a square
            shipCanvas.FillRectangle(brush, shipLocation.X, shipLocation.Y, shipSize, shipSize);
        }

        private void moveShip()
        {
            // Check if ship has enough fuel to move
            // Check that it is not going to be out of bounds
            // Readjust velocity 
            if (shipLocation.X >= (boundsRectangle.Width - shipSize) || (shipLocation.X <= 0))
            {
                shipVelocity.X *= -1;
            }
            else if (shipLocation.Y >= (boundsRectangle.Height - shipSize) || (shipLocation.Y <= 0))
            {
                shipVelocity.Y *= -1;
            }

            shipLocation.X += shipVelocity.X;
            shipLocation.Y += shipVelocity.Y;
        }

        private void refuel()
        {
            throw new NotImplementedException();
        }

       private void usePetrol()
        {
            throw new NotImplementedException();
        }

        // Public methods
       public void OnFullOfFuelEvent()
       {
           EventArgs e = new EventArgs();
           if (FullOfFuelEvent != null)
               FullOfFuelEvent(this, e);
       }

       public void OnOutOfFuelEvent(Point currShipLocation)
       {
           ShipEventArgs sea = new ShipEventArgs(currShipLocation);
           if (OutOfFuelEvent != null)
               OutOfFuelEvent(this, sea);
       }

       public void ShipCycle()
       {
           //throw new NotImplementedException();
           // Assume most things will happen in this method
           drawShip();
           moveShip();
       }
    }
}
