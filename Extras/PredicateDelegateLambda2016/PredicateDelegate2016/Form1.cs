using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PredicateDelegate2016
{
    public partial class Form1 : Form
    {
        Random rGen;
        List<int> allNumbers;

        public Form1()
        {
            InitializeComponent();
            allNumbers = new List<int>();
            rGen = new Random();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            lstGenerate.Items.Clear();

            for (int i = 0; i < 100; i++)
                allNumbers.Add(rGen.Next(100));

            foreach(int i in allNumbers)
                lstGenerate.Items.Add(i.ToString());
        }

        private void LambdaFilter(Predicate<int> filter)
        {
            lstFilter.Items.Clear();

            List<int> filtered = allNumbers.FindAll(filter);

            foreach (int i in filtered)
                lstFilter.Items.Add(i.ToString());

        }

        private void btnEven_Click(object sender, EventArgs e)
        {
            LambdaFilter(n => n%2 == 0);
        }

        private void btnSelectLessThan_Click(object sender, EventArgs e)
        {
            LambdaFilter(n => n < 10);
        }
    }
}
