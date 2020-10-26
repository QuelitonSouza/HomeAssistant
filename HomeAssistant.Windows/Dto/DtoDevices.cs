using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace HomeAssistant.Windows.Dto
{
	#region dto Respose
	public class DtoDevices
	{
		public Payload payload { get; set; }
		public Header header { get; set; }
	}
	public class Data
	{
		public bool online { get; set; }
		public bool state { get; set; }
	}

	public class Device
	{
		public Data data { get; set; }
		public string name { get; set; }
		public string icon { get; set; }
		public string id { get; set; }
		public string dev_type { get; set; }
		public string ha_type { get; set; }
	}

	public class Payload
	{
		public List<Device> devices { get; set; }
		public List<object> scenes { get; set; }
	}

	public class Header
	{
		public string code { get; set; }
		public int payloadVersion { get; set; }
	}
	#endregion

	#region Request
	public class HeaderRequest
	{
		[JsonProperty("name")]
		public string Name;

		[JsonProperty("namespace")]
		public string Namespace;

		[JsonProperty("payloadVersion")]
		public int PayloadVersion;
	}

	public class PayloadRequest
	{
		[JsonProperty("accessToken")]
		public string AccessToken;
		
		[JsonProperty("devId")]
		public string DevId;

		[JsonProperty("value")]
		public int Value;
	}

	[Serializable]
	public class DtoDevicesRequest
	{
		[JsonProperty("header")]
		public HeaderRequest Header;

		[JsonProperty("payload")]
		public PayloadRequest Payload;

		public DtoDevicesRequest() { }

		public DtoDevicesRequest(DtoAuth auth)
		{
			this.Header = new HeaderRequest()
			{
				Name = "Discovery",
				Namespace = "discovery",
				PayloadVersion = 1
			};

			this.Payload = new PayloadRequest()
			{
				AccessToken = auth.access_token
			};
		}

		public DtoDevicesRequest(DtoAuth auth, DtoDevices dtoDevice, int value)
		{
			this.Header = new HeaderRequest()
			{
				Name = "turnOnOff",
				Namespace = "control",
				PayloadVersion = 1
			};

			this.Payload = new PayloadRequest()
			{
				AccessToken = auth.access_token,
				DevId = dtoDevice.payload.devices.SingleOrDefault().id,
				Value = value
			};
		}
	}
	#endregion
}
