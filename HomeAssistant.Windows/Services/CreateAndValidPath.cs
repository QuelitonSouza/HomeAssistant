using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssistant.Windows.Services
{
	public class CreateAndValidPath
	{
		public string PathDefault()
		{
			return AppDomain.CurrentDomain.BaseDirectory.ToString();
		}

		public bool ValidPath(string folder)
		{
			var path = string.Format("{0}{1}", PathDefault(), folder);
			return Directory.Exists(path);
		}

		public string CreateFolder(string folder)
		{
			var path = string.Format("{0}{1}", PathDefault(), folder);
			if (!ValidPath(folder))
			{
				Directory.CreateDirectory(path);
			}

			return path + "\\";
		}

		public string CreateFolder()
		{
			var path = PathDefault();
			if (!ValidPath(string.Empty))
			{
				Directory.CreateDirectory(path);
			}

			return path + "\\";
		}
	}
}
