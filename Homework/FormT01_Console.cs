using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework
{
    public partial class FormT01_Console : Form
    {       
        public FormT01_Console()
        {
            InitializeComponent();
            AllocConsole();
            Console.Beep();
            ConsoleColor oriColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("* Don't close this console window or the application will also close.");
            Console.WriteLine();
            Console.ForegroundColor = oriColor;

            Console.WriteLine("123456");
        }
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        [DllImport("Kernel32")]
        public static extern void FreeConsole();        
    }
}
