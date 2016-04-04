using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Predicate
{
    public partial class Form1 : Form
    {
        List<int> randomList;
        List<int> sortedList;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            generateRandoms();
        }

      
        private void btnEven_Click(object sender, EventArgs e)
        {
            Predicate<int> isEvenPredicate = new Predicate<int>(isEven);
            if (randomList == null)
                MessageBox.Show("Please generate numbers before trying to sort");
            else
                sortList(isEvenPredicate, randomList);
        }

        

        private void btnLessThanTen_Click(object sender, EventArgs e)
        {
            Predicate<int> isLessThanTenPredicate = new Predicate<int>(isLessThanTen);
            if (randomList == null)
                MessageBox.Show("Please generate numbers before trying to sort");
            else
                sortList(isLessThanTenPredicate, randomList);
        }

        private void generateRandoms()
        {
            randomList = new List<int>();
            Random r = new Random();

            for (int i = 0; i < 100; i++)
            {
                randomList.Add(r.Next(0, 99));  // number between 0-99
            }

            fillListBox(listGeneratedNumbers, randomList);
        }

        private void fillListBox(ListBox listBox, List<int> IntegerList)    // use whenever we want to fill a ListBox on form
        {
            listBox.Items.Clear();
            foreach (int i in IntegerList)
            {
                listBox.Items.Add(i);
            }
        }

        private void sortList(Predicate<int> sortingPredicate, List<int> listToBeSorted)    // accepts predicate & a list to be sorted
        {
            sortedList = listToBeSorted.FindAll(sortingPredicate);                          // place in list based on the sorting predicate passed in
            fillListBox(listSelectedNumbers, sortedList);                                   // fill list on form
        }

        // methods to be used with our predicate
        private bool isEven(int inputInt)
        {
            bool isAnEvenNumber = ((inputInt % 2) == 0);    // mod 2 = 0 means even number 
            return isAnEvenNumber;
        }

        private bool isLessThanTen(int inputInt)
        {
            bool isLessThanTen = (inputInt < 10);           // if our input int < 10
            return isLessThanTen;
        }

      
    }
}
