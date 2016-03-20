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
        List<ModelMaker> modelList = new List<ModelMaker>();
        public Form1()
        {
            InitializeComponent();

            modelList.Add(new Walt());
            modelList.Add(new Mike());
            modelList.Add(new Gus());
            modelList.Add(new Flynn());
            modelList.Add(new Jesse());
            modelList.Add(new Saul());

            PopulateComboBox(cbHead, modelList);
            PopulateComboBox(cbTorso, modelList);
            PopulateComboBox(cbLegs, modelList);
        }

        private void PopulateComboBox(ComboBox comboBox, List<ModelMaker> allModels)
        {
            foreach (ModelMaker m in allModels)
            { 
                comboBox.Items.Add(m.Name); 
            }
            comboBox.SelectedIndex = 1;     // remove blank entry at top 
        }

        private void btnMakeCharacter_Click(object sender, EventArgs e)
        {
            string currentHeadCharacterName = cbHead.SelectedItem.ToString();
            string currentTorsoCharacterName = cbTorso.SelectedItem.ToString();
            string currentLegsCharacterName = cbLegs.SelectedItem.ToString();

            ModelFactory currentModelFactory = new ModelFactory();
            ModelMaker currentModel = currentModelFactory.createModel(currentHeadCharacterName);
            pbHead.Image = currentModel.Head;

            currentModel = currentModelFactory.createModel(currentTorsoCharacterName);
            pbTorso.Image = currentModel.Torso;

            currentModel = currentModelFactory.createModel(currentLegsCharacterName);
            pbLegs.Image = currentModel.Legs;
        }
    }
}
