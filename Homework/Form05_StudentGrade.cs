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
    public partial class Form05_StudentGrade : Form
    {        
        public Form05_StudentGrade()
        {
            InitializeComponent();			
		}

		private int ID = 0;		
        private StructGrade[] strGrade = new StructGrade[100];
        private StructStatistics strSta = default(StructStatistics);
        private Random R = new Random();

		internal void MaxAndMin()
		{
			// 方法：計算最高最低分科目
			int max = -1; // 最高分
			int min = 101; // 最低分			

			// 計算最高分
			if (strGrade[ID].CN > max) // 測試國文
			{
				max = strGrade[ID].CN;
				strGrade[ID].MajorMax = "國文" + string.Format("{0,3}", Convert.ToString(strGrade[ID].CN));
			}
			if (strGrade[ID].EN > max) // 測試英文
			{
				max = strGrade[ID].EN;
				strGrade[ID].MajorMax = "英文" + string.Format("{0,3}", Convert.ToString(strGrade[ID].EN));
			}
			if (strGrade[ID].Math > max) // 測試數學
			{
				max = strGrade[ID].Math;
				strGrade[ID].MajorMax = "數學" + string.Format("{0,3}", Convert.ToString(strGrade[ID].Math));
			}

			// 計算最低分
			if (strGrade[ID].CN < min) // 測試國文
			{
				min = strGrade[ID].CN;
				strGrade[ID].MajorMin = "國文" + string.Format("{0,3}", Convert.ToString(strGrade[ID].CN));
			}
			if (strGrade[ID].EN < min) // 測試英文
			{
				min = strGrade[ID].EN;
				strGrade[ID].MajorMin = "英文" + string.Format("{0,3}", Convert.ToString(strGrade[ID].EN));
			}
			if (strGrade[ID].Math < min) // 測試數學
			{
				min = strGrade[ID].Math;
				strGrade[ID].MajorMin = "數學" + string.Format("{0,3}", Convert.ToString(strGrade[ID].Math));
			}
		}

		private void btnAdd_Click(object sender, EventArgs e)
        {
			// 按鈕：加入學生資料
			try
			{
				// 測試資料是否為空
				if (txtName.Text == string.Empty || txtCN.Text == string.Empty || txtEng.Text == string.Empty || txtMath.Text == string.Empty)
				{
					MessageBox.Show("姓名或成績不可為空!!", "警告！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}

				btnTotal.Enabled = true;
				// 指派資料給 strGrade
				strGrade[ID].Name = txtName.Text;
				strGrade[ID].CN = int.Parse(txtCN.Text);
				strGrade[ID].EN = int.Parse(txtEng.Text);
				strGrade[ID].Math = int.Parse(txtMath.Text);
				strGrade[ID].Sum = strGrade[ID].CN + strGrade[ID].EN + strGrade[ID].Math;
				strGrade[ID].Avg = strGrade[ID].Sum / 3;
				// 計算最高最低分科目
				MaxAndMin();

                //lblGrade.Text = lblGrade.Text + string.Format("{0,-10}", strGrade[ID].Name) + string.Format("{0,6}", strGrade[ID].CN) + string.Format("{0,6}", strGrade[ID].EN) + string.Format("{0,6}", strGrade[ID].Math) +
                //    string.Format("{0,6}", strGrade[ID].Sum) + string.Format("{0,8:f1}", strGrade[ID].Avg) + string.Format("{0,8}", strGrade[ID].MajorMin) + string.Format("{0,8}\n", strGrade[ID].MajorMax);
                lblGrade.Text += string.Format("{0,-10}{1,6}{2,6}{3,6}{4,6}{5,8:f1}{6,8}{7,8}\n", 
					strGrade[ID].Name, strGrade[ID].CN, strGrade[ID].EN, strGrade[ID].Math, strGrade[ID].Sum, strGrade[ID].Avg, strGrade[ID].MajorMin, strGrade[ID].MajorMax);

				ID++;
				txtCurrent.Text = ID.ToString();
				txtLeft.Text = (100 - ID).ToString();
				if (ID == 100)
				{
					MessageBox.Show("記憶空間已滿，請先刪除舊有資料。", "警告！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					btnRng.Enabled = false;
				}
			}
			catch (Exception ex)
			{
				Form00_MessageBox.msgError(ex);
			}
		}		

        private void btnRng_Click(object sender, EventArgs e)
        {
            // 按鈕：隨機儲存資料
            try 
			{
				btnTotal.Enabled = true;
				strGrade[ID].Name = "Student" + string.Format("{0:000}", ID + 1);
				strGrade[ID].CN = R.Next(0, 100);
				strGrade[ID].EN = R.Next(0, 100);
				strGrade[ID].Math = R.Next(0, 100);
				strGrade[ID].Sum = strGrade[ID].CN + strGrade[ID].EN + strGrade[ID].Math;
				strGrade[ID].Avg = strGrade[ID].Sum / 3.0;
				MaxAndMin();
				//lblGrade.Text = lblGrade.Text + string.Format("{0,2}", strGrade[ID].Name) + string.Format("{0,6}", strGrade[ID].CN) + string.Format("{0,6}", strGrade[ID].EN) + string.Format("{0,6}", strGrade[ID].Math) +
				//    string.Format("{0,6}", strGrade[ID].Sum) + string.Format("{0,8:f1}", strGrade[ID].Avg) + string.Format("{0,8}", strGrade[ID].MajorMin) + string.Format("{0,8}\n", strGrade[ID].MajorMax);
				lblGrade.Text += string.Format("{0,2}{1,6}{2,6}{3,6}{4,6}{5,8:f1}{6,8}{7,8}\n",
					strGrade[ID].Name, strGrade[ID].CN, strGrade[ID].EN, strGrade[ID].Math, strGrade[ID].Sum, strGrade[ID].Avg, strGrade[ID].MajorMin, strGrade[ID].MajorMax);
				ID++;
				txtCurrent.Text = ID.ToString();
				txtLeft.Text = (100 - ID).ToString();

				if (ID == 100)
				{
					MessageBox.Show("記憶空間已滿，請先刪除舊有資料。", "警告！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					btnAdd.Enabled = false;
				}
			}
			catch (Exception ex)
            {
				Form00_MessageBox.msgError(ex);
            }
		}

        private void btnTotal_Click(object sender, EventArgs e)
        {
			// 按扭：各科統計
			try
            {
				for (int i = 0; i < ID; i++)
				{
					strSta.TCN += strGrade[i].CN;
					strSta.TEN += strGrade[i].EN;
					strSta.TMath += strGrade[i].Math;
				}
				strSta.AvgCN = strSta.TCN / (double)ID;
				strSta.AvgEN = strSta.TEN / (double)ID;
				strSta.AvgMath = strSta.TMath / (double)ID;
				strSta.MinCN = 999;
				strSta.MinEN = 999;
				strSta.MinMath = 999;
				for (int j = 0; j < ID; j++)
				{
					if (strGrade[j].CN > strSta.MaxCN)
					{
						strSta.MaxCN = strGrade[j].CN;
					}
					if (strGrade[j].EN > strSta.MaxEN)
					{
						strSta.MaxEN = strGrade[j].EN;
					}
					if (strGrade[j].Math > strSta.MaxMath)
					{
						strSta.MaxMath = strGrade[j].Math;
					}
					if (strGrade[j].CN < strSta.MinCN)
					{
						strSta.MinCN = strGrade[j].CN;
					}
					if (strGrade[j].EN < strSta.MinEN)
					{
						strSta.MinEN = strGrade[j].EN;
					}
					if (strGrade[j].Math < strSta.MinMath)
					{
						strSta.MinMath = strGrade[j].Math;
					}
				}
				lblCaculate.Text = string.Format("總分{0,8} {1,6}{2,6}\n", strSta.TCN, strSta.TEN, strSta.TMath) + string.Format("平均{0,10:f1} {1,6:f1}{2,6:f1}\n", strSta.AvgCN, strSta.AvgEN, strSta.AvgMath) + string.Format("最高分{0,6}{1,7}{2,6}\n", strSta.MaxCN, strSta.MaxEN, strSta.MaxMath) + string.Format("最低分{0,6}{1,7}{2,6}", strSta.MinCN, strSta.MinEN, strSta.MinMath);
				btnTotal.Enabled = false;
				btnAdd.Enabled = false;
				btnRng.Enabled = false;
				btnReset.Enabled = true;
				btnRngX.Enabled = false;
			}
			catch (Exception ex)
            {
				Form00_MessageBox.msgError(ex);
            }
		}

        private void btnReset_Click(object sender, EventArgs e)
        {
			// 按鈕：各科統計
			try
			{
				for (int i = 0; i < ID; i++)
				{
					strGrade[i].CN = 0;
					strGrade[i].EN = 0;
					strGrade[i].Math = 0;
					strGrade[i].Sum = 0.0;
					strGrade[i].Avg = 0.0;
					strSta.AvgCN = 0.0;
					strSta.AvgEN = 0.0;
					strSta.AvgMath = 0.0;
					strSta.TCN = 0.0;
					strSta.TEN = 0.0;
					strSta.TMath = 0.0;
					strSta.MaxCN = 0;
					strSta.MaxEN = 0;
					strSta.MaxMath = 0;
					strSta.MinCN = 0;
					strSta.MinEN = 0;
					strSta.MinMath = 0;
				}
				ID = 0;
				lblGrade.Text = string.Empty;
				lblCaculate.Text = string.Empty;
				btnAdd.Enabled = true;
				btnRng.Enabled = true;
				btnRngX.Enabled = true;
				btnReset.Enabled = false;
			}
			catch (Exception ex)
            {
				Form00_MessageBox.msgError(ex);
            }
		}

        private void btnRngX_Click(object sender, EventArgs e)
		{
            // 按鈕：隨機加入20筆
            try
            {
				btnTotal.Enabled = true;
				int iD = ID;
				while (ID < iD + 20)
				{
					strGrade[ID].Name = "Student" + string.Format("{0:000}", ID + 1);
					strGrade[ID].CN = R.Next(0, 100);
					strGrade[ID].EN = R.Next(0, 100);
					strGrade[ID].Math = R.Next(0, 100);
					strGrade[ID].Sum = strGrade[ID].CN + strGrade[ID].EN + strGrade[ID].Math;
					strGrade[ID].Avg = strGrade[ID].Sum / 3.0;
					MaxAndMin();
					lblGrade.Text += string.Format("{0,2}{1,6}{2,6}{3,6}{4,6}{5,8:f1}{6,8}{7,8}\n",
					strGrade[ID].Name, strGrade[ID].CN, strGrade[ID].EN, strGrade[ID].Math, strGrade[ID].Sum, strGrade[ID].Avg, strGrade[ID].MajorMin, strGrade[ID].MajorMax);
					ID++;
					txtCurrent.Text = ID.ToString();
					txtLeft.Text = (100 - ID).ToString();
				}
				if (ID == 100)
				{
					MessageBox.Show("記憶空間已滿，請先刪除舊有資料。", "警告！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					btnAdd.Enabled = false;
				}
			}
			catch(Exception ex)
            {
				Form00_MessageBox.msgError(ex);
            }
		}

        private void btnRngX2_Click(object sender, EventArgs e)
        {			
            //按鈕：隨機加入20筆(2)_偷吃步 直接觸發20次隨機單筆
            for (int i = 0; i < 20; i++)
            {
				btnRng_Click(this, e);
				//btnRng.PerformClick(); //另一個寫法
			}
        }
    }
}
