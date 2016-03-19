using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MixAndMatch
{
    public partial class Form1 : Form
    {
        IHeadFactory currentHeadFactory;
        ITorsoFactory currentTorsoFactory;
        ILegsFactory currentLegsFactory;
        CharacterPrinter formSetupPrinter;
        public Form1()
        {
            InitializeComponent();
            formSetupPrinter = new CharacterPrinter(cbHead);
            formSetupPrinter.PopulateComboBox();
        }

        private void btnMakeCharacter_Click(object sender, EventArgs e)
        {
            currentHeadFactory = new MikeHeadFactory();
            currentTorsoFactory = new WaltTorsoFactory();
            currentLegsFactory = new WaltLegsFactory();

            CharacterPrinter currentCharacterPrinter = new CharacterPrinter(currentHeadFactory,
                currentTorsoFactory, currentLegsFactory, pbHead, pbTorso, pbLegs);
            currentCharacterPrinter.PrintCharacter();

        }
    }
}
