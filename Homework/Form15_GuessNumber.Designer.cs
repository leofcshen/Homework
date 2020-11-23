namespace Homework
{
    partial class Form15_GuessNumber
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
            this.lblRange = new System.Windows.Forms.Label();
            this.btnGuess = new System.Windows.Forms.Button();
            this.btnShowAnswer = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRange
            // 
            this.lblRange.AutoSize = true;
            this.lblRange.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblRange.Location = new System.Drawing.Point(272, 164);
            this.lblRange.Name = "lblRange";
            this.lblRange.Size = new System.Drawing.Size(169, 30);
            this.lblRange.TabIndex = 0;
            this.lblRange.Text = "請輸入 0 - 100";
            // 
            // btnGuess
            // 
            this.btnGuess.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnGuess.Location = new System.Drawing.Point(277, 260);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(108, 52);
            this.btnGuess.TabIndex = 1;
            this.btnGuess.Text = "Guess";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // btnShowAnswer
            // 
            this.btnShowAnswer.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnShowAnswer.Location = new System.Drawing.Point(410, 260);
            this.btnShowAnswer.Name = "btnShowAnswer";
            this.btnShowAnswer.Size = new System.Drawing.Size(183, 52);
            this.btnShowAnswer.TabIndex = 2;
            this.btnShowAnswer.Text = "Show Answer";
            this.btnShowAnswer.UseVisualStyleBackColor = true;
            this.btnShowAnswer.Click += new System.EventHandler(this.btnShowAnswer_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("微軟正黑體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTitle.Location = new System.Drawing.Point(272, 84);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(219, 61);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "終極密碼";
            // 
            // Form15_GuessNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnShowAnswer);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.lblRange);
            this.Name = "Form15_GuessNumber";
            this.Text = "Form15_GuessNumber";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.Button btnShowAnswer;
        internal System.Windows.Forms.Label lblRange;
        internal System.Windows.Forms.Label lblTitle;
    }
}