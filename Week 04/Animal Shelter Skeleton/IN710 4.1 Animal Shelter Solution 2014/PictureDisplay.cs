using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace IN710_4._1_Animal_Shelter_Solution_2014
{
    class PictureDisplay: IDisplay
    {
        List<PictureBox> PictureBoxList;
        public PictureDisplay(List<PictureBox> pictureBoxList)
        {
            PictureBoxList = pictureBoxList;
        }

        public void displayCritterList(List<Critter> critterList)
        {
            Image[] images = new Image[PictureBoxList.Count];   // make array of images that is the size of our picture box list
            int i = 0;                                          // counter
            foreach (Critter c in critterList)
            {
                Image image = Image.FromFile(c.ImageFileName);
                images[i] = image;
                i++; 
            }
            i = 0;  // reset
            foreach (PictureBox pb in PictureBoxList)           // loop through picture boxes
            {
                pb.Image = images[i];
                i++;
            }
        }

        public void clearDisplay()
        {
            foreach (PictureBox pb in PictureBoxList)
            {
                pb.Image = null;    // clear each image
            }
        }
    }
}
