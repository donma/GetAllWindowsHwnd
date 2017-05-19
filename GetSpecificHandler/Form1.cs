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

namespace GetSpecificHandler
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        static extern int EnumWindows(CallbackDef callback, int lParam);

      
        [DllImport("user32.dll")]
        static extern int GetWindowText(int hWnd, StringBuilder text, int count);

        delegate bool CallbackDef(int hWnd, int lParam);


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private bool ShowWindowHandler(int hWnd, int lParam)
        {

            string mystring;

            StringBuilder text = new StringBuilder(255);
            GetWindowText(hWnd, text, 255);

            mystring = text.ToString();
            listBox1.Items.Insert(0, text + "," + Convert.ToString((int)hWnd, 16).ToUpper());

            return true;

        }


        private bool ShowIEWindowHandler(int hWnd, int lParam)
        {

            string mystring;

            StringBuilder text = new StringBuilder(255);
            GetWindowText(hWnd, text, 255);

            mystring = text.ToString();
            if(mystring.Contains("Chrome"))
            listBox1.Items.Insert(0, text + "," + Convert.ToString((int)hWnd, 16).ToUpper());

            return true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            CallbackDef callback = new CallbackDef(ShowWindowHandler);
            EnumWindows(callback, 0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            CallbackDef callback = new CallbackDef(ShowIEWindowHandler);
            EnumWindows(callback, 0);
        }
    }
}
