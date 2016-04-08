using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipBasic
{
    public enum EPetrolBotState { wandering, refuelling, docked };
    public class PetrolBot
    {
        const int BOT_SIZE = 20;

        Graphics botsCanvas;
        Color botColor;

        Ship botsShip; 

        public Point botCurrentLocation;
        Point botStartingLocation;
        Point shipLocation;

        public EPetrolBotState botState;

        // Constructor
        public PetrolBot(Ship botsShip, Graphics botsCanvas, int xPos, Random rGen)  
        {
            this.botsShip = botsShip;
            this.botsCanvas = botsCanvas;
            shipLocation = botsShip.ShipLocation;
            botState = EPetrolBotState.docked;
            xPos = xPos * 30;
            botStartingLocation = new Point(xPos, 520);
            botCurrentLocation = botStartingLocation;
           
            int r = rGen.Next(255);
            int g = rGen.Next(255);
            int b = rGen.Next(255);
            botColor = Color.FromArgb(r, g, b);

            Ship.OutOfFuelEventHandler outOfFuelHandler = new Ship.OutOfFuelEventHandler(OutOfFuelEventHandler);
            this.botsShip.OutOfFuelEvent += outOfFuelHandler;

            EventHandler fullOfFuelHandler = new EventHandler(FullOfFuelEventHandler);
            this.botsShip.FullOfFuelEvent += fullOfFuelHandler;
        }

        // Private method(s)
        private void drawBot()
        {           
            Brush botBrush = new SolidBrush(botColor);
            //botStartingLocation = new Point(xPos, 520);
            botsCanvas.FillEllipse(botBrush, botCurrentLocation.X, botCurrentLocation.Y, BOT_SIZE, BOT_SIZE);
        }

        private double calculateAngle()
        {
            // Use some maths to figure out where our ship is
            int distX = shipLocation.X - botStartingLocation.X;
            int distY = shipLocation.Y - botStartingLocation.Y;

            double angleRadians = Math.Atan2(distY + 25, distX + 25);
            return angleRadians;
            //int angleDegrees = (int)Math.toDegrees(angleRadians);
        }

        private void updateCurrentLocation()
        {
            double angleToShip = calculateAngle();

            double xAxis = 3 * Math.Cos(angleToShip);
            double yAxis = 3 * Math.Sin(angleToShip);

            botCurrentLocation.X += (int)xAxis;
            botCurrentLocation.Y += (int)yAxis;
        }

         // Public method(s)
        public void CycleBot()
        {
            drawBot();
        }  
               
        public void FullOfFuelEventHandler(object o, EventArgs e)
        {
            botCurrentLocation = botStartingLocation;
        }

        public void OutOfFuelEventHandler(object o, ShipEventArgs e)
        {
            shipLocation = e.ShipLocation;
            updateCurrentLocation();
            //botCurrentLocation = e.ShipLocation;
        }
    }

}
