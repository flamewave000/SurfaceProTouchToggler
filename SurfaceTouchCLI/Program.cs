using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using SurfaceTouchCore;

namespace SurfaceTouchCLI
{
	class Program
	{
		static string ProgramName = Assembly.GetExecutingAssembly().GetName().Name;
		static string[] args;
		static bool verbose = false;

		static TouchManager touchManager;
		static StreamReader reader;
		static StreamWriter writer;

		static void Main(string[] args)
		{
			Program.args = args.Where(x =>
			{
				if (x == "-v")
				{
					verbose = true;
					return false;
				}
				return true;
			}).ToArray();

			using (FileStream file = new FileStream("./hardware_id", FileMode.OpenOrCreate, FileAccess.ReadWrite))
			{
				reader = new StreamReader(file);
				writer = new StreamWriter(file);
				touchManager = new TouchManager(reader.ReadToEnd());
				if (Program.args.Length == 0) ShowHelp();
				else if (Program.args.Length == 1) SingleArg(Program.args[0]);
				else if (Program.args.Length == 2) DoubleArgs(Program.args[0], Program.args[1]);
			}
			if (Debugger.IsAttached)
				Console.ReadKey();
		}

		static void ShowHelp(string error = null)
		{
			Console.WriteLine($@"{(error != null ? error : "")}
Usage: {ProgramName} [-v] [option]
    -v        Verbose mode
    status    Shows as 'enabled', 'disabled' or 'not set'
    list      Lists the Hardware IDs for the system
    enable    Enables the hardware ID that has been set
    disable   Disables the hardware ID that has been set
    set <id>  Sets the given hardware ID for enabling and disabling");
		}

		static Action GetCommand(string arg)
		{
			switch (arg)
			{
				case "status":
					return ShowStatus;
				case "list":
					return ListDevices;
				case "enable":
					return EnableDevice;
				case "disable":
					return DisableDevice;
				default:
					return null;
			}
		}

		static void SingleArg(string arg)
		{
			var command = GetCommand(arg);
			if (command == null)
				ShowHelp($"Unknown command '{arg}'");
			else
				command();
		}

		static void DoubleArgs(string first, string second)
		{
			if (first != "set")
			{
				if (GetCommand(first) == null)
					ShowHelp($"Unknown command '{first}'");
				else
					ShowHelp($"Command '{first}' does not take additional arguments");
				return;
			}
			SetDeviceID(second);
		}

		static void ShowStatus()
		{
			if (String.IsNullOrWhiteSpace(touchManager.HardwareId))
			{
				Console.WriteLine(verbose ? $"No hardware ID set. Use '{ProgramName} set <id>' to set one" : "no id");
				return;
			}
			bool? isEnabled = touchManager.IsEnabled;
			if (verbose)
			{
				if (isEnabled == null)
					Console.WriteLine("The hardware device id is invalid");
				else
					Console.WriteLine("The hardware device is " + (isEnabled == true ? "enabled" : "disabled"));
			}
			else
				Console.WriteLine(isEnabled == true ? "enabled" : isEnabled == false ? "disabled" : "invalid");
		}
		static void EnableDevice()
		{
			if (String.IsNullOrWhiteSpace(touchManager.HardwareId))
			{
				Console.WriteLine(verbose ? $"No hardware ID set. Use '{ProgramName} set <id>' to set one" : "no id");
				return;
			}
			if (touchManager.Enable())
			{
				if (verbose) Console.WriteLine("Device Enabled");
			}
			else
				Console.WriteLine(verbose ? "The hardware device id is invalid" : "invalid");
		}
		static void DisableDevice()
		{
			if (String.IsNullOrWhiteSpace(touchManager.HardwareId))
			{
				Console.WriteLine(verbose ? $"No hardware ID set. Use '{ProgramName} set <id>' to set one" : "no id");
				return;
			}
			if (touchManager.Disable())
			{
				if (verbose) Console.WriteLine("Device Disabled");
			}
			else
				Console.WriteLine(verbose ? "The hardware device id is invalid" : "invalid");
		}
		static void ListDevices()
		{
			if (verbose) Console.WriteLine("Device Hardware ID List");
			string[] lines = DevCon.GetDevices();
			foreach (string line in lines)
			{
				Console.WriteLine(line);
			}
			if (verbose) Console.WriteLine($"Total Devices: {lines.Length}");
		}
		static void SetDeviceID(string id)
		{
			writer.BaseStream.SetLength(0);
			writer.Write(id);
			writer.Flush();

			string[] devices = DevCon.GetDevices();
			string stripped = id.Replace("*", "");
			if (devices.Any(x => x != null && x.Contains(stripped)))
			{
				if (verbose) Console.WriteLine($"Hardware ID set to '{id}'");
			}
			else
				Console.WriteLine(verbose ? "The hardware device id is invalid" : "invalid");
		}
	}
}
