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
    public partial class Form14_PicViewer : Form
    {
        public Form14_PicViewer()
        {
            InitializeComponent();
            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is PictureBox)
                {
                    control.Click += Pic_Click;
                }
            }
        }

        private void Pic_Click(object sender, EventArgs e)
        {
            Form form = new Form();
            form.BackgroundImage = ((PictureBox)sender).Image;
            form.BackgroundImageLayout = ImageLayout.Zoom;
            form.Show();
        }
    }
}
