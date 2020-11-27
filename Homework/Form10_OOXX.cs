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
	public partial class Form10_OOXX : Form
	{
		public Form10_OOXX()
		{
			InitializeComponent();

			foreach (Button control in panel1.Controls)
			{
				control.BackColor = Color.Beige;
				control.Text = "";
				control.Click += OOXXButton_Click;
			}
		}
		private bool turnOver = true;

		private void btnEsc_Click(object sender, EventArgs e) // 按鈕：Esc
		{
			Close();
		}

		private void btnReset_Click(object sender, EventArgs e) // 按鈕：Reset
		{
			reset();
		}

		private void reset() // 方法：Reset
		{
			foreach (Button control in panel1.Controls)
			{				
				control.Text = "";
				control.Enabled = true;
			}
			lblPlayer.Text = "比賽開始\nX 方回合";
			turnOver = true;
		}

		private void OOXXButton_Click(object sender, EventArgs e) // 按鈕：標記 OX
		{
			if (turnOver)
			{
				((Button)sender).Text = "X";
				lblPlayer.Text = "O 方回合";
			}
			else
			{
				((Button)sender).Text = "O";
				lblPlayer.Text = "X 方回合";
			}
			turnOver = !turnOver;
			((Button)sender).Enabled = false;
			// 判斷 8條連線是否達成
			// ┌　┬　┬　┐      直：123、456、789
			// │１│２│３│      橫：147、258、369
			// ├　┼　┼　┤      Ｘ：159、357
			// │４│５│６│
			// ├　┼　┼　┤
			// │７│８│９│
			// └　┴　┴　┘   
			if (button1.Text != "" && button2.Text != "" && button3.Text != "" && button1.Text == button2.Text && button2.Text == button3.Text)
			{
				MessageBox.Show(button1.Text + " 方獲勝!", "遊戲結束!");
				reset();
			}
			else if (button4.Text != "" && button5.Text != "" && button6.Text != "" && button4.Text == button5.Text && button5.Text == button6.Text)
			{
				MessageBox.Show(button4.Text + " 方獲勝!", "遊戲結束!");
				reset();
			}
			else if (button7.Text != "" && button8.Text != "" && button9.Text != "" && button7.Text == button8.Text && button8.Text == button9.Text)
			{
				MessageBox.Show(button7.Text + " 方獲勝!", "遊戲結束!");
				reset();
			}
			else if (button1.Text != "" && button4.Text != "" && button7.Text != "" && button1.Text == button4.Text && button4.Text == button7.Text)
			{
				MessageBox.Show(button1.Text + " 方獲勝!", "遊戲結束!");
				reset();
			}
			else if (button2.Text != "" && button5.Text != "" && button8.Text != "" && button2.Text == button5.Text && button5.Text == button8.Text)
			{
				MessageBox.Show(button2.Text + " 方獲勝!", "遊戲結束!");
				reset();
			}
			else if (button3.Text != "" && button6.Text != "" && button9.Text != "" && button3.Text == button6.Text && button6.Text == button9.Text)
			{
				MessageBox.Show(button3.Text + " 方獲勝!", "遊戲結束!");
				reset();
			}
			else if (button1.Text != "" && button5.Text != "" && button9.Text != "" && button1.Text == button5.Text && button5.Text == button9.Text)
			{
				MessageBox.Show(button1.Text + " 方獲勝!", "遊戲結束!");
				reset();
			}
			else if (button3.Text != "" && button5.Text != "" && button7.Text != "" && button3.Text == button5.Text && button5.Text == button7.Text)
			{
				MessageBox.Show(button3.Text + " 方獲勝!", "遊戲結束!");
				reset();
			}
			else if (button1.Text != "" && button2.Text != "" && button3.Text != "" && button4.Text != "" && button5.Text != "" && button6.Text != "" && button7.Text != "" && button8.Text != "" && button9.Text != "")
			{
				MessageBox.Show("平手! 按下確定重新開始", "遊戲結束");
				reset();
			}
            ActiveControl = null; // 跳出 Focus
		}

		private void Form10_OOXX_KeyDown(object sender, KeyEventArgs e) // 鍵盤事件
		{
			// 鍵盤功能：R
			if (e.KeyCode == Keys.R)
			{
				btnReset_Click(this, e);
			}
			// 鍵盤功能：Esc
			if (e.KeyCode == Keys.Escape)
			{
				btnEsc_Click(this, e);
			}
		}
	}
}
