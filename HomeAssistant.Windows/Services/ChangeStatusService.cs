using HomeAssistant.Windows.Enums;
using HomeAssistant.Windows.Config;
using System.Windows.Forms;
using HomeAssistant.Windows.Dto;
using System;

namespace HomeAssistant.Windows.Services
{
	public class ChangeStatusService
	{
		private DtoConfigs confgis = null;

		public bool ChangeStatusSwitch(StatusDeviceEnum OnOrOff, DtoConfigs pConfgis = null)
		{
			confgis = pConfgis != null ? pConfgis : confgis;

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

			new WriterAndReadConfigs().WriterLog(OnOrOff == StatusDeviceEnum.on ? "Ligar" : "Desligar");

			if (confgis != null)
			{
				confgis.LastStateDevice = OnOrOff;
				new WriterAndReadConfigs().WriterConfigs(confgis);
			}
			
			return result;
		}

		public bool MonitorBatery()
		{
			try
			{
				new WriterAndReadConfigs().WriterLog("Inicio");
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
			}
			catch (Exception ex)
			{
				new WriterAndReadConfigs().WriterLog(ex.Message);
			}

			new WriterAndReadConfigs().WriterLog("Fim");
			return false;
		}
	}
}
