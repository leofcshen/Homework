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
    public partial class Form02_Loan : Form
    {
        public Form02_Loan()
        {
            InitializeComponent();
        }

        double A; // 金額
        double P; // 期數
        double R; // 利率
        int MonthPay; // 月付額

        private double Handmade(double A, double P, double R)
        {
            // 方法：月付款公式 = a * r * (1 + r) ^ p / [(1 + r) ^ p - 1] * p  (a:本金, r:利率, p:期數)
            try
            {
                MonthPay = Convert.ToInt32(A * R * Math.Pow((1 + R), P) / (Math.Pow((1 + R), P) - 1));
                return MonthPay;
            }
            catch (Exception ex)
            {
                Form00.msgError(ex);
                return 0;
            }
        }        

        private void btnPMT_Click(object sender, EventArgs e)
        {
            // 點擊按鈕：月付款(PMT) (使用 PMT 函數)
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
                Form00.msgError(ex);
            }
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            // 點擊按鈕：總付款(PMT) (使用 PMT 函數)
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
                Form00.msgError(ex);
            }
        }
        
        private void btnMonthPay_Click(object sender, EventArgs e)
        {
            // 點擊按鈕：月付款(公式)
            // 月付款公式：月付款 = a * r * (1 + r) ^ p / [(1 + r) ^ p - 1]   (a:本金, r:利率, p:期數)
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
                Form00.msgError(ex);
            }
        }

        private void btnTotal2_Click(object sender, EventArgs e)
        {
            // 點擊按鈕：總付款(公式) (使用公式)             
            // 總付款公式：總付款 = 月付款 * 期數
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
                Form00.msgError(ex);
            }
        }
        private void btnReport_Click(object sender, EventArgs e)
        {
            // 點擊按鈕：Report)
            try
            {
                Form02_Loan_Report flr = new Form02_Loan_Report();
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
                Form00.msgError(ex);
            }
        }
    }
}

