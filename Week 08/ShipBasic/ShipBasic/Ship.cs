using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ShipBasic
{
    public enum EShipState { wandering, refueling };
    public class Ship
    {
        // Constants
        const int MAX_PETROL = 300;
        const int MAX_VELOCITY = 10;

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

            int velX = rGen.Next(MAX_VELOCITY);     // randomly generate our velocity 
            int velY = rGen.Next(MAX_VELOCITY);
            shipVelocity = new Point(velX,velY);
      
            petrol = rGen.Next(MAX_PETROL);    // randomly generate petrol

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
            double petrolRatio = petrol / 300.00;
            double redValue = 255 * petrolRatio;
            shipColor = Color.FromArgb((int)redValue, 0, 0);
            SolidBrush shipBrush = new SolidBrush(shipColor);

            shipCanvas.FillRectangle(shipBrush, shipLocation.X, shipLocation.Y, shipSize, shipSize);

            //SolidBrush brush = new SolidBrush(shipColor);   // Create a new brush that is the color of our ship
            // Pass the brush to shipCanvas' FillRectangle method, followed by X and Y location of ship, as well
            // as the width & height of the rectangle we wish to fill - can use shipSize as we are a square
            //shipCanvas.FillRectangle(brush, shipLocation.X, shipLocation.Y, shipSize, shipSize);

        }

        private void moveShip()
        {
            // Check if ship has enough fuel to move
            // Check that it is not going to be out of bounds
            // Readjust velocity
            if (petrol > 0 && shipState == EShipState.wandering)
            {
                // This code not quite right, ships will travel slightly too far right. Fix later?  * 1.25 = hacky way of fixing this
                if (shipLocation.X >= (boundsRectangle.Width - shipSize * 1.25) || (shipLocation.X <= 0))  // if outside bounds rectangle 
                    shipVelocity.X *= -1;   // invert our velocity - repeat below

                else if (shipLocation.Y >= (boundsRectangle.Height - shipSize) || (shipLocation.Y <= 0))
                    shipVelocity.Y *= -1;

                shipLocation.X += shipVelocity.X;   // adjust ship velocity
                shipLocation.Y += shipVelocity.Y;
                usePetrol();    // decrement our gas
            }
            else
            {
                shipState = EShipState.refueling;
            }
        }

        private void refuel()
        {
           
            if (petrol < 300)
            {
                shipState = EShipState.refueling;
                
                //shipVelocity = new Point(0, 0);
                OnOutOfFuelEvent(shipLocation);
                petrol += 10;
            }
            else // we have finished refueling
            {
                //shipVelocity = oldVelocity;
                shipState = EShipState.wandering;
                OnFullOfFuelEvent();
            }
        }

       private void usePetrol()
        {
            petrol -= 1;
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
           // Assume most things will happen in this method
           drawShip();
           if (shipState == EShipState.wandering)
               moveShip();
           else
               refuel();
       }
    }
}
