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
using SurfaceProTouchToggler.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace SurfaceProTouchToggler.Forms
{
	public partial class SettingsForm : Form
	{
		/// <summary>
		/// The path to the key where Windows looks for startup applications
		/// </summary>
		private static RegistryKey rkApp = Registry.CurrentUser.OpenSubKey(Resources.registry_autorun_string, true);

		/// <summary>
		/// True if the app is set to run at windows start
		/// </summary>
		public static bool RunAtStartup
		{
			get
			{
				object value = rkApp.GetValue(AboutBox.AssemblyTitle, null);
				return value != null && (string)value != "False";
			}
		}

		#region Constructors
		public SettingsForm()
		{
			InitializeComponent();
			// Set the text field values
			hardwareIdTextBox.Text = Settings.Default.hardware_id;
			deviceEnabledTextBox.Text = Settings.Default.text_enabled;
			deviceDisabledTextBox.Text = Settings.Default.text_disabled;
			runAtStartCheckBox.Checked = RunAtStartup;
		}
		#endregion


		#region Event Handlers
		private void saveButton_Click(object sender, EventArgs e)
		{
			Settings.Default.hardware_id = hardwareIdTextBox.Text;
			Settings.Default.text_enabled = deviceEnabledTextBox.Text;
			Settings.Default.text_disabled = deviceDisabledTextBox.Text;
			Settings.Default.Save();

			if (RunAtStartup != runAtStartCheckBox.Checked)
			{
				if (runAtStartCheckBox.Checked)
				{
					rkApp.SetValue(AboutBox.AssemblyTitle, '"' + Application.ExecutablePath.ToString() + '"');
				}
				else
				{
					rkApp.DeleteValue(AboutBox.AssemblyTitle, true);
				}
			}

			UpdateSaveButton(this, EventArgs.Empty);
		}
		private void deviceListButton_Click(object sender, EventArgs e)
		{
			DeviceListForm devices = new DeviceListForm();
			devices.ShowDialog(this);
		}
		private void UpdateSaveButton(object sender, EventArgs e)
		{
			saveButton.Enabled =
				hardwareIdTextBox.Text != Settings.Default.hardware_id ||
				deviceEnabledTextBox.Text != Settings.Default.text_enabled ||
				deviceDisabledTextBox.Text != Settings.Default.text_disabled ||
				runAtStartCheckBox.Checked != RunAtStartup;
		}
		private void editHardwareIdButton_Click(object sender, EventArgs e)
		{
			editHardwareIdButton.Visible = false;
			hardwareIdTextBox.Visible = true;
		}
		#endregion
	}
}
