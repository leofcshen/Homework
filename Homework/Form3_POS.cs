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
    public partial class Form3_POS : Form
    {		
		private  int APrize = 120; // A品項價格
		private  int BPrize = 180; // B品項價格
		private  int CPrize = 350; // C品項價格
		private  int DPrize = 320; // D品項價格		
		private int AA = 0; // A品項數量
		private int BA = 0; // B品項數量
		private int CA = 0; // C品項數量
		private int DA = 0; // D品項數量
		private string AL; // A品項清單
		private string BL; // B品項清單
		private string CL; // C品項清單
		private string DL; // D品項清單
		private int Total = 0; // 總金額
		public Form3_POS()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
			// 清除清單
			try
			{
				lblList.Text = "尚未點餐";
				Total = 0;
				lblTotal.Text = "NT$ " + Total;
				AA = 0;
				BA = 0;
				CA = 0;
				DA = 0;
				//AL = string.Empty;
				//BL = string.Empty;
				//CL = string.Empty;
				//DL = string.Empty;
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error code = {ex.Message}, 請檢查程式碼", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

        private void btnMenu1_Click(object sender, EventArgs e)
        {
			// 點選 A 菜單
			try
			{
				AA++;
				Total += 120;
				lblTotal.Text = "NT$ " + Total;
				if (AA > 0)
				{
					AL = "3D油飯 x" + AA + ",共NT$ " + AA * APrize + " 元\n";
				}
				else
				{
					AL = string.Empty;
				}
				lblList.Text = AL + BL + CL + DL;
			}
			catch (Exception ex)
            {
				MessageBox.Show($"Error code = {ex.Message}, 請檢查程式碼", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

        private void btnMenu2_Click(object sender, EventArgs e)
        {
			// 點選 B 菜單
			try
			{
				BA++;
				Total += 180;
				lblTotal.Text = "NT$ " + Total;
				if (BA > 0)
				{
					BL = "南部粽 x" + BA + ",共NT$ " + BA * BPrize + " 元\n";
				}
				else
				{
					BL = string.Empty;
				}
				lblList.Text = AL + BL + CL + DL;
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error code = {ex.Message}, 請檢查程式碼", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

        private void btnMenu3_Click(object sender, EventArgs e)
        {
			// 點選 C 菜單
			try
			{
				CA++;
				Total += 350;
				lblTotal.Text = "NT$ " + Total;
				if (CA > 0)
				{
					CL = "中部粽 x" + CA + ",共NT$ " + CA * CPrize + " 元\n";
				}
				else
				{
					CL = string.Empty;
				}
				lblList.Text = AL + BL + CL + DL;
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error code = {ex.Message}, 請檢查程式碼", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

        private void btnmenu4_Click(object sender, EventArgs e)
        {
			// 點選 D 菜單
			try
			{
				DA++;
				Total += 320;
				lblTotal.Text = "NT$ " + Total;
				if (DA > 0)
				{
					DL = "海景第一排 x" + DA + ",共NT$ " + DA * DPrize + " 元\n";
				}
				else
				{
					DL = string.Empty;
				}
				lblList.Text = AL + BL + CL + DL;
			}
			catch (Exception ex)
            {
				MessageBox.Show($"Error code = {ex.Message}, 請檢查程式碼", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

        private void btnCash_Click(object sender, EventArgs e)
        {
			// 點選現金結帳
			try
			{
				if (Total < 1)
				{
					MessageBox.Show("尚未點餐！", "確認付款", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
				else
				{
					MessageBox.Show("總金額：NT$" + Total, "確認付款", MessageBoxButtons.OKCancel);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error code = {ex.Message}, 請檢查程式碼", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}		
		}

        private void btnCredit_Click(object sender, EventArgs e)
        {
			// 點選信用卡結帳
			try
            {
				if (Total < 1)
				{
					MessageBox.Show("尚未點餐！", "確認付款", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}
				MessageBox.Show("總金額：NT$ " + Total + "\n折扣後金額：NT$ " + (double)Total * 0.9, "確認付款", MessageBoxButtons.OKCancel);
			}
			catch (Exception ex)
            {
				MessageBox.Show($"Error code = {ex.Message}, 請檢查程式碼", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
    }
}
