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
				control.Click += XOGameButton_Click;
			}
		}
		private bool turnOver = true;

		private void btnEsc_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnReset_Click(object sender, EventArgs e)
		{
			reset();
		}

		private void reset()
		{
			foreach (Button control in panel1.Controls)
			{
				control.Text = "";
				control.Enabled = true;
			}
			lblPlayer.Text = "比賽開始\nX 方回合";
			turnOver = true;
		}

		private void XOGameButton_Click(object sender, EventArgs e)
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
			// 判斷是否獲勝
			if (button1.Text != "" && button2.Text != "" && button3.Text != "" && button1.Text == button2.Text && button2.Text == button3.Text)
			{
				MessageBox.Show(button1.Text + " 方獲勝!", "遊戲結束!");
				reset();
			}
			else if (button1.Text != "" && button4.Text != "" && button7.Text != "" && button1.Text == button4.Text && button4.Text == button7.Text)
			{
				MessageBox.Show(button1.Text + " 方獲勝!", "遊戲結束!");
				reset();
			}
			else if (button1.Text != "" && button5.Text != "" && button9.Text != "" && button1.Text == button5.Text && button5.Text == button9.Text)
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
		}

		private void Form10_OOXX_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.R)
			{
				this.btnReset_Click(this, e);
			}
		}
	}
}
