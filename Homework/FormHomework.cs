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
    public partial class FormHomework : Form
    {
        public FormHomework()
        {
            InitializeComponent();
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear(); 
            Form1_Hello fh = new Form1_Hello();
            fh.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(fh);
            fh.Show();
        }

        private void btnNote_Click(object sender, EventArgs e)
        {
            if (lblHint.Visible == false)
            {
                lblHint.Visible = true;
            }
           else
            {
                lblHint.Visible = false;
            }
        }

        // 跑馬燈設定
        //private string bless = "溫馨小祝福：歡迎互相討論再以自己的理解編寫，照抄者祝您廁所都沒衛生紙，手遊抽卡都是 N。~^^               ";
        //private void timer1_Tick(object sender, EventArgs e)
        //{            
        //    string bless_one = bless.Substring(0, 1);
        //    bless = bless.Substring(1, bless.Length - 1) + bless_one;  // 新字串從第二個字開始，並把第一個字補到最後
        //    stslbl.Text = bless;
        //}

        private void btnLoan_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Form2_Loan fl = new Form2_Loan();
            fl.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(fl);
            fl.Show();
        }
    }
}
