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
    public partial class Form15_GuessNumber : Form
    {
        public Form15_GuessNumber()
        {
            InitializeComponent();
        }
        private Random rand = new Random();
private void btnGuess_Click(object sender, EventArgs e)
        {
            Class1.x = this;
            Class1.ans = rand.Next(1, 100);
            Form15_GuessMsgBox formGuessMessageBox = new Form15_GuessMsgBox();
            formGuessMessageBox.ShowDialog();
        }

        private void btnShowAnswer_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Answer：{Class1.ans}");
        }
    }
}