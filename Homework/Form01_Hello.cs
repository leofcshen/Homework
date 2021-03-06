﻿using System;
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
    public partial class Form01_Hello : Form
    {
        public Form01_Hello()
        {
            InitializeComponent();
        }
        
        private void btnHello_Click(object sender, EventArgs e)
        {
            // 點擊按鈕：Say Hello!
            string Cname = txtCname.Text;
            string Ename = txtEname.Text;
            string Sex = txtSex.Text;
            string StarSign = txtStarSign.Text;

            try
            {
                DialogResult Result = MessageBox.Show("Hello,我是 " + Cname + ",\r\n"
                + "英文名字是 " + Ename + ",\r\n"
                + "性別是 " + Sex + ",\r\n"
                + "星座是 " + StarSign + ",\r\n"
                + "很高興認識你。 ,\r\n\r\n"
                + "繼續請按確定，離開請按取消。",
                "Say Hello!",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information
                );
                if (Result == DialogResult.No)
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
               Form00.msgError(ex);
            }
        }

        private void btnHi_Click(object sender, EventArgs e)
        {
            // 點擊按鈕：Say Hi!
            string Cname = txtCname.Text;
            string Ename = txtEname.Text;
            string Sex = txtSex.Text;
            string StarSign = txtStarSign.Text;

            try
            {
                DialogResult Result = MessageBox.Show("Hi,我是 " + Cname + ",\r\n"
                + "英文名字是 " + Ename + ",\r\n"
                + "性別是 " + Sex + ",\r\n"
                + "星座是 " + StarSign + ",\r\n"
                + "很高興認識你。 ,\r\n\r\n"
                + "繼續請按確定，離開請按取消。",
                "Say Hi!",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information
                );
                if (Result == DialogResult.No)
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
               Form00.msgError(ex);
            }
        }
    }
}
