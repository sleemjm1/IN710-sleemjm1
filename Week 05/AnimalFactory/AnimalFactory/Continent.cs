using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalFactory
{
    public abstract class Continent
    {
        public const int ANIMAL_SIM_COUNT = 4;

        protected ListBox displayBox;
        protected Random rGen;
        protected int nAnimalTypes;
        protected Graphics canvas;
        protected IAnimalFactory animalFactory;     // Instantiated in the children

        public Continent(ListBox listBox, Random myRGen, int myAnimalTypes, Graphics myCanvis)
        {
            displayBox = listBox;
            rGen = myRGen;
            nAnimalTypes = myAnimalTypes;
            canvas = myCanvis;
        }

        public void runSimulation()
        {
            Animal currentAnimal;

            for (int i = 0; i < ANIMAL_SIM_COUNT; i++)
            {
                // Randomly select animal type
                int animalChoice = rGen.Next(nAnimalTypes);

                // Use the factory
                currentAnimal = animalFactory.createAnimal(animalChoice);

                // Simulate the animal
                displayBox.Items.Add(currentAnimal.ToString());
                canvas.DrawImage(currentAnimal.Image, 20, 20 + (i * 120));
            }
        }
    }
}
