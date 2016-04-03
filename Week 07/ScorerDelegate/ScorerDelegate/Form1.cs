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

            if (rbChildren.Checked)
                scoreComputer = new ScoreDelegate(Scorer.ChildrenScore);
            else
                scoreComputer = new ScoreDelegate(Scorer.AdultScore);

            lblScore.Text = scoreComputer(correct, incorrect).ToString();

        }
    }
}
