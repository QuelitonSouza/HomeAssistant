using HomeAssistant.Windows.Dto;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace HomeAssistant.Windows.Services
{
	public class WriterAndReadAuth
	{
		public void WriterAuth(DtoAuth dto)
		{
			using (StreamWriter writer = new StreamWriter("auth.json"))
			{
				var json = Newtonsoft.Json.JsonConvert.SerializeObject(dto);
				writer.Write(json);
				writer.Close();
			}
		}

		public DtoAuth ReadAuth()
		{
			DtoAuth result = null;
			string file = "auth.json";
			if (File.Exists(file))
			{
				using (StreamReader read = new StreamReader(file))
				{
					string line; 
					while ((line = read.ReadLine()) != null)
					{
						result = Newtonsoft.Json.JsonConvert.DeserializeObject<DtoAuth>(line);
					}
				}
			}

			return result;
		}
	}
}
