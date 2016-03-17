using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalFactory
{
    class NewZealand : Continent
    {
        public NewZealand(ListBox listBox, Random rGen, int nAnimalTypes, Graphics canvas)
            : base(listBox, rGen, nAnimalTypes, canvas)
        {
            animalFactory = new NewZealandAnimalFactory();
        }
    }
}
