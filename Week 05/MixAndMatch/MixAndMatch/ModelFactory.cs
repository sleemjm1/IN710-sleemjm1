using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixAndMatch
{
    class ModelFactory 
    {
        public ModelMaker createModel(string Name)
        {
            ModelMaker newModel = null;

            switch (Name)
            {
                case "Walter White":
                    newModel = new Walt();
                    break;
                case "Mike Ehrmantraut":
                    newModel = new Mike();
                    break;
                case "Gustavo Fring":
                    newModel = new Gus();
                    break;
                case "Flynn White":
                    newModel = new Flynn();
                    break;
                case "Jesse Pinkman":
                    newModel = new Jesse();
                    break;
                case "Saul Goodman":
                    newModel = new Saul();
                    break;
            }
            return newModel;
        }
    }
}
