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
    public partial class Form_Index : Form
    {
        public Form_Index()
        {
            InitializeComponent();

            // timer 設定一秒時間才會更新，進程式先跳一次當前時間。
            DateTime time = DateTime.Now;
            sslblTimer.Text = String.Format("現在時間 {0:00}:{1:00}:{2:00}", time.Hour, time.Minute, time.Second);

        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            splitContainer3.Panel1.Controls.Clear();
            Form01_Hello fh = new Form01_Hello();
            fh.TopLevel = false;
            splitContainer3.Panel1.Controls.Add(fh);            
            fh.Show();
        }

        private void btnLoan_Click(object sender, EventArgs e)
        {
            splitContainer3.Panel1.Controls.Clear();
            Form02_Loan fl = new Form02_Loan();
            fl.TopLevel = false;
            splitContainer3.Panel1.Controls.Add(fl);
            // 設定預設值
            fl.txtAmount.Text = "100000";
            fl.txtYear.Text = "2";
            fl.txtRate.Text = "10";
            fl.txtDownPayment.Text = "0";

            fl.Show();
        }

        private void btnNote_Click(object sender, EventArgs e)
        {
            // lblHint 不存在時動態產生
            if (splitContainer3.Panel1.Controls.ContainsKey("lblHint") == false)
            {
                splitContainer3.Panel1.Controls.Clear();
                // lblHint 參數
                Label lblHint = new Label();
                lblHint.Font = new Font("Tahoma", 20, FontStyle.Bold);
                lblHint.Name = "lblHint";
                lblHint.Text = "此為動態產生之Label\n" +
                    "動態分隔線控件 > splitcontainer >orientation > 調整垂直或水平\n" +
                    "啟動視窗最大化 > WindowState > Maximize\n" +
                    "跑馬燈新增設定 timer，Enable = ture，Interval 預設 100(數字越大越跑馬燈快)\n" +
                    "功能視窗預設在右下Panel 開啟，開啟前先設定清空panel，不然會開一堆重覆視窗。";
                lblHint.Height = 200;
                lblHint.Width =1200;
                
                splitContainer3.Panel1.Controls.Add(lblHint);
                lblHint.Show();
            }
            else
            {
                // 抓取動態產生的 Label: lblHint，Visible 切換。
                foreach (Control c in splitContainer3.Panel1.Controls)
                {
                    if (c is Label && c.Name == "lblHint" && c.Visible == false)
                    {
                        c.Visible = true; 
                    }
                    else
                    {
                        c.Visible = false;
                    }
                }
            }
        }

        // 跑馬燈設定
        private string bless = "溫馨小祝福：歡迎互相討論再以自己的理解編寫，照抄者祝您廁所都沒衛生紙，手遊抽卡都是 N。~^^   ";
        //private string bless = "test 1234567890~^^   ";
        private void timer1_Tick(object sender, EventArgs e)
        {
            string bless_one = bless.Substring(0, 1);
            bless = bless.Substring(1, bless.Length - 1) + bless_one;  // 新字串從第二個字開始，並把第一個字補到最後
            lblBless.Text = bless;
        }

        private void btnPOS_Click(object sender, EventArgs e)
        {
            splitContainer3.Panel1.Controls.Clear();
            Form03_POS fp = new Form03_POS();
            fp.TopLevel = false;
            splitContainer3.Panel1.Controls.Add(fp);
            fp.Show();
        }
        
        private void tmClock_Tick(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            sslblTimer.Text = String.Format("現在時間 {0:00}:{1:00}:{2:00}", time.Hour, time.Minute, time.Second);
        }

        private void btnGrade_Click(object sender, EventArgs e)
        {
            splitContainer3.Panel1.Controls.Clear();
            Form04_Grade fg = new Form04_Grade();
            fg.TopLevel = false;
            splitContainer3.Panel1.Controls.Add(fg);
            fg.Show();
        }

        private void btnStuGrade_Click(object sender, EventArgs e)
        {
            splitContainer3.Panel1.Controls.Clear();
            Form05_StudentGrade fsg = new Form05_StudentGrade();
            fsg.TopLevel = false;
            splitContainer3.Panel1.Controls.Add(fsg);
            fsg.Show();
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            splitContainer3.Panel1.Controls.Clear();
            Form08_Caculator fc = new Form08_Caculator();
            fc.TopLevel = false;
            splitContainer3.Panel1.Controls.Add(fc);
            fc.Show();
        }

        private void btnXO_Click(object sender, EventArgs e)
        {
            splitContainer3.Panel1.Controls.Clear();
            Form10_OOXX fo = new Form10_OOXX();
            fo.TopLevel = false;
            splitContainer3.Panel1.Controls.Add(fo);
            fo.Show();
        }

        private void btnPicViewer_Click(object sender, EventArgs e)
        {
            splitContainer3.Panel1.Controls.Clear();
            Form14_PicViewer fp = new Form14_PicViewer();
            fp.TopLevel = false;
            splitContainer3.Panel1.Controls.Add(fp);
            fp.Show();
        }

        private void btnGuessNumber_Click(object sender, EventArgs e)
        {
            splitContainer3.Panel1.Controls.Clear();
            Form15_GuessNumber fg = new Form15_GuessNumber();
            fg.TopLevel = false;
            splitContainer3.Panel1.Controls.Add(fg);
            fg.Show();
        }

        private void btnDrawPaint_Click(object sender, EventArgs e)
        {
            splitContainer3.Panel1.Controls.Clear();
            Form13_DrawPaint fd = new Form13_DrawPaint();
            fd.TopLevel = false;
            splitContainer3.Panel1.Controls.Add(fd);
            fd.Show();
        }
    }
}
