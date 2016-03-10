using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clocks
{
    public partial class Form1 : Form
    {
        IClock analogueClock
        public Form1()
        {
            InitializeComponent();

            analogueClock = new AnalogueClock();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (rbAnalogue.Checked)
            {
                
            }
        }
    }
}
