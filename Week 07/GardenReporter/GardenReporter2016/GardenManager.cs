using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GardenReporter2016
{
    public class GardenManager
    {
        public List<Garden> gardenList;

        public GardenManager()
        {
            gardenList = new List<Garden>();
        }
        public void AddGarden(Garden garden)
        {
            gardenList.Add(garden);
        }

        public void ProcessGardens(GardenReporter2016.Form1.GardenReportDelegate gardenReportDelegate, ListBox listBox1)
        {
            listBox1.Items.Clear();
            foreach (Garden g in gardenList)
            {
                string ownerName = g.OwnerName;
                string delegateString = gardenReportDelegate(g).ToString();
                string reportString = String.Format("{0,-14}:{1,8:F2}", ownerName, delegateString);
                listBox1.Items.Add(reportString);
            }
        }
    }
}
