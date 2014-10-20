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
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurfaceProTouchToggler
{
	/// <summary>
	/// A helper class for running a shell command process
	/// </summary>
	public class ShellProcess
	{
		#region Class Variables
		/// <summary>
		/// Holds the data printed to standard output by the shell command
		/// </summary>
		private static List<string> _data = new List<string>();
		#endregion


		#region Class Properties
		/// <summary>
		/// The data printed by the previously run shell command
		/// </summary>
		public static string[] DataFromLastProcess
		{
			get { return _data.ToArray(); }
		}
		#endregion


		#region Public Class Methods
		/// <summary>
		/// Runs a single shell command and returns the result data
		/// </summary>
		/// <param name="command">A string defining the shell command to be run</param>
		/// <param name="arguments">A string containing the arguments to be passed to the shell command</param>
		/// <returns>Array of strings where each string is a line of output</returns>
		public static string[] Run(string command, string arguments)
		{
			_data.Clear();
			Process process = new Process();
			process.OutputDataReceived += (object sender, DataReceivedEventArgs e) => { _data.Add(e.Data); };
			process.StartInfo = new ProcessStartInfo(command, arguments);
			process.StartInfo.RedirectStandardOutput = true;
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.CreateNoWindow = true;
			process.Start();
			process.BeginOutputReadLine();
			process.WaitForExit();
			process.Close();
			return _data.ToArray();
		}
		#endregion
	}
}
