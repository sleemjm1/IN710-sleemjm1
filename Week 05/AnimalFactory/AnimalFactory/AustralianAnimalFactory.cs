﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFactory
{
    class AustralianAnimalFactory : IAnimalFactory
    {
        public Animal createAnimal(int animalCode)
        {
            Animal newAnimal = null;

            switch (animalCode)
            {
                case 0:
                    newAnimal = new Koala();
                    break;
                case 1:
                    newAnimal = new Crocodile();
                    break;
                case 2:
                    newAnimal = new Kangaroo();
                    break;
            }
            return newAnimal;
        }
    }
}
