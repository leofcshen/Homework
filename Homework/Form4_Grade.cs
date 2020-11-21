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
    public partial class Form4_Grade : Form
    {      
        private StructGrade grade;
        public Form4_Grade()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
			// 儲存資料到 garde
			try
			{
				grade.Name = txtName.Text;
				grade.CN = int.Parse(txtCN.Text);
				grade.EN = int.Parse(txtEng.Text);
				grade.Math = int.Parse(txtMath.Text);
			}
			catch (Exception ex)
            {
				MessageBox.Show($"Error code = {ex.Message}, 請檢查程式碼", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
        }

        private void btnShowSave_Click(object sender, EventArgs e)
        {
			// 顯示  grade 的資料
			try
			{
				lblGrade.Text = $"姓名：{grade.Name}\n" +
					$"國文：{grade.CN}分\n" +
					$"英文：{grade.EN}分\n" +
					$"數學：{grade.Math}分";
			}
			catch (Exception ex)
            {
				MessageBox.Show($"Error code = {ex.Message}, 請檢查程式碼", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
        }

        private void btnMaxMin_Click(object sender, EventArgs e)
        {
			// 點選最高最低分按扭			
			try
			{
				if (lblGrade.Text != "")
				{
					if (grade.CN < 101 & grade.CN > -1 & grade.EN < 101 & grade.EN > -1 & grade.Math < 101 & grade.Math > -1) // 限制 0-100
					{
						// 計算最高分
						if (grade.CN > grade.EN)
						{
							if (grade.CN > grade.Math)
							{
								grade.Max = "國文" + Convert.ToString(grade.CN);
							}
							else
							{
								grade.Max = "數學" + Convert.ToString(grade.Math);
							}
						}
						else if (grade.EN > grade.Math)
						{
							if (grade.EN > grade.CN)
							{
								grade.Max = "英文" + Convert.ToString(grade.EN);
							}
							else
							{
								grade.Max = "國文" + Convert.ToString(grade.CN);
							}
						}
						else if (grade.EN > grade.Math)
						{
							grade.Max = "英文" + Convert.ToString(grade.EN);
						}
						else
						{
							grade.Max = "數學" + Convert.ToString(grade.Math);
						}

						//計算最低分
						if (grade.CN < grade.EN)
						{
							if (grade.CN < grade.Math)
							{
								grade.Min = "國文" + Convert.ToString(grade.CN);
							}
							else
							{
								grade.Min = "數學" + Convert.ToString(grade.Math);
							}
						}
						else if (grade.EN < grade.Math)
						{
							if (grade.EN < grade.CN)
							{
								grade.Min = "英文" + Convert.ToString(grade.EN);
							}
							else
							{
								grade.Min = "國文" + Convert.ToString(grade.CN);
							}
						}
						else if (grade.EN < grade.Math)
						{
							grade.Min = "英文" + Convert.ToString(grade.EN);
						}
						else
						{
							grade.Min = "數學" + Convert.ToString(grade.Math);
						}
						lblMaxMin.Text = "最高科目成績為：" + grade.Max + "分\n最低科目成績為：" + grade.Min + "分";
					}
					else
						MessageBox.Show("分數請輸入 0 - 100。", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
				else
					MessageBox.Show("請先存入資料","Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error code = {ex.Message}, 請檢查程式碼", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

        private void btnMinMax2_Click(object sender, EventArgs e)
        {
			// 點選最高最低分按扭2
			try
			{
				int max = 0; //最高分
				string maxMajor; //最高科目
				int min = 101; //最低分
				string minMajor; //最高科目				

				if (grade.CN < 101 & grade.CN > -1 & grade.EN < 101 & grade.EN > -1 & grade.Math < 101 & grade.Math > -1) // 限制 0-100
				{
					// 計算最高分
					if (grade.CN > max)
					{
						max = grade.CN;
						maxMajor = "國文";
					}
					if (grade.EN > max)
					{
						max = grade.EN;
						maxMajor = "英文";
					}
					if (grade.Math > max)
					{
						max = grade.Math;
						maxMajor = "數學";
					}

					// 計算最低分
					if (grade.CN < min)
					{
						min = grade.CN;
						minMajor = "國文";
					}
					if (grade.EN > min)
					{
						min = grade.EN;
						minMajor = "英文";
					}
					if (grade.Math > min)
					{
						min = grade.Math;
						minMajor = "數學";
					}

					lblMaxMin.Text = "最高科目成績為：" + max + "分\n最低科目成績為：" + min + "分";
				}
				else
					MessageBox.Show("分數請輸入 0 - 100。");
			}
			catch(Exception ex)
            {
				MessageBox.Show($"Error code = {ex.Message}, 請檢查程式碼", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
        }
    }
}
