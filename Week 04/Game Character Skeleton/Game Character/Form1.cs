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

            characterList.Add(new Knight(listBox1, "Tuco"));
            characterList.Add(new Queen(listBox1, "Emma"));

            foreach (Character c in characterList)
            {
                checkedListBox1.Items.Add(c.Name);
                checkedListBox2.Items.Add(c.Name);
            }
        }

        private void btnAddCharacter_Click(object sender, EventArgs e)
        {
            string newName = txtName.Text;

            // long ass if/else
            if (rdKing.Checked)
            {
                characterList.Add(new King(listBox1, newName));
            }
            else if (rdQueen.Checked)
            {
                characterList.Add(new Queen(listBox1, newName));
            }
            else if (rdTroll.Checked)
            {
                characterList.Add(new Troll(listBox1, newName));
            }
            else if (rdKnight.Checked)
            {
                characterList.Add(new Knight(listBox1, newName));
            }
            checkedListBox1.Items.Add(newName);
            checkedListBox2.Items.Add(newName);
        }
    }
}
