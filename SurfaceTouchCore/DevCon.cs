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

namespace SurfaceTouchCore
{
	public static class DevCon
	{
		public static Uri GetPath()
		{
			Version os = Environment.OSVersion.Version;
			if (os.Major != 6 || (os.Minor != 2 && os.Minor != 3))
			{
				throw new NotSupportedException("Running unsupported OS version. Only Windows 8 and Windows 8.1 are supported");
			}
			string path;
			if (os.Minor == 2)
			{
				if (Environment.Is64BitOperatingSystem)
					path = Resources.devcon_8_0_64 + Resources.devcon_exe;
				else
					path = Resources.devcon_8_0_86 + Resources.devcon_exe;
			}
			else
			{
				if (Environment.Is64BitOperatingSystem)
					path = Resources.devcon_8_1_64 + Resources.devcon_exe;
				else
					path = Resources.devcon_8_1_86 + Resources.devcon_exe;
			}
			return new Uri(new Uri(Environment.CurrentDirectory + "\\", UriKind.Absolute), path);
		}

		public static string[] GetDevices()
		{
			return ShellProcess.Run(GetPath().LocalPath, " find *");
		}

		public static string[] EnableDevice(string hardwareId)
		{
			return ShellProcess.Run(GetPath().LocalPath, String.Format(Resources.devcon_enable, hardwareId));
		}

		public static string[] DisableDevice(string hardwareId)
		{
			return ShellProcess.Run(GetPath().LocalPath, String.Format(Resources.devcon_disable, hardwareId));
		}

		internal static string[] GetStatus(string hardwareId)
		{
			return ShellProcess.Run(GetPath().LocalPath, String.Format(Resources.devcon_status, hardwareId));
		}
	}
}
