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
    public partial class Form16_Alarm : Form
    {
        private Form_Index fd;
        public Form16_Alarm(Form_Index form1)
        {
            fd = form1;
            InitializeComponent();
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
                //gpbDTP.BackColor = SystemColors.Control; 
            }
            else
            {
                BackColor = Color.Black;
                //gpbDTP.BackColor = SystemColors.Control;
            }
            flag = !flag;
         }

        private void timer1_Tick(object sender, EventArgs e) // 鬧鐘時間比對
        {
            // MTB 比對
            NowTime = DateTime.Now.ToString("hh時mm分ss秒");
            if (AlarmTimeMTB == NowTime)
            {
                timer2.Enabled = true;
            }
            else
            {
                timer2.Enabled = false;
            }
            // DTP 比對
            NowTime1 = DateTime.Now.ToString("hh:mm:ss");
            if (AlarmTimeDTP == NowTime1)
            {
                timer2.Enabled = true;
                MessageBox.Show(timer2.Enabled.ToString());
            }
            else
            {
                timer2.Enabled = false;
            }
        }

        private void ckbSetAlarm_CheckedChanged(object sender, EventArgs e) // 勾選：變更
        {
            if(!flagCKB) // 勾選就設定鬧鐘，反之復原
            {
                AlarmTimeMTB = maskedTextBox1.MaskedTextProvider.ToString();
                gpbMTB.BackColor = Color.Red;
                lblMTB.Text = "鬧鐘已設定" + AlarmTimeMTB;                
            }
            else
            {
                AlarmTimeMTB = "";
                gpbMTB.BackColor = SystemColors.Control;
                lblMTB.Text = "鬧鐘未設定";
            }
            flagCKB = !flagCKB;
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            maskedTextBox1.Focus();
            maskedTextBox1.SelectAll();
        }

        private void btnDTP_Click(object sender, EventArgs e) // 按鈕：設定DTP鬧鐘
        {
            AlarmTimeDTP = dateTimePicker1.Text;
            gpbDTP.BackColor = Color.Red;
            lblDTP.Text = "鬧鐘已設定" + AlarmTimeDTP;
        }

        private void btnCancelDTP_Click(object sender, EventArgs e) // 按鈕：取消DTP鬧鐘
        {
            AlarmTimeDTP = "";
            gpbDTP.BackColor = SystemColors.Control;
            lblDTP.Text = "鬧鐘未設定";
        }
    }
}
