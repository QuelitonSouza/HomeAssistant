using System;
using System.Threading;
using System.Timers;
using Timer = System.Timers.Timer;

namespace HomeAssistant.Windows.Services
{
	public class ConfigService
	{
		internal Timer TimeService;
		Thread _thrService;

		public ConfigService()
		{
			var intervaloService = TimeSpan.FromSeconds(30).TotalMilliseconds;
			TimeService = new Timer(intervaloService);
			TimeService.AutoReset = true;
			TimeService.Elapsed += timer_ElapsedTimerService;
		}

		public void Star()
		{
			TimeService.Start();
		}

		public void Stop()
		{
			if (TimeService != null)
			{
				TimeService.Stop();
				TimeService.Dispose();
			}
		}

		private void timer_ElapsedTimerService(object sender, ElapsedEventArgs e)
		{
			if (_thrService == null || !_thrService.IsAlive)
			{
				_thrService = new Thread(runService);
				_thrService.IsBackground = true;
				_thrService.Name = "Thread Service Home Assistant";
				_thrService.Start();
			}
		}

		public void runService()
		{
			new ChangeStatusService().MonitorBatery();
		}
	}
}
