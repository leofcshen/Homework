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
    
        private void Picture(PictureBox pic, ref int gowhere, ref int upwhere) // 方法：圖片移動
        {
            pic.Left += gowhere;
            pic.Top += upwhere;
            if (pic.Left + pic.Width > base.Width || pic.Left < 0) // 圖片超過左右邊界，移動座標反轉
            {
                gowhere = -gowhere;
            }
            if (pic.Top + pic.Height > base.Height || pic.Top < 0) // 圖片超過上下邊界，移動座標反轉
            {
                upwhere = -upwhere;
            }
        }

        private void timer1_Tick(object sender, EventArgs e) // timer1 
        {
            Picture(pictureBox1, ref gowhere, ref upwhere);
        }

        private void ScreenSaver_MouseMove(object sender, MouseEventArgs e) // 滑鼠移動
        {
            if (exit) // 設定鼠標位置
            {
                mouseX = e.X;
                mouseY = e.Y;
                exit = !exit;
            }
            else if (Math.Abs(e.X - mouseX) > 50 || Math.Abs(e.Y - mouseY) > 50) // 移動超過設定範圍就關閉
            {
                Close();
            }
        }
    }
}
