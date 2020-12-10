using System;
using System.Collections;
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
    public partial class FormT06 : Form
    {
        public FormT06()
        {
            InitializeComponent();
        }

        Image bkg1 = Image.FromFile(@"..\..\Pic\圖像_炎柱.jpg");
        Image bkg2 = Image.FromFile(@"..\..\Pic\圖像_風柱.jpg");
        Image bkg3 = Image.FromFile(@"..\..\Pic\圖像_霞柱.jpg");
        Image bkg4 = Image.FromFile(@"..\..\Pic\圖像_蟲柱.jpg");
        Image bkg5 = Image.FromFile(@"..\..\Pic\圖像_戀柱.jpg");
        Image bkg6 = Image.FromFile(@"..\..\Pic\圖像_水柱.jpg");

        Button[,] buttons = new Button[6, 2];

        private static int[,] randomList(int[] a) // 方法：亂序
        {
            int[,] b = new int[6, 2]; // 儲存a隨機排序後的資料
            Random rand = new Random();
            List<int> myList = new List<int>();
            for (int j = 0; j < 12; j++)
            {
                myList.Add(a[j]);
            }

            //隨機存入資料
            int k = 12;
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    int c = rand.Next(0, k); //產生隨機數
                    b[i, j] = (myList[c]); // 從 myList 選擇隨機數塞到 int[] b
                    myList.Remove(myList[c]);// 從 myList 移除已經選擇過的數
                    k--;
                }
            }
            // 回傳亂序後的 int[6,2] b
            return b;
        }

        private void button1_Click(object sender, EventArgs e) // 按鈕：要比對 %6 餘數
        {
            panel1.Controls.Clear();
            int[] a = { 1,2,3,4,5,6,7,8,9,10,11,12};
            int[,] arr = randomList(a);            
            
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Size = new Size(200, 200);
                    buttons[i, j].Font = new Font("Tahoma", 30, FontStyle.Bold);
                    buttons[i, j].ForeColor = Color.Red;
                    buttons[i, j].Name = $"btn[{i},{j}]";
                    buttons[i, j].Location = new Point(200 * i, 200 * j);
                    buttons[i, j].BackColor = Color.Beige;
                    buttons[i, j].Text = arr[i, j].ToString();
                    //if (int.Parse(buttons[i, j].Text) %6 == 1)
                    //{
                    //    buttons[i, j].BackgroundImage = bkg1;
                    //    buttons[i, j].BackgroundImageLayout = ImageLayout.Zoom;
                    //}
                    //if (int.Parse(buttons[i, j].Text) % 6 == 2)
                    //{
                    //    buttons[i, j].BackgroundImage = bkg2;
                    //    buttons[i, j].BackgroundImageLayout = ImageLayout.Zoom;
                    //}
                    //if (int.Parse(buttons[i, j].Text) % 6 == 3)
                    //{
                    //    buttons[i, j].BackgroundImage = bkg3;
                    //    buttons[i, j].BackgroundImageLayout = ImageLayout.Zoom;
                    //}
                    //if (int.Parse(buttons[i, j].Text) % 6 == 4)
                    //{
                    //    buttons[i, j].BackgroundImage = bkg4;
                    //    buttons[i, j].BackgroundImageLayout = ImageLayout.Zoom;
                    //}
                    //if (int.Parse(buttons[i, j].Text) % 6 == 5)
                    //{
                    //    buttons[i, j].BackgroundImage = bkg5;
                    //    buttons[i, j].BackgroundImageLayout = ImageLayout.Zoom;
                    //}
                    //if (int.Parse(buttons[i, j].Text) % 6 == 0)
                    //{
                    //    buttons[i, j].BackgroundImage = bkg6;
                    //    buttons[i, j].BackgroundImageLayout = ImageLayout.Zoom;
                    //}

                    panel1.Controls.Add(buttons[i, j]);

                    foreach (Button control in panel1.Controls)
                    {
                        control.Click += Button_Click;                        
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e) // 按鈕：直接比對值
        {
            panel1.Controls.Clear();
            int[] a = { 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6 };
            int[,] arr = randomList(a);

            

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Size = new Size(200, 200);
                    buttons[i, j].Font = new Font("Tahoma", 30, FontStyle.Bold);
                    buttons[i, j].ForeColor = Color.Red;
                    buttons[i, j].Name = $"btn[{i},{j}]";
                    buttons[i, j].Location = new Point(200 * i, 200 * j);
                    buttons[i, j].BackColor = Color.Beige;
                    buttons[i, j].Text = arr[i, j].ToString();
                    
                    panel1.Controls.Add(buttons[i, j]);

                    foreach (Button control in panel1.Controls)
                    {
                        control.Click += Button_Click;
                    }
                }
            }
        }
        int flip = 2;
        private void Button_Click(object sender, EventArgs e)
        {            
            //if (flip > 0)
            {
                if  (int.Parse(((Button)sender).Text) % 6 == 1)
                {
                    ((Button)sender).BackgroundImage = bkg1;
                    ((Button)sender).BackgroundImageLayout = ImageLayout.Zoom;
                    flip--;
                }
                else if (int.Parse(((Button)sender).Text) % 6 == 2)
                {
                    ((Button)sender).BackgroundImage = bkg2;
                    ((Button)sender).BackgroundImageLayout = ImageLayout.Zoom;
                    flip--;
                }
                else if (int.Parse(((Button)sender).Text) % 6 == 3)
                {
                    ((Button)sender).BackgroundImage = bkg3;
                    ((Button)sender).BackgroundImageLayout = ImageLayout.Zoom;
                    flip--;
                }
                else if (int.Parse(((Button)sender).Text) % 6 == 4)
                {
                    ((Button)sender).BackgroundImage = bkg4;
                    ((Button)sender).BackgroundImageLayout = ImageLayout.Zoom;
                    flip--;
                }
                else if (int.Parse(((Button)sender).Text) % 6 == 5)
                {
                    ((Button)sender).BackgroundImage = bkg5;
                    ((Button)sender).BackgroundImageLayout = ImageLayout.Zoom;
                    flip--;
                }
                else if (int.Parse(((Button)sender).Text) % 6 == 0)
                {
                    ((Button)sender).BackgroundImage = bkg6;
                    ((Button)sender).BackgroundImageLayout = ImageLayout.Zoom;
                    flip--;
                }                
            }            
        }

        // 為了方便觀看，我把值塞在 button.text，但 text 不能隱藏，如果button設定圖片做比對，建議把值塞在button.tag，用tag的值去比對。
        // 
    }
}
