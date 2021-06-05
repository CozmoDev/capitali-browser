using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capitali_browser_1
{
    public partial class Form1 : Form
    {
        public CefSharp.WinForms.ChromiumWebBrowser browser;
        public Form1()
        {
            InitializeComponent();
            browser = new CefSharp.WinForms.ChromiumWebBrowser("http://theoldnet.com/browser/")
            {
                Dock = DockStyle.Fill,
            };
            chromiumbrowser.Controls.Add(browser);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            button4.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            button2.BringToFront();
        }

        private void geckoWebBrowser1_Click(object sender, EventArgs e)
        {

        }

        private void chromiumWebBrowser1_LoadingStateChanged(object sender, CefSharp.LoadingStateChangedEventArgs e)
        {

        }
    }
}
