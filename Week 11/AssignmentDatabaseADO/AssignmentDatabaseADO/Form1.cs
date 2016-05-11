﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentDatabaseADO
{
    public partial class Form1 : Form
    {
        DBManager dbMan;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dbMan = new DBManager();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dbMan.ListAllPapers(dataGridView1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dbMan.ListPapersDueInTwoWeeks(dataGridView1);
        }

        
    }
}
