using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncryptionTool
{
    public partial class Form1 : Form
    {
        IEncrypt iEncrypt;
        public Form1()
        {
            iEncrypt = new Rot();
            InitializeComponent();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (rbReverse.Checked) iEncrypt = new Reverse();
            else iEncrypt = new Rot();            
            txtOutput.Text = iEncrypt.PerformEncryption(txtInput.Text);
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (rbReverse.Checked) iEncrypt = new Reverse();
            else iEncrypt = new Rot();
            txtOutput.Text = iEncrypt.PerformDecryption(txtInput.Text);
        }
    }
}
