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
    public partial class Form5_StudentGrade : Form
    {
        private int ID = 0;
        private StructGrade[] stug0709 = new StructGrade[100];
        private Statistics Sta = default(Statistics);		

        private Random R = new Random();
        public Form5_StudentGrade()
        {
            InitializeComponent();
			lblGrade.Font = new Font("Tahoma",15, FontStyle.Bold);
			lblCaculate.Font = new Font("Tahoma", 15, FontStyle.Bold);
		}

        private void btnAdd_Click(object sender, EventArgs e)
        {
			btnTotal.Enabled = true;
			if (txtName.Text == string.Empty)
			{
				MessageBox.Show("請輸入姓名。", "警告！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			if (txtCN.Text == string.Empty)
			{
				MessageBox.Show("請輸入國文成績", "警告！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			if (txtEng.Text == string.Empty)
			{
				MessageBox.Show("請輸入英文成績", "警告！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			if (txtMath.Text == string.Empty)
			{
				MessageBox.Show("請輸入數學成績。", "警告！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			stug0709[ID].Name = txtName.Text;
			stug0709[ID].CN = int.Parse(txtCN.Text);
			stug0709[ID].EN = int.Parse(txtEng.Text);
			stug0709[ID].Math = int.Parse(txtMath.Text);
			stug0709[ID].Sum = stug0709[ID].CN + stug0709[ID].EN + stug0709[ID].Math;
			stug0709[ID].Avg = stug0709[ID].Sum / 3.0;
			MaxAndMin();
			Label gradeShowLabel = lblGrade;
			gradeShowLabel.Text = gradeShowLabel.Text + string.Format("{0,-6}{1,6}{2,6}", stug0709[ID].Name, stug0709[ID].CN, stug0709[ID].EN) + string.Format("{0,6}{1,6}{2,6:N1}", stug0709[ID].Math, stug0709[ID].Sum, stug0709[ID].Avg) + string.Format("{0,6}{1,6}\n", stug0709[ID].Min, stug0709[ID].Max);
			ID++;
			if (ID == 100)
			{
				MessageBox.Show("記憶空間已滿，請先刪除舊有資料。", "警告！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				btnRng.Enabled = false;
			}
		}
		internal void MaxAndMin()
		{
			if (stug0709[ID].CN > stug0709[ID].EN)
			{
				if (stug0709[ID].CN > stug0709[ID].Math)
				{
					stug0709[ID].Max = "國文" + Convert.ToString(stug0709[ID].CN);
				}
				else
				{
					stug0709[ID].Max = "數學" + Convert.ToString(stug0709[ID].Math);
				}
			}
			else if (stug0709[ID].EN > stug0709[ID].Math)
			{
				if (stug0709[ID].EN > stug0709[ID].CN)
				{
					stug0709[ID].Max = "英文" + Convert.ToString(stug0709[ID].EN);
				}
				else
				{
					stug0709[ID].Max = "國文" + Convert.ToString(stug0709[ID].CN);
				}
			}
			else if (stug0709[ID].EN > stug0709[ID].Math)
			{
				stug0709[ID].Max = "英文" + Convert.ToString(stug0709[ID].EN);
			}
			else
			{
				stug0709[ID].Max = "數學" + Convert.ToString(stug0709[ID].Math);
			}
			if (stug0709[ID].CN < stug0709[ID].EN)
			{
				if (stug0709[ID].CN < stug0709[ID].Math)
				{
					stug0709[ID].Min = "國文" + Convert.ToString(stug0709[ID].CN);
				}
				else
				{
					stug0709[ID].Min = "數學" + Convert.ToString(stug0709[ID].Math);
				}
			}
			else if (stug0709[ID].EN < stug0709[ID].Math)
			{
				if (stug0709[ID].EN < stug0709[ID].CN)
				{
					stug0709[ID].Min = "英文" + Convert.ToString(stug0709[ID].EN);
				}
				else
				{
					stug0709[ID].Min = "國文" + Convert.ToString(stug0709[ID].CN);
				}
			}
			else if (stug0709[ID].EN < stug0709[ID].Math)
			{
				stug0709[ID].Min = "英文" + Convert.ToString(stug0709[ID].EN);
			}
			else
			{
				stug0709[ID].Min = "數學" + Convert.ToString(stug0709[ID].Math);
			}
		}

        private void btnRng_Click(object sender, EventArgs e)
        {
			btnTotal.Enabled = true;
			stug0709[ID].Name = Convert.ToString(ID + 1);
			stug0709[ID].CN = R.Next(0, 100);
			stug0709[ID].EN = R.Next(0, 100);
			stug0709[ID].Math = R.Next(0, 100);
			stug0709[ID].Sum = stug0709[ID].CN + stug0709[ID].EN + stug0709[ID].Math;
			stug0709[ID].Avg = stug0709[ID].Sum / 3.0;
			MaxAndMin();
			Label gradeShowLabel = lblGrade;
			gradeShowLabel.Text = gradeShowLabel.Text + string.Format("{0,-6}{1,6}{2,6}", stug0709[ID].Name, stug0709[ID].CN, stug0709[ID].EN) + string.Format("{0,6}{1,6}{2,8:f1}", stug0709[ID].Math, stug0709[ID].Sum, stug0709[ID].Avg) + string.Format("{0,6}{1,6}\n", stug0709[ID].Min, stug0709[ID].Max);
			ID++;
			if (ID == 100)
			{
				MessageBox.Show("記憶空間已滿，請先刪除舊有資料。", "警告！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				btnAdd.Enabled = false;
			}
		}

        private void btnTotal_Click(object sender, EventArgs e)
        {
			for (int i = 0; i < ID; i++)
			{
				Sta.TtCh += stug0709[i].CN;
				Sta.TtEn += stug0709[i].EN;
				Sta.TtMa += stug0709[i].Math;
			}
			Sta.AVGCh = Sta.TtCh / (double)ID;
			Sta.AVGEn = Sta.TtEn / (double)ID;
			Sta.AVGMa = Sta.TtMa / (double)ID;
			Sta.MINCh = 999;
			Sta.MINEn = 999;
			Sta.MINMa = 999;
			for (int j = 0; j < ID; j++)
			{
				if (stug0709[j].CN > Sta.MAXCh)
				{
					Sta.MAXCh = stug0709[j].CN;
				}
				if (stug0709[j].EN > Sta.MAXEn)
				{
					Sta.MAXEn = stug0709[j].EN;
				}
				if (stug0709[j].Math > Sta.MAXMa)
				{
					Sta.MAXMa = stug0709[j].Math;
				}
				if (stug0709[j].CN < Sta.MINCh)
				{
					Sta.MINCh = stug0709[j].CN;
				}
				if (stug0709[j].EN < Sta.MINEn)
				{
					Sta.MINEn = stug0709[j].EN;
				}
				if (stug0709[j].Math < Sta.MINMa)
				{
					Sta.MINMa = stug0709[j].Math;
				}
			}
			lblCaculate.Text = string.Format("總分{0,8} {1,6}{2,6}\n", Sta.TtCh, Sta.TtEn, Sta.TtMa) + string.Format("平均{0,8:N1} {1,6:N1}{2,6:N1}\n", Sta.AVGCh, Sta.AVGEn, Sta.AVGMa) + string.Format("最高分{0,6}{1,6}{2,6}\n", Sta.MAXCh, Sta.MAXEn, Sta.MAXMa) + string.Format("最低分{0,6}{1,6}{2,6}", Sta.MINCh, Sta.MINEn, Sta.MINMa);
			btnTotal.Enabled = false;
			btnAdd.Enabled = false;
			btnRng.Enabled = false;
			btnRngX.Enabled = false;
		}

        private void btnReset_Click(object sender, EventArgs e)
        {
			for (int i = 0; i < ID; i++)
			{
				stug0709[i].CN = 0;
				stug0709[i].EN = 0;
				stug0709[i].Math = 0;
				stug0709[i].Sum = 0.0;
				stug0709[i].Avg = 0.0;
				Sta.AVGCh = 0.0;
				Sta.AVGEn = 0.0;
				Sta.AVGMa = 0.0;
				Sta.TtCh = 0.0;
				Sta.TtEn = 0.0;
				Sta.TtMa = 0.0;
				Sta.MAXCh = 0;
				Sta.MAXEn = 0;
				Sta.MAXMa = 0;
				Sta.MINCh = 0;
				Sta.MINEn = 0;
				Sta.MINMa = 0;
			}
			ID = 0;
			lblGrade.Text = string.Empty;
			lblCaculate.Text = string.Empty;
			btnAdd.Enabled = true;
			btnRng.Enabled = true;
			btnRngX.Enabled = true;
		}

        private void btnRngX_Click(object sender, EventArgs e)
        {
			btnTotal.Enabled = true;
			int iD = ID;
			while (ID < iD + 20)
			{
				stug0709[ID].Name = Convert.ToString(ID + 1);
				stug0709[ID].CN = R.Next(0, 100);
				stug0709[ID].EN = R.Next(0, 100);
				stug0709[ID].Math = R.Next(0, 100);
				stug0709[ID].Sum = stug0709[ID].CN + stug0709[ID].EN + stug0709[ID].Math;
				stug0709[ID].Avg = stug0709[ID].Sum / 3.0;
				MaxAndMin();
				Label gradeShowLabel = lblGrade;
				gradeShowLabel.Text = gradeShowLabel.Text + string.Format("{0,-6}{1,6}{2,6}", stug0709[ID].Name, stug0709[ID].CN, stug0709[ID].EN) + string.Format("{0,6}{1,6}{2,8:f1}", stug0709[ID].Math, stug0709[ID].Sum, stug0709[ID].Avg) + string.Format("{0,6}{1,6}\n", stug0709[ID].Min, stug0709[ID].Max);
				ID++;
			}
			if (ID == 100)
			{
				MessageBox.Show("記憶空間已滿，請先刪除舊有資料。", "警告！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				btnAdd.Enabled = false;
			}
		}
    }
}
