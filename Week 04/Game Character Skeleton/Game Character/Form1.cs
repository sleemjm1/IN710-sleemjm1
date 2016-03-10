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

            characterList.Add(new Knight(listBox1, "Tuco Salamanca"));
            characterList.Add(new Troll(listBox1, "Walter White"));
            characterList.Add(new King(listBox1, "Gustavo Fring"));
            characterList.Add(new Knight(listBox1, "Mike Ehrmantraut"));
            characterList.Add(new Queen(listBox1, "Emma"));
            characterList.Add(new Troll(listBox1, "Joe"));
            characterList.Add(new Troll(listBox1, "Thomas"));

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

        private void btnBattle_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.CheckedIndices.Count != 2)
            {
                MessageBox.Show("Please select exactly 2 characters for battle.");
            }
            else
            {
                listBox1.Items.Clear();
                //loop through checked items and call Name, Rank, Attack 
                foreach (int indexChecked in checkedListBox1.CheckedIndices)
                {
                    Character c = characterList[indexChecked];
                    c.SayName();
                    c.Speak();
                    c.Attack();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IWeapon newWeapon = null;
            if (rdBow.Checked)
            { 
                newWeapon = new Bow(); 
            }
            else if (rdSword.Checked)
            {
                newWeapon = new Sword();
            }
            else if (rdKnife.Checked)
            {
                newWeapon = new Knife();
            }

            if (newWeapon == null)
            {
                MessageBox.Show("Please select a new weapon.");
            }
            else
            {
                foreach (int indexChecked in checkedListBox2.CheckedIndices)
                {
                    Character c = characterList[indexChecked];
                    c.ChangeWeapon(newWeapon);
                }
            }
        }
    }
}
