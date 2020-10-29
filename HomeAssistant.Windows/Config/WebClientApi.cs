using HomeAssistant.Windows.Dto;
using RestSharp;

namespace HomeAssistant.Windows.Config
{
	public class WebClientApi
	{
		private RestClient client;
		private string urlBase = "https://px1.tuyaeu.com/homeassistant";
		private string urlLogin = "/auth.do";
		private string urlDevices = "/skill";

		public WebClientApi(DtoAuth auth = null)
		{
			var ResultUrl = ValidBasrUrl(auth);
			client = new RestClient(ResultUrl);
		}

		private string ValidBasrUrl(DtoAuth dto)
		{
			if (dto != null)
			{
				if (dto.access_token.Substring(0, 2) == "EU")
				{
					return urlBase;
				}
				else if (dto.access_token.Substring(0, 2) == "AY")
				{
					return urlBase.Replace("eu", "cn");
				}
				else
				{
					return urlBase.Replace("eu", "us");
				}
			}

			return urlBase;
		}

		public DtoAuth auth(DtoConfigs configs)
		{
			var result = new DtoAuth();
			var request = new RestRequest(urlLogin, Method.POST);
			request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
			request.AddParameter("userName", configs.UserName);
			request.AddParameter("password", configs.Password);
			request.AddParameter("countryCode", "55");
			request.AddParameter("bizType", "smart_life");
			request.AddParameter("from", "tuya");

			var respose = client.Execute<DtoAuth>(request);

			if (respose != null)
				result = respose.Data;

			return result;
		}

		public DtoDevices GetDevices(DtoAuth auth)
		{
			var result = new DtoDevices();
			var json = Newtonsoft.Json.JsonConvert.SerializeObject(new DtoDevicesRequest(auth));
			var request = new RestRequest(urlDevices, Method.POST);
			request.AddHeader("Content-Type", "application/json");
			request.AddHeader("X-Requested-With", "XMLHttpRequest");
			request.AddParameter("application/json", json, ParameterType.RequestBody);

			var respose = client.Execute<DtoDevices>(request);

			if (respose != null)
				result = respose.Data;

			return result;
		}

		public DtoDevices ChangeStatusDevice(DtoAuth auth, DtoDevices dto, int value)
		{

			var result = new DtoDevices();
			var json = Newtonsoft.Json.JsonConvert.SerializeObject(new DtoDevicesRequest(auth, dto, value));
			var request = new RestRequest(urlDevices, Method.POST);
			request.AddHeader("Content-Type", "application/json");
			request.AddHeader("X-Requested-With", "XMLHttpRequest");
			request.AddParameter("application/json", json, ParameterType.RequestBody);
			var respose = client.Execute<DtoDevices>(request);

			if (respose != null)
				result = respose.Data;

			return result;
		}
	}
}
