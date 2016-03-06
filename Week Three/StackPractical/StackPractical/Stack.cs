using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackPractical
{
    class Stack
    {
        Node head = null;
        Node tail = null;

        public void Stack()
        {
            throw new NotImplementedException();
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
                tail = newNode;
            }
        }

        public string Pop(Node nodeToDelete) // Returns + deletes most recently added node
        {
            Node nodeWalker = head;
            if (nodeToDelete == head)
            {
                if (nodeToDelete == tail)
                {
                    head = null;
                    tail = null;
                }
                else
                {
                    head = head.Next;
                }
            }
            else
            {
                while (nodeWalker != null)
                {
                    if (nodeWalker.Next == nodeToDelete)
                    {
                        if (nodeToDelete == tail)  //if we are going to delete last node in the list
                        {
                            tail = nodeWalker;     //point tail at previous node
                        }
                        else                                //we're on a normal node
                        {
                            nodeWalker.Next = nodeToDelete.Next;
                        }
                    }
                    nodeWalker = nodeWalker.Next;
                }
            }
            return nodeToDelete.String;
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
