using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class TheGame
    {
        private Random R = new Random();
        public void the新的一局(int 幾排, int 幾欄, int 雷數)
        {
            this.the幾排 = 幾排;
            this.the幾欄 = 幾欄;
            this.雷區個數 = 雷數;

            // todo  :  msit129 下行要恢復成 註解


            Console.WriteLine("地雷個數 為 " + this.the地雷個數);

            the翻幾個算贏 = this.雷區個數 - this.the地雷個數;
            the已經翻幾個 = 0;

            this.the雷區 = new int[this.the幾排, this.the幾欄];
        }
        public void the佈雷()
        {
            // todo  :  msit129 下面要隨機佈雷
            //this.the雷區[2, 1] = -9;
            //this.the雷區[5, 2] = -9;
            for (int i = 雷區個數; i > 0; i +=0) // for 完一次陣列有可能還沒佈完，多設一層迴圈測試剩除雷數，還有剩就再進陣列迴圈佈雷
            {
                for (int x = 0; x < the幾排; x++)
                {
                    for (int y = 0; y < the幾欄; y++)
                    {
                        if (i > 0 && R.Next(1, 101) < 16 && this.the雷區[x, y] != -9) // 如果還有剩餘雷數 && 亂數 1-100 < 16 (每格佈雷率15%) && 未佈過雷以避免第二次進陣列迴圈會重覆設置
                        {
                            this.the雷區[x, y] = -9;
                            i--;
                        }
                    }
                }     
            }
        }



        public void the算雷()
        {
            // fix 練習 #1 
            for (int 第幾排 = 0; 第幾排 < this.the幾排; 第幾排++)
            {
                for (int 第幾欄 = 0; 第幾欄 < this.the幾欄; 第幾欄++)
                {
                    int what = this.the雷區[第幾排, 第幾欄];
                    if (what >= 0)
                    {
                        int 周遭共有幾個是地雷 = 0;

                        Console.WriteLine();
                        Console.WriteLine("第{0}排, 第{1}欄   不是地雷", 第幾排, 第幾欄);
                        int 上面一排 = (第幾排 - 1);
                        上面一排 = (第幾排 - 1) >= 0 ? (第幾排 - 1) : 0;

                        Console.WriteLine("上面一排 是{0}", 上面一排);
                        int 下面一排 = (第幾排 + 1);
                        下面一排 = (第幾排 + 1) < this.the幾排 ? (第幾排 + 1) : (this.the幾排 - 1);

                        Console.WriteLine("下面一排 是{0}", 下面一排);

                        int 左一欄 = (第幾欄 - 1);
                        左一欄 = (第幾欄 - 1) >= 0 ? (第幾欄 - 1) : 0;

                        int 右一欄 = (第幾欄 + 1);
                        右一欄 = (第幾欄 + 1) < this.the幾欄 ? (第幾欄 + 1) : (this.the幾欄 - 1);

                        for (int Row = 上面一排; Row <= 下面一排; Row++)
                        {
                            for (int Column = 左一欄; Column <= 右一欄; Column++)
                            {
                                int target = this.the雷區[Row, Column];
                                if (target < 0)
                                {
                                    周遭共有幾個是地雷 += 1;
                                }
                            }
                        }
                        this.the雷區[第幾排, 第幾欄] =
                                    周遭共有幾個是地雷;
                    }

                }
                Console.WriteLine();
            }

        }

        public void the印出雷區()
        {
            for (int 第幾排 = 0; 第幾排 < this.the幾排; 第幾排++)
            {
                for (int 第幾欄 = 0; 第幾欄 < this.the幾欄; 第幾欄++)
                {
                    int what = this.the雷區[第幾排, 第幾欄];
                    if (what >= 0)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(what + " ");
                }
                Console.WriteLine();
            }
        }
        // todo  :  msit129 下幾行要恢復成 private
        public int the幾排 = 6;
        public int the幾欄 = 5;
        public int 雷區個數 = 0;
        public int the地雷個數 = 2;
        public int the翻幾個算贏 = 0;
        public int the已經翻幾個 = 0;
        public int[,] the雷區;

        private TheGame()
        {
            Console.WriteLine();
            Console.WriteLine("TheGame 建構子 msit129");
        }
        public static TheGame theFetch()
        {
            if (TheGame._gn == null)
            {
                TheGame._gn = new TheGame();
            }
            return TheGame._gn;
        }
        private static TheGame _gn = null;
    }
}
