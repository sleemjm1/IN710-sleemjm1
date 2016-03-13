using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IN710_4._1_Animal_Shelter_Solution_2014
{
    class TextDisplay: IDisplay
    {
        ListBox listBox;
        public TextDisplay(ListBox myListBox)
        {
            listBox = myListBox;
        }
        public void displayCritterList(List<Critter> critterList)
        {
            foreach (Critter c in critterList)
            {
                listBox.Items.Add(c.ToString());
            }
        }

        public void clearDisplay()
        {
            listBox.Items.Clear();
        }
    }
}
