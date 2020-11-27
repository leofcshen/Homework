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
            // 找出所有控制元件 in flowLayoutPanel1
            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is PictureBox) // 如果該元件是 PictureBox
                {
                    control.Click += Pic_Click;
                }
            }
        }

        private void Pic_Click(object sender, EventArgs e)
        {
            // 點擊圖片開啟視窗
            Form form = new Form();
            form.Size = new Size(816, 489);
            form.BackgroundImage = ((PictureBox)sender).Image;
            form.BackgroundImageLayout = ImageLayout.Zoom;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
        }        
    }
}
