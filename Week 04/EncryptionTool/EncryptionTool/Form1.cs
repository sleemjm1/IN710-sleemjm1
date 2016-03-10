﻿using System;
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
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (rbReverse.Checked)
            {
                IEncrypt iEncrypt = new Reverse();
                String stringToConvert = txtInput.Text;

                String convertedString = iEncrypt.PerformEncryption(stringToConvert);
                txtOutput.Text = convertedString;
            }
            else if (rbRot13.Checked)
            {
                IEncrypt iEncrypt = new Rot();
                String stringToConvert = txtInput.Text;

                String convertedString = iEncrypt.PerformEncryption(stringToConvert);
                txtOutput.Text = convertedString;
            }
        }
    }
}
