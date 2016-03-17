using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFactory
{
    class NewZealandAnimalFactory : IAnimalFactory
    {
        public Animal createAnimal(int animalCode)
        {
            Animal newAnimal = null;

            switch (animalCode)
            {
                case 0:
                    newAnimal = new Kiwi();
                    break;
                case 1:
                    newAnimal = new YellowEyedPenguin();
                    break;
                case 2:
                    newAnimal = new RoyalAlbatross();
                    break;
                case 3:
                    newAnimal = new Moa();
                    break;
            }
            return newAnimal;
        }
    }
}
