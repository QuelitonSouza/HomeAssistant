using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssistant.Windows.Dto
{

	public class dtoChart
	{
		public List<DtoChartOn> On { get; set; }
		public List<DtoChartOff> Off { get; set; }

		public dtoChart()
		{
			On = new List<DtoChartOn>();
			Off = new List<DtoChartOff>();
		}
	}

	public class DtoChartOn
	{
		public string Description { get; set; }
		public int Index { get; set; }
		public double Time { get; set; }
	}

	public class DtoChartOff 
	{
		public string Description { get; set; }
		public int Index { get; set; }
		public double Time { get; set; }
	}
}
