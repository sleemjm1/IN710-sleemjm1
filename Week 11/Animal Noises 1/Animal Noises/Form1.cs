using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Animal_Noises
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Animal mainAnimal;
        private Thread thread;

        private void Form1_Load(object sender, EventArgs e)
        {
            mainAnimal = new Animal();
            ThreadStart startDelegate = new ThreadStart(mainAnimal.speak);
            thread = new Thread(startDelegate);
        }

        private void btnSpeak_Click(object sender, EventArgs e)
        {

            thread.Start();         // Start thread
            //mainAnimal.speak();
        }

        private void btnWhat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("It is a frog");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            thread.Abort();         // Stop thread
        }


    }
}
