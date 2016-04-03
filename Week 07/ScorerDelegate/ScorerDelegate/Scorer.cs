using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScorerDelegate
{
    public static class Scorer
    {

        // Adults get 10 points per correct answer, and lose one point for incorrect answers
        public static int AdultScore(int correct, int incorrect)
        {
            return correct * 10 - incorrect;     // little computation to generate the score
        }

        // Children get 15 points per correct answer, and have no penalty for incorrect answers
        public static int ChildrenScore(int correct, int incorrect)
        {
            return correct * 15;    // do nothing with incorrect, but method signature needs to match    
        }
    }
}
