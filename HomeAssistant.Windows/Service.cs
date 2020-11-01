using HomeAssistant.Windows.Forms;
using HomeAssistant.Windows.Services;
using System;
using System.Diagnostics;
using System.Drawing;
using System.ServiceProcess;
using System.Threading;
using System.Timers;
using System.Windows.Forms;

namespace HomeAssistant.Windows
{
	partial class Service : ServiceBase
	{
		private System.Timers.Timer timer;

		public Service()
		{
			InitializeComponent();
		}

#if DEBUG
		public void Start(string[] args)
		{
			OnStart(args);
		}
#endif

		protected override void OnStart(string[] args)
		{
			timer = new System.Timers.Timer(15000);
			this.timer.AutoReset = true;
			this.timer.Elapsed += new System.Timers.ElapsedEventHandler(OnTimer);
			timer.Start();
		}

		protected override void OnStop()
		{
			this.timer.Stop();
			this.timer = null;
		}

		public void OnTimer(object sender, ElapsedEventArgs args)
		{
			this.timer.Stop();
			new ChangeStatusService().MonitorBatery();
			this.timer.Start();
		}
	}
}
