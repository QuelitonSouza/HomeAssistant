using HomeAssistant.Windows.Dto;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace HomeAssistant.Windows.Services
{
	public class WriterAndReadConfigs
	{
		public void WriterConfigs(DtoConfigs dto)
		{
			using (StreamWriter writer = new StreamWriter("configs.json"))
			{
				var json = Newtonsoft.Json.JsonConvert.SerializeObject(dto);
				writer.Write(json);
				writer.Close();
			}
		}

		public DtoConfigs ReadConfigs()
		{
			DtoConfigs result = null;
			string file = "configs.json";
			if (File.Exists(file))
			{
				using (StreamReader read = new StreamReader(file))
				{
					string line;
					StringBuilder fileString = new StringBuilder();
					while ((line = read.ReadLine()) != null)
					{
						fileString.Append(line);
					}

					result = Newtonsoft.Json.JsonConvert.DeserializeObject<DtoConfigs>(fileString.ToString());
				}
			}

			return result;
		}
	}
}
