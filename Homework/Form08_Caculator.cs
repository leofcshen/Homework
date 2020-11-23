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
    public partial class Form08_Caculator : Form
    {
		private double number1;
		private double number2;
		
		public Form08_Caculator()
        {
            InitializeComponent();
        }

		// 方法：加法
		private static double Add(double N1, double N2)
		{
			return N1 + N2;
		}

		// 方法：減法
		private static double Minus(double N1, double N2)
		{
			return N1 - N2;
		}

		// 方法：乘法
		private static double Multiply(double N1, double N2)
		{
			return N1 * N2;
		}

		// 方法：除法
		private static double Divided(double N1, double N2)
		{
			return N1 / N2;
		}

		// 方法：空值回傳訊息
		private static void msg()
        {			
			MessageBox.Show("數值不可為空。", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

		// 按下
		private void btnPlus_Click(object sender, EventArgs e)
        {
			try
            {
				if (double.TryParse(txtNum1.Text, out double number1) && double.TryParse(txtNum2.Text, out number2))
				{
					txtAnswer.Text = $" {Add(number1, number2)}";
					lblEquation.Text = $" {number1} + {number2} = {Add(number1, number2)}";
				}
				else
				{
					msg();
				}
			}
			catch (Exception ex)
            {
				Form00_MessageBox.msgError(ex);
            }
		}

        private void btnMinus_Click(object sender, EventArgs e)
        {
			try
			{
				if (double.TryParse(txtNum1.Text, out number1) && double.TryParse(txtNum2.Text, out number2))
				{
					txtAnswer.Text = $" {Minus(number1, number2)}";
					lblEquation.Text = $" {number1} - {number2} = {Minus(number1, number2)}";
				}
				else
				{
					msg();
				}
			}
			catch (Exception ex)
			{
				Form00_MessageBox.msgError(ex);
			}
		}

        private void btnMultiply_Click(object sender, EventArgs e)
        {
			try
			{
				if (double.TryParse(txtNum1.Text, out number1) && double.TryParse(txtNum2.Text, out number2))
				{
					txtAnswer.Text = $" {Multiply(number1, number2)}";
					lblEquation.Text = $" {number1} - {number2} = {Multiply(number1, number2)}";
				}
				else
				{
					msg();
				}
			}
			catch (Exception ex)
			{
				Form00_MessageBox.msgError(ex);
			}
		}

        private void btnDivided_Click(object sender, EventArgs e)
        {
			try
			{
				if (double.TryParse(txtNum1.Text, out number1) && double.TryParse(txtNum2.Text, out number2))
				{
					txtAnswer.Text = $" {Divided(number1, number2):f4}";
					lblEquation.Text = $" {number1} / {number2} = {Divided(number1, number2):f4}";
				}
				else
				{
					msg();
				}
			}
			catch (Exception ex)
			{
				Form00_MessageBox.msgError(ex);
			}
		}
    }
}
