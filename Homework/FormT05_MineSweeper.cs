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
            MessageBox.Show("左鍵：踩雷\n右鍵：標記/取消標記", "操作說明");
        }
        
        int filedNumber = 0; // 雷區數
        int testNumber = 0; // 踩雷數
        int flagNumber = 0; // 標雷數
        int row = 0;
        int col = 0;
        int bombNumber = 0;
        string level = "";
        bool flag = true;

        private void btnNewGame_Click(object sender, EventArgs e) // 按扭：開新遊戲
        {
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
                    buttons[i, j].Size = new Size(30, 30);
                    buttons[i, j].Name = $"btn[{i},{j}]";
                    buttons[i, j].Location = new Point(30 + 30 * i, 30 + 30 * j);
                    buttons[i, j].BackColor = Color.Beige;
                    //buttons[i, j].Text = g.the雷區[i, j].ToString();
                    buttons[i, j].Tag = g.the雷區[i, j].ToString();
                    panel1.Controls.Add(buttons[i, j]);
                }
            }
            foreach (Button control in panel1.Controls)
            {
                control.MouseDown += BombButton_MouseDown;
            }
            filedNumber = row * col;
        }        
        
        private void BombButton_MouseDown(object sender, MouseEventArgs e) // 按鈕：地雷區
        {
            if (e.Button == MouseButtons.Left) // 左鍵踩雷
            {
                if (((Button)sender).Text == "|>") // 標記不能踩
                    return;

                if (((Button)sender).Tag.ToString() == "-9") // 中雷
                {
                    flag = false;
                    btnUntagBomb.Enabled = false;
                    btnTagBomb.Enabled = false;
                    
                    foreach (Button control in panel1.Controls) // Button 全開並鎖定
                    {
                        control.Text = control.Tag.ToString();
                        if (control.Text == "-9")
                            control.BackColor = Color.Red;
                        control.Enabled = false;
                    }
                    FormT05_MineSweeper_Die fmd = new FormT05_MineSweeper_Die();
                    fmd.ShowDialog();
                }
                else
                {
                    if (((Button)sender).Tag.ToString() == "0") // 沒中雷是0
                    {
                        ((Button)sender).BackColor = Color.Blue;
                    }

                    ((Button)sender).Text = (sender as Button).Tag.ToString(); // 指派 Tag 值給 Text
                    ((Button)sender).Enabled = false; // 鎖定按扭
                    testNumber++;
                    txtTest.Text = testNumber.ToString();

                    if (testNumber == filedNumber - bombNumber) // 判定是否結束
                    {
                        flag = false;
                        btnUntagBomb.Enabled = false;
                        btnTagBomb.Enabled = false;
                        FormT05_MineSweeper_Survival fms = new FormT05_MineSweeper_Survival();
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

        // TODO 預設難度、0的按鈕開啟
    }
}
