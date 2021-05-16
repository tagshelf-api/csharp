using Newtonsoft.Json;

namespace TagshelfApi.Responses
{
    public class StatusResponse
    {
        #region Properties

        [JsonProperty("db_status")]
        public string Status { get; set; }

        [JsonProperty("api_version")]
        public string Version { get; set; }
        #endregion
    }
}
