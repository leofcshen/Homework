namespace Homework
{
    partial class Form3_POS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3_POS));
            this.gpbMenu = new System.Windows.Forms.GroupBox();
            this.btnmenuD = new System.Windows.Forms.Button();
            this.btnMenuC = new System.Windows.Forms.Button();
            this.btnMenuB = new System.Windows.Forms.Button();
            this.btnMenuA = new System.Windows.Forms.Button();
            this.gpbTotal = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.gpbPayWay = new System.Windows.Forms.GroupBox();
            this.lblOnSale = new System.Windows.Forms.Label();
            this.btnCredit = new System.Windows.Forms.Button();
            this.btnCash = new System.Windows.Forms.Button();
            this.gpbList = new System.Windows.Forms.GroupBox();
            this.lblList = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.gpbMenu.SuspendLayout();
            this.gpbTotal.SuspendLayout();
            this.gpbPayWay.SuspendLayout();
            this.gpbList.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbMenu
            // 
            this.gpbMenu.Controls.Add(this.btnmenuD);
            this.gpbMenu.Controls.Add(this.btnMenuC);
            this.gpbMenu.Controls.Add(this.btnMenuB);
            this.gpbMenu.Controls.Add(this.btnMenuA);
            this.gpbMenu.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gpbMenu.Location = new System.Drawing.Point(12, 12);
            this.gpbMenu.Name = "gpbMenu";
            this.gpbMenu.Size = new System.Drawing.Size(740, 698);
            this.gpbMenu.TabIndex = 0;
            this.gpbMenu.TabStop = false;
            this.gpbMenu.Text = "菜單";
            // 
            // btnmenuD
            // 
            this.btnmenuD.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnmenuD.BackgroundImage")));
            this.btnmenuD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnmenuD.Font = new System.Drawing.Font("微軟正黑體", 36F);
            this.btnmenuD.ForeColor = System.Drawing.Color.Red;
            this.btnmenuD.Location = new System.Drawing.Point(288, 376);
            this.btnmenuD.Name = "btnmenuD";
            this.btnmenuD.Size = new System.Drawing.Size(446, 316);
            this.btnmenuD.TabIndex = 3;
            this.btnmenuD.Text = "320元";
            this.btnmenuD.UseVisualStyleBackColor = true;
            this.btnmenuD.Click += new System.EventHandler(this.btnMenuD_Click);
            // 
            // btnMenuC
            // 
            this.btnMenuC.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMenuC.BackgroundImage")));
            this.btnMenuC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMenuC.Font = new System.Drawing.Font("微軟正黑體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMenuC.ForeColor = System.Drawing.Color.Red;
            this.btnMenuC.Location = new System.Drawing.Point(24, 376);
            this.btnMenuC.Name = "btnMenuC";
            this.btnMenuC.Size = new System.Drawing.Size(258, 316);
            this.btnMenuC.TabIndex = 2;
            this.btnMenuC.Text = "350 元";
            this.btnMenuC.UseVisualStyleBackColor = true;
            this.btnMenuC.Click += new System.EventHandler(this.btnMenuC_Click);
            // 
            // btnMenuB
            // 
            this.btnMenuB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMenuB.BackgroundImage")));
            this.btnMenuB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMenuB.Font = new System.Drawing.Font("微軟正黑體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMenuB.ForeColor = System.Drawing.Color.Red;
            this.btnMenuB.Location = new System.Drawing.Point(288, 41);
            this.btnMenuB.Name = "btnMenuB";
            this.btnMenuB.Size = new System.Drawing.Size(255, 338);
            this.btnMenuB.TabIndex = 1;
            this.btnMenuB.Text = "180 元";
            this.btnMenuB.UseVisualStyleBackColor = true;
            this.btnMenuB.Click += new System.EventHandler(this.btnMenuB_Click);
            // 
            // btnMenuA
            // 
            this.btnMenuA.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMenuA.BackgroundImage")));
            this.btnMenuA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMenuA.Font = new System.Drawing.Font("微軟正黑體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMenuA.ForeColor = System.Drawing.Color.Red;
            this.btnMenuA.Location = new System.Drawing.Point(24, 41);
            this.btnMenuA.Name = "btnMenuA";
            this.btnMenuA.Size = new System.Drawing.Size(258, 338);
            this.btnMenuA.TabIndex = 0;
            this.btnMenuA.Text = "120 元";
            this.btnMenuA.UseVisualStyleBackColor = true;
            this.btnMenuA.Click += new System.EventHandler(this.btnMenuA_Click);
            // 
            // gpbTotal
            // 
            this.gpbTotal.Controls.Add(this.lblTotal);
            this.gpbTotal.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gpbTotal.Location = new System.Drawing.Point(800, 336);
            this.gpbTotal.Name = "gpbTotal";
            this.gpbTotal.Size = new System.Drawing.Size(264, 135);
            this.gpbTotal.TabIndex = 1;
            this.gpbTotal.TabStop = false;
            this.gpbTotal.Text = "總金額";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(31, 52);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(79, 30);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "NT$ 0";
            // 
            // gpbPayWay
            // 
            this.gpbPayWay.Controls.Add(this.lblOnSale);
            this.gpbPayWay.Controls.Add(this.btnCredit);
            this.gpbPayWay.Controls.Add(this.btnCash);
            this.gpbPayWay.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gpbPayWay.Location = new System.Drawing.Point(800, 500);
            this.gpbPayWay.Name = "gpbPayWay";
            this.gpbPayWay.Size = new System.Drawing.Size(264, 174);
            this.gpbPayWay.TabIndex = 1;
            this.gpbPayWay.TabStop = false;
            this.gpbPayWay.Text = "付款方式";
            // 
            // lblOnSale
            // 
            this.lblOnSale.AutoSize = true;
            this.lblOnSale.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOnSale.Location = new System.Drawing.Point(116, 132);
            this.lblOnSale.Name = "lblOnSale";
            this.lblOnSale.Size = new System.Drawing.Size(125, 32);
            this.lblOnSale.TabIndex = 2;
            this.lblOnSale.Text = "信用卡9折";
            // 
            // btnCredit
            // 
            this.btnCredit.Location = new System.Drawing.Point(16, 127);
            this.btnCredit.Name = "btnCredit";
            this.btnCredit.Size = new System.Drawing.Size(94, 41);
            this.btnCredit.TabIndex = 1;
            this.btnCredit.Text = "信用卡";
            this.btnCredit.UseVisualStyleBackColor = true;
            this.btnCredit.Click += new System.EventHandler(this.btnCredit_Click);
            // 
            // btnCash
            // 
            this.btnCash.Location = new System.Drawing.Point(20, 65);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(72, 41);
            this.btnCash.TabIndex = 0;
            this.btnCash.Text = "現金現金";
            this.btnCash.UseVisualStyleBackColor = true;
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // gpbList
            // 
            this.gpbList.Controls.Add(this.lblList);
            this.gpbList.Controls.Add(this.btnClear);
            this.gpbList.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gpbList.Location = new System.Drawing.Point(758, 30);
            this.gpbList.Name = "gpbList";
            this.gpbList.Size = new System.Drawing.Size(331, 289);
            this.gpbList.TabIndex = 2;
            this.gpbList.TabStop = false;
            this.gpbList.Text = "購物清單";
            // 
            // lblList
            // 
            this.lblList.Font = new System.Drawing.Font("細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblList.Location = new System.Drawing.Point(6, 35);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(319, 186);
            this.lblList.TabIndex = 1;
            this.lblList.Text = "尚未點餐";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(200, 237);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(125, 46);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "清除清單";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form3_POS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 739);
            this.Controls.Add(this.gpbList);
            this.Controls.Add(this.gpbPayWay);
            this.Controls.Add(this.gpbTotal);
            this.Controls.Add(this.gpbMenu);
            this.Name = "Form3_POS";
            this.Text = "Form3_POS";
            this.gpbMenu.ResumeLayout(false);
            this.gpbTotal.ResumeLayout(false);
            this.gpbTotal.PerformLayout();
            this.gpbPayWay.ResumeLayout(false);
            this.gpbPayWay.PerformLayout();
            this.gpbList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbMenu;
        private System.Windows.Forms.GroupBox gpbTotal;
        private System.Windows.Forms.GroupBox gpbPayWay;
        private System.Windows.Forms.GroupBox gpbList;
        private System.Windows.Forms.Label lblOnSale;
        private System.Windows.Forms.Button btnCredit;
        private System.Windows.Forms.Button btnCash;
        private System.Windows.Forms.Button btnmenuD;
        private System.Windows.Forms.Button btnMenuC;
        private System.Windows.Forms.Button btnMenuB;
        private System.Windows.Forms.Button btnMenuA;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblList;
    }
}