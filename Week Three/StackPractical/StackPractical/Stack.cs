using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackPractical
{
    public class Stack
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
                //tail.Previous = tail;
                tail = newNode;
            }
        }

        public string Pop() // Returns + deletes most recently added node
        {
            if (tail != null)
            {
                string returnString = tail.String; // This is the string we want to show -- Top of stack

                Node nodeWalker = head; // walk the list
                if (nodeWalker != tail)
                {
                    while (nodeWalker != null)
                    {
                        if (nodeWalker.Next == tail) // If the next node is the tail
                        {
                            tail = nodeWalker;      // Tail is now previous node
                        }
                        nodeWalker = nodeWalker.Next;
                    }
                }
                else
                {
                    head = null;
                    tail = null;
                }
                return returnString;
            }
            else return ("Stack is empty.");
        }

        public string Peek() // Returns most recently added string
        {
            if (tail != null)
            {
                return tail.String; //null reference
            }
            else
            {
                return "Stack is empty.";
            }
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
