using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GardenReporter2016
{
    public class GardenManager
    {
        public List<Garden> gardenList;

        public GardenManager()
        {
            gardenList = new List<Garden>();
        }
        public void AddGarden(Garden garden)
        {
            gardenList.Add(garden);
        }

        public void ProcessGardens()
        {
            throw new NotImplementedException;
        }
    }
}
