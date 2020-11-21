using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework
{
    public partial class Form2_LoanReport : Form
    {
        public Form2_LoanReport()
        {
            InitializeComponent();
        }

        private void btnMail_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                DialogResult result = MessageBox.Show("Email 不可為空!!\r\n繼續請按 Yes，離開請按 No。", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                {
                    this.Close();
                }
            }
            else
            {
                try
                {
                    string Body = $"{lblAmonut.Text} : {txtRAmount.Text} \r\n " +
                        $"{lblYear.Text} : {txtRYear.Text} \r\n " +
                        $"{lblRate.Text} : {txtRRate.Text} \r\n " +
                        $"{lblMonthPay.Text} : {txtRMonthPay.Text} \r\n" +
                        $" {lblTotal.Text} : {txtRTotal.Text}";
                    System.Net.Mail.SmtpClient MySmtp = new System.Net.Mail.SmtpClient("smtp.gmail.com", 587);
                    MySmtp.Credentials = new System.Net.NetworkCredential("rovingwind93@gmail.com", "wbiesolnfcrgmjfn");
                    MySmtp.EnableSsl = true;
                    MySmtp.Send("測試主機端<rovingwind93@gmail.com>", txtEmail.Text, "貸款報告書", Body);
                    MySmtp.Dispose();

                    DialogResult result = MessageBox.Show("已發送報告\r\n繼續請按 Yes，離開請按 No。", "mail", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.No)
                    {
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error code = {ex.Message}, 請檢查程式碼", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }                        
        }
    }
}
