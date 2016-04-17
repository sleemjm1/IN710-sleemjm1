using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LambdaPredicate
{
    // Simple task converting an old practical where we used Predicates as parameters to filter our lists
    // We are now going to refactor that old code to use Lambda expressions 
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
            if (randomList == null)
                MessageBox.Show("Please generate numbers before trying to sort");
            else
                lambdaFilter(n => n % 2 == 0);
                // sortListEvenNumbers(randomList); // Wrong, wrong, wrong
        }

        private void btnLessThanTen_Click(object sender, EventArgs e)
        {
            if (randomList == null)
                MessageBox.Show("Please generate numbers before trying to sort");
            else
                lambdaFilter(n => n < 10);
               // sortListLessThanTen(randomList);
        }

        private void generateRandoms()
        {
            randomList = new List<int>();
            Random r = new Random();

            for (int i = 0; i < 100; i++)
            {
                randomList.Add(r.Next(0, 99));
            }

            fillListBox(listGeneratedNumbers, randomList);
        }

        private void fillListBox(ListBox listBox, List<int> IntegerList)
        {
            listBox.Items.Clear();
            foreach (int i in IntegerList)
            {
                listBox.Items.Add(i);
            }
        }

        //private void sortListLessThanTen(List<int> listToBeSorted)
        //{
        //    sortedList = listToBeSorted.FindAll(i => i < 10);   // Lambda expression
        //    fillListBox(listSortedNumbers, sortedList);
        //}

        //private void sortListEvenNumbers(List<int> listToBeSorted)
        //{
        //    sortedList = listToBeSorted.FindAll(i => (i % 2) == 0); // Lambda expression
        //    fillListBox(listSortedNumbers, sortedList);
        //}

        private void lambdaFilter(Predicate<int> filter)
        {
            listSortedNumbers.Items.Clear();

            List<int> filtered = randomList.FindAll(filter);

            foreach (int i in filtered)
                listSortedNumbers.Items.Add(i.ToString());
        }

       

        
    }
}
