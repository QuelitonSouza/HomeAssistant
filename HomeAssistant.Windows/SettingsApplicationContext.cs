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
	public class SettingsApplicationContext : ApplicationContext
	{
		private NotifyIcon trayIcon;
		private ConfigService service;

		public SettingsApplicationContext()
		{
			trayIcon = new NotifyIcon()
			{
				Icon = new Icon(this.GetType(), "home.ico"),
				ContextMenu = new ContextMenu(new MenuItem[] {
					new MenuItem("Configurações", Openmenu),
					new MenuItem("Fechar", Exit),

				})
			};

#if (DEBUG)
			trayIcon.Text = "Home Assistant - TESTE";
			trayIcon.Visible = true;
#else
			trayIcon.Text = "Home Assistant";
			trayIcon.Visible = true;
#endif

			service = new ConfigService();
			service.Star();
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
