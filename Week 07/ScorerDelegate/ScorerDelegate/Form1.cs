using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScorerDelegate
{
    public partial class Form1 : Form
    {
        int correct;
        int incorrect;
        // Create & declare our delegate -- Signature has to match that of our static methods in Scorer class
        public delegate int ScoreDelegate(int correct, int incorrect);
        ScoreDelegate scoreComputer;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            try
            {
                correct = Int32.Parse(txtCorrect.Text);
                incorrect = Int32.Parse(txtIncorrect.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numerical values in all fields");
            }

            if (rbChildren.Checked)         // We will use ChildrenScore 
                scoreComputer = new ScoreDelegate(Scorer.ChildrenScore);
            else                            // We will use AdultScore
                scoreComputer = new ScoreDelegate(Scorer.AdultScore);

            // Our delegate will return int -- convert to string for displaying
            lblScore.Text = scoreComputer(correct, incorrect).ToString();   

        }
    }
}
