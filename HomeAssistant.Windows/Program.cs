using HomeAssistant.Windows.Config;
using HomeAssistant.Windows.Enums;
using HomeAssistant.Windows.Forms;
using HomeAssistant.Windows.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeAssistant.Windows
{
	public class Program
	{

		public static Thread _thrNotifyMenu;

		public static void RunMenuHomeAssistante()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new SettingsApplicationContext());
		}

		[STAThread]
		public static void Main(string[] args)
		{



#if (DEBUG)

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new SettingsApplicationContext());

			Service service = new Service();
			service.Start(args);
			Thread.Sleep(Timeout.Infinite);
			service.Stop();
#else

			try
			{
				//Thread.Sleep(TimeSpan.FromSeconds(30));

				//if (_thrNotifyMenu == null || !_thrNotifyMenu.IsAlive)
				//{
				//	_thrNotifyMenu = new Thread(RunMenuHomeAssistante);
				//	_thrNotifyMenu.IsBackground = true;
				//	_thrNotifyMenu.Name = "Thread menu HomeAssistant";
				//	_thrNotifyMenu.Start();
				//}

				ServiceBase[] ServicesToRun;
				ServicesToRun = new ServiceBase[]
				{
				new Service()
				};
				ServiceBase.Run(ServicesToRun);
			}
			catch(Exception ex)
			{
				ex.Message.ToString();
			}
#endif
		}
	}

	public class SettingsApplicationContext : ApplicationContext
	{
		private NotifyIcon trayIcon;

		public SettingsApplicationContext()
		{
			trayIcon = new NotifyIcon()
			{
				Icon = new Icon(this.GetType(), "home.ico"),
				ContextMenu = new ContextMenu(new MenuItem[] {
				new MenuItem("Settings", Openmenu),
				new MenuItem("Exit", Exit),

			}),
				Visible = true
			};
#if (DEBUG)
			trayIcon.Text = "Home Assistant - TESTE";
			trayIcon.Visible = true;
#else
			trayIcon.Text = "Home Assistant";
			trayIcon.Visible = true;
#endif
		}


		void Openmenu(object sender, EventArgs e)
		{
			var form = new FormMenu();
			form.ShowDialog();
		}

		void Exit(object sender, EventArgs e)
		{
			trayIcon.Visible = false;
			Application.Exit();
		}
	}
}
