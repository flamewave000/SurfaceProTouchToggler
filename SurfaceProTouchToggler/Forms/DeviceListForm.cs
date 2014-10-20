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
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SurfaceProTouchToggler.Forms
{
	public partial class DeviceListForm : Form
	{
		#region Constructors
		public DeviceListForm()
		{
			InitializeComponent();

			// Get the list of devices on the computer
			string[] results = ShellProcess.Run(DevConUri.Path.LocalPath, " find *");
			string text = "";
			foreach (string line in results)
			{
				if (line == null)
					continue;
				text += line + "\r\n";
			}
			deviceListBox.Text = text;
		}
		#endregion
	}
}
