using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace RainbowChicken2016
{
    public class PelletList
    {
        Pellet headPointer = null;
        Pellet tailPointer = null;

        Rectangle boundsRectangle;

        //==============================================================================
        // Ctor
        //==============================================================================
        public PelletList(Rectangle boundsRectangle)
        {
            this.boundsRectangle = boundsRectangle;
        }

        //==============================================================================
        // Add Pellet newPellet at the end of the list.
        //==============================================================================
        public void addPellet(Pellet newPellet)
        {
            if (headPointer == null)
            {
                headPointer = newPellet;
                tailPointer = newPellet;
            }
            else 
            {
                tailPointer.Next = newPellet;
                tailPointer = newPellet;
            }
        }

        //==============================================================================
        // Walk the list, counting the number of Pellet. Return the count.
        //==============================================================================
        public int Count()
        {
            int count = 0;
            Pellet pelletWalker = headPointer;
            while (pelletWalker != null)
            {
                count++;
                pelletWalker = pelletWalker.Next;
            }

            return count;
        }

        //==============================================================================
        // Walk the list, calling the Move() method of each Pellet
        //==============================================================================
        public void Move()
        {
            Pellet pelletWalker = headPointer;
            while (pelletWalker != null)
            {
                pelletWalker.Move();
                pelletWalker = pelletWalker.Next;
            }
        }

        //==============================================================================
        // Walk the list. For each Pellet, call TestOutOfBounds, passing boundsRectangle.
        // For each node that is out of bounds, set its IsAlive property to false.
        //==============================================================================
        public void KillOutOfBounds()
        {
            Pellet pelletWalker = headPointer;
            while (pelletWalker != null)
            {
                if (pelletWalker.TestOutOfBounds(boundsRectangle))
                {
                    pelletWalker.IsAlive = false;
                }
                pelletWalker = pelletWalker.Next;
            }
        }

        //==============================================================================
        // Delete the argument Pellet pelletToDelete from the list.
        // Be careful to maintain the integrity of the list, including
        // headPointer and tailPointer.
        //==============================================================================
        public void DeleteOne(Pellet pelletToDelete)
        {
            Pellet pelletWalker = headPointer;
            if (pelletToDelete == headPointer)
            {
                if (pelletToDelete == tailPointer)
                {
                    headPointer = null;
                    tailPointer = null;
                }
                else
                {
                    headPointer = headPointer.Next;
                }
            }
            else
            {
                while (pelletWalker != null)
                {
                    if (pelletWalker.Next == pelletToDelete)
                    {
                        if (pelletToDelete == tailPointer)  //if we are going to delete last pellet in the list
                        {
                            tailPointer = pelletWalker;     //point tailpointer at previous pellet
                        }
                        else                                //we're on a normal pellet
                        {
                            pelletWalker.Next = pelletToDelete.Next;
                        }
                    }
                    pelletWalker = pelletWalker.Next;
                }
            }
        }

        //==============================================================================
        // Walk the list, deleting all nodes whose IsAlive propoerty is false
        //==============================================================================
        public void DeleteNotAlive()
        {
            Pellet pelletWalker = headPointer;
            while (pelletWalker != null)
            {
                if (pelletWalker.IsAlive == false)
                {
                    DeleteOne(pelletWalker);
                }
                pelletWalker = pelletWalker.Next;
            }
        }

        //==============================================================================
        // Walk the list, calling each node's Draw method
        //==============================================================================
        public void Draw()
        {
            Pellet pelletWalker = headPointer;
            while (pelletWalker != null)
            {
                pelletWalker.Draw();
                pelletWalker = pelletWalker.Next;
            }
            
        }
    }
}
