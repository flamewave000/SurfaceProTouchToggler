/**
 * Copyright (C) 2014  flamewave000
 * 
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 * 
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <http://www.gnu.org/licenses/>
 * 
 * This program can be used to enable and disable other types of files.
 * By modifying the hardware id in the settings to any other device,
 * the program will effectively toggle that device.
 */
namespace SurfaceProTouchToggler.Forms
{
	partial class Main
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
			this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.mainMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.optionsFlyout = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutButton = new System.Windows.Forms.ToolStripMenuItem();
			this.settingsButton = new System.Windows.Forms.ToolStripMenuItem();
			this.exitButton = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.enableTouch = new System.Windows.Forms.ToolStripMenuItem();
			this.disableTouch = new System.Windows.Forms.ToolStripMenuItem();
			this.mainMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// notifyIcon
			// 
			this.notifyIcon.ContextMenuStrip = this.mainMenu;
			this.notifyIcon.Text = "Toggle Touch Screen";
			this.notifyIcon.Visible = true;
			this.notifyIcon.Click += new System.EventHandler(this.notifyIcon_Click);
			// 
			// mainMenu
			// 
			this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsFlyout,
            this.toolStripSeparator1,
            this.enableTouch,
            this.disableTouch});
			this.mainMenu.Name = "contextMenuStrip1";
			this.mainMenu.Size = new System.Drawing.Size(117, 76);
			// 
			// optionsFlyout
			// 
			this.optionsFlyout.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutButton,
            this.settingsButton,
            this.exitButton});
			this.optionsFlyout.Name = "optionsFlyout";
			this.optionsFlyout.Size = new System.Drawing.Size(116, 22);
			this.optionsFlyout.Text = "Options";
			// 
			// aboutButton
			// 
			this.aboutButton.Name = "aboutButton";
			this.aboutButton.Size = new System.Drawing.Size(116, 22);
			this.aboutButton.Text = "About";
			// 
			// settingsButton
			// 
			this.settingsButton.Name = "settingsButton";
			this.settingsButton.Size = new System.Drawing.Size(116, 22);
			this.settingsButton.Text = "Settings";
			// 
			// exitButton
			// 
			this.exitButton.Name = "exitButton";
			this.exitButton.Size = new System.Drawing.Size(116, 22);
			this.exitButton.Text = "Exit";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(113, 6);
			// 
			// enableTouch
			// 
			this.enableTouch.Name = "enableTouch";
			this.enableTouch.Size = new System.Drawing.Size(116, 22);
			this.enableTouch.Text = "Enable";
			// 
			// disableTouch
			// 
			this.disableTouch.Name = "disableTouch";
			this.disableTouch.Size = new System.Drawing.Size(116, 22);
			this.disableTouch.Text = "Disable";
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(124, 23);
			this.ControlBox = false;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Main";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
			this.mainMenu.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.NotifyIcon notifyIcon;
		private System.Windows.Forms.ContextMenuStrip mainMenu;
		private System.Windows.Forms.ToolStripMenuItem enableTouch;
		private System.Windows.Forms.ToolStripMenuItem disableTouch;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem optionsFlyout;
		private System.Windows.Forms.ToolStripMenuItem aboutButton;
		private System.Windows.Forms.ToolStripMenuItem settingsButton;
		private System.Windows.Forms.ToolStripMenuItem exitButton;
	}
}