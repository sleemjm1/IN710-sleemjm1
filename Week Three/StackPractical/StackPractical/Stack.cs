using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackPractical
{
    class Stack
    {
        Node head;
        Node tail;
        
        public Stack()
        {
            head = null;
            tail = null;
        }

        public void Push(Node newNode) //Adds a new string to the stack
        {
            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                tail.Next = newNode;
                tail.Previous = tail;
                tail = newNode;
            }
        }

        public string Pop() // Returns + deletes most recently added node
        {
            string returnString = tail.String;

            Node nodeWalker = head;
            while(nodeWalker != null)
            {
                if(nodeWalker.Next == tail)
                {
                    tail = nodeWalker;
                }
                nodeWalker = nodeWalker.Next;
            }
            return returnString;
        }

        public string Peek() // Returns most recently added string
        {
            return tail.String;
        }

        public int Count() // Returns count of stack
        {
            int count = 0;
            Node NodeWalker = head;
            while (NodeWalker != null)
            {
                count++;
                NodeWalker = NodeWalker.Next;
            }

            return count;
        }

        public bool IsEmpty() // Check for empty
        {
            if (tail == null)
                return true;
            else
                return false;
        }
    }
}
