
namespace Homework
{
    partial class Form16_Alarm
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.gpbMTB = new System.Windows.Forms.GroupBox();
            this.lblDTP = new System.Windows.Forms.Label();
            this.btnDTP = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblMTB = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.ckbSetAlarm = new System.Windows.Forms.CheckBox();
            this.lblTimer = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnCancelDTP = new System.Windows.Forms.Button();
            this.gpbDTP = new System.Windows.Forms.GroupBox();
            this.gpbMTB.SuspendLayout();
            this.gpbDTP.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // gpbMTB
            // 
            this.gpbMTB.Controls.Add(this.lblMTB);
            this.gpbMTB.Controls.Add(this.maskedTextBox1);
            this.gpbMTB.Controls.Add(this.ckbSetAlarm);
            this.gpbMTB.Controls.Add(this.label2);
            this.gpbMTB.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gpbMTB.Location = new System.Drawing.Point(12, 42);
            this.gpbMTB.Name = "gpbMTB";
            this.gpbMTB.Size = new System.Drawing.Size(384, 396);
            this.gpbMTB.TabIndex = 3;
            this.gpbMTB.TabStop = false;
            this.gpbMTB.Text = "MaskedTextBox";
            // 
            // lblDTP
            // 
            this.lblDTP.AutoSize = true;
            this.lblDTP.Location = new System.Drawing.Point(88, 83);
            this.lblDTP.Name = "lblDTP";
            this.lblDTP.Size = new System.Drawing.Size(133, 30);
            this.lblDTP.TabIndex = 9;
            this.lblDTP.Text = "鬧鐘未設定";
            // 
            // btnDTP
            // 
            this.btnDTP.Location = new System.Drawing.Point(146, 187);
            this.btnDTP.Name = "btnDTP";
            this.btnDTP.Size = new System.Drawing.Size(102, 38);
            this.btnDTP.TabIndex = 8;
            this.btnDTP.Text = "設定";
            this.btnDTP.UseVisualStyleBackColor = true;
            this.btnDTP.Click += new System.EventHandler(this.btnDTP_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "hh:mm:ss";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(93, 129);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 39);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // lblMTB
            // 
            this.lblMTB.AutoSize = true;
            this.lblMTB.Location = new System.Drawing.Point(139, 83);
            this.lblMTB.Name = "lblMTB";
            this.lblMTB.Size = new System.Drawing.Size(133, 30);
            this.lblMTB.TabIndex = 6;
            this.lblMTB.Text = "鬧鐘未設定";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(144, 129);
            this.maskedTextBox1.Mask = "90時90分90秒";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(160, 39);
            this.maskedTextBox1.TabIndex = 4;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            this.maskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // ckbSetAlarm
            // 
            this.ckbSetAlarm.AutoSize = true;
            this.ckbSetAlarm.Location = new System.Drawing.Point(124, 187);
            this.ckbSetAlarm.Name = "ckbSetAlarm";
            this.ckbSetAlarm.Size = new System.Drawing.Size(142, 34);
            this.ckbSetAlarm.TabIndex = 3;
            this.ckbSetAlarm.Text = "Set Alarm";
            this.ckbSetAlarm.UseVisualStyleBackColor = true;
            this.ckbSetAlarm.CheckedChanged += new System.EventHandler(this.ckbSetAlarm_CheckedChanged);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTimer.Location = new System.Drawing.Point(18, 9);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(81, 30);
            this.lblTimer.TabIndex = 4;
            this.lblTimer.Text = "label3";
            // 
            // timer2
            // 
            this.timer2.Enabled = false;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnCancelDTP
            // 
            this.btnCancelDTP.Location = new System.Drawing.Point(146, 247);
            this.btnCancelDTP.Name = "btnCancelDTP";
            this.btnCancelDTP.Size = new System.Drawing.Size(102, 38);
            this.btnCancelDTP.TabIndex = 10;
            this.btnCancelDTP.Text = "取消";
            this.btnCancelDTP.UseVisualStyleBackColor = true;
            this.btnCancelDTP.Click += new System.EventHandler(this.btnCancelDTP_Click);
            // 
            // gpbDTP
            // 
            this.gpbDTP.Controls.Add(this.lblDTP);
            this.gpbDTP.Controls.Add(this.btnCancelDTP);
            this.gpbDTP.Controls.Add(this.dateTimePicker1);
            this.gpbDTP.Controls.Add(this.btnDTP);
            this.gpbDTP.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gpbDTP.Location = new System.Drawing.Point(427, 42);
            this.gpbDTP.Name = "gpbDTP";
            this.gpbDTP.Size = new System.Drawing.Size(361, 396);
            this.gpbDTP.TabIndex = 5;
            this.gpbDTP.TabStop = false;
            this.gpbDTP.Text = "DateTimePicker";
            // 
            // Form16_Alarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gpbDTP);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.gpbMTB);
            this.Name = "Form16_Alarm";
            this.Text = "Form16_Alarm";
            this.gpbMTB.ResumeLayout(false);
            this.gpbMTB.PerformLayout();
            this.gpbDTP.ResumeLayout(false);
            this.gpbDTP.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gpbMTB;
        internal System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.CheckBox ckbSetAlarm;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblMTB;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnDTP;
        private System.Windows.Forms.Label lblDTP;
        private System.Windows.Forms.Button btnCancelDTP;
        private System.Windows.Forms.GroupBox gpbDTP;
    }
}