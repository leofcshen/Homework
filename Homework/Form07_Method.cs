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
    public partial class Form07_Method : Form
    {
        public Form07_Method()
        {
            InitializeComponent();
        }

		private int[] array = new int[10]
	{
		1,
		5,
		6,
		8,
		7,
		97,
		54,
		887,
		65,
		578
	};

		private string[] array_Str = new string[8]
		{
		"mother張",
		"emma",
		"迪克蕭",
		"J40",
		"Candy",
		"Cindy",
		"Coconut",
		"Motherfacker"
		};

		private int[,] grid0711 = new int[10, 10];
		private static void OddOrEven(int num, out string oddeven)
		{
			string text = "";
			oddeven = string.Format(arg1: (num % 2 != 0) ? " 奇數" : " 偶數", format: "輸入的數 {0}為 {1}。", arg0: num);
		}

		private static void OdOrEnCount(int[] array, out int odcount, out int encount)
		{
			odcount = 0;
			encount = 0;
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] % 2 == 0)
				{
					encount++;
				}
				else
				{
					odcount++;
				}
			}
		}

		private static void arrayMaxMin(int[] array, out int arrMax, out int arrMin)
		{
			arrMax = array[0];
			arrMin = array[array.Length - 1];
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] > arrMax)
				{
					arrMax = array[i];
				}
				if (array[i] < arrMin)
				{
					arrMin = array[i];
				}
			}
		}

		private static void arrayStrLongest(string[] array, out string longestname)
		{
			longestname = array[0];
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i].Length > longestname.Length)
				{
					longestname = array[i];
				}
			}
		}

		private static void os1ins0(ref int[,] grid, out string gridstring)
		{
			gridstring = "";
			for (int i = 0; i < grid.GetLength(0); i++)
			{
				for (int j = 0; j < grid.GetLength(1); j++)
				{
					if (i == 0 || i == grid.GetLength(0) - 1 || j == 0 || j == grid.GetLength(1) - 1)
					{
						gridstring += string.Format("{0,2} ", grid[i, j] = 1);
					}
					else
					{
						gridstring += string.Format("{0,2} ", grid[i, j] = 0);
					}
				}
				gridstring += "\n ";
			}
		}

		private static void os0ins1(ref int[,] grid, out string gridstring)
		{
			gridstring = "";
			for (int i = 0; i < grid.GetLength(0); i++)
			{
				for (int j = 0; j < grid.GetLength(1); j++)
				{
					if (i == 0 || i == grid.GetLength(0) - 1 || j == 0 || j == grid.GetLength(1) - 1)
					{
						gridstring += string.Format("{0,2} ", grid[i, j] = 0);
					}
					else
					{
						gridstring += string.Format("{0,2} ", grid[i, j] = 1);
					}
				}
				gridstring += "\n ";
			}
		}

		private static void o10s10(ref int[,] grid, out string gridstring)
		{
			gridstring = "";
			for (int i = 0; i < grid.GetLength(0); i++)
			{
				for (int j = 0; j < grid.GetLength(1); j++)
				{
					if (i % 2 == 0)
					{
						if (j % 2 == 0)
						{
							gridstring += string.Format("{0,2} ", grid[i, j] = 1);
						}
						else
						{
							gridstring += string.Format("{0,2} ", grid[i, j] = 0);
						}
					}
					else if (j % 2 == 0)
					{
						gridstring += string.Format("{0,2} ", grid[i, j] = 0);
					}
					else
					{
						gridstring += string.Format("{0,2} ", grid[i, j] = 1);
					}
				}
				gridstring += "\n ";
			}
		}

		private static void swaparr(ref int x, ref int y)
		{
			int num = x;
			x = y;
			y = num;
		}

		private static void sumarr(int[] array, out int arrSum)
		{
			arrSum = 0;
			for (int i = 0; i < array.Length; i++)
			{
				arrSum += array[i];
			}
		}

		private static void maxarr(int[] array, out int arrMax)
		{
			arrMax = array[0];
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] > arrMax)
				{
					arrMax = array[i];
				}
			}
		}

		private static void minarr(int[] array, out int arrMin)
		{
			arrMin = array[array.Length - 1];
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] < arrMin)
				{
					arrMin = array[i];
				}
			}
		}

        private void button1_Click(object sender, EventArgs e)
        {
			if (int.TryParse(txtNumber.Text, out var result))
			{
				OddOrEven(result, out var oddeven);
				lblShowResult.Text = oddeven;
			}
			else
			{
				MessageBox.Show("請輸入數值");
			}
		}

        private void button4_Click(object sender, EventArgs e)
        {
			lblShowResult.Text = "結果";
		}

        private void button5_Click(object sender, EventArgs e)
        {
			OdOrEnCount(array, out var odcount, out var encount);
			lblShowResult.Text = "int陣列array[ 1,5, 6, 8, 7, 97, 54, 887, 65, 578]\n" + $"奇數共 {odcount}\n偶數共 {encount}";
		}

        private void button2_Click(object sender, EventArgs e)
        {
			arrayMaxMin(array, out var arrMax, out var arrMin);
			lblShowResult.Text = "int陣列array[ 1,5, 6, 8, 7, 97, 54, 887, 65, 578]\n" + $"最大值為 {arrMax}\n最小值為 {arrMin}";
		}

        private void button6_Click(object sender, EventArgs e)
        {
			arrayStrLongest(array_Str, out var longestname);
			lblShowResult.Text = "陣列array_Str [ mother張,emma,迪克蕭,J40]\n最長的名字為" + longestname;
		}

        private void button7_Click(object sender, EventArgs e)
        {
			string gridstring = "";
			os1ins0(ref grid0711, out gridstring);
			lblShowResult.Text = gridstring;
		}

        private void button8_Click(object sender, EventArgs e)
        {
			string gridstring = "";
			os0ins1(ref grid0711, out gridstring);
			lblShowResult.Text = gridstring;
		}

        private void button9_Click(object sender, EventArgs e)
        {
			string gridstring = "";
			o10s10(ref grid0711, out gridstring);
			lblShowResult.Text = gridstring;
		}

        private void button10_Click(object sender, EventArgs e)
        {
			int x = 100;
			int y = 200;
			lblShowResult.Text = $"換位前n1={x} , n2={y}";
			swaparr(ref x, ref y);
			lblShowResult.Text += $"\n換位後n1={x} , n2={y}";
		}

        private void button11_Click(object sender, EventArgs e)
        {
			sumarr(array, out var arrSum);
			lblShowResult.Text = "int陣列array[ 1,5, 6, 8, 7, 97, 54, 887, 65, 578]\n" + $"加總為 {arrSum}";
		}

        private void button12_Click(object sender, EventArgs e)
        {
			maxarr(array, out var arrMax);
			lblShowResult.Text = "int陣列array[ 1,5, 6, 8, 7, 97, 54, 887, 65, 578]\n" + $"最大值為 {arrMax}";
		}

        private void button13_Click(object sender, EventArgs e)
        {
			minarr(array, out var arrMin);
			lblShowResult.Text = "int陣列array[ 1,5, 6, 8, 7, 97, 54, 887, 65, 578]\n" + $"最小值為 {arrMin}";
		}

        private void button3_Click(object sender, EventArgs e)
        {
			int num = 0;
			lblShowResult.Text = "array_Str陣列：";
			for (int i = 0; i < array_Str.Length; i++)
			{
				Label label = lblShowResult;
				label.Text = label.Text + "    " + array_Str[i];
				if (array_Str[i].IndexOf("C") != -1 || array_Str[i].IndexOf("c") != -1)
				{
					num++;
				}
			}
			lblShowResult.Text += $"\n有C 及 c的名字共有 {num} 個";
		}
    }
}
