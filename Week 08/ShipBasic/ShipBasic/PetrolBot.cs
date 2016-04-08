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
        const int BOT_SIZE = 20;

        Graphics botsCanvas;
        Color botColor;

        Ship botsShip; 

        Point botCurrentLocation;
        Point botStartingLocation;
        Point shipLocation;

        // Constructor
        public PetrolBot(Ship botsShip, Graphics botsCanvas, int xPos)  
        {
            this.botsShip = botsShip;
            this.botsCanvas = botsCanvas;
            shipLocation = botsShip.ShipLocation;
            xPos = xPos * 30;
            botStartingLocation = new Point(xPos, 520);
            botCurrentLocation = botStartingLocation;

            Ship.OutOfFuelEventHandler outOfFuelHandler = new Ship.OutOfFuelEventHandler(OutOfFuelEventHandler);
            this.botsShip.OutOfFuelEvent += outOfFuelHandler;

            EventHandler fullOfFuelHandler = new EventHandler(FullOfFuelEventHandler);
            this.botsShip.FullOfFuelEvent += fullOfFuelHandler;
        }

        // Private method(s)
        public void drawBot()
        {
            botColor = Color.DarkOrange;
            Brush botBrush = new SolidBrush(botColor);
            //botStartingLocation = new Point(xPos, 520);
            botsCanvas.FillEllipse(botBrush, botCurrentLocation.X, botCurrentLocation.Y, BOT_SIZE, BOT_SIZE);
        }

        public void CycleBot()
        {
            drawBot();
        }

        // Public method(s)
        public void FullOfFuelEventHandler(object o, EventArgs e)
        {
            botCurrentLocation = botStartingLocation;
        }

        public void OutOfFuelEventHandler(object o, ShipEventArgs e)
        {
            botCurrentLocation = e.ShipLocation;
            //drawBot();
        }
    }

}
