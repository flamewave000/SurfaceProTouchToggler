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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SurfaceProTouchToggler.Properties;

namespace SurfaceProTouchToggler
{
	/// <summary>
	/// Helper class for defining the correct URI to the DevCon program based on the computer's OS version and architecture
	/// </summary>
	public class DevConUri
	{
		#region Class Variables
		/// <summary>
		/// The calculated relative path to the DevCon program
		/// </summary>
		private static string _path = "";
		#endregion

		#region Class Properties
		/// <summary>
		/// The absolute URI path to the DevCon program
		/// </summary>
		public static Uri Path
		{
			get;
			private set;
		}
		#endregion

		#region Constructors
		/// <summary>
		/// Determines the path to the DevCon program upon the first static reference to this helper class
		/// </summary>
		static DevConUri()
		{
			Version os = Environment.OSVersion.Version;
			if (os.Major != 6 || (os.Minor != 2 && os.Minor != 3))
			{
				MessageBox.Show("Running unsupported OS version. Only Windows 8 and Windows 8.1 are supported", "Unsupported OS", MessageBoxButtons.OK);
				Application.Exit();
			}
			if (os.Minor == 2)
			{
				if (System.Environment.Is64BitOperatingSystem)
					_path = Resources.devcon_8_0_x64_uri + Resources.devcon_exe;
				else
					_path = Resources.devcon_8_0_x86_uri + Resources.devcon_exe;
			}
			else
			{
				if (System.Environment.Is64BitOperatingSystem)
					_path = Resources.devcon_8_1_x64_uri + Resources.devcon_exe;
				else
					_path = Resources.devcon_8_1_x86_uri + Resources.devcon_exe;
			}
			Path = new Uri(new Uri(Environment.CurrentDirectory + "\\", UriKind.Absolute), _path);
		}

		/// <summary>
		/// This is a static access only class
		/// </summary>
		private DevConUri()
		{ }
		#endregion
	}
}
