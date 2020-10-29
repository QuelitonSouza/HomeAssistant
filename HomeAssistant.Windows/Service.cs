using HomeAssistant.Windows.Services;
using System.Diagnostics;
using System.ServiceProcess;
using System.Threading;
using System.Timers;

namespace HomeAssistant.Windows
{
	partial class Service : ServiceBase
	{
		private System.Timers.Timer timer;
		public Service()
		{
			InitializeComponent();
		}

		public void Start(string[] args)
		{
			OnStart(args);
		}

		protected override void OnStart(string[] args)
		{
			timer = new System.Timers.Timer();
			timer.Interval = 30000; // 30 seconds
			timer.Elapsed += new ElapsedEventHandler(this.OnTimer);
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
