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

        private ComboBox headComboBox;

        public CharacterPrinter(ComboBox headComboBox)
        {
            this.headComboBox = headComboBox;
        }
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

        public void PopulateComboBox()
        {
            
            List<BodyPart> headList = new List<BodyPart>();

            headList.Add(new WaltHead());
            headList.Add(new MikeHead());

            foreach (Head h in headList)
            {
                headComboBox.Items.Add(h.Name.ToString());
            }
            headComboBox.SelectedIndex = 1;

        }
    }
}
