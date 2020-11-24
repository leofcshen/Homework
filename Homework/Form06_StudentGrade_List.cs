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
    public partial class Form06_StudentGrade_List : Form
    {
        public Form06_StudentGrade_List()
        {
            InitializeComponent();
        }
		private List<StructGrade> GradeList = new List<StructGrade>();

		private StructGrade strGrade = default(StructGrade);

		private StructStatistics strSta = default(StructStatistics);
		internal void EnterList() // 方法 Enter
		{
			strGrade.Name = txtName.Text;
			strGrade.CN = int.Parse(txtCN.Text);
			strGrade.EN = int.Parse(txtEng.Text);
			strGrade.Math = int.Parse(txtMath.Text);
			strGrade.Sum = strGrade.CN + strGrade.EN + strGrade.Math;
			strGrade.Avg = strGrade.Sum / 3.0;
		}

		internal void MaxAndMin() // 方法：計算最高最低分
		{
			// 方法：計算最高最低分科目
			int max = -1; // 最高分
			int min = 101; // 最低分			

			// 計算最高分
			if (strGrade.CN > max) // 測試國文
			{
				max = strGrade.CN;
				strGrade.MajorMax = "國文" + string.Format("{0,3}", Convert.ToString(strGrade.CN));
			}
			if (strGrade.EN > max) // 測試英文
			{
				max = strGrade.EN;
				strGrade.MajorMax = "英文" + string.Format("{0,3}", Convert.ToString(strGrade.EN));
			}
			if (strGrade.Math > max) // 測試數學
			{
				max = strGrade.Math;
				strGrade.MajorMax = "數學" + string.Format("{0,3}", Convert.ToString(strGrade.Math));
			}

			// 計算最低分
			if (strGrade.CN < min) // 測試國文
			{
				min = strGrade.CN;
				strGrade.MajorMin = "國文" + string.Format("{0,3}", Convert.ToString(strGrade.CN));
			}
			if (strGrade.EN < min) // 測試英文
			{
				min = strGrade.EN;
				strGrade.MajorMin = "英文" + string.Format("{0,3}", Convert.ToString(strGrade.EN));
			}
			if (strGrade.Math < min) // 測試數學
			{
				min = strGrade.Math;
				strGrade.MajorMin = "數學" + string.Format("{0,3}", Convert.ToString(strGrade.Math));
			}
		}

		internal void ShowGrade() // 方法：顯示 Grade Label
		{
			lblGrade.Text = string.Empty;
			for (int i = 0; i < GradeList.Count; i++)
			{
				Label gradeShowLabel = lblGrade;
				gradeShowLabel.Text = gradeShowLabel.Text + string.Format("{0,-10}{1,6}{2,6}", GradeList[i].Name, GradeList[i].CN, GradeList[i].EN) + string.Format("{0,6}{1,6}{2,6:f1}", GradeList[i].Math, GradeList[i].Sum, GradeList[i].Avg) + string.Format("{0,8}{1,8}\n", GradeList[i].MajorMin, GradeList[i].MajorMax);
				txtCurrent.Text = GradeList.Count.ToString();
			}
		}
		internal void Notify() // 方法：輸入值測試
		{
			if (txtName.Text == string.Empty)
			{
				MessageBox.Show("請輸入姓名。", "警告！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else if (txtCN.Text == string.Empty)
			{
				MessageBox.Show("請輸入國文成績", "警告！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else if (txtEng.Text == string.Empty)
			{
				MessageBox.Show("請輸入英文成績", "警告！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else if (txtMath.Text == string.Empty)
			{
				MessageBox.Show("請輸入數學成績。", "警告！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}
		private void btnAdd_Click(object sender, EventArgs e) // 按鈕：加入學生資料
        {
			btnRemove.Enabled = true;
			btnTotal.Enabled = true;
			btnReset.Enabled = true;
			Notify();
			EnterList();
			MaxAndMin();
			GradeList.Add(strGrade);
			ShowGrade();
		}

        private void btnInsert_Click(object sender, EventArgs e) // 按鈕：插入儲存資料
		{
			btnTotal.Enabled = true;
			btnRemove.Enabled = true;
			Notify();
			EnterList();
			MaxAndMin();
			GradeList.Insert(0, strGrade);
			ShowGrade();
		}

        private void btnRemove_Click(object sender, EventArgs e) // 按鈕：移除資料
        {			
			try
            {
				if (GradeList.Count == 0)
				{
					MessageBox.Show("沒東西了，你再刪我要叫了。");
					return;
				}

				GradeList.RemoveAt(0);
				MaxAndMin();
				ShowGrade();
			}
			catch(Exception ex)
            {
				Form00_MessageBox.msgError(ex);
            }			
		}

        private void btnReset_Click(object sender, EventArgs e) // 按鈕：清除所有資料
		{
			GradeList.Clear();
			ShowGrade();
			lblCaculate.Text = string.Empty;
			btnAdd.Enabled = true;
			btnInsert.Enabled = true;
			btnRemove.Enabled = true;
		}

        private void btnTotal_Click(object sender, EventArgs e) // 按扭：各科統計
		{			
			try
			{
				for (int i = 0; i < GradeList.Count; i++)
				{
					strSta.TCN += GradeList[i].CN;
					strSta.TEN += GradeList[i].EN;
					strSta.TMath += GradeList[i].Math;
				}
				strSta.AvgCN = strSta.TCN / (double)GradeList.Count;
				strSta.AvgEN = strSta.TEN / (double)GradeList.Count;
				strSta.AvgMath = strSta.TMath / (double)GradeList.Count;
				strSta.MinCN = 999;
				strSta.MinEN = 999;
				strSta.MinMath = 999;
				for (int j = 0; j < GradeList.Count; j++)
				{
					if (GradeList[j].CN > strSta.MaxCN)
					{
						strSta.MaxCN = GradeList[j].CN;
					}
					if (GradeList[j].EN > strSta.MaxEN)
					{
						strSta.MaxEN = GradeList[j].EN;
					}
					if (GradeList[j].Math > strSta.MaxMath)
					{
						strSta.MaxMath = GradeList[j].Math;
					}
					if (GradeList[j].CN < strSta.MinCN)
					{
						strSta.MinCN = GradeList[j].CN;
					}
					if (GradeList[j].EN < strSta.MinEN)
					{
						strSta.MinEN = GradeList[j].EN;
					}
					if (GradeList[j].Math < strSta.MinMath)
					{
						strSta.MinMath = GradeList[j].Math;
					}
				}
				lblCaculate.Text = string.Format("總分{0,8} {1,6}{2,6}\n", strSta.TCN, strSta.TEN, strSta.TMath) + string.Format("平均{0,10:f1} {1,6:f1}{2,6:f1}\n", strSta.AvgCN, strSta.AvgEN, strSta.AvgMath) + string.Format("最高分{0,6}{1,7}{2,6}\n", strSta.MaxCN, strSta.MaxEN, strSta.MaxMath) + string.Format("最低分{0,6}{1,7}{2,6}", strSta.MinCN, strSta.MinEN, strSta.MinMath);
				btnTotal.Enabled = false;
				btnAdd.Enabled = false;				
				btnReset.Enabled = true;				
			}
			catch (Exception ex)
			{
				Form00_MessageBox.msgError(ex);
			}
		}

        private void btnSearch_Click(object sender, EventArgs e)  // 按鈕：Search
		{
			try
            {
				int num = int.Parse(textBox1.Text);
				int num2 = int.Parse(textBox2.Text);
				lblGrade.Text = string.Empty;
				for (int i = 0; i < GradeList.Count; i++)
				{
					if (num <= GradeList[i].CN && num2 >= GradeList[i].CN)
					{
						Label gradeShowLabel = lblGrade;
						gradeShowLabel.Text = gradeShowLabel.Text + string.Format("{0,-6}{1,6}{2,6}", GradeList[i].Name, GradeList[i].CN, GradeList[i].EN) + string.Format("{0,6}{1,6}{2,6:N1}", GradeList[i].Math, GradeList[i].Sum, GradeList[i].Avg) + string.Format("{0,6}{1,6}\n", GradeList[i].MajorMin, GradeList[i].MajorMax);
					}
				}
			}
			catch(Exception ex)
            {
				Form00_MessageBox.msgError(ex);
            }
		}
    }
}
