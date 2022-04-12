using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CefSharp;
using CefSharp.WinForms;
using System.Windows.Forms;

namespace TSoftRestApiTestApp
{
    public partial class WebBrowser : Form
    {
        public string url;

        ChromiumWebBrowser browser;

        public void InitBrowser()
        {

            if (Cef.IsInitialized)
            {
                Cef.Shutdown();
            }

            Cef.Initialize(new CefSettings()); 
            browser = new ChromiumWebBrowser(url);
            this.Controls.Add(browser);
            browser.Dock = DockStyle.Fill;
        }


        public WebBrowser()
        {
            InitializeComponent();
        }

        private void WebBrowser_Load(object sender, EventArgs e)
        {

            InitBrowser();
        }

        private void WebBrowser_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cef.Shutdown();

        }
    }
}
