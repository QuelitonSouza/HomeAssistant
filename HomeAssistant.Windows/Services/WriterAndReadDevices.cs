using HomeAssistant.Windows.Dto;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace HomeAssistant.Windows.Services
{
	public class WriterAndReadDevices

	{
		public void WriterDevices(DtoDevices dto)
		{
			using (StreamWriter writer = new StreamWriter("devices.json"))
			{
				var json = Newtonsoft.Json.JsonConvert.SerializeObject(dto);
				writer.Write(json);
				writer.Close();
			}
		}

		public DtoDevices ReadDevices()
		{
			DtoDevices result = null;
			string file = "devices.json";
			if (File.Exists(file))
			{
				using (StreamReader read = new StreamReader(file))
				{
					string line;
					while ((line = read.ReadLine()) != null)
					{
						result = Newtonsoft.Json.JsonConvert.DeserializeObject<DtoDevices>(line);
					}
				}
			}

			return result;
		}
	}
}
