using HomeAssistant.Windows.Dto;
using HomeAssistant.Windows.Enums;
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
			var path = new CreateAndValidPath().CreateFolder(PathsEnum.pathJsons);
			var file = string.Format("{0}devices.json", path);
			using (StreamWriter writer = new StreamWriter(file))
			{
				var json = Newtonsoft.Json.JsonConvert.SerializeObject(dto);
				writer.Write(json);
				writer.Close();
			}
		}

		public DtoDevices ReadDevices()
		{
			DtoDevices result = null;
			var path = new CreateAndValidPath().CreateFolder(PathsEnum.pathJsons);
			var file = string.Format("{0}devices.json", path);
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
