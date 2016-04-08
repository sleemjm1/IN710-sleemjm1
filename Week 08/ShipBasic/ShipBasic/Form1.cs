using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShipBasic
{
    public partial class Form1 : Form
    {
        // Constants
        const int SHIP_SIZE = 50;   // May need adjusting

        // Properties
        int numShips;
        int seaHeight;              // Height of the sea
   
        List<PetrolBot> botList;
        List<Ship> shipList;
        Graphics mainCanvas;
        //Graphics offScreenGraphics; // Don't need this unless flickering annoys me

        Brush seaBrush;
        Brush dockBrush;

        Random rGen = new Random();

        Rectangle boundsRectangle;
        Rectangle dockRectangle;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numShips = 5;
            botList = new List<PetrolBot>();
            shipList = new List<Ship>();
            mainCanvas = CreateGraphics();
            seaHeight = Height - 100;  // we need to give some room for our ship bots to dock
            //dockHeight = 100;
            boundsRectangle = new Rectangle(0, 0, Width, seaHeight);
            dockRectangle = new Rectangle(0, 500, Width, 100);

            seaBrush = new SolidBrush(Color.LightSeaGreen);
            dockBrush = new SolidBrush(Color.SaddleBrown);

            for (int i = 0; i < numShips; i++)
            {
                shipList.Add(new Ship(SHIP_SIZE, boundsRectangle, mainCanvas, rGen));
            }
            foreach (Ship s in shipList)
                botList.Add(new PetrolBot(s, mainCanvas, shipList.IndexOf(s), rGen));

            timer1.Start();            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            mainCanvas.FillRectangle(seaBrush, boundsRectangle);
            mainCanvas.FillRectangle(dockBrush, dockRectangle);

            foreach (Ship s in shipList)
                s.ShipCycle();
            foreach (PetrolBot pb in botList)
                pb.CycleBot();
        }
    }
}
