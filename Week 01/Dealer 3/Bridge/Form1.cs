﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bridge
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            THand[] Hands = new THand[4];
            for (int i = 0; i < Hands.Length; i++) Hands[i] = new THand(listBox1);
            TDeck myDeck = new TDeck();
            myDeck.shuffle();
            myDeck.Deal(Hands);
            for (int i = 0; i < Hands.Length; i++)
            {
                Hands[i].SortHand();
                Hands[i].DispayHand();
            }
            
        }
    }
}
