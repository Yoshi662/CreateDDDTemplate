using System.Diagnostics;

namespace CreateDDDTemplate
{
	public static class Utils
	{
		public static string GetCurrentPath()
		{
			return Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
		}
		public static void ExecuteDotNet(string args)
		{
			Process dotnet = new Process()
			{
				StartInfo = new ProcessStartInfo()
				{
					FileName = "dotnet",
					Arguments = args,
					CreateNoWindow = true,
				}
			};
			dotnet.Start();
			dotnet.WaitForExit();
		}
	}
}
