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
        const int NUM_NA_ANIMALS = 4;       // number of American animal classes we have
        const int NUM_AUS_ANIMALS = 4;      // number of Australian animal classes we have
        const int NUM_NZ_ANIMALS = 4;       // number of New Zeland animal classes we have
        // These are all the same at the moment, but would change if we had a different number of animals in each class
        public Form1()
        {
            InitializeComponent();
            mainCanvas = CreateGraphics();
            rGen = new Random();
        }

        public void ClearControls() // used to tidy up form controls
        {
            mainCanvas.Clear(SystemColors.Control);
            listDisplay.Items.Clear();
        }

        private void btnNorthAmerica_Click(object sender, EventArgs e)
        {
            ClearControls();
            mainContinent = new NorthAmerica(listDisplay, rGen, NUM_NA_ANIMALS, mainCanvas);
            mainContinent.runSimulation();
        }

        private void btnAustralia_Click(object sender, EventArgs e)
        {
            ClearControls();
            mainContinent = new Australia(listDisplay, rGen, NUM_AUS_ANIMALS, mainCanvas);
            mainContinent.runSimulation();
        }

        private void btnNewZealand_Click(object sender, EventArgs e)
        {
            ClearControls();
            mainContinent = new NewZealand(listDisplay, rGen, NUM_NZ_ANIMALS, mainCanvas);
            mainContinent.runSimulation();
        }
    }
}
