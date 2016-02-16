using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TwoToOne
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void TwoToOne()
        {
            const int columnCount = 4;
            const int rowCount = 2;

            Char[] oneDimensional = new Char[columnCount * rowCount];
            Char[,] twoDimensional = new Char[columnCount, rowCount] { { 'a', 'b' }, { 'c', 'd' }, { 'e', 'f' }, { 'g', 'h' } };

            // convert to one dimension
            for (int c = 0; c < columnCount; c++)
                for (int r = 0; r < rowCount; r++)
                {
                    //Add code here. DO NOT declare any new variables
                    //arrayPosition = rowCount * c + r so that we can figure out which slot of the 
                    //one dimensional array we are up to. 
                    //ex:  1, 2 => 2 * 1 + 2 = 4 => [1, 2] in 2D array becomes [4] in 1D array.

                    int arrayPosition = rowCount * c + r;
                    oneDimensional[arrayPosition] = twoDimensional[c, r];
                }

            //printing one dimensional array
            for (int i = 0; i < columnCount * rowCount; i++)
                listBox1.Items.Add(oneDimensional[i]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TwoToOne();
        }

        
    } //end form
}
