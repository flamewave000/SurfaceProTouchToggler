using System.Linq;
using System.Text.RegularExpressions;

namespace SurfaceTouchCore
{
	public class TouchManager
	{
		public string HardwareId { get; }
		public bool? IsEnabled
		{
			get
			{
				string[] result = DevCon.GetStatus(HardwareId);
				foreach (string line in result)
				{
					if (line == null) break;
					if (line.Contains("No matching devices")) return null;
					if (Regex.Match(line, Resources.regex_disabled, RegexOptions.IgnoreCase).Success)
					{
						return false;
					}
				}
				return true;
			}
		}

		public TouchManager(string hardwareId)
		{
			HardwareId = hardwareId;
		}

		public bool Enable()
		{
			string[] lines = DevCon.EnableDevice(HardwareId);
			if (lines.Any(x => x != null && x.Contains("No matching devices")))
			{
				return false;
			}
			return true;
		}

		public bool Disable()
		{
			string[] lines = DevCon.DisableDevice(HardwareId);
			if (lines.Any(x => x != null && x.Contains("No matching devices")))
			{
				return false;
			}
			return true;
		}
	}
}
