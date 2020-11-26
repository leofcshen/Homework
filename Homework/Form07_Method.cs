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
		private Random R = new Random();

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
					if (i == 0 || i == grid.GetLength(0) - 1 || j == 0 || j == grid.GetLength(1) - 1) // 邊界判定 [ i =0 || i = i 維度長度, j =0 || j = j 的維度長度] 
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
					if (i == 0 || i == grid.GetLength(0) - 1 || j == 0 || j == grid.GetLength(1) - 1) // 邊界判定 [ i =0 || i = i 維度長度, j =0 || j = j 的維度長度] 
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

		private static void swap(ref int x, ref int y) // 方法 Swap
		{
			int num = x;
			x = y;
			y = num;
		}
		private static void swap2(ref int x, ref int y) // 方法 Swap 2
		{
			x = x * y;
			y = x / y;
			x = x / y;
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
		private static int SumFor(int from, int to, int step) // 方法：總和 For
		{
			int num = 0;
		   for(int i = from; i <= to; i+=step)
			{
				num += from;
				from += step;
			}
			return num;
		}

		private static int SumWhile(int from, int to, int step) // 方法：總和 While
		{
			int num = 0;
			while (from <= to)
			{
				num += from;
				from += step;
			}
			return num;
		}

		private static int SumDo(int from, int to, int step)  // 方法：總和 Do 
		{
			int num = 0;
			do
			{
				num += from;
				from += step;
			}
			while (from <= to);
			return num;
		}

		private static string SingleSideTree(int rows) //方法：直角聖誕樹
		{
			string text = "";
			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < rows; j++)
				{
					text = ((j > i) ? (text + " ") : (text + "*"));
				}
				text += "\n";
			}
			return text;
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
			swap(ref x, ref y);
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

            for (int i = 0; i < arrayStr.Length; i++) // 比對字元
            {               
                lblShowResult.Text = lblShowResult.Text + "    " + arrayStr[i];
                if (arrayStr[i].IndexOf("C") != -1 || arrayStr[i].IndexOf("c") != -1)
                {
                    num++;
                }
            }

            lblShowResult.Text = $"陣列arrayStr [ {arrayList}]\n有C 及 c的名字共有 {num} 個";			
		}

        private void button14_Click(object sender, EventArgs e) // 按鈕：Swap(2)
        {
			int x = 100;
			int y = 200;
			lblShowResult.Text = $"使用方法2：不建立新的變數\n\n換位前n1={x} , n2={y}";
			swap2(ref x, ref y);
			lblShowResult.Text += $"\n換位後n1={x} , n2={y}";
			lblShowResult.Text += $"\n\nx = x * y ;\ny = x / y ;\nx = x / y ;";
		}

        private void button18_Click(object sender, EventArgs e) // 按鈕：直角聖誕樹
        {
			if (int.TryParse(txtRow.Text, out var result))
			{
				lblShowResult.Text = SingleSideTree(result);
				return;
			}
			MessageBox.Show("請輸入數值");
			txtRow.Focus();
			txtRow.SelectAll();
		}

        private void button20_Click(object sender, EventArgs e) // 按鈕：100的二進位
        {
			if(int.TryParse(txtBinary.Text,out int number))
            {
				lblShowResult.Text = "";
				while (number / 2 > 0)
				{
					lblShowResult.Text = number % 2 + lblShowResult.Text;
					number /= 2;
				}
				if (number / 2 == 0)
				{
					lblShowResult.Text = number + lblShowResult.Text;
				}
				return;
			}
			MessageBox.Show("請確認數值");
			txtBinary.Focus();
			txtBinary.SelectAll();
		}

        private void button21_Click(object sender, EventArgs e) // 按鈕：樂透號碼
        {
            int[] array = new int[6];
            lblShowResult.Text = "樂透號碼\n";
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = R.Next(1, 50); // R.Next(1, 49) 不會產生 49
                for (int j = 0; j < i; j++)
                {
                    while (array[j] == array[i]) // 檢查重覆
                    {
                        array[i] = R.Next(1, 50);
                        j = 0;
                    }
                }
                lblShowResult.Text += $"{array[i]} ";
            }
        }

        private void button19_Click(object sender, EventArgs e) // 按鈕：九九乘法表
        {
			lblShowResult.Text = "九九乘法表\n";
			for (int i = 1; i <= 9; i++)
			{
				for (int j = 2; j <= 9; j++)
				{
					lblShowResult.Text += string.Format("{0,2}x{1,2}={2,2}|", j, i, j * i);
				}
				lblShowResult.Text += "\n";
			}
		}

        private void button15_Click(object sender, EventArgs e) // 按鈕：For
        {
			if (int.TryParse(txtFrom.Text, out var from) && int.TryParse(txtTo.Text, out var to) && int.TryParse(txtStep.Text, out var step))
			{
				lblShowResult.Text = $"{from} 到 {to} 相隔 {step - 1}\nFor 迴圈加總為 {SumFor(from, to, step)}";
			}
			else
			{
				MessageBox.Show("請檢查數值");
				txtFrom.Focus();
				txtFrom.SelectAll();
			}
		}

        private void button16_Click(object sender, EventArgs e) // 按扭：While
        {
			if (int.TryParse(txtFrom.Text, out var from) && int.TryParse(txtTo.Text, out var to) && int.TryParse(txtStep.Text, out var step))
			{
				lblShowResult.Text = $"{from} 到 {to} 相隔 {step - 1}\nWhile 迴圈加總為 {SumWhile(from, to, step)}";
			}
			else
			{
				MessageBox.Show("請檢查數值");
				txtFrom.Focus();
				txtFrom.SelectAll();
			}
		}

        private void button17_Click(object sender, EventArgs e) // 按扭：Do
		{
			if (int.TryParse(txtFrom.Text, out var from) && int.TryParse(txtTo.Text, out var to) && int.TryParse(txtStep.Text, out var step))
			{
				lblShowResult.Text = $"{from} 到 {to} 相隔 {step - 1}\nDo 迴圈加總為 {SumDo(from, to, step)}";
			}
			else
			{
				MessageBox.Show("請檢查數值");
				txtFrom.Focus();
				txtFrom.SelectAll();
		}
		}

		private void button22_Click(object sender, EventArgs e) // 按鈕：樂透號碼不重覆2
		{
			List<int> numberList = new List<int>();
			for (int i = 0; i < 6; i++) // 產生6個數
			{
				int number = R.Next(1, 50);
				for (int j =0; j < numberList.Count; j++) // 檢查重覆
					if (number == numberList[j])
                    {
						//MessageBox.Show("亂數第"+ i +" 個數 "+number.ToString() + "已存在於第 " + (j+1) + "個數，重新亂數。");
						number = R.Next(1, 50);
						j = 0;
					}
				numberList.Add(number);
			}
			lblShowResult.Text = "樂透號碼(方法2)\n";
			foreach (int r in numberList)
			{
				lblShowResult.Text += r + " ";
			}			
		}
    }
}
