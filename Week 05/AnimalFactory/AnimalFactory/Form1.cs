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
        public Form1()
        {
            InitializeComponent();
            mainCanvas = CreateGraphics();
        }

        private void btnNorthAmerica_Click(object sender, EventArgs e)
        {

        }
    }
}
