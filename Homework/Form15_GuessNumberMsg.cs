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
    public partial class Form15_GuessNumberMsg : Form
    {
        public Form15_GuessNumberMsg()
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
                if (GuessNumber < ClassDataPass.answer)
                {
                    Min = GuessNumber;
                    ClassDataPass.fg.lblRange.Text = "Too Small!!!" + Resault();
                }
                else if (GuessNumber > ClassDataPass.answer)
                {
                    Max = GuessNumber;
                    ClassDataPass.fg.lblRange.Text = "Too Large!!!" + Resault();
                }
                else if (GuessNumber == ClassDataPass.answer)
                {
                    MessageBox.Show($"Congradulations!!! You got {ClassDataPass.answer}!!!");
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
