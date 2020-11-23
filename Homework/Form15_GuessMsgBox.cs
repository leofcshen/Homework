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
    public partial class Form15_GuessMsgBox : Form
    {
        public Form15_GuessMsgBox()
        {
            InitializeComponent();
            CenterToScreen();
        }
        private int GuessNumber;
        private int Max = 100;
        private int Min = 0;
        

        private string Resault()
        {
            return $"\nBetween {Min}  and {Max}";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        private bool TransSuccess()
        {
            return int.TryParse(txtNumber.Text, out GuessNumber);
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (TransSuccess() && GuessNumber <= Max && GuessNumber >= Min)
            {
                if (GuessNumber < Class1.ans)
                {
                    Min = GuessNumber;
                    Class1.x.lblRange.Text = "Too Small!!!" + Resault();
                }
                else if (GuessNumber > Class1.ans)
                {
                    Max = GuessNumber;
                    Class1.x.lblRange.Text = "Too Large!!!" + Resault();
                }
                else if (GuessNumber == Class1.ans)
                {
                    MessageBox.Show($"Congradulations!!! You got {Class1.ans}!!!");
                }
            }
            else
            {
                MessageBox.Show($"請輸入{Min}~{Max}之間的數字。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            txtNumber.Focus();
            txtNumber.SelectAll();        
        }
    }
}
