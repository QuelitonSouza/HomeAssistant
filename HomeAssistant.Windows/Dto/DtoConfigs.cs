using HomeAssistant.Windows.Enums;

namespace HomeAssistant.Windows.Dto
{
	public class DtoConfigs
	{
		public string UserName { get; set; }
		public string Password { get; set; }
		public StatusDeviceEnum LastStateDevice { get; set; }
		public float BatteryLifePercentLow { get; set; }
		public float BatteryLifePercentHigh { get; set; }
	}
}
