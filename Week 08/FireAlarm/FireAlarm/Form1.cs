using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FireAlarm
{
    public partial class Form1 : Form
    {
        FireAlarmSubject fireAlarmSubject;
        InstructionsObserver instructionsObserver;
        BeepObserver beepObserver;
        EFireCategory currFireCategory;
        public Form1()
        {
            InitializeComponent();
            rbMinor.Checked = true;
            fireAlarmSubject = new FireAlarmSubject();
            instructionsObserver = new InstructionsObserver(fireAlarmSubject);
            beepObserver = new BeepObserver(fireAlarmSubject);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rbInferno.Checked)
                currFireCategory = EFireCategory.INFERNO;
            else if (rbSerious.Checked)
                currFireCategory = EFireCategory.SERIOUS;
            else
                currFireCategory = EFireCategory.MINOR;

            fireAlarmSubject.OnFireEvent(currFireCategory);
        }
    }
}
