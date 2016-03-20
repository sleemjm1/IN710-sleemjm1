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
            Monitor currentMonitor = computerMaker.makeMonitor();

            double totalPrice = currentCPU.Price + currentRAM.Price + currentGraphicsCard.Price + currentMonitor.Price;

            listBox.Items.Clear();
            listBox.Items.Add("Part\tPrice\tComponent");
            listBox.Items.Add("------------------------------------------------------------------------------------");

            listBox.Items.Add("CPU:\t" + currentCPU.ToString());
            listBox.Items.Add("RAM:\t" + currentRAM.ToString());
            listBox.Items.Add("Graphics:\t" + currentGraphicsCard.ToString());
            listBox.Items.Add("Monitor:\t" + currentMonitor.ToString());

            listBox.Items.Add("------------------------------------------------------------------------------------");
            listBox.Items.Add("Total Price: $" + totalPrice.ToString());
        }
    }
}
