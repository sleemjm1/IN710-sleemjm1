using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MixAndMatch
{
    class CharacterPrinter
    {
        private IHeadFactory headMaker; 
        private ITorsoFactory torsoMaker;
        private ILegsFactory legsMaker;

        private PictureBox headPictureBox;
        private PictureBox torsoPictureBox;
        private PictureBox legsPictureBox;

        public CharacterPrinter(IHeadFactory headMaker, ITorsoFactory torsoMaker, 
            ILegsFactory legsMaker, PictureBox headPictureBox, PictureBox torsoPictureBox,
            PictureBox legsPictureBox)
        {
            this.headMaker = headMaker;
            this.torsoMaker = torsoMaker;
            this.legsMaker = legsMaker;
            this.headPictureBox = headPictureBox;
            this.torsoPictureBox = torsoPictureBox;
            this.legsPictureBox = legsPictureBox;
        }

        public void PrintCharacter()
        {
            Head currentHead = headMaker.makeHead();
            Body currentTorso = torsoMaker.makeBody();
            Legs currentLegs = legsMaker.makeLegs();

            headPictureBox.Image = currentHead.Image;
            torsoPictureBox.Image = currentTorso.Image;
            legsPictureBox.Image = currentLegs.Image;
        }
    }
}
