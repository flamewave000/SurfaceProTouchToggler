﻿/**
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
using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using SurfaceProTouchToggler.Properties;
using SurfaceTouchCore;

namespace SurfaceProTouchToggler.Forms
{
	public partial class Main : Form
	{
		#region Instance Variables
		/// <summary>
		/// True if touch is enabled on the device
		/// </summary>
		private bool _touchEnabled = true;
		#endregion


		#region Properties
		/// <summary>
		/// True if touch is enabled on the device
		/// </summary>
		public bool TouchEnabled
		{
			get { return _touchEnabled; }
			private set
			{
				_touchEnabled = value;
				if (value)
				{
					notifyIcon.Text = Settings.text_enabled;
					notifyIcon.Icon = new Icon(Resources.icon_enabled);
				}
				else
				{
					notifyIcon.Text = Settings.text_disabled;
					notifyIcon.Icon = new Icon(Resources.icon_disabled);
				}
				enableTouch.Enabled = !value;
				disableTouch.Enabled = value;
			}
		}

		/// <summary>
		/// Helper property for accessing the settings
		/// </summary>
		private Settings Settings { get { return Settings.Default; } }

		private TouchManager TouchManager { get; set; }
		#endregion


		#region Constructors
		public Main()
		{
			InitializeComponent();

			// Subscribe to the different buttons
			enableTouch.Click += enableTouch_Click;
			disableTouch.Click += disableTouch_Click;
			exitButton.Click += exitButton_Click;
			aboutButton.Click += (sender, e) => { AboutBox about = new AboutBox(); about.ShowDialog(this); };
			settingsButton.Click += (sender, e) => { SettingsForm settings = new SettingsForm(); settings.ShowDialog(this); };

			TouchManager = new TouchManager(Settings.hardware_id);

			// Determine if the device is enabled or disabled
			TouchEnabled = TouchManager.IsEnabled == true;
		}
		#endregion


		#region Overrides
		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);
			Hide();
		}
		#endregion


		#region Event Handlers
		/// <summary>
		/// Enable the device
		/// </summary>
		protected void enableTouch_Click(object sender, EventArgs e)
		{
			if (TouchManager.Enable())
				TouchEnabled = true;
		}
		/// <summary>
		/// Disable the device
		/// </summary>
		protected void disableTouch_Click(object sender, EventArgs e)
		{
			if (TouchManager.Disable())
				TouchEnabled = false;
		}
		/// <summary>
		/// Exit the windows forms application
		/// </summary>
		protected void exitButton_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		/// <summary>
		/// Open the context menu when user left clicks the notify icon
		/// </summary>
		private void notifyIcon_Click(object sender, EventArgs e)
		{
			MethodInfo mi = typeof(NotifyIcon).GetMethod("ShowContextMenu", BindingFlags.Instance | BindingFlags.NonPublic);
			mi.Invoke(notifyIcon, null);
		}
		#endregion
	}
}
