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
            //Application.Run(new Form1_Hello());            
            //Application.Run(new Form2_Loan());
            //Application.Run(new Form2_LoanReport());
            //Application.Run(new Form3_POS());
            //Application.Run(new Form4_Grade());
            //Application.Run(new Form5_StudentGrade());
            //Application.Run(new Form8_Caculator());
        }
    }
}
