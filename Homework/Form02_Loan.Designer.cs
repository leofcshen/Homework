
namespace Homework
{
    partial class Form02_Loan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtDownPayment = new System.Windows.Forms.TextBox();
            this.lblDownPayment = new System.Windows.Forms.Label();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.lblRate = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.btnTotal = new System.Windows.Forms.Button();
            this.btnPMT = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblAmonut = new System.Windows.Forms.Label();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnMonthPay = new System.Windows.Forms.Button();
            this.btnTotal2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDownPayment
            // 
            this.txtDownPayment.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDownPayment.Location = new System.Drawing.Point(419, 266);
            this.txtDownPayment.Name = "txtDownPayment";
            this.txtDownPayment.Size = new System.Drawing.Size(137, 39);
            this.txtDownPayment.TabIndex = 29;
            // 
            // lblDownPayment
            // 
            this.lblDownPayment.AutoSize = true;
            this.lblDownPayment.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDownPayment.Location = new System.Drawing.Point(244, 269);
            this.lblDownPayment.Name = "lblDownPayment";
            this.lblDownPayment.Size = new System.Drawing.Size(85, 30);
            this.lblDownPayment.TabIndex = 28;
            this.lblDownPayment.Text = "頭期款";
            // 
            // txtRate
            // 
            this.txtRate.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtRate.Location = new System.Drawing.Point(419, 206);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(137, 39);
            this.txtRate.TabIndex = 27;
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblRate.Location = new System.Drawing.Point(244, 209);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(98, 30);
            this.lblRate.TabIndex = 26;
            this.lblRate.Text = "利率(%)";
            // 
            // txtYear
            // 
            this.txtYear.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtYear.Location = new System.Drawing.Point(419, 138);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(137, 39);
            this.txtYear.TabIndex = 25;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblYear.Location = new System.Drawing.Point(244, 141);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(101, 30);
            this.lblYear.TabIndex = 24;
            this.lblYear.Text = "期限(年)";
            // 
            // btnTotal
            // 
            this.btnTotal.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnTotal.Location = new System.Drawing.Point(419, 322);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(173, 50);
            this.btnTotal.TabIndex = 23;
            this.btnTotal.Text = "總付款(PMT)";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // btnPMT
            // 
            this.btnPMT.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPMT.Location = new System.Drawing.Point(249, 322);
            this.btnPMT.Name = "btnPMT";
            this.btnPMT.Size = new System.Drawing.Size(164, 50);
            this.btnPMT.TabIndex = 22;
            this.btnPMT.Text = "月付款(PMT)";
            this.btnPMT.UseVisualStyleBackColor = true;
            this.btnPMT.Click += new System.EventHandler(this.btnPMT_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtAmount.Location = new System.Drawing.Point(419, 79);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(137, 39);
            this.txtAmount.TabIndex = 21;
            // 
            // lblAmonut
            // 
            this.lblAmonut.AutoSize = true;
            this.lblAmonut.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblAmonut.Location = new System.Drawing.Point(244, 82);
            this.lblAmonut.Name = "lblAmonut";
            this.lblAmonut.Size = new System.Drawing.Size(109, 30);
            this.lblAmonut.TabIndex = 20;
            this.lblAmonut.Text = "貸款金額";
            // 
            // btnReport
            // 
            this.btnReport.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReport.Location = new System.Drawing.Point(598, 322);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(137, 50);
            this.btnReport.TabIndex = 30;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnMonthPay
            // 
            this.btnMonthPay.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMonthPay.Location = new System.Drawing.Point(249, 378);
            this.btnMonthPay.Name = "btnMonthPay";
            this.btnMonthPay.Size = new System.Drawing.Size(164, 50);
            this.btnMonthPay.TabIndex = 31;
            this.btnMonthPay.Text = "月付款(公式)";
            this.btnMonthPay.UseVisualStyleBackColor = true;
            this.btnMonthPay.Click += new System.EventHandler(this.btnMonthPay_Click);
            // 
            // btnTotal2
            // 
            this.btnTotal2.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnTotal2.Location = new System.Drawing.Point(419, 378);
            this.btnTotal2.Name = "btnTotal2";
            this.btnTotal2.Size = new System.Drawing.Size(173, 50);
            this.btnTotal2.TabIndex = 32;
            this.btnTotal2.Text = "總付款(公式)";
            this.btnTotal2.UseVisualStyleBackColor = true;
            this.btnTotal2.Click += new System.EventHandler(this.btnTotal2_Click);
            // 
            // Form02_Loan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTotal2);
            this.Controls.Add(this.btnMonthPay);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.txtDownPayment);
            this.Controls.Add(this.lblDownPayment);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.btnPMT);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblAmonut);
            this.Name = "Form02_Loan";
            this.Text = "Form02_Loan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDownPayment;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Button btnPMT;
        private System.Windows.Forms.Label lblAmonut;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnMonthPay;
        private System.Windows.Forms.Button btnTotal2;
        internal System.Windows.Forms.TextBox txtDownPayment;
        internal System.Windows.Forms.TextBox txtRate;
        internal System.Windows.Forms.TextBox txtYear;
        internal System.Windows.Forms.TextBox txtAmount;
    }
}