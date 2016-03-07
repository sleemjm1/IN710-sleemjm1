using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StackPractical
{
    public partial class Form1 : Form
    {
        Stack stack;
        public Form1()
        {
            InitializeComponent();

            stack = new Stack();
        }

        private void btnPush_Click(object sender, EventArgs e)
        {
            if (txtPush.Text != "")
            {
                Node newNode = new Node(txtPush.Text);
                stack.Push(newNode);
            }
            else MessageBox.Show("Cannot enter empty string.");
        }

        private void btnPop_Click(object sender, EventArgs e)
        {
            string poppedString = stack.Pop();
            txtPop.Text = poppedString;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string peekedString;
            peekedString = stack.Peek();
            txtPeek.Text = peekedString;
        }
        
    }
}
