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
    
    public partial class Form13_DrawPaint : Form
    {
        private Graphics g;
        private bool flag = false;
        private Pen p = new Pen(Color.Black, 1f);
        private Point point;

        public Form13_DrawPaint()
        {
            InitializeComponent();
            g = CreateGraphics();
            label1.Text = string.Concat(trackBar1.Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                p.Color = colorDialog1.Color;
                label2.BackColor = colorDialog1.Color;
            }
        }
        private void Form13_DrawPaint_MouseDown(object sender, MouseEventArgs e)
        {
            flag = true;
            point.X = e.X;
            point.Y = e.Y;
        }
        private void Form13_DrawPaint_MouseMove(object sender, MouseEventArgs e)
        {
            if (flag)
            {
                g.DrawLine(p, point.X, point.Y, e.X, e.Y);
                point.X = e.X;
                point.Y = e.Y;
            }
        }

        private void Form13_DrawPaint_MouseUp(object sender, MouseEventArgs e)
        {
            flag = false;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text = string.Concat(trackBar1.Value);
            p.Width = trackBar1.Value;
        }
    }
}
