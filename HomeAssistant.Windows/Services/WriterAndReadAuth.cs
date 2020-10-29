using HomeAssistant.Windows.Dto;
using HomeAssistant.Windows.Enums;
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
			var path = new CreateAndValidPath().CreateFolder(PathsEnum.pathJsons);
			var file = string.Format("{0}auth.json", path);
			using (StreamWriter writer = new StreamWriter(file))
			{
				var json = Newtonsoft.Json.JsonConvert.SerializeObject(dto);
				writer.Write(json);
				writer.Close();
			}
		}

		public DtoAuth ReadAuth()
		{
			DtoAuth result = null;
			var path = new CreateAndValidPath().CreateFolder(PathsEnum.pathJsons);
			var file = string.Format("{0}auth.json", path);
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
