﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework
{
    public partial class Form1_1 : Form
    {
        private Form1 frm;
        public Form1_1( Form1 form1)
        {
            frm = form1;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            frm.lblA.Text = textBox1.Text;
        }
    }
}
