using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerMaker
{
    class MachineSpecPrinter
    {
        private IComputerFactory computerMaker;
        private ListBox listBox;

        public MachineSpecPrinter(IComputerFactory computerMaker, ListBox listBox)
        {
            this.computerMaker = computerMaker;
            this.listBox = listBox;
        }

        public void printSpec()
        {
            CPU currentCPU = computerMaker.makeCPU();
            RAM currentRAM = computerMaker.makeRAM();
            GraphicsCard currentGraphicsCard = computerMaker.makeGraphicsCard();

            double totalPrice = currentCPU.Price + currentRAM.Price + currentGraphicsCard.Price;

            listBox.Items.Clear();
            listBox.Items.Add("Price\tComponent");
            listBox.Items.Add("----------------------------------");

            listBox.Items.Add(currentCPU.ToString());
            listBox.Items.Add(currentRAM.ToString());
            listBox.Items.Add(currentGraphicsCard.ToString());

            listBox.Items.Add("----------------------------------");
            listBox.Items.Add("Total Price: $" + totalPrice.ToString());
        }
    }
}
