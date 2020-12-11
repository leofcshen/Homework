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
    public partial class FormT05_MineSweeper : Form
    {
        public FormT05_MineSweeper()
        {
            InitializeComponent();
            KeyPreview = true;
            button1.MouseDown += button1_MouseDown;
        }
        
        int filedNumber = 0; // 雷區數
        int testNumber = 0; // 踩雷數
        int flagNumber = 0; // 標雷數
        static int row = 0;
        static int col = 0;
        int bombNumber = 0;
        string level = "";
        bool flag = true;
        Button[,] buttons = new Button[row, col];
        Image bkg = Image.FromFile(@"..\..\Pic\地雷.png");
        DateTime TimeNow = new DateTime();
        TimeSpan TimeCount = new TimeSpan();
        bool flagTimer = false;
        

        private void timer1_Tick(object sender, EventArgs e) // Timer：計時器
        {
            TimeCount = DateTime.Now - TimeNow;
            lblTimer.Text = string.Format("{0:00}:{1:00}:{2:00}", TimeCount.Hours, TimeCount.Minutes, TimeCount.Seconds);
        }

        private void Form_KeyDown(object sender, KeyEventArgs e) // 按鍵觸發快捷鍵
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    btnNewGame_Click(this, EventArgs.Empty);
                    break;
            }
        }

        static string[] XY(string s) // 方法：回傳按下的按鈕 X , Y 座標
        {
            string[] sArray = s.Substring(s.IndexOf("[") + 1).TrimEnd(']').Split(','); // x,y
            return sArray;
        }

        private void btnNewGame_Click(object sender, EventArgs e) // 按扭：開新遊戲
        {
            timer1.Stop();
            flagTimer = false;
            lblTimer.Text = "00:00:00";
            btnClickAll.Enabled = true;
            filedNumber = 0;
            testNumber = 0;
            txtTest.Text = testNumber.ToString();
            flagNumber = 0;
            txtFlag.Text = flagNumber.ToString();
            txtBombLeft.Text = "0";
            row = 0;
            col = 0;
            bombNumber = 0;
            level = "";
            btnTagBomb.Enabled = true;
            btnUntagBomb.Enabled = true;
            flag = true;

            if (cbbLevel.Text == "")
            {
                MessageBox.Show("請選擇難度");
                return;
            }

            if (cbbLevel.Text == "簡單  8* 8 雷數10")
            {
                level = "簡單";
                row = 8;
                col = 8;
                bombNumber = 10;
            }
            else if (cbbLevel.Text == "普通 16*16 雷數40")
            {
                level = "普通";
                row = 16;
                col = 16;
                bombNumber = 40;
            }
            else if (cbbLevel.Text == "困難 30*16 雷數99")
            {
                level = "困難";
                row = 30;
                col = 16;
                bombNumber = 99;
            }

            TheGame g = TheGame.theFetch();
            Console.WriteLine("#######################");
            g.the新的一局(row, col, bombNumber);
            //g.the新的一局(8,8,10);
            g.the印出雷區();
            Console.WriteLine("佈雷");
            g.the佈雷();
            g.the印出雷區();
            Console.WriteLine("算雷");
            g.the算雷();
            g.the印出雷區();

            panel1.Controls.Clear();

            txtLevel.Text = level.ToString();
            txtBombNumber.Text = bombNumber.ToString();
            txtBombLeft.Text = bombNumber.ToString();

            Button[,] buttons = new Button[row, col];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Size = new Size(35, 35);
                    buttons[i, j].Name = $"btn[{i},{j}]";
                    buttons[i, j].Location = new Point(35 + 34 * i, 35 + 35 * j);
                    buttons[i, j].BackColor = Color.Beige;
                    //buttons[i, j].Text = g.the雷區[i, j].ToString();
                    buttons[i, j].Tag = g.the雷區[i, j].ToString();
                    panel1.Controls.Add(buttons[i, j]);
                }
            }
            foreach (Button control in panel1.Controls)
            {
                control.MouseDown += BombButton_MouseDown;
                control.MouseUp += BombButton_MouseUp;
            }
            filedNumber = row * col;
        }

        private bool lf = false;
        private bool rf = false;

        private void BombButton_MouseDown(object sender, MouseEventArgs e) // 按鈕：地雷區
        {
            //if (e.Button == MouseButtons.Left)
            //{
            //    lf = true;
            //}
            //else if (e.Button == MouseButtons.Right)
            //{
            //    rf = true;
            //}
            //if (lf && rf)
            //{
            //    MessageBox.Show("R + L");
            //    return;
            //}

            if (flagTimer == false)
            {
                timer1.Start();
                TimeNow = DateTime.Now;
                flagTimer = true;
            }

            if (e.Button == MouseButtons.Left) // 左鍵踩雷
            {
                if (((Button)sender).Text == "|>") // 有標記不動作
                    return;

                if (((Button)sender).Text != "") // 有踩過不動作
                    return;

                if (((Button)sender).Tag.ToString() == "-9") // 中雷
                {
                    timer1.Stop();
                    flagTimer = false;
                    flag = false;
                    btnClickAll.Enabled = false;
                    btnUntagBomb.Enabled = false;
                    btnTagBomb.Enabled = false;
                    
                    foreach (Button control in panel1.Controls) // Button 全開並鎖定
                    {
                        control.Text = control.Tag.ToString();
                        if (control.Text == "0")
                            control.Text = "";
                        if (control.Text == "-9")
                        {
                            control.BackgroundImage = bkg;
                            control.BackgroundImageLayout = ImageLayout.Zoom;
                        }                            
                        control.Enabled = false;
                    }
                    FormT05_MineSweeper_Die fmd = new FormT05_MineSweeper_Die();
                    fmd.ShowDialog();
                }
                else
                {
                    if (((Button)sender).Tag.ToString() == "0" ) // 沒中雷且是0
                    {
                        //((Button)sender).Text = (sender as Button).Tag.ToString(); // 指派 Tag 值給 Text
                        ((Button)sender).Enabled = false; // 鎖定按扭
                        
                        int x, y;
                        //((Button)sender).BackColor =  Color.Blue;
                        string[] sArray = XY(((Button)sender).Name); // 取得 X , Y 座標用以當周圍無炸彈時遞迴按下周圍八格
                        x = int.Parse(sArray[0]);
                        y = int.Parse(sArray[1]);

                        // 周圍八格觸發按鈕事件
                        // ┌　┬　┬　┐
                        // │１│２│３│
                        // ├　┼　┼　┤
                        // │４│　│６│
                        // ├　┼　┼　┤
                        // │７│８│９│
                        // └　┴　┴　┘
                        if (x - 1 >= 0)　// 4
                        {
                            foreach (Button control in panel1.Controls)
                            {
                                if (control.Name == $"btn[{x - 1},{y}]" && control.Enabled == true)
                                    BombButton_MouseDown(control, e);
                            }
                        }
                        if (x - 1 >= 0 && y - 1 >= 0) // 1
                        {
                            foreach (Button control in panel1.Controls)
                            {
                                if (control.Name == $"btn[{x - 1},{y - 1}]" && control.Enabled == true)
                                    BombButton_MouseDown(control, e);
                            }
                        }                       
                        if (y - 1 >= 0) // 2
                        {
                            foreach (Button control in panel1.Controls)
                            {
                                if (control.Name == $"btn[{x},{y - 1}]" && control.Enabled == true)
                                    BombButton_MouseDown(control, e);
                            }
                        }
                        if (x + 1 <= row - 1 && y - 1 >= 0) // 3
                        {
                            foreach (Button control in panel1.Controls)
                            {
                                if (control.Name == $"btn[{x + 1},{y - 1}]" && control.Enabled == true)
                                    BombButton_MouseDown(control, e);
                            }
                        }
                        if (x + 1 <= row - 1) // 6
                        {
                            foreach (Button control in panel1.Controls)
                            {
                                if (control.Name == $"btn[{x + 1},{y}]" && control.Enabled == true)
                                    BombButton_MouseDown(control, e);
                            }
                        }
                        if (x + 1 <= row - 1 && y + 1 <= col - 1) // 9
                        {
                            foreach (Button control in panel1.Controls)
                            {
                                if (control.Name == $"btn[{x + 1},{y + 1}]" && control.Enabled == true)
                                    BombButton_MouseDown(control, e);
                            }
                        }                       
                        if (y + 1 <= col - 1) // 8
                        {
                            foreach (Button control in panel1.Controls)
                            {
                                if (control.Name == $"btn[{x},{y + 1}]" && control.Enabled == true)
                                    BombButton_MouseDown(control, e);
                            }
                        }                       
                        if (x - 1 >= 0 && y + 1 <= col - 1) // 7
                        {
                            foreach (Button control in panel1.Controls)
                            {
                                if (control.Name == $"btn[{x - 1},{y + 1}]" && control.Enabled == true)
                                    BombButton_MouseDown(control, e);
                            }
                        }
                    }

                    if (((Button)sender).Tag.ToString() != "0") // 沒中雷且不是 0，指派 Tag 值給 Text
                        ((Button)sender).Text = (sender as Button).Tag.ToString();

                    ((Button)sender).Enabled = false; // 鎖定按扭
                    ((Button)sender).BackColor = default;
                    testNumber++;
                    txtTest.Text = testNumber.ToString();
                                       

                    if (testNumber == filedNumber - bombNumber) // 判定是否結束
                    {
                        timer1.Stop();
                        flagTimer = false;

                        foreach (Button control in panel1.Controls) // Button 全開並鎖定
                        {
                            //control.Text = control.Tag.ToString();
                            if (control.Tag.ToString() == "-9")
                            {
                                control.BackgroundImage = bkg;
                                control.BackgroundImageLayout = ImageLayout.Zoom;
                            }
                            control.Enabled = false;
                        }
                        flag = false;
                        btnUntagBomb.Enabled = false;
                        btnTagBomb.Enabled = false;
                        btnClickAll.Enabled = false;
                        FormT05_MineSweeper_Survival fms = new FormT05_MineSweeper_Survival();
                        fms.lblTimer.Text = lblTimer.Text;
                        fms.ShowDialog();
                    }
                }                
                ActiveControl = null; // 跳出 Focus
            }
            else if (e.Button == MouseButtons.Right) // 右鍵標 flag
            {
                if (((Button)sender).Text == "") // 空值才能標 flag
                {
                    if (flagNumber == bombNumber) // 測試標記是否已滿
                    {
                        MessageBox.Show("標雷數已滿");
                        return;
                    }
                    // 標記設定
                    ((Button)sender).Text = "|>";
                    ((Button)sender).BackColor = Color.Yellow;
                    flagNumber++;
                    txtFlag.Text = flagNumber.ToString();
                    txtBombLeft.Text =(int.Parse(txtBombNumber.Text) - flagNumber).ToString();
                }
                else if (((Button)sender).Text == "|>") // 反標記
                {
                    //反標記設定
                    ((Button)sender).Text = "";
                    ((Button)sender).BackColor = Color.Beige;
                    flagNumber--;
                    txtFlag.Text = flagNumber.ToString();
                    txtBombLeft.Text = (int.Parse(txtBombNumber.Text) - flagNumber).ToString();
                }
            }
        }

        private void btnTagBomb_Click(object sender, EventArgs e) // 按鈕：一鍵標雷
        {
            foreach (Button control in panel1.Controls)
            {
                if (control.Text == "|>") // 先清掉自行標記的
                {
                    control.Text = "";
                    control.BackColor = Color.Beige;
                    flagNumber--;
                    txtFlag.Text = flagNumber.ToString();
                    txtBombLeft.Text = (int.Parse(txtBombNumber.Text) - flagNumber).ToString();
                }

                if (control.Tag.ToString() == "-9") // 標記
                {
                    control.Text = "|>";
                    control.BackColor = Color.Yellow;
                    flagNumber++;
                    txtFlag.Text = flagNumber.ToString();
                    txtBombLeft.Text = (int.Parse(txtBombNumber.Text) - flagNumber).ToString();
                }
            }
            btnTagBomb.Enabled = false;
            btnUntagBomb.Enabled = true;
        }

        private void btnUntagBomb_Click(object sender, EventArgs e) // 按鈕：取消標雷
        {
            foreach (Button control in panel1.Controls)
            {
                if (control.Text == "|>")
                {
                    control.Text = "";
                    control.BackColor = Color.Beige;
                    flagNumber--;
                    txtFlag.Text = flagNumber.ToString();
                    txtBombLeft.Text = (int.Parse(txtBombNumber.Text) - flagNumber).ToString();
                }
            }            
            btnTagBomb.Enabled = true;
        }

        private void btnReadme_Click(object sender, EventArgs e) // 按鈕：操作說明
        {
            MessageBox.Show("左鍵：踩雷\n右鍵：標記/取消標記", "操作說明");
        }
        
        private void btnClickAll_Click(object sender, EventArgs e) // 按鈕：一鍵開獎
        {
            if (flagNumber != bombNumber) // 地雷沒標滿不動作
            {
                MessageBox.Show("地雷尚未全部標記。");
                return;
            }

            DialogResult result = MessageBox.Show("是否翻開所有未標記的雷區？\n標記如有誤會引爆地雷！！", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                btnClickAll.Enabled = false;
                //EventArgs繼承自MouseEventArgs,所以可以強轉
                MouseEventArgs Mouse_e = (MouseEventArgs)e;

                foreach (Button control in panel1.Controls)
                {
                    if (control.Text != "|>" && flag == true)
                    {
                        BombButton_MouseDown(control, Mouse_e); // 觸發地雷區的按鈕
                    }
                }
            }            
        }

        private void BombButton_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                lf = false;
            }
            else if (e.Button == MouseButtons.Right)
            {
                rf = false;
            }
        }

        DateTime oldDate = DateTime.Now;
        MouseButtons preButton = MouseButtons.None;
        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
            if ((e.Button == MouseButtons.Left && preButton == MouseButtons.Right)
                || (e.Button == MouseButtons.Right && preButton == MouseButtons.Left))
            {                
                TimeSpan ts = DateTime.Now - oldDate;
                if (ts.TotalMilliseconds < 1000)
                {
                    MessageBox.Show("Both");
                }
            }
            oldDate = DateTime.Now;
            preButton = e.Button;

            //if (e.Button == MouseButtons.Left)
            //{
            //    MessageBox.Show("左鍵");
            //}
            //else if (e.Button == MouseButtons.Right)
            //{
            //    MessageBox.Show("右鍵");
            //}
        }
        // TODO 預設難度、雙鍵功能，一堆垃圾Code
    }
}
