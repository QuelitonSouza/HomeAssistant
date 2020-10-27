using HomeAssistant.Windows.Enums;
using HomeAssistant.Windows.Config;
using System.Windows.Forms;

namespace HomeAssistant.Windows.Services
{
	public class ChangeStatusService
	{
		public bool ChangeStatusSwitch(StatusDeviceEnum OnOrOff)
		{

			var resultAuth = new WriterAndReadAuth().ReadAuth();
			var IsUpdateJson = resultAuth == null || resultAuth.IsExpired;
			if (IsUpdateJson)
			{
				resultAuth = new WebClientApi().auth();
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

			return result;
		}

		public bool MonitorBatery()
		{
			PowerStatus pwr = SystemInformation.PowerStatus;
			var BatteryStatus = pwr.BatteryChargeStatus.ToString();

			if (pwr.BatteryLifePercent <= 0.15)
			{
				if (pwr.PowerLineStatus == PowerLineStatus.Offline)
				{
					return ChangeStatusSwitch(StatusDeviceEnum.on);
				}
			}

			if (pwr.BatteryLifePercent >= 0.99)
			{
				if (pwr.PowerLineStatus == PowerLineStatus.Online && BatteryStatus.Contains(BatteryChargeStatus.Charging.ToString()))
				{
					return ChangeStatusSwitch(StatusDeviceEnum.off);
				}
			}

			return false;
		}
	}
}
