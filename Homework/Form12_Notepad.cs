using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework
{
    public partial class Form12_Notepad : Form
    {
        public Form12_Notepad()
        {
            InitializeComponent();            
        }

        internal void msgFake()
        {
            Form12_Notepad_Msgbox fnm = new Form12_Notepad_Msgbox();
            fnm.ShowDialog();
        }

        // ==================================================檔案
        private void 新增ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form12_Notepad fn = new Form12_Notepad();
            fn.Show();
        }

        private void 開啟ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                textBox1.Text = sr.ReadToEnd();
                sr.Close();
                sr.Dispose();
            }
        }

        private void 儲存ToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            saveFileDialog1.Filter = "文字檔案(*.txt)|*.txt|所有檔案|*.*";
            saveFileDialog1.FileName = "儲存";
            //saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.AddExtension = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog1.FileName;
                FileStream fsWrite = new FileStream(filePath, FileMode.Create);
                StreamWriter sw = new StreamWriter(fsWrite, Encoding.Default);
                sw.Write(textBox1.Text);
                sw.Close();
                sw.Dispose();
            }
        }

        private void 另存新檔ToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            saveFileDialog1.Filter = "文字檔案(*.txt)|*.txt|所有檔案|*.*";
            saveFileDialog1.FileName = "儲存";
            //saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.AddExtension = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog1.FileName;
                FileStream fsWrite = new FileStream(filePath, FileMode.Create);
                StreamWriter sw = new StreamWriter(fsWrite, Encoding.Default);
                sw.Write(textBox1.Text);
                sw.Close();
                sw.Dispose();
            }
        }

        private void 結束ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        // ==================================================編輯
        private void 復原ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Undo();            
        }
        private void 取消復原ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            msgFake();
        }

        private void 剪下ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }

        private void 複製ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }

        private void 貼上ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }

        private void 全選ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }

        // ==================================================工具
        private void 自訂ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            msgFake();
        }

        private void 選項ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            msgFake();
        }

        // ==================================================格式
        private void 顏色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.ForeColor = colorDialog1.Color;
            }
        }

        private void 字型ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Font = fontDialog1.Font;
            }
        }

        private void toUpperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.ToUpper();
        }

        private void toLowerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.ToLower();
        }

        private void 自動換行ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.WordWrap = !textBox1.WordWrap;
        }
        // ==================================================格式_快選顏色
        private void RedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Red;
        }

        private void GreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Green;
        }

        private void BlackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Black;
        }

        private void BlueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Blue;
        }

        // ==================================================說明
        private void 內容ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            msgFake();
        }

        private void 索引ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            msgFake();
        }

        private void 搜尋ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            msgFake();
        }

        private void 關於ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form12_Notepad_About fna = new Form12_Notepad_About();
            fna.ShowDialog();
        }

        // ==================================================ToolStrip 按鈕
        private void 新增NToolStripButton_Click(object sender, EventArgs e)
        {
            Form12_Notepad fn = new Form12_Notepad();
            fn.Show();
        }

        private void 開啟OToolStripButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                textBox1.Text = sr.ReadToEnd();
                sr.Close();
                sr.Dispose();
            }
        }
        private void 儲存SToolStripButton_Click(object sender, EventArgs e)
        {            
            saveFileDialog1.Filter = "文字檔案(*.txt)|*.txt|所有檔案|*.*";
            saveFileDialog1.FileName = "儲存";
            //saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.AddExtension = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog1.FileName;
                FileStream fsWrite = new FileStream(filePath, FileMode.Create);
                StreamWriter sw = new StreamWriter(fsWrite, Encoding.Default);
                sw.Write(textBox1.Text);
                sw.Close();
                sw.Dispose();
            }
        }

        private void 列印PToolStripButton_Click(object sender, EventArgs e)
        {
            msgFake();
        }

        private void 剪下UToolStripButton_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }

        private void 複製CToolStripButton_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }

        private void 貼上PToolStripButton_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }

        private void 說明LToolStripButton_Click(object sender, EventArgs e)
        {
            Form12_Notepad_About fna = new Form12_Notepad_About();
            fna.ShowDialog();
        }

        // ==================================================Timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
