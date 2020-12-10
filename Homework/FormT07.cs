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
    public partial class FormT07 : Form
    {
        Image bkg = Image.FromFile(@"..\..\Pic\地雷.png");
        string[] a = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"};
        string[] Cards = { "", "", "", "", "", "", "", "", "", "", "", ""}; // 儲存a隨機排序後的資料
        PictureBox n1 = null, n2 = null; //分別指向第1張與第2張翻牌
        String s1 = null, s2 = null; //記錄翻牌第1張與第2張的文字，用來比較用

    public FormT07()
        {
            InitializeComponent();
            randomList();
            foreach (PictureBox control in panel1.Controls)
            {                
                control.Click += Picture_Click;
            }
            //MessageBox.Show(Cards[0] + " " + Cards[1] + " " + Cards[2] + " " + Cards[3] + " " + Cards[4] + " " + Cards[5] + " " +
            //    Cards[6] + " " + Cards[7] + " " + Cards[8] + " " + Cards[9] + " " + Cards[10] + " " + Cards[11]);
        }
        private void randomList() // 方法：亂序
        {           
            Random rand = new Random();
            List<string> myList = new List<string>();

            for (int j = 0; j < 12; j++)
            {
                myList.Add(a[j]);
            }

            //隨機存入資料
            int k = 12;
            for (int i = 0; i < 12; i++)
            {
                int c = rand.Next(0, k); //產生隨機數
                Cards[i] = (myList[c]); // 從 myList 選擇隨機數塞到 int[] b
                myList.Remove(myList[c]);// 從 myList 移除已經選擇過的數
                k--;
            }
        }

        private void Picture_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            String s = pb.Name.Replace("pictureBox", "");
            int index = Int32.Parse(s);
            //pb.Image = bkg;
            pb.Image = (Image)Properties.Resources.ResourceManager.GetObject("ace_of_clubs");

            if (n1 == null) //翻第1張牌的時候
            {
                n1 = pb; pb.Enabled = false; //用n1指向翻出來的牌的pictureBox, 並將該pictureBox設為不作用，以防止再按該pictureBox
                s1 = Cards[index - 1]; //s1字串用來記錄第1張牌的文字
            }
            else //翻第2張牌
            {
                n2 = pb; n2.Enabled = false; //同第1張牌一樣，此部份係處理第2張牌
                s2 = Cards[index - 1];

                if (int.Parse(s1) % 6 != int.Parse(s2) % 6) //比較翻出來的2張牌，若不一樣，則蓋牌，重新啟動二張卡的作用…
                {
                    System.Threading.Thread.Sleep(1000); //delay1秒，讓玩家可以看出牌被蓋住
                    n1.Image = Properties.Resources.black_joker; //把2張牌再度用鬼牌蓋上
                    n2.Image = n1.Image; //第2張牌也是用鬼牌來蓋上
                    n1.Enabled = true; n2.Enabled = true;//若翻出來的2張牌不一樣，該2張牌蓋上後再設enabled為true
                }
                //n1~n2、s1~s2再設為null，重新進行翻牌判斷
                n1 = null; n2 = null;
                s1 = null; s2 = null;
            }
        }
    }
}
