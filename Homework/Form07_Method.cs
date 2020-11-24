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

		private int[] arrayInt = new int[10]
		{
			1, 5, 6, 8, 7, 97, 54, 887, 65, 578
		};		
        private string[] arrayStr = new string[8]
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
		private int[,] grid= new int[10, 10];
		
		private static void OddEven(int number, out string oddeven) // 方法：判定奇偶
		{			
			oddeven = $"輸入的數 {number} 為 {((number % 2 != 0) ? "奇數" : "偶數")}。";
			//oddeven = string.Format(arg1: (number % 2 != 0) ? " 奇數" : " 偶數", format: "輸入的數 {0}為 {1}。", arg0: number);
		}

		private static void OdEvenCount(int[] arrayInt, out int oddCount, out int evenCount) // 方法：判定奇偶數量
		{
			oddCount = 0;
			evenCount = 0;
			for (int i = 0; i < arrayInt.Length; i++)
			{
				if (arrayInt[i] % 2 == 0)
				{
					evenCount++;
				}
				else
				{
					oddCount++;
				}
			}
		}

		private static void arrayMaxMin(int[] array, out int arrMax, out int arrMin) // 方法：判定 Array 最大最小
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

		private static void arrayStrLongest(string[] array, out string longest) // 方法：判定 Array 最長字
		{			
			longest = array[0];
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i].Length > longest.Length)
				{
					longest = array[i];
				}
			}
		}

		private static void o1i0(ref int[,] grid, out string gridstring) // 方法：生成陣列 1 包圍 0
		{			
			gridstring = "";
			for (int i = 0; i < grid.GetLength(0); i++)
			{
				for (int j = 0; j < grid.GetLength(1); j++)
				{
					if (i == 0 || i == grid.GetLength(0) - 1 || j == 0 || j == grid.GetLength(1) - 1)
					{
						gridstring += string.Format("{0,0} ", grid[i, j] = 1);
					}
					
					else
					{
						gridstring += string.Format("{0,0} ", grid[i, j] = 0);
					}
				}
				gridstring += "\n";	
			}			
		}

		private static void o0i1(ref int[,] grid, out string gridstring) // 方法：生成陣列 0 包圍 1
		{
			gridstring = "";
			for (int i = 0; i < grid.GetLength(0); i++)
			{
				for (int j = 0; j < grid.GetLength(1); j++)
				{
					if (i == 0 || i == grid.GetLength(0) - 1 || j == 0 || j == grid.GetLength(1) - 1)
					{
						gridstring += string.Format("{0,0} ", grid[i, j] = 0);
					}
					else
					{
						gridstring += string.Format("{0,0} ", grid[i, j] = 1);
					}
				}
				gridstring += "\n";
			}
		}

		private static void o10s10(ref int[,] grid, out string gridstring) // 方法：生成陣列 1 0 交錯
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
							gridstring += string.Format("{0,0} ", grid[i, j] = 1);
						}
						else
						{
							gridstring += string.Format("{0,0} ", grid[i, j] = 0);
						}
					}
					else if (j % 2 == 0)
					{
						gridstring += string.Format("{0,0} ", grid[i, j] = 0);
					}
					else
					{
						gridstring += string.Format("{0,0} ", grid[i, j] = 1);
					}
				}
				gridstring += "\n";
			}
		}

		private static void swaparr(ref int x, ref int y) // 方法 Swap
		{
			int num = x;
			x = y;
			y = num;
		}

		private static void sumarr(int[] array, out int arrSum) // 方法：Array 總和
		{
			arrSum = 0;
			for (int i = 0; i < array.Length; i++)
			{
				arrSum += array[i];
			}
		}

		private static void maxarr(int[] array, out int arrMax) // 方法：Array 最大值
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

		private static void minarr(int[] array, out int arrMin) // 方法：Array 最小值
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

        private void button1_Click(object sender, EventArgs e) // 按鈕：判定奇偶
        {
			if (int.TryParse(txtNumber.Text, out var result))
			{
				OddEven(result, out var oddeven);
				lblShowResult.Text = oddeven;
			}
			else
			{
				MessageBox.Show("請輸入數值");
			}
		}

        private void button4_Click(object sender, EventArgs e) // 按鈕：清空結果
        {
			lblShowResult.Text = "";
		}

        private void button5_Click(object sender, EventArgs e) // 按鈕：統計奇偶
        {
			string arrayList = "";
			OdEvenCount(arrayInt, out var odcount, out var encount);
			for (int i =0; i < arrayInt.Length; i++)
				arrayList += arrayInt[i].ToString() + " ";
            lblShowResult.Text = $"int陣列arrayInt [ {arrayList}]\n奇數共 {odcount}\n偶數共 {encount}";
		}

        private void button2_Click(object sender, EventArgs e) // 按鈕：最大/最小值
		{
			string arrayList = "";
			arrayMaxMin(arrayInt, out var arrMax, out var arrMin);
			for (int i = 0; i < arrayInt.Length; i++)
				arrayList += arrayInt[i].ToString() + " ";
            lblShowResult.Text = $"int陣列arrayInt [ {arrayList}]\n最大值為 {arrMax}\n最小值為 {arrMin}";
		}

        private void button6_Click(object sender, EventArgs e) // 按鈕：最長字
		{
			string arrayList = "";
			arrayStrLongest(arrayStr, out var longest);
			for (int i = 0; i < arrayStr.Length; i++)
				arrayList += arrayStr[i] + " ";
			lblShowResult.Text = $"陣列arrayStr [ {arrayList}]\n最長的名字為" + longest;
		}

        private void button7_Click(object sender, EventArgs e) // 按鈕：邊1內0
		{
			string gridstring = "";
			o1i0(ref grid, out gridstring);
			lblShowResult.Text = gridstring;
		}

        private void button8_Click(object sender, EventArgs e) // 按鈕：邊0內1
		{
			string gridstring = "";
			o0i1(ref grid, out gridstring);
			lblShowResult.Text = gridstring;
		}

        private void button9_Click(object sender, EventArgs e) // 按鈕：01交錯
		{
			string gridstring = "";
			o10s10(ref grid, out gridstring);
			lblShowResult.Text = gridstring;
		}

        private void button10_Click(object sender, EventArgs e) // 按鈕：SWAP
		{
			int x = 100;
			int y = 200;
			lblShowResult.Text = $"換位前n1={x} , n2={y}";
			swaparr(ref x, ref y);
			lblShowResult.Text += $"\n換位後n1={x} , n2={y}";
		}

        private void button11_Click(object sender, EventArgs e)  // 按鈕：陣列總和
		{
			string arrayList = "";			
			for (int i = 0; i < arrayInt.Length; i++)
				arrayList += arrayInt[i].ToString() + " ";			
			sumarr(arrayInt, out var arrSum);
			lblShowResult.Text = $"int陣列arrayInt [ {arrayList}]\n加總為 {arrSum}";
		}

        private void button12_Click(object sender, EventArgs e) // 按鈕：陣列最大值
		{
			string arrayList = "";
			for (int i = 0; i < arrayInt.Length; i++)
				arrayList += arrayInt[i].ToString() + " ";
			maxarr(arrayInt, out var arrMax);
            lblShowResult.Text = $"int陣列arrayInt [ {arrayList}]\n" + $"最大值為 {arrMax}";
		}

        private void button13_Click(object sender, EventArgs e) // 按鈕：陣列最小值
		{
			string arrayList = "";
			for (int i = 0; i < arrayInt.Length; i++)
				arrayList += arrayInt[i].ToString() + " ";
			minarr(arrayInt, out var arrMin);
			lblShowResult.Text = $"int陣列arrayInt [ {arrayList}]\n最小值為 {arrMin}";
		}

        private void button3_Click(object sender, EventArgs e) // 按鈕：陣列Cc統計
		{
			int num = 0;
			
			string arrayList = "";
			for (int i = 0; i < arrayStr.Length; i++)
				arrayList += arrayStr[i].ToString() + " ";

            for (int i = 0; i < arrayStr.Length; i++)
            {
                Label label = lblShowResult;
                label.Text = label.Text + "    " + arrayStr[i];
                if (arrayStr[i].IndexOf("C") != -1 || arrayStr[i].IndexOf("c") != -1)
                {
                    num++;
                }
            }

            lblShowResult.Text = $"陣列arrayStr [ {arrayList}]\n有C 及 c的名字共有 {num} 個";			
		}
    }
}
