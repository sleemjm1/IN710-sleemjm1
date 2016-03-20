using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerMaker
{
    public partial class Form1 : Form
    {
        IComputerFactory currentComputerFactory;
        public Form1()
        {
            InitializeComponent();
            rbLaptop.Checked = true;    // Checked so that we match up with if statement below
        }

        private void btnPrintSpec_Click(object sender, EventArgs e)
        {
            if (rbGaming.Checked)
                currentComputerFactory = new GamingComputerFactory();
            else if (rbBusiness.Checked)
                currentComputerFactory = new BusinessComputerFactory();
            else if (rbMultimedia.Checked)
                currentComputerFactory = new MultimediaComputerFactory();
            else
                currentComputerFactory = new LaptopComputerFactory();

            MachineSpecPrinter currentSpecPrinter = new MachineSpecPrinter(currentComputerFactory, listDisplay);
            currentSpecPrinter.printSpec();
            
        }
    }
}
