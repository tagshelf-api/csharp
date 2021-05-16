using Newtonsoft.Json;
using System.Collections.Generic;

namespace TagshelfApi.Responses
{
    public class WhoAmIResponse
    {
        #region Properties

        [JsonProperty("request_origin_ip_address")]
        public string RequestOriginIp { get; set; }

        [JsonProperty("authentication_type")]
        public string AuthenticationType { get; set; }

        [JsonProperty("roles")]
        public List<string> Roles { get; set; }

        [JsonProperty("app_id")]
        public string AppId { get; set; }

        [JsonProperty("app_name")]
        public string AppName { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("company_id")]
        public string CompanyId { get; set; }

        [JsonProperty("company_name")]
        public string CompanyName { get; set; }

        [JsonProperty("user_id")]
        public string UserId { get; set; }

        [JsonProperty("user_name")]
        public string Username { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }
        #endregion
    }
}
