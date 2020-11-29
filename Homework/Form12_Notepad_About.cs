using System;
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
    public partial class Form12_Notepad_About : Form
    {
        public Form12_Notepad_About()
        {
            InitializeComponent();
            CenterToScreen();
            label2.Text = "C#的記事本作業測試，\n敬請您安心服用。";
        }
    }
}
