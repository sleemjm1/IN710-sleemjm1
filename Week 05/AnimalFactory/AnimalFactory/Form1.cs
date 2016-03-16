using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalFactory
{
    public partial class Form1 : Form
    {
        Graphics mainCanvas;
        Continent mainContinent;
        Random rGen;
        public Form1()
        {
            InitializeComponent();
            mainCanvas = CreateGraphics();
            rGen = new Random();
        }

        private void btnNorthAmerica_Click(object sender, EventArgs e)
        {
            mainCanvas.Clear(Color.Gray);
            mainContinent = new NorthAmerica(listDisplay, rGen, 3, mainCanvas);
            mainContinent.runSimulation();
        }
    }
}
