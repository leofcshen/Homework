using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Homework
{
    public partial class Form2_Loan : Form
    {
        double A; // 金額
        double P; // 期數
        double R; // 利率
        int MonthPay; // 月付額
        public Form2_Loan()
        {
            InitializeComponent();
        }        

        private void btnTotal_Click(object sender, EventArgs e)
        {
            // 總付額使用PMT函數
            try
            {
                A = Convert.ToDouble(txtAmount.Text) - Convert.ToDouble(txtDownPayment.Text);
                P = Convert.ToDouble(txtYear.Text) * 12;
                R = Convert.ToDouble(txtRate.Text) / 1200;
                MonthPay = Convert.ToInt32(Financial.Pmt(R, P, A)) * -1; // using Microsoft.VisualBasic;
                MessageBox.Show("總付款：" + (double)MonthPay * P + "元");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error code = {ex.Message}, 請檢查程式碼", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnPMT_Click(object sender, EventArgs e)
        {
            // 月付額使用PMT函數
            try
            {
                A = Convert.ToDouble(txtAmount.Text) - Convert.ToDouble(txtDownPayment.Text);
                P = Convert.ToDouble(txtYear.Text) * 12;
                R = Convert.ToDouble(txtRate.Text) / 1200;
                MonthPay = Convert.ToInt32(Financial.Pmt(R, P, A)) * -1; // using Microsoft.VisualBasic;
                MessageBox.Show("月付款：" + MonthPay + "元");
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error code = {ex.Message}, 請檢查程式碼", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            // Report
            try
            {
                Form2_LoanReport flr = new Form2_LoanReport();
                // 不同 form取控件值需要修改權限
                flr.txtRAmount.Text = txtAmount.Text;
                flr.txtRYear.Text = txtYear.Text;
                flr.txtRRate.Text = txtRate.Text;
                A = Convert.ToDouble(txtAmount.Text) - Convert.ToDouble(txtDownPayment.Text);
                P = Convert.ToDouble(txtYear.Text) * 12;
                R = Convert.ToDouble(txtRate.Text) / 1200;
                MonthPay = Convert.ToInt32(Financial.Pmt(R, P, A)) * -1;
                flr.txtRMonthPay.Text = $"{MonthPay}";
                flr.txtRTotal.Text = $"{MonthPay * P}";
                flr.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error code = {ex.Message}, 請檢查程式碼", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        
        private void btnMonthPay_Click(object sender, EventArgs e)
        {
            // 月付額使用公式： 月付額 = a * r * (1 + r) ^ p / [(1 + r) ^ p - 1]   (a:本金, r:利率, p:期數)
            try
            {
                A = Convert.ToDouble(txtAmount.Text) - Convert.ToDouble(txtDownPayment.Text);
                P = Convert.ToDouble(txtYear.Text) * 12;
                R = Convert.ToDouble(txtRate.Text) / 1200;
                MonthPay = Convert.ToInt32(Handmade(A, P, R));

                MessageBox.Show("月付額 = " + MonthPay);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error code = {ex.Message}, 請檢查程式碼", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnTotal2_Click(object sender, EventArgs e)
        {
            // 總付額使用公式： 總付額 = 月付額 * 期數
            try
            {
                A = Convert.ToDouble(txtAmount.Text) - Convert.ToDouble(txtDownPayment.Text);
                P = Convert.ToDouble(txtYear.Text) * 12;
                R = Convert.ToDouble(txtRate.Text) / 1200;
                MonthPay = Convert.ToInt32(Handmade(A, P, R));

                MessageBox.Show("總付款：" + MonthPay * P + "元");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error code = {ex.Message}, 請檢查程式碼", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private double Handmade(double A, double P, double R)
        {
            // 使用公式： 月付額 = a * r * (1 + r) ^ p / [(1 + r) ^ p - 1] * p  (a:本金, r:利率, p:期數)
            try
            {
                MonthPay = Convert.ToInt32(A * R * Math.Pow((1 + R), P) / (Math.Pow((1 + R), P) - 1));
                return MonthPay;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error code = {ex.Message}, 請檢查程式碼", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 0;
            }
            
        }
    }
}
