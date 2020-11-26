using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
        private bool faOpen = false;
        private bool Mode = true;

        // 跑馬燈設定
        private string bless = "溫馨小祝福：歡迎互相討論再以自己的理解編寫才會進步，一味照抄者祝您廁所都沒衛生紙，手遊抽卡都是 N。~^^   ";
        //private string bless = "test 1234567890~^^   ";
        private void timer1_Tick(object sender, EventArgs e) // 跑馬燈 Tick
        {
            string bless_one = bless.Substring(0, 1);
            bless = bless.Substring(1, bless.Length - 1) + bless_one;  // 新字串從第二個字開始，並把第一個字補到最後
            lblBless.Text = bless;
        }
        private void tmClock_Tick(object sender, EventArgs e) // 時間 Tick
        {
            DateTime time = DateTime.Now;
            sslblTimer.Text = String.Format("現在時間 {0:00}:{1:00}:{2:00}", time.Hour, time.Minute, time.Second);

            foreach (Form f in splitContainer3.Panel1.Controls) //尋找 Form16 的 Label 設定時間
            {
                foreach (Control c in f.Controls)
                {
                    if (c is Label && c.Name == "lblTimer")
                        c.Text = String.Format("現在時間 {0:00}:{1:00}:{2:00}", time.Hour, time.Minute, time.Second);
                }
            }
        }

        private void btnTest_Click(object sender, EventArgs e) // 按鈕：切換模式
        {
            splitContainer3.Panel1.Controls.Clear();
            if (Mode)
            {
                btnMode.Text = "Function Mode";
                btnHello.Visible = false;
                btnLoan.Visible = false;
                btnPOS.Visible = false;
                btnStructForm.Visible = false;
                btnGrade.Visible = false;
                btnGrade_List.Visible = false;
                btnMethod.Visible = false;
                btnCal.Visible = false;
                btnForDoWhile.Visible = false;
                btnOOXX.Visible = false;
                btnScreenSaver.Visible = false;
                btnNotepad.Visible = false;
                btnDrawPaint.Visible = false;
                btnPicViewer.Visible = false;
                btnGuessNumber.Visible = false;
                btnAlarm.Visible = false;
                btnNoteTest.Visible = false;                

                btnNoteTest.Visible = true;
                btnConsole.Visible = true;
                btnDataCross.Visible = true;
            }
            else
            {
                btnMode.Text = "Test Mode";
                btnHello.Visible = true;
                btnLoan.Visible = true;
                btnPOS.Visible = true;
                btnStructForm.Visible = true;
                btnGrade.Visible = true;
                btnGrade_List.Visible = true;
                btnMethod.Visible = true;
                btnCal.Visible = true;
                btnForDoWhile.Visible = true;
                btnOOXX.Visible = true;
                btnScreenSaver.Visible = true;
                btnNotepad.Visible = true;
                btnDrawPaint.Visible = true;
                btnPicViewer.Visible = true;
                btnGuessNumber.Visible = true;
                btnAlarm.Visible = true;
                btnNoteTest.Visible = true;

                btnNoteTest.Visible = false;
                btnConsole.Visible = false;
                btnDataCross.Visible = false;
            }
            Mode = !Mode;
        }

        private void btnHello_Click(object sender, EventArgs e) // 按鈕：Hello
        {
            splitContainer3.Panel1.Controls.Clear();
            Form01_Hello fh = new Form01_Hello();
            fh.TopLevel = false;
            splitContainer3.Panel1.Controls.Add(fh);            
            fh.Show();
        }

        private void btnLoan_Click(object sender, EventArgs e) // 按鈕：Loan
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

        private void btnPOS_Click(object sender, EventArgs e) // 按鈕：POS
        {
            splitContainer3.Panel1.Controls.Clear();
            Form03_POS fp = new Form03_POS();
            fp.TopLevel = false;
            splitContainer3.Panel1.Controls.Add(fp);
            fp.Show();
        }        

        private void btnGrade_Click(object sender, EventArgs e) // 按鈕：StructForm
        {
            splitContainer3.Panel1.Controls.Clear();
            Form04_Grade fg = new Form04_Grade();
            fg.TopLevel = false;
            splitContainer3.Panel1.Controls.Add(fg);
            fg.Show();
        }

        private void btnStuGrade_Click(object sender, EventArgs e) // 按鈕：Grade
        {
            splitContainer3.Panel1.Controls.Clear();
            Form05_StudentGrade fsg = new Form05_StudentGrade();
            fsg.TopLevel = false;
            splitContainer3.Panel1.Controls.Add(fsg);
            fsg.Show();
        }

        private void btnStudenGradeList_Click(object sender, EventArgs e) // 按鈕：Grade_List
        {
            splitContainer3.Panel1.Controls.Clear();
            Form06_StudentGrade_List fsl = new Form06_StudentGrade_List();
            fsl.TopLevel = false;
            splitContainer3.Panel1.Controls.Add(fsl);
            fsl.Show();
        }

        private void btnMethod_Click(object sender, EventArgs e) // 按鈕：Method
        {
            splitContainer3.Panel1.Controls.Clear();
            Form07_Method fm = new Form07_Method();
            fm.TopLevel = false;
            splitContainer3.Panel1.Controls.Add(fm);
            fm.Show();
        }

        private void btnCal_Click(object sender, EventArgs e) // 按鈕：Caculator
        {
            splitContainer3.Panel1.Controls.Clear();
            Form08_Caculator fc = new Form08_Caculator();
            fc.TopLevel = false;
            splitContainer3.Panel1.Controls.Add(fc);
            fc.Show();
        }

        private void button1_Click(object sender, EventArgs e) // 按鈕：For Do While
        {
            splitContainer3.Panel1.Controls.Clear();
            Form07_Method fm = new Form07_Method();
            fm.TopLevel = false;
            splitContainer3.Panel1.Controls.Add(fm);
            fm.Show();
        }

        private void btnXO_Click(object sender, EventArgs e) // 按鈕：OOXX
        {
            splitContainer3.Panel1.Controls.Clear();
            Form10_OOXX fo = new Form10_OOXX();
            fo.TopLevel = false;
            splitContainer3.Panel1.Controls.Add(fo);
            fo.Show();
        }

        private void btnScreenSaver_Click(object sender, EventArgs e) // 按鈕：Screen Saver
        {
            splitContainer3.Panel1.Controls.Clear();
            Form11_ScreenSaver fs = new Form11_ScreenSaver();
            fs.Show();
        }

        private void btnNotepad_Click(object sender, EventArgs e) // 按鈕：Notepad
        {
            //splitContainer3.Panel1.Controls.Clear();
            //Form12_Notepad fn = new Form12_Notepad();
            //fn.TopLevel = false;
            //splitContainer3.Panel1.Controls.Add(fn);
            //fn.Show();
            MessageBox.Show("施工中");
        }

        private void btnDrawPaint_Click(object sender, EventArgs e) // 按鈕：小畫家
        {
            splitContainer3.Panel1.Controls.Clear();
            Form13_DrawPaint fd = new Form13_DrawPaint();
            fd.TopLevel = false;
            splitContainer3.Panel1.Controls.Add(fd);
            fd.Show();
        }

        private void btnPicViewer_Click(object sender, EventArgs e) //按鈕：Picture Viewer
        {
            splitContainer3.Panel1.Controls.Clear();
            Form14_PicViewer fp = new Form14_PicViewer();
            fp.TopLevel = false;
            splitContainer3.Panel1.Controls.Add(fp);
            fp.Show();
        }

        private void btnGuessNumber_Click(object sender, EventArgs e) // 按鈕：終極密碼
        {
            splitContainer3.Panel1.Controls.Clear();
            Form15_GuessNumber fg = new Form15_GuessNumber();
            fg.TopLevel = false;
            splitContainer3.Panel1.Controls.Add(fg);
            fg.Show();
        }
        
        private void btnAlarm_Click(object sender, EventArgs e) // 按鈕：Alarm
        {
            splitContainer3.Panel1.Controls.Clear();
            Form16_Alarm fa = new Form16_Alarm(this);
            fa.TopLevel = false;
            splitContainer3.Panel1.Controls.Add(fa);
            fa.Show();
            faOpen = true;
        }

        private void btnNote_Click(object sender, EventArgs e) // 按扭：顯示說明
        {
            splitContainer3.Panel1.Controls.Clear();
            Form17_Note fn = new Form17_Note();
            fn.TopLevel = false;
            splitContainer3.Panel1.Controls.Add(fn);
            fn.Show();

            Label lblHint = new Label();
            lblHint.Font = new Font("Tahoma", 20, FontStyle.Bold);
            lblHint.Name = "lblHint";
            lblHint.Text = "此為動態產生之Label\n" +
                "動態分隔線控件 > splitcontainer >orientation > 調整垂直或水平\n" +
                "啟動視窗最大化 > WindowState > Maximize\n" +
                "跑馬燈新增設定 timer，Enable = ture，Interval 預設 100(數字越大越跑馬燈快)\n" +
                "功能視窗預設在右下Panel 開啟，開啟前先設定清空panel，不然會開一堆重覆視窗。\n" +
                "Random.Next(number1, number2) 是 number1 <= 隨機數 < number2，要注意number2 是否需要加1。";
            lblHint.Height = 200;
            lblHint.Width = 1200;
            fn.Controls.Add(lblHint);
        }
       
        private void btnTNote_Click(object sender, EventArgs e) // 測試按鈕：顯示說明
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
                lblHint.Width = 1200;

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

        private void btnDataCross_Click(object sender, EventArgs e)
        {
            splitContainer3.Panel1.Controls.Clear();
            FormT03_DataCrossForm fd = new FormT03_DataCrossForm();
            fd.TopLevel = false;
            splitContainer3.Panel1.Controls.Add(fd);
            fd.Show();
        }

        [DllImport("kernel32.dll")]
        static extern bool FreeConsole();
        [DllImport("kernel32.dll")]
        public static extern bool AllocConsole();
        private void btnConsole_Click(object sender, EventArgs e) // 測試按鈕：Console
        {
            AllocConsole();
            ConsoleColor oriColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("* Don't close this console window or the application will also close.");
            Console.WriteLine();
            Console.ForegroundColor = oriColor;

            //for (int i = 1; i < 10; i++)
            //{
            //    for (int j = 2; j < 6; j++)
            //    {
            //        Console.Write(j + "*" + i + "=" + (j * i).ToString("00") + "  ");
            //    }
            //    Console.Write("\n");
            //}
            //Console.WriteLine("\r");

            //for (int i = 1; i < 10; i++)
            //{
            //    for (int j = 6; j < 10; j++)
            //    {
            //        Console.Write(j + "*" + i + "=" + (j * i).ToString("00") + "  ");
            //    }
            //    Console.Write("\n");
            //}
            //Console.ReadLine();

            Random R = new Random();
            for (int i =1; i < 1000; i++)
            {
                int j = R.Next(1, 50);
                if (j==49)
                    Console.WriteLine(j);
            }
            

        }        
    }
}
