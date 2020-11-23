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
    public partial class Form03_POS : Form
    {		
		public Form03_POS()
        {
            InitializeComponent();
        }

		private int APrize = 120; // A品項價格
		private int BPrize = 180; // B品項價格
		private int CPrize = 350; // C品項價格
		private int DPrize = 320; // D品項價格		
		private int AA = 0; // A品項數量
		private int BA = 0; // B品項數量
		private int CA = 0; // C品項數量
		private int DA = 0; // D品項數量
		private string AL; // A品項數量金額清單
		private string BL; // B品項數量金額清單
		private string CL; // C品項數量金額清單
		private string DL; // D品項數量金額清單
		private int Total = 0; // 總金額

		private void btnMenuA_Click(object sender, EventArgs e)
        {
			// 按鈕：A 菜單
			try
			{
				AA++; // 數量 + 1
				Total += 120; // 累加總金額
				lblTotal.Text = "NT$ " + Total; // 秀出總金額

				 // 設定品項數量金額清單
				AL = String.Format("{0,11}", "3D油飯 x ") + String.Format("{0,3}", AA) + ",共NT$ " + String.Format("{0,5}", APrize * AA) + " 元\n";
				
				lblList.Text = AL + BL + CL + DL; // 加總所有品項清單並秀出
			}
			catch (Exception ex)
            {
				Form00_MessageBox.msgError(ex);
			}
		}

        private void btnMenuB_Click(object sender, EventArgs e)
        {
			// 按鈕：B 菜單
			try
			{
				BA++; // 數量 + 1
				Total += 180; // 累加總金額
				lblTotal.Text = "NT$ " + Total; // 秀出總金額

				// 設定品項數量金額清單
				BL = String.Format("{0,10}", "南部粽 x ") + String.Format("{0,3}", BA) + ",共NT$ " + String.Format("{0,5}", BPrize * BA) + " 元\n";
								
				lblList.Text = AL + BL + CL + DL; // 加總所有品項清單並秀出
			}
			catch (Exception ex)
			{
				Form00_MessageBox.msgError(ex);
			}
		}

        private void btnMenuC_Click(object sender, EventArgs e)
        {
			// 按鈕：C 菜單
			try
			{
				CA++; // 數量 + 1
				Total += 350; // 累加總金額
				lblTotal.Text = "NT$ " + Total; // 秀出總金額
				
				// 設定品項數量金額清單
				CL = String.Format("{0,10}", "中部粽 x ") + String.Format("{0,3}", CA) + ",共NT$ " + String.Format("{0,5}", CPrize * CA) + " 元\n";
				
				lblList.Text = AL + BL + CL + DL; // 加總所有品項清單並秀出
			}
			catch (Exception ex)
			{				
				Form00_MessageBox.msgError(ex);
			}
		}

        private void btnMenuD_Click(object sender, EventArgs e)
        {
			// 按鈕：D 菜單
			try
			{
				DA++; // 數量 + 1
				Total += 320; // 累加總金額
				lblTotal.Text = "NT$ " + Total; // 秀出總金額
				
				// 設定品項數量金額清單
				DL = String.Format("{0,8}", "海景第一排 x ") + String.Format("{0,3}", DA) + ",共NT$ " + String.Format("{0,5}", DPrize * DA) + " 元\n";
				
				lblList.Text = AL + BL + CL + DL; // 加總所有品項清單並秀出
			}
			catch (Exception ex)
            {
				Form00_MessageBox.msgError(ex);				
			}
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			// 按鈕：清除清單
			try
			{
				lblList.Text = "尚未點餐";
				Total = 0; // 總金額歸 0
				lblTotal.Text = "NT$ " + Total;
				AA = 0; // 品項數量歸 0
				BA = 0;
				CA = 0;
				DA = 0;
				AL = string.Empty; // 清空品項數量金額清單
				BL = string.Empty;
				CL = string.Empty;
				DL = string.Empty;
			}
			catch (Exception ex)
			{
				Form00_MessageBox.msgError(ex);
			}
		}

		private void btnCash_Click(object sender, EventArgs e)
        {
			// 按鈕：現金
			try
			{
				if (Total < 1) // 如果總金額 < 1 
				{
					MessageBox.Show("尚未點餐！", "確認付款", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
				else
				{
					MessageBox.Show($"總金額：NT$  {Total} ","確認付款", MessageBoxButtons.OKCancel);
				}
			}
			catch (Exception ex)
			{
				Form00_MessageBox.msgError(ex);
			}		
		}

        private void btnCredit_Click(object sender, EventArgs e)
        {
			// 按鈕：信用卡
			try
            {
				if (Total < 1) // 如果總金額 < 1 
				{
					MessageBox.Show("尚未點餐！", "確認付款", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}
				MessageBox.Show($"總金額：NT$  {Total} \n折扣後金額：NT$ {(double)Total * 0.9}", "確認付款", MessageBoxButtons.OKCancel);
			}
			catch (Exception ex)
            {
				Form00_MessageBox.msgError(ex);
			}
		}
    }
}
