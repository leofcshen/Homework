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
    public partial class Form00_MessageBox : Form
    {        
        public Form00_MessageBox()
        {
            InitializeComponent();
        }

        // 方法：try catch 通用錯誤視窗
        internal static void msgError(Exception ex)
        {
            MessageBox.Show($"Error code = {ex.Message}, 請檢查程式碼或輸入值", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }       
    }
}
