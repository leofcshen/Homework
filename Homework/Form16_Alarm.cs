﻿using System;
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
    public partial class Form16_Alarm : Form
    {
        private Form_Index fd;
        public Form16_Alarm(Form_Index form1)
        {
            fd = form1;
            InitializeComponent();
            mtbTime.Text = DateTime.Now.ToString("hh時mm分ss秒");
        }
        private bool flag = false;
        private bool flagCKB = false;       
        private string AlarmTimeDTP;
        private string AlarmTimeMTB;
        private string NowTime;
        private string NowTime1;
                
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (flag)
            {                
                BackColor = Color.Red;                
            }
            else
            {
                BackColor = Color.Black;                
            }
            flag = !flag;
         }

        private void timer1_Tick(object sender, EventArgs e) // 鬧鐘時間比對
        {
            if (flagCKB) // MTB 比對
            {                
                NowTime = DateTime.Now.ToString("hh時mm分ss秒");
                if (AlarmTimeMTB == NowTime)
                {
                    timer2.Enabled = true;
                }
                else
                {
                    timer2.Enabled = false;
                }
            }
            else
            {
                // DTP 比對
                NowTime1 = DateTime.Now.ToString("hh:mm:ss");
                if (AlarmTimeDTP == NowTime1)
                {
                    timer2.Enabled = true;
                }
                else
                {
                    timer2.Enabled = false;
                }
            }
        }

        private void ckbSetAlarm_CheckedChanged(object sender, EventArgs e) // 勾選：變更
        {
            if(!flagCKB) // 勾選就設定鬧鐘，反之復原
            {
                AlarmTimeMTB = mtbTime.MaskedTextProvider.ToString();
                gpbMTB.BackColor = Color.Red;
                lblMTB.Text = "鬧鐘已設定" + AlarmTimeMTB;
                btnDTP.Enabled = false;
            }
            else
            {
                AlarmTimeMTB = "";
                gpbMTB.BackColor = SystemColors.Control;
                lblMTB.Text = "鬧鐘未設定";
                BackColor = DefaultBackColor;
                btnDTP.Enabled = true;
            }
            flagCKB = !flagCKB;
        }

        private void maskedTextBox1_Click(object sender, EventArgs e)
        {
            mtbTime.Focus();
        }
        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            mtbTime.Focus();
            mtbTime.SelectAll();
        }

        private void btnDTP_Click(object sender, EventArgs e) // 按鈕：設定DTP鬧鐘
        {
            AlarmTimeDTP = dateTimePicker1.Text;
            gpbDTP.BackColor = Color.Red;
            lblDTP.Text = "鬧鐘已設定" + AlarmTimeDTP;
            ckbSetAlarm.Enabled = false;
        }

        private void btnCancelDTP_Click(object sender, EventArgs e) // 按鈕：取消DTP鬧鐘
        {
            AlarmTimeDTP = "";
            gpbDTP.BackColor = SystemColors.Control;
            lblDTP.Text = "鬧鐘未設定";
            BackColor = DefaultBackColor;
            ckbSetAlarm.Enabled = true;
        }
    }
}
