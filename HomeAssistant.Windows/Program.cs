using System;
using System.Windows.Forms;

namespace HomeAssistant.Windows
{
	public class Program
	{
		[STAThread]
		public static void Main(string[] args)
		{
			try
			{
#if !DEBUG
				Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
				key.DeleteValue("HOMEASSISTANT", false);

				//Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
				key.SetValue("HOMEASSISTANT", Application.ExecutablePath);
#endif


				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(false);
				Application.Run(new SettingsApplicationContext());
			}
			catch (Exception ex)
			{
				ex.Message.ToString();
			}
		}
	}
}
