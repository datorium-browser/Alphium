﻿namespace AlphiumBrowser
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.ButtonGo = new System.Windows.Forms.ToolStripButton();
			this.AddressBar = new System.Windows.Forms.ToolStripTextBox();
			this.ButtonAddTab = new System.Windows.Forms.ToolStripButton();
			this.ButtonRemoveTab = new System.Windows.Forms.ToolStripButton();
			this.BrowserTabs = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.ButtonChangeTheme = new System.Windows.Forms.ToolStripButton();
			this.toolStrip1.SuspendLayout();
			this.BrowserTabs.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ButtonGo,
            this.AddressBar,
            this.ButtonAddTab,
            this.ButtonRemoveTab,
            this.ButtonChangeTheme});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(600, 39);
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// ButtonGo
			// 
			this.ButtonGo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.ButtonGo.Font = new System.Drawing.Font("Segoe UI", 18F);
			this.ButtonGo.Image = ((System.Drawing.Image)(resources.GetObject("ButtonGo.Image")));
			this.ButtonGo.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.ButtonGo.Name = "ButtonGo";
			this.ButtonGo.Size = new System.Drawing.Size(49, 36);
			this.ButtonGo.Text = "Go";
			this.ButtonGo.Click += new System.EventHandler(this.ButtonGo_Click);
			// 
			// AddressBar
			// 
			this.AddressBar.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AddressBar.Name = "AddressBar";
			this.AddressBar.Size = new System.Drawing.Size(301, 39);
			this.AddressBar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddressBar_KeyDown);
			this.AddressBar.Click += new System.EventHandler(this.AddressBar_Click);
			// 
			// ButtonAddTab
			// 
			this.ButtonAddTab.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.ButtonAddTab.Font = new System.Drawing.Font("Segoe UI", 18F);
			this.ButtonAddTab.Image = ((System.Drawing.Image)(resources.GetObject("ButtonAddTab.Image")));
			this.ButtonAddTab.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.ButtonAddTab.Name = "ButtonAddTab";
			this.ButtonAddTab.Size = new System.Drawing.Size(35, 36);
			this.ButtonAddTab.Text = "+";
			this.ButtonAddTab.Click += new System.EventHandler(this.ButtonAddTab_Click);
			// 
			// ButtonRemoveTab
			// 
			this.ButtonRemoveTab.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.ButtonRemoveTab.Font = new System.Drawing.Font("Segoe UI", 18F);
			this.ButtonRemoveTab.Image = ((System.Drawing.Image)(resources.GetObject("ButtonRemoveTab.Image")));
			this.ButtonRemoveTab.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.ButtonRemoveTab.Name = "ButtonRemoveTab";
			this.ButtonRemoveTab.Size = new System.Drawing.Size(29, 36);
			this.ButtonRemoveTab.Text = "-";
			this.ButtonRemoveTab.Click += new System.EventHandler(this.ButtonRemoveTab_Click);
			// 
			// BrowserTabs
			// 
			this.BrowserTabs.Controls.Add(this.tabPage1);
			this.BrowserTabs.Controls.Add(this.tabPage2);
			this.BrowserTabs.Dock = System.Windows.Forms.DockStyle.Fill;
			this.BrowserTabs.Location = new System.Drawing.Point(0, 39);
			this.BrowserTabs.Margin = new System.Windows.Forms.Padding(2);
			this.BrowserTabs.Name = "BrowserTabs";
			this.BrowserTabs.SelectedIndex = 0;
			this.BrowserTabs.Size = new System.Drawing.Size(600, 327);
			this.BrowserTabs.TabIndex = 1;
			// 
			// tabPage1
			// 
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
			this.tabPage1.Size = new System.Drawing.Size(592, 301);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "tabPage1";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
			this.tabPage2.Size = new System.Drawing.Size(592, 301);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "tabPage2";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// ButtonChangeTheme
			// 
			this.ButtonChangeTheme.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.ButtonChangeTheme.Font = new System.Drawing.Font("Segoe UI", 18F);
			this.ButtonChangeTheme.Image = ((System.Drawing.Image)(resources.GetObject("ButtonChangeTheme.Image")));
			this.ButtonChangeTheme.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.ButtonChangeTheme.Name = "ButtonChangeTheme";
			this.ButtonChangeTheme.Size = new System.Drawing.Size(52, 36);
			this.ButtonChangeTheme.Text = "🎨";
			this.ButtonChangeTheme.Click += new System.EventHandler(this.ButtonChangeTheme_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(600, 366);
			this.Controls.Add(this.BrowserTabs);
			this.Controls.Add(this.toolStrip1);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "Form1";
			this.Text = "Form1";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Browser_FormClosing);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.BrowserTabs.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton ButtonGo;
		private System.Windows.Forms.ToolStripTextBox AddressBar;
		private System.Windows.Forms.TabControl BrowserTabs;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.ToolStripButton ButtonAddTab;
		private System.Windows.Forms.ToolStripButton ButtonRemoveTab;
		private System.Windows.Forms.ToolStripButton ButtonChangeTheme;
	}
}

