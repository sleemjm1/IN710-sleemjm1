using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackPractical
{
    class Node
    {
        public Node Next { get; set; }
        public Node Previous { get; set; }
        public string String;

        public Node(string newString)
        {
            String = newString;
        }

        public string ToString()
        {
            return String;
        }
    }
}
