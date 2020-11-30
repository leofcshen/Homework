using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework
{
    static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form_Index());
            //Application.Run(new Form01_Hello());
            //Application.Run(new Form02_Loan());
            //Application.Run(new Form02_Loan_Report());
            //Application.Run(new Form03_POS());
            //Application.Run(new Form04_Grade());
            //Application.Run(new Form05_StudentGrade());
            //Application.Run(new Form06_StudentGrade_List());
            //Application.Run(new Form07_Method());
            //Application.Run(new Form08_Caculator());
            //Application.Run(new Form10_OOXX());
            //Application.Run(new Form11_ScreenSaver());
            //Application.Run(new Form12_Notepad());
            //Application.Run(new Form13_DrawPaint());
            //Application.Run(new Form14_PicViewer());
            //Application.Run(new Form15_GuessNumber());
            //Application.Run(new Form16_Alarm());
            //Application.Run(new Form1());            
        }
    }
}
