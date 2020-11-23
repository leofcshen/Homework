
namespace Homework
{
    partial class Form06_StudentGrade_List
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
            this.btnRngX2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRam = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCurrent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCaculate = new System.Windows.Forms.Label();
            this.pnlCaculate = new System.Windows.Forms.Panel();
            this.lblIndex = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.txtLeft = new System.Windows.Forms.TextBox();
            this.pnlGarde = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnTotal = new System.Windows.Forms.Button();
            this.btnRngX = new System.Windows.Forms.Button();
            this.txtMath = new System.Windows.Forms.TextBox();
            this.lblMath = new System.Windows.Forms.Label();
            this.txtEng = new System.Windows.Forms.TextBox();
            this.lblEng = new System.Windows.Forms.Label();
            this.txtCN = new System.Windows.Forms.TextBox();
            this.lblCN = new System.Windows.Forms.Label();
            this.btnRng = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.pnlCaculate.SuspendLayout();
            this.pnlGarde.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRngX2
            // 
            this.btnRngX2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRngX2.Location = new System.Drawing.Point(143, 403);
            this.btnRngX2.Name = "btnRngX2";
            this.btnRngX2.Size = new System.Drawing.Size(40, 39);
            this.btnRngX2.TabIndex = 71;
            this.btnRngX2.Text = "(2)";
            this.btnRngX2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(14, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 69;
            this.label3.Text = "剩餘筆數";
            // 
            // txtRam
            // 
            this.txtRam.Location = new System.Drawing.Point(93, 282);
            this.txtRam.Name = "txtRam";
            this.txtRam.Size = new System.Drawing.Size(52, 22);
            this.txtRam.TabIndex = 67;
            this.txtRam.Text = "100";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(14, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 68;
            this.label2.Text = "記憶體";
            // 
            // txtCurrent
            // 
            this.txtCurrent.Location = new System.Drawing.Point(93, 305);
            this.txtCurrent.Name = "txtCurrent";
            this.txtCurrent.Size = new System.Drawing.Size(52, 22);
            this.txtCurrent.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(14, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 51;
            this.label1.Text = "目前筆數";
            // 
            // lblCaculate
            // 
            this.lblCaculate.AutoSize = true;
            this.lblCaculate.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblCaculate.Location = new System.Drawing.Point(5, 5);
            this.lblCaculate.Name = "lblCaculate";
            this.lblCaculate.Size = new System.Drawing.Size(0, 16);
            this.lblCaculate.TabIndex = 0;
            // 
            // pnlCaculate
            // 
            this.pnlCaculate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlCaculate.Controls.Add(this.lblCaculate);
            this.pnlCaculate.Location = new System.Drawing.Point(244, 307);
            this.pnlCaculate.Name = "pnlCaculate";
            this.pnlCaculate.Size = new System.Drawing.Size(543, 135);
            this.pnlCaculate.TabIndex = 66;
            // 
            // lblIndex
            // 
            this.lblIndex.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblIndex.Location = new System.Drawing.Point(3, 5);
            this.lblIndex.Name = "lblIndex";
            this.lblIndex.Size = new System.Drawing.Size(516, 16);
            this.lblIndex.TabIndex = 1;
            this.lblIndex.Text = "姓名         國文  英文  數學  總分   平均   最低      最高";
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGrade.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblGrade.Location = new System.Drawing.Point(3, 25);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(2, 18);
            this.lblGrade.TabIndex = 0;
            // 
            // txtLeft
            // 
            this.txtLeft.Location = new System.Drawing.Point(93, 325);
            this.txtLeft.Name = "txtLeft";
            this.txtLeft.Size = new System.Drawing.Size(52, 22);
            this.txtLeft.TabIndex = 70;
            // 
            // pnlGarde
            // 
            this.pnlGarde.AutoScroll = true;
            this.pnlGarde.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlGarde.Controls.Add(this.lblIndex);
            this.pnlGarde.Controls.Add(this.lblGrade);
            this.pnlGarde.Location = new System.Drawing.Point(244, 15);
            this.pnlGarde.Name = "pnlGarde";
            this.pnlGarde.Size = new System.Drawing.Size(543, 286);
            this.pnlGarde.TabIndex = 65;
            // 
            // btnReset
            // 
            this.btnReset.Enabled = false;
            this.btnReset.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReset.Location = new System.Drawing.Point(13, 358);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(124, 39);
            this.btnReset.TabIndex = 63;
            this.btnReset.Text = "重設所有資料";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnTotal
            // 
            this.btnTotal.Enabled = false;
            this.btnTotal.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnTotal.Location = new System.Drawing.Point(13, 242);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(124, 39);
            this.btnTotal.TabIndex = 62;
            this.btnTotal.Text = "各科統計";
            this.btnTotal.UseVisualStyleBackColor = true;
            // 
            // btnRngX
            // 
            this.btnRngX.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRngX.Location = new System.Drawing.Point(13, 403);
            this.btnRngX.Name = "btnRngX";
            this.btnRngX.Size = new System.Drawing.Size(124, 39);
            this.btnRngX.TabIndex = 64;
            this.btnRngX.Text = "隨機加入20筆";
            this.btnRngX.UseVisualStyleBackColor = true;
            // 
            // txtMath
            // 
            this.txtMath.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMath.Location = new System.Drawing.Point(81, 112);
            this.txtMath.Name = "txtMath";
            this.txtMath.Size = new System.Drawing.Size(137, 29);
            this.txtMath.TabIndex = 61;
            // 
            // lblMath
            // 
            this.lblMath.AutoSize = true;
            this.lblMath.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblMath.Location = new System.Drawing.Point(14, 115);
            this.lblMath.Name = "lblMath";
            this.lblMath.Size = new System.Drawing.Size(41, 20);
            this.lblMath.TabIndex = 60;
            this.lblMath.Text = "數學";
            // 
            // txtEng
            // 
            this.txtEng.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEng.Location = new System.Drawing.Point(81, 77);
            this.txtEng.Name = "txtEng";
            this.txtEng.Size = new System.Drawing.Size(137, 29);
            this.txtEng.TabIndex = 59;
            // 
            // lblEng
            // 
            this.lblEng.AutoSize = true;
            this.lblEng.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblEng.Location = new System.Drawing.Point(14, 80);
            this.lblEng.Name = "lblEng";
            this.lblEng.Size = new System.Drawing.Size(41, 20);
            this.lblEng.TabIndex = 58;
            this.lblEng.Text = "英文";
            // 
            // txtCN
            // 
            this.txtCN.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCN.Location = new System.Drawing.Point(81, 42);
            this.txtCN.Name = "txtCN";
            this.txtCN.Size = new System.Drawing.Size(137, 29);
            this.txtCN.TabIndex = 57;
            // 
            // lblCN
            // 
            this.lblCN.AutoSize = true;
            this.lblCN.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblCN.Location = new System.Drawing.Point(14, 45);
            this.lblCN.Name = "lblCN";
            this.lblCN.Size = new System.Drawing.Size(41, 20);
            this.lblCN.TabIndex = 56;
            this.lblCN.Text = "國文";
            // 
            // btnRng
            // 
            this.btnRng.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRng.Location = new System.Drawing.Point(13, 197);
            this.btnRng.Name = "btnRng";
            this.btnRng.Size = new System.Drawing.Size(124, 39);
            this.btnRng.TabIndex = 55;
            this.btnRng.Text = "隨機儲存資料";
            this.btnRng.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAdd.Location = new System.Drawing.Point(13, 152);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(124, 39);
            this.btnAdd.TabIndex = 54;
            this.btnAdd.Text = "加入學生資料";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName.Location = new System.Drawing.Point(81, 8);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(137, 29);
            this.txtName.TabIndex = 53;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblName.Location = new System.Drawing.Point(14, 11);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 20);
            this.lblName.TabIndex = 52;
            this.lblName.Text = "姓名";
            // 
            // Form06_StudentGrade_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRngX2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCurrent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlCaculate);
            this.Controls.Add(this.txtLeft);
            this.Controls.Add(this.pnlGarde);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.btnRngX);
            this.Controls.Add(this.txtMath);
            this.Controls.Add(this.lblMath);
            this.Controls.Add(this.txtEng);
            this.Controls.Add(this.lblEng);
            this.Controls.Add(this.txtCN);
            this.Controls.Add(this.lblCN);
            this.Controls.Add(this.btnRng);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Name = "Form06_StudentGrade_List";
            this.Text = "Form06_StudentGrade_List";
            this.pnlCaculate.ResumeLayout(false);
            this.pnlCaculate.PerformLayout();
            this.pnlGarde.ResumeLayout(false);
            this.pnlGarde.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRngX2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCurrent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCaculate;
        private System.Windows.Forms.Panel pnlCaculate;
        private System.Windows.Forms.Label lblIndex;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.TextBox txtLeft;
        private System.Windows.Forms.Panel pnlGarde;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Button btnRngX;
        private System.Windows.Forms.TextBox txtMath;
        private System.Windows.Forms.Label lblMath;
        private System.Windows.Forms.TextBox txtEng;
        private System.Windows.Forms.Label lblEng;
        private System.Windows.Forms.TextBox txtCN;
        private System.Windows.Forms.Label lblCN;
        private System.Windows.Forms.Button btnRng;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
    }
}