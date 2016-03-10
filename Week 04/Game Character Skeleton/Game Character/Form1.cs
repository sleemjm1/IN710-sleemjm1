using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Character
{
    public partial class Form1 : Form
    {
        List<Character> characterList = new List<Character>();
        public Form1()
        {
            InitializeComponent();

            characterList.Add(new Knight(listBox1, "Stewie"));
        }

        private void btnAddCharacter_Click(object sender, EventArgs e)
        {
            

            //testing
            foreach (Character c in characterList)
            {
                c.Speak();
                c.SayName();
            }
        }
    }
}
