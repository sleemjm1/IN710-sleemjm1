using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MixAndMatch
{
    class MixAndMatchPrinter
    {
        private ICharacterFactory characterFactory;
        private PictureBox headPictureBox;
        private PictureBox bodyPictureBox;
        private PictureBox legsPictureBox;

        public MixAndMatchPrinter(ICharacterFactory characterFactory, PictureBox headPictureBox, PictureBox bodyPictureBox, PictureBox legsPictureBox)
        {
            this.characterFactory = characterFactory;
            this.headPictureBox = headPictureBox;
            this.bodyPictureBox = bodyPictureBox;
            this.legsPictureBox = legsPictureBox;
        }

        public void displayCharacter()
        {
            Head currentHead = characterFactory.makeHead();
            Body currentBody = characterFactory.makeBody();
            Legs currentLegs = characterFactory.makeLegs();

            headPictureBox.Image = currentHead.Image;
            bodyPictureBox.Image = currentBody.Image;
            legsPictureBox.Image = currentLegs.Image;
        }
    }
}
