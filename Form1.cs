﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

namespace AlphiumBrowser
{
    public partial class AlphiumBrowser : Form
    {
        public ChromiumWebBrowser currentBrowser = null;
        public ChromiumWebBrowser chromeBrowser = null;
        private string initialURL = "https://datorium.eu";
        public string WebTitle;

        public AlphiumBrowser()
        {
            InitializeComponent();
            InitializeChromium();
            InitializeBrowserTabs();
        }

        public void InitializeChromium()
        {
            CefSettings settings = new CefSettings();
            // Initialize cef with the provided settings
            Cef.Initialize(settings);
        }

        private void InitializeBrowserTabs()
        {
            BrowserTabs.TabPages.Clear();
            AddNewTab();
        }

        private void Browser_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cef.Shutdown();
        }

        private void ButtonGo_Click(object sender, EventArgs e)
        {
            NavigateToURL();
        }
        private void AddressBar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                NavigateToURL();
            }
        }


        private void NavigateToURL()
        {
            string googleURL = $"https://www.google.com/search?q=";
            string addressBarUrl = AddressBar.Text;

            currentBrowser = (ChromiumWebBrowser)BrowserTabs.SelectedTab.Controls[0];

            bool urlPrefix =
                addressBarUrl.Contains("https://") ||
                addressBarUrl.Contains("http://") ||
                addressBarUrl.Contains("www.");
            if (urlPrefix)
            {
                currentBrowser.Load(addressBarUrl);
            }
            else
            {
                currentBrowser.Load(googleURL + addressBarUrl);
            }

            currentBrowser.TitleChanged += Browser_TitleChanged;
        }



        private void ButtonAddTab_Click(object sender, EventArgs e)
        {
            AddNewTab();
        }
        private void Browser_TitleChanged(object sender, TitleChangedEventArgs e)
        {
            WebTitle = e.Title;
            Invoke(new Action(() => BrowserTabs.SelectedTab.Text = WebTitle));
        }

        private void AddNewTab()
        {
            var tp = new TabPage();
            tp.Text = "Datorium";
            BrowserTabs.TabPages.Add(tp);
            chromeBrowser = new ChromiumWebBrowser(initialURL);
            tp.Controls.Add(chromeBrowser);
            chromeBrowser.Dock = DockStyle.Fill;
            
        }

        private void ButtonRemoveTab_Click(object sender, EventArgs e)
        {
            var tp = BrowserTabs.TabPages[BrowserTabs.TabPages.Count - 1];
            var mtp = BrowserTabs.TabCount;
            if (mtp != 1)
			{
				BrowserTabs.TabPages.Remove(tp);
				tp.Controls.Remove(chromeBrowser);
			}
			else
			{
                this.Close();
            }
		}
        private void AddressBar_Click(object sender, EventArgs e)
        {

        }

		private void ButtonChangeTheme_Click(object sender, EventArgs e)
		{
            if (this.BackColor != Color.Black)
            {
                this.BackColor = Color.Black;
                toolStrip1.BackColor = Color.Black;
                ButtonAddTab.ForeColor = Color.WhiteSmoke;
                ButtonGo.ForeColor = Color.WhiteSmoke;
                ButtonRemoveTab.ForeColor = Color.WhiteSmoke;
                ButtonChangeTheme.ForeColor = Color.WhiteSmoke;
                ButtonBackward.ForeColor = Color.WhiteSmoke;
                ButtonForward.ForeColor = Color.WhiteSmoke;
                ButtonReload.ForeColor = Color.WhiteSmoke;
                AddressBar.BackColor = Color.DarkOrange;
                AddressBar.ForeColor = Color.White;
            }
            else 
            {
                this.BackColor = Color.WhiteSmoke;
                toolStrip1.BackColor = Color.WhiteSmoke;
                ButtonAddTab.ForeColor = Color.Black;
                ButtonGo.ForeColor = Color.Black;
                ButtonRemoveTab.ForeColor = Color.Black;
                ButtonChangeTheme.ForeColor = Color.Black;
                ButtonBackward.ForeColor = Color.Black;
                ButtonForward.ForeColor = Color.Black;
                ButtonReload.ForeColor = Color.Black;
                AddressBar.BackColor = Color.White;
                AddressBar.ForeColor = Color.Black;
            }
		}

		private void ButtonBackward_Click(object sender, EventArgs e)
		{
            currentBrowser = (ChromiumWebBrowser)BrowserTabs.SelectedTab.Controls[0];
            currentBrowser.Back();
        }

		private void ButtonForward_Click(object sender, EventArgs e)
        {
            currentBrowser = (ChromiumWebBrowser)BrowserTabs.SelectedTab.Controls[0];
            currentBrowser.Forward();
        }

		private void ButtonReload_Click(object sender, EventArgs e)
		{
            currentBrowser = (ChromiumWebBrowser)BrowserTabs.SelectedTab.Controls[0];
            currentBrowser.Reload();
        }
	}
}

