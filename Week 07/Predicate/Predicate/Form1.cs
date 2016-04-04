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
    // A predicate is a function that returns true or false. A predicate delegate is a reference to a predicate.
    // Very useful for filtering lists of values, as we will do in this lab

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
            //Predicate<int> isLessThanTenPredicate = new Predicate<int>(isLessThanTen);
            if (randomList == null)
                MessageBox.Show("Please generate numbers before trying to sort");
            else
                sortListLessThanTenLambda(randomList);  // using the lambda method for this one
        }

        // used to generate random numbers and populate ListBox on form
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

        // Using a lambda for a slightly cleaner method for sorting the list -- Don't have to pass in a Predicate
        private void sortListLessThanTenLambda(List<int> listToBeSorted)
        {
            sortedList = listToBeSorted.FindAll(i => i < 10);
            fillListBox(listSelectedNumbers, sortedList);
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

    }   // class end
}   // namespace end
