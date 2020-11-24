using System;
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
    public partial class Form11_ScreenSaver : Form
    {
        public Form11_ScreenSaver()
        {
            InitializeComponent();
            base.MouseMove += ScreenSaver_MouseMove;
        }
        private int mouseX;
        private int mouseY;
        private int gowhere = 2;
        private int upwhere = 2;
        private bool exit = true;         
    
        private void Picture(PictureBox pic, ref int gowhere, ref int upwhere)
        {
            pic.Left += gowhere;
            pic.Top += upwhere;
            if (pic.Left + pic.Width > base.Width || pic.Left < 0)
            {
                gowhere = -gowhere;
            }
            if (pic.Top + pic.Height > base.Height || pic.Top < 0)
            {
                upwhere = -upwhere;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Picture(pictureBox1, ref gowhere, ref upwhere);
        }

        private void ScreenSaver_MouseMove(object sender, MouseEventArgs e)
        {
            if (exit)
            {
                mouseX = e.X;
                mouseY = e.Y;
                exit = !exit;
            }
            else if (Math.Abs(e.X - mouseX) > 100 || Math.Abs(e.Y - mouseY) > 100)
            {
                Close();
            }
        }

    }
}
