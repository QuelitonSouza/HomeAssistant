using HomeAssistant.Windows.Dto;
using HomeAssistant.Windows.Enums;
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
			var path = new CreateAndValidPath().CreateFolder();
			var file = string.Format("{0}configs.json", path);
			using (StreamWriter writer = new StreamWriter(file))
			{
				var json = Newtonsoft.Json.JsonConvert.SerializeObject(dto);
				writer.Write(json);
				writer.Close();
			}
		}

		public void WriterLog(string logMessage)
		{
			var path = new CreateAndValidPath().CreateFolder(PathsEnum.pathLog);
			var nomeFile = string.Format("{0}LOG_{1}.txt", path, DateTime.Now.ToString("ddMMyyyy"));
			using (StreamWriter writer = new StreamWriter(nomeFile, append: true))
			{
				string message = string.Format("{0} - {1}", DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"), logMessage);
				writer.WriteLine(message);
				writer.Close();
			}
		}

		public DtoConfigs ReadConfigs()
		{
			DtoConfigs result = null;
			var path = new CreateAndValidPath().CreateFolder();
			var file = string.Format("{0}configs.json", path);
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

		public List<DtoLog> ReadLogs()
		{
			List<DtoLog> result = new List<DtoLog>();
			var path = new CreateAndValidPath().CreateFolder(PathsEnum.pathLog);
			var file = string.Format("{0}LOG_{1}.txt", path, DateTime.Now.ToString("ddMMyyyy"));
			if (File.Exists(file))
			{
				StringBuilder fileString = new StringBuilder();
				using (StreamReader read = new StreamReader(file))
				{
					string line;
					
					while ((line = read.ReadLine()) != null)
					{
						var splitData = line.Split('-');
						DtoLog item = new DtoLog();
						item.DateLog = DateTime.Parse(splitData[0].Trim());
						item.Message = splitData[1].Trim();
						result.Add(item);
					}
				}

			}

			return result;
		}
	}
}
