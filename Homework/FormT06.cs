using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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

        Image bkg = Image.FromFile(@"..\..\Pic\卡背.jpg");
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

        static string[] XY(string s) // 方法：回傳按下的按鈕 X , Y 座標
        {
            string[] sArray = s.Substring(s.IndexOf("[") + 1).TrimEnd(']').Split(','); // x,y
            return sArray;
        }

        private void button1_Click(object sender, EventArgs e) // 按鈕：要比對 %6 餘數
        {
            panel1.Controls.Clear();
            int[] a = { 1,2,3,4,5,6,7,8,9,10,11,12};
            int[,] arr = randomList(a);            
            
            for (int i = 0; i < 6; i++) // 產生按鈕
            {
                for (int j = 0; j < 2; j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Size = new Size(200, 200);
                    buttons[i, j].Font = new Font("Tahoma", 30, FontStyle.Bold);
                    buttons[i, j].ForeColor = Color.Red;
                    buttons[i, j].TextAlign = ContentAlignment.BottomRight;
                    buttons[i, j].Name = $"btn[{i},{j}]";
                    buttons[i, j].Location = new Point(200 * i, 200 * j);
                    buttons[i, j].BackColor = Color.Beige;
                    buttons[i, j].Text = arr[i, j].ToString();
                    buttons[i, j].BackgroundImage = bkg;
                    buttons[i, j].BackgroundImageLayout = ImageLayout.Zoom;

                    panel1.Controls.Add(buttons[i, j]);                    
                }
            }
            foreach (Button control in panel1.Controls) // 註冊翻牌區的按鈕事件
            {
                control.Click += Button_Click;
            }
        }

        private void button2_Click(object sender, EventArgs e) // 按鈕：直接比對值
        {
            panel1.Controls.Clear();
            int[] a = { 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6 };
            int[,] arr = randomList(a);

            for (int i = 0; i < 6; i++) // 產生按鈕
            {
                for (int j = 0; j < 2; j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Size = new Size(200, 200);
                    buttons[i, j].Font = new Font("Tahoma", 30, FontStyle.Bold);
                    buttons[i, j].ForeColor = Color.Red;
                    buttons[i, j].TextAlign = ContentAlignment.BottomRight;
                    buttons[i, j].Name = $"btn[{i},{j}]";
                    buttons[i, j].Location = new Point(200 * i, 200 * j);
                    buttons[i, j].BackColor = Color.Beige;
                    buttons[i, j].Text = arr[i, j].ToString();
                    buttons[i, j].BackgroundImage =
                    buttons[i, j].BackgroundImage = bkg;
                    buttons[i, j].BackgroundImageLayout = ImageLayout.Zoom;

                    panel1.Controls.Add(buttons[i, j]);
                }                
            }
            foreach (Button control in panel1.Controls) // 註冊翻牌區的按鈕事件
            {
                control.Click += Button_Click;
            }
        }

        int flip = 0; // 翻牌次數
        string strName1 = "";
        string strText1 = "";
        string strName2 = "";
        string strText2 = "";
        int x1 = 0, y1 = 0, x2 = 0, y2 = 0;

        private void Button_Click(object sender, EventArgs e) // 按鈕：翻牌區
        {
            //Button btn = (Button)sender;

            if (int.Parse(((Button)sender).Text) % 6 == 1)
            {
                ((Button)sender).BackgroundImage = bkg1;
                ((Button)sender).BackgroundImageLayout = ImageLayout.Zoom;
                flip++;
            }
            else if (int.Parse(((Button)sender).Text) % 6 == 2)
            {
                ((Button)sender).BackgroundImage = bkg2;
                ((Button)sender).BackgroundImageLayout = ImageLayout.Zoom;
                flip++;
            }
            else if (int.Parse(((Button)sender).Text) % 6 == 3)
            {
                ((Button)sender).BackgroundImage = bkg3;
                ((Button)sender).BackgroundImageLayout = ImageLayout.Zoom;
                flip++;
            }
            else if (int.Parse(((Button)sender).Text) % 6 == 4)
            {
                ((Button)sender).BackgroundImage = bkg4;
                ((Button)sender).BackgroundImageLayout = ImageLayout.Zoom;
                flip++;
            }
            else if (int.Parse(((Button)sender).Text) % 6 == 5)
            {
                ((Button)sender).BackgroundImage = bkg5;
                ((Button)sender).BackgroundImageLayout = ImageLayout.Zoom;
                flip++;
            }
            else if (int.Parse(((Button)sender).Text) % 6 == 0)
            {
                ((Button)sender).BackgroundImage = bkg6;
                ((Button)sender).BackgroundImageLayout = ImageLayout.Zoom;
                flip++;
            }
            
            if (flip == 1) // 儲存第一個按鈕的資訊
            {
                ((Button)sender).Enabled = false;
                strName1 = ((Button)sender).Name;
                strText1 = ((Button)sender).Text;
                string[] sArray = XY(((Button)sender).Name);
                x1 = int.Parse(sArray[0]);
                y1 = int.Parse(sArray[1]);
            }
            else if (flip == 2) // 儲存第二個按鈕的資訊並比對
            {
                ((Button)sender).Enabled = false;
                strName2 = ((Button)sender).Name;
                strText2 = ((Button)sender).Text;
                string[] sArray = XY(((Button)sender).Name);
                x2 = int.Parse(sArray[0]);
                y2 = int.Parse(sArray[1]);

                if (int.Parse(strText1)%6 == int.Parse(strText2) %  6) // 如果圖片一樣
                {
                    foreach (Button control in panel1.Controls)
                    {
                        if ((control.Name == $"btn[{x1},{y1}]") || (control.Name == $"btn[{x2},{y2}]"))
                        {
                            control.Enabled = false;
                        }
                    }
                    flip = 0; // 重設翻牌次數
                }
                else if (int.Parse(strText1) % 6 != int.Parse(strText2) % 6)  // 如果圖片不一樣
                {
                    Thread.Sleep(1000); // 暫停一秒讓使用者看
                    foreach (Button control in panel1.Controls) // 搜尋兩次按的按扭重設狀態
                    {
                        if ((control.Name == $"btn[{x1},{y1}]") || (control.Name == $"btn[{x2},{y2}]"))
                        {
                            control.Enabled = true;
                            control.BackgroundImage = bkg;
                        }
                    }
                    flip = 0; // 重設翻牌次數
                }
            }
        }
        // 為了方便觀看，我把值塞在 button.text，但 text 不能隱藏，如果button設定圖片做比對，建議把值塞在button.tag，用tag的值去比對。        
    }
}
