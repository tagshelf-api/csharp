using Newtonsoft.Json;

namespace TagshelfApi.Responses
{
    public class Ping
    {
        #region Properties

        [JsonProperty("pong")]
        public string Pong { get; set; }
        #endregion
    }
}
