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
        Graphics offScreenGraphics; // Don't need this unless flickering annoys me

        Brush bgBrush;
        Brush fgBrush;

        Random rGen = new Random();

        public Form1()
        {
            InitializeComponent();

            numShips = 5;
            botList = new List<PetrolBot>();
            shipList = new List<Ship>();
            mainCanvas = CreateGraphics();
            seaHeight = Height - 100;  // we need to give some room for our ship bots to dock
            Rectangle boundsRectangle = new Rectangle(0, 0, Width, seaHeight);

            bgBrush = new SolidBrush(Color.Black);
           

            for (int i = 0; i < numShips; i++)
            {
                shipList.Add(new Ship(SHIP_SIZE, boundsRectangle, mainCanvas, rGen));
                // add bots here too
            }
            
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            mainCanvas.FillRectangle(bgBrush, 0, 0, Width, seaHeight);
            foreach (Ship s in shipList)
            {
                s.ShipCycle();
            }
        }
    }
}
