using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControlHandlers
{
    public partial class Form1 : Form
    {
        CustomObserver observer1;
        CustomObserver observer2;
        public Form1()
        {
            InitializeComponent();
            Random r = new Random();
            observer1 = new CustomObserver(r.Next(0, 100), button1);
            observer2 = new CustomObserver(r.Next(0, 100), button1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is the button on the form event");
        }
    }
}
