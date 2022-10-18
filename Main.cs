using MelonLoader;
using System;
using System.Runtime.InteropServices;


using ABI_RC.Core.Savior;


namespace MinimiseOnLoad
{
	public static class BuildInfo
	{
		public const string Name = "MinimiseOnLoad";
		public const string Description = "Loads configs from a different file because Proton :)";
		public const string Author = "CrispyPin";
		public const string Version = "0.1.0";
		public const string DownloadLink = "https://github.com/CrispyPin/CVR-MinimiseOnLoad/releases";
	}

	public class MinimiseOnLoadMod : MelonMod
	{
		[DllImport("user32.dll")]
		private static extern bool ShowWindow(IntPtr hwnd, int nCmdShow);
		[DllImport("user32.dll")]
		private static extern IntPtr GetActiveWindow();

		public override void OnSceneWasLoaded(int buildIndex, string sceneName)
		{
			if (buildIndex == -1 && MetaPort.Instance.isUsingVr)
			{
				ShowWindow(GetActiveWindow(), 2);
			}
		}
	}
}