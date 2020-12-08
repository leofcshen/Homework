
namespace Homework
{
    partial class FormT05_MineSweeper
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.gpbBomb = new System.Windows.Forms.GroupBox();
            this.cbbLevel = new System.Windows.Forms.ComboBox();
            this.btnClickAll = new System.Windows.Forms.Button();
            this.btnReadme = new System.Windows.Forms.Button();
            this.btnUntagBomb = new System.Windows.Forms.Button();
            this.btnTagBomb = new System.Windows.Forms.Button();
            this.txtTest = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFlag = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLevel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.txtBombLeft = new System.Windows.Forms.TextBox();
            this.txtBombNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTimer = new System.Windows.Forms.Label();
            this.gpbBomb.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(266, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1073, 632);
            this.panel1.TabIndex = 0;
            // 
            // gpbBomb
            // 
            this.gpbBomb.Controls.Add(this.lblTimer);
            this.gpbBomb.Controls.Add(this.cbbLevel);
            this.gpbBomb.Controls.Add(this.btnClickAll);
            this.gpbBomb.Controls.Add(this.btnReadme);
            this.gpbBomb.Controls.Add(this.btnUntagBomb);
            this.gpbBomb.Controls.Add(this.btnTagBomb);
            this.gpbBomb.Controls.Add(this.txtTest);
            this.gpbBomb.Controls.Add(this.label5);
            this.gpbBomb.Controls.Add(this.txtFlag);
            this.gpbBomb.Controls.Add(this.label4);
            this.gpbBomb.Controls.Add(this.txtLevel);
            this.gpbBomb.Controls.Add(this.label3);
            this.gpbBomb.Controls.Add(this.lblLevel);
            this.gpbBomb.Controls.Add(this.btnNewGame);
            this.gpbBomb.Controls.Add(this.txtBombLeft);
            this.gpbBomb.Controls.Add(this.txtBombNumber);
            this.gpbBomb.Controls.Add(this.label2);
            this.gpbBomb.Controls.Add(this.label1);
            this.gpbBomb.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gpbBomb.Location = new System.Drawing.Point(12, 12);
            this.gpbBomb.Name = "gpbBomb";
            this.gpbBomb.Size = new System.Drawing.Size(248, 523);
            this.gpbBomb.TabIndex = 1;
            this.gpbBomb.TabStop = false;
            this.gpbBomb.Text = "統計";
            // 
            // cbbLevel
            // 
            this.cbbLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLevel.Font = new System.Drawing.Font("細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbbLevel.FormattingEnabled = true;
            this.cbbLevel.Items.AddRange(new object[] {
            "簡單  8* 8 雷數10",
            "普通 16*16 雷數40",
            "困難 30*16 雷數99"});
            this.cbbLevel.Location = new System.Drawing.Point(73, 378);
            this.cbbLevel.Name = "cbbLevel";
            this.cbbLevel.Size = new System.Drawing.Size(164, 24);
            this.cbbLevel.TabIndex = 7;
            // 
            // btnClickAll
            // 
            this.btnClickAll.Enabled = false;
            this.btnClickAll.Location = new System.Drawing.Point(14, 321);
            this.btnClickAll.Name = "btnClickAll";
            this.btnClickAll.Size = new System.Drawing.Size(86, 38);
            this.btnClickAll.TabIndex = 17;
            this.btnClickAll.Text = "一鍵開獎";
            this.btnClickAll.UseVisualStyleBackColor = true;
            this.btnClickAll.Click += new System.EventHandler(this.btnClickAll_Click);
            // 
            // btnReadme
            // 
            this.btnReadme.Location = new System.Drawing.Point(151, 481);
            this.btnReadme.Name = "btnReadme";
            this.btnReadme.Size = new System.Drawing.Size(86, 38);
            this.btnReadme.TabIndex = 16;
            this.btnReadme.Text = "操作說明";
            this.btnReadme.UseVisualStyleBackColor = true;
            this.btnReadme.Click += new System.EventHandler(this.btnReadme_Click);
            // 
            // btnUntagBomb
            // 
            this.btnUntagBomb.Enabled = false;
            this.btnUntagBomb.Location = new System.Drawing.Point(98, 130);
            this.btnUntagBomb.Name = "btnUntagBomb";
            this.btnUntagBomb.Size = new System.Drawing.Size(86, 38);
            this.btnUntagBomb.TabIndex = 15;
            this.btnUntagBomb.Text = "取消標雷";
            this.btnUntagBomb.UseVisualStyleBackColor = true;
            this.btnUntagBomb.Click += new System.EventHandler(this.btnUntagBomb_Click);
            // 
            // btnTagBomb
            // 
            this.btnTagBomb.Enabled = false;
            this.btnTagBomb.Location = new System.Drawing.Point(6, 130);
            this.btnTagBomb.Name = "btnTagBomb";
            this.btnTagBomb.Size = new System.Drawing.Size(86, 38);
            this.btnTagBomb.TabIndex = 14;
            this.btnTagBomb.Text = "一鍵標雷";
            this.btnTagBomb.UseVisualStyleBackColor = true;
            this.btnTagBomb.Click += new System.EventHandler(this.btnTagBomb_Click);
            // 
            // txtTest
            // 
            this.txtTest.Enabled = false;
            this.txtTest.Location = new System.Drawing.Point(119, 183);
            this.txtTest.Name = "txtTest";
            this.txtTest.Size = new System.Drawing.Size(52, 29);
            this.txtTest.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "踩雷數：";
            // 
            // txtFlag
            // 
            this.txtFlag.Enabled = false;
            this.txtFlag.Location = new System.Drawing.Point(119, 231);
            this.txtFlag.Name = "txtFlag";
            this.txtFlag.Size = new System.Drawing.Size(52, 29);
            this.txtFlag.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "標雷數：";
            // 
            // txtLevel
            // 
            this.txtLevel.Enabled = false;
            this.txtLevel.Location = new System.Drawing.Point(88, 35);
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.Size = new System.Drawing.Size(52, 29);
            this.txtLevel.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "難度：";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(10, 378);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(57, 20);
            this.lblLevel.TabIndex = 5;
            this.lblLevel.Text = "難度：";
            // 
            // btnNewGame
            // 
            this.btnNewGame.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNewGame.Location = new System.Drawing.Point(14, 436);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(223, 39);
            this.btnNewGame.TabIndex = 4;
            this.btnNewGame.Text = "開新遊戲(F1)";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // txtBombLeft
            // 
            this.txtBombLeft.Enabled = false;
            this.txtBombLeft.Location = new System.Drawing.Point(119, 278);
            this.txtBombLeft.Name = "txtBombLeft";
            this.txtBombLeft.Size = new System.Drawing.Size(52, 29);
            this.txtBombLeft.TabIndex = 3;
            // 
            // txtBombNumber
            // 
            this.txtBombNumber.Enabled = false;
            this.txtBombNumber.Location = new System.Drawing.Point(88, 82);
            this.txtBombNumber.Name = "txtBombNumber";
            this.txtBombNumber.Size = new System.Drawing.Size(52, 29);
            this.txtBombNumber.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "餘雷數：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "總雷數：";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Location = new System.Drawing.Point(157, 33);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(71, 20);
            this.lblTimer.TabIndex = 18;
            this.lblTimer.Text = "00:00:00";
            // 
            // FormT05_MineSweeper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 657);
            this.Controls.Add(this.gpbBomb);
            this.Controls.Add(this.panel1);
            this.Name = "FormT05_MineSweeper";
            this.Text = "FormT05_MineSweeper";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_KeyDown);
            this.gpbBomb.ResumeLayout(false);
            this.gpbBomb.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gpbBomb;
        private System.Windows.Forms.TextBox txtBombLeft;
        private System.Windows.Forms.TextBox txtBombNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.ComboBox cbbLevel;
        private System.Windows.Forms.TextBox txtLevel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFlag;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTest;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnTagBomb;
        private System.Windows.Forms.Button btnUntagBomb;
        private System.Windows.Forms.Button btnReadme;
        private System.Windows.Forms.Button btnClickAll;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTimer;
    }
}