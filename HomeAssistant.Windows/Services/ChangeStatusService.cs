using HomeAssistant.Windows.Enums;
using HomeAssistant.Windows.Config;
using System.Windows.Forms;
using HomeAssistant.Windows.Dto;

namespace HomeAssistant.Windows.Services
{
	public class ChangeStatusService
	{
		private DtoConfigs confgis = null;

		public bool ChangeStatusSwitch(StatusDeviceEnum OnOrOff)
		{
			var resultAuth = new WriterAndReadAuth().ReadAuth();
			var IsUpdateJson = resultAuth == null || resultAuth.IsExpired;
			if (IsUpdateJson)
			{
				resultAuth = new WebClientApi().auth(confgis);
				new WriterAndReadAuth().WriterAuth(resultAuth);
			}

			var resultDevices = new WriterAndReadDevices().ReadDevices();
			if (resultDevices == null || IsUpdateJson)
			{
				resultDevices = new WebClientApi(resultAuth).GetDevices(resultAuth);
				new WriterAndReadDevices().WriterDevices(resultDevices);
			}

			var resultDevice = new WebClientApi(resultAuth).ChangeStatusDevice(resultAuth, resultDevices, (int)OnOrOff);
			var result = resultDevice != null && resultDevice.header.code == DiscoveryCodeEnum.SUCCESS;
			
			confgis.LastStateDevice = OnOrOff;
			new WriterAndReadConfigs().WriterConfigs(confgis);

			return result;
		}

		public bool MonitorBatery()
		{
			confgis = new WriterAndReadConfigs().ReadConfigs();
			PowerStatus pwr = SystemInformation.PowerStatus;

			if (pwr.BatteryLifePercent <= confgis.BatteryLifePercentLow)
			{
				if (confgis.LastStateDevice == StatusDeviceEnum.off)
				{
					return ChangeStatusSwitch(StatusDeviceEnum.on);
				}
			}

			if (pwr.BatteryLifePercent >= confgis.BatteryLifePercentHigh)
			{
				if (confgis.LastStateDevice == StatusDeviceEnum.on)
				{
					return ChangeStatusSwitch(StatusDeviceEnum.off);
				}
			}

			return false;
		}
	}
}
