using HomeAssistant.Windows.Config;
using HomeAssistant.Windows.Enums;
using HomeAssistant.Windows.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeAssistant.Windows
{
	class Program
	{
		static void Main(string[] args)
		{
			ServiceBase[] ServicesToRun;
			ServicesToRun = new ServiceBase[]
			{
				new Service()
			};
			ServiceBase.Run(ServicesToRun);
		}
	}
}
