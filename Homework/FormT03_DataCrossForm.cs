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
    public partial class FormT03_DataCrossForm : Form
    {
        public FormT03_DataCrossForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormT03_DataCrossForm_1 f = new FormT03_DataCrossForm_1(this);            
            f.Show();

        }
    }
}
