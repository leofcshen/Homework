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
    public partial class Form04_Grade : Form
    {      
		private StructGrade strGrade; // 宣告 strGrade
		public Form04_Grade()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
			// 按鈕：儲存 (儲存資料到 strGarde)
			try
			{
				// 測試姓名是否輸入且分數是否介於 0 - 100 
				if (txtName.Text !="" & Int32.Parse(txtCN.Text) < 101 & Int32.Parse(txtCN.Text) > -1 & Int32.Parse(txtEN.Text) < 101 & Int32.Parse(txtEN.Text) > -1 & Int32.Parse(txtMath.Text) < 101 & Int32.Parse(txtMath.Text) > -1)
                {
					// 指派資料到 strGrade
					strGrade.Name = txtName.Text;
					strGrade.CN = int.Parse(txtCN.Text);
					strGrade.EN = int.Parse(txtEN.Text);
					strGrade.Math = int.Parse(txtMath.Text);
				}				
				else
					MessageBox.Show("請輸入姓名\r分數必需介於 0 - 100。", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			catch (Exception ex)
            {
				Form00.msgError(ex);
			}
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
			// 按鈕：顯示儲存內容 (輸出 strGrade 的資料到 lblGrade)
			try
			{
				// 測試 strGrade 是否有存入的資料，因已設定所有欄位都有資料才能存入，所以測試一個欄位就好，不用測試四個欄位。
				if (strGrade.Name != null)
                {
					string FmtCN = String.Format("{0,3}", strGrade.CN.ToString());
					string FmtEN = String.Format("{0,3}", strGrade.EN.ToString());
					string FmtMath = String.Format("{0,3}", strGrade.Math.ToString());
					lblGrade.Text = $"姓名：{strGrade.Name}\n" +
					$"國文：{FmtCN} 分\n" +
					$"英文：{FmtEN} 分\n" +
					$"數學：{FmtMath} 分";
				}
				else
					MessageBox.Show("請先存入資料", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			catch (Exception ex)
            {
				Form00.msgError(ex);
			}
        }

        private void btnMaxMin_Click(object sender, EventArgs e)
        {
			// 按鈕：最高分/最低分科目 (輸出最高最低分科目到 lblMinMax)
			try
			{
				// 測試 lblGrade 有沒有資料
				if (lblGrade.Text != "")
				{					
					// 計算最高分
					if (strGrade.CN > strGrade.EN) // 測試國文 > 英文
					{
						if (strGrade.CN > strGrade.Math) // 測試國文 > 數學
						{
							strGrade.MajorMax = "國文 " + String.Format("{0,3}", Convert.ToString(strGrade.CN));
						}
						else
						{
							strGrade.MajorMax = "數學 " + String.Format("{0,3}", Convert.ToString(strGrade.Math));
						}
					}
					else if (strGrade.EN > strGrade.Math) // 測試英文 > 數學
					{
						if (strGrade.EN > strGrade.CN) // 測試英文 > 國文
						{
							strGrade.MajorMax = "英文 " + String.Format("{0,3}", Convert.ToString(strGrade.EN));
						}
						else
						{
							strGrade.MajorMax = "國文 " + String.Format("{0,3}", Convert.ToString(strGrade.CN));
						}
					}
					else 
					{
						strGrade.MajorMax = "數學 " + String.Format("{0,3}", Convert.ToString(strGrade.Math));
					}

					//計算最低分
					if (strGrade.CN < strGrade.EN) // 測試國文 < 英文
					{
						if (strGrade.CN < strGrade.Math) // 測試國文 < 數學
						{
							strGrade.MajorMin = "國文 " + String.Format("{0,3}", Convert.ToString(strGrade.CN));
						}
						else
						{
							strGrade.MajorMin = "數學 " + String.Format("{0,3}", Convert.ToString(strGrade.Math));
						}
					}
					else if (strGrade.EN < strGrade.Math) // 測試英文 < 數學
					{
						if (strGrade.EN < strGrade.CN) // 測試英文 < 國文
						{
							strGrade.MajorMin = "英文 " + String.Format("{0,3}", Convert.ToString(strGrade.EN));
						}
						else
						{
							strGrade.MajorMin = "國文 " + String.Format("{0,3}", Convert.ToString(strGrade.CN));
						}
					}
					else
					{
						strGrade.MajorMin = "數學 " + String.Format("{0,3}", Convert.ToString(strGrade.Math));
					}
					// 輸出到 lblMaxMin
					lblMaxMin.Text = "最高科目成績為：" + strGrade.MajorMax + " 分\n最低科目成績為：" + strGrade.MajorMin + " 分";										
				}
				else
					MessageBox.Show("請先秀出資料","Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			catch (Exception ex)
			{
				Form00.msgError(ex);
			}
		}

        private void btnMinMax2_Click(object sender, EventArgs e)
        {
			// 按鈕：最高分/最低分科目 (2) (輸出最高最低分科目到 lblMinMax)
			try
			{
				int max = -1; // 最高分
				string maxMajor = string.Empty; // 最高分科目
				int min = 101; // 最低分
				string minMajor = string.Empty; // 最低分科目

				// 測試 lblGrade 有沒有資料
				if (lblGrade.Text != "")
				{
					// 計算最高分
					if (strGrade.CN > max) // 測試國文
					{
						max = strGrade.CN;

						maxMajor = "國文";
					}
					if (strGrade.EN > max) // 測試英文
					{
						max = strGrade.EN;
						maxMajor = "英文";
					}
					if (strGrade.Math > max) // 測試數學
					{
						max = strGrade.Math;
						maxMajor = "數學";
					}

					// 計算最低分
					if (strGrade.CN < min) // 測試國文
					{
						min = strGrade.CN;
						minMajor = "國文";
					}
					if (strGrade.EN < min) // 測試英文
					{
						min = strGrade.EN;
						minMajor = "英文";
					}
					if (strGrade.Math < min) // 測試數學
					{
						min = strGrade.Math;
						minMajor = "數學";
					}
					// 輸出到 lblMaxMin
					string strMax = String.Format("{0,3}", max);
					string strMin = String.Format("{0,3}", min);
					//string strMax = max.ToString().PadLeft(3, ' ');
					//string strMin = min.ToString().PadLeft(3, ' ');
					lblMaxMin.Text = $"使用最高/最低分(2)\n最高科目成績為：{maxMajor} {strMax} 分\n最低科目成績為：{minMajor} {strMin} 分";					
				}
				else
					MessageBox.Show("請先秀出資料", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			catch(Exception ex)
            {
				Form00.msgError(ex);
			}
        }

        private void btnMinMax3_Click(object sender, EventArgs e)
        {
			// 按鈕：最高分/最低分科目 (3) (輸出最高最低分科目到 lblMinMax 可測試同分)
			try
			{
				int max = -1; // 最高分
				string maxMajor = string.Empty; // 最高分科目
				int min = 101; // 最低分
				string minMajor = string.Empty; // 最低分科目

				// 測試 lblGrade 有沒有資料
				if (lblGrade.Text != "")
				{
					if ( ! (strGrade.CN == strGrade.EN & strGrade.EN == strGrade.Math)) // 如果(國文 = 英文 且 英文 = 數學)不成立
					{
						// 計算最高分
						if (strGrade.CN > max) // 測試國文
						{
							max = strGrade.CN;
							maxMajor = "國文";
						}

						if (strGrade.EN > max) // 測試英文
						{
							max = strGrade.EN;
							maxMajor = "英文";
						}
						else if (strGrade.EN == max)
                        {
							maxMajor +="英文";
						}

						if (strGrade.Math > max) // 測試數學
						{
							max = strGrade.Math;
							maxMajor = "數學";
						}
						else if (strGrade.Math == max)
						{							
							maxMajor += "數學";
						}

						// 計算最低分
						if (strGrade.CN < min) // 測試國文
						{
							min = strGrade.CN;
							minMajor = "國文";
						}

						if (strGrade.EN < min) // 測試英文
						{
							min = strGrade.EN;
							minMajor = "英文";
						}
						else if (strGrade.EN == min)
						{							
							minMajor += "英文";
						}

						if (strGrade.Math < min) // 測試數學
						{
							min = strGrade.Math;
							minMajor = "數學";
						}
						else if (strGrade.Math == min)
						{							
							minMajor += "數學";
						}

						// 輸出到 lblMaxMin
						string strMax = String.Format("{0,3}", max);
						string strMin = String.Format("{0,3}", min);
						//string strMax = max.ToString().PadLeft(3, ' ');
						//string strMin = min.ToString().PadLeft(3, ' ');
						lblMaxMin.Text = $"使用最高/最低分(3)\n附加測試同分\n\n最高科目成績為：{maxMajor} {strMax} 分\n最低科目成績為：{minMajor} {strMin} 分";
					}
					else
						lblMaxMin.Text = $"使用最高 / 最低分(3)\n附加測試同分\n\n國文英文數學三科同分 { strGrade.CN} 分";					
				}
				else
					MessageBox.Show("請先秀出資料", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			catch (Exception ex)
			{
				Form00.msgError(ex);
			}
		}
    }
}
