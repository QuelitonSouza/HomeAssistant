using Newtonsoft.Json;
using System;

namespace HomeAssistant.Windows.Dto
{
    public class DtoAuth
    {
        public string access_token { get; set; }
        public string refresh_token { get; set; }
        public string token_type { get; set; }
        public int expires_in { get; set; }
        public DateTime token_date { get; set; } = DateTime.Now;

        [JsonIgnore]
        public bool IsExpired => DateTime.Now > token_date.AddSeconds(expires_in);
    }
}
