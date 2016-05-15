using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Animal_Noises
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<Animal> animalList;
        private List<Thread> threadList;
        // Make some sort of object to lock on which all threads will have access to..
        // In this case, we can use a string, we could also use a class if we wanted to.
        // Just has to be an object. 
        private String sharedLockString;        
      

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            animalList = new List<Animal>();
            threadList = new List<Thread>();
            sharedLockString = "Shared lock string";    // Doesn't matter what the string is.

            // Pass sharedLockString in to all objects so that they have a reference to it
            animalList.Add(new Animal("frog.wav", sharedLockString));
            animalList.Add(new Animal("duck.wav", sharedLockString));
            animalList.Add(new Animal("meow.wav", sharedLockString));

            for (int i = 0; i < animalList.Count; i++)
                threadList.Add(new Thread(animalList[i].speak));

            for (int i = 0; i < animalList.Count; i++)
                    threadList[i].Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < animalList.Count; i++)
                threadList[i].Abort();
        }
    }
}
