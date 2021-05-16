using RestSharp;
using RestSharp.Deserializers;
using TagshelfApi.Cache.Abstract;
using TagshelfApi.Client.Abstract;
using TagshelfApi.Responses;
using TagshelfApi.Tooling.Abstract;

namespace TagshelfApi.Client.Concrete
{
    public class TagshelfApiClient : BaseClient
    {        
        public TagshelfApiClient(string apiKey,
                         string appName,
                         ICacheService cache,
                         IDeserializer serializer,
                         IErrorLogger errorLogger)
              : base(apiKey, appName, cache, serializer, errorLogger, "https://staging.tagshelf.com/api/")
        { }

        /// <summary>
        /// Tagshelf API tagshelf/status
        /// </summary>
        /// <returns>
        /// Provides network information on TagShelf’s systems.
        /// </returns>
        public StatusResponse Status()
        {
            RestRequest request = new RestRequest("tagshelf/status", Method.GET);
            return Get<StatusResponse>(request);
        }

        /// <summary>
        /// Tagshelf API tagshelf/who-am-i
        /// </summary>
        /// <returns>
        /// Provides account information for the requesting user.
        /// </returns>
        public WhoAmIResponse whoAmI()
        {
            RestRequest request = new RestRequest("tagshelf/who-am-i", Method.GET);
            return Get<WhoAmIResponse>(request);
        }

        /// <summary>
        /// Tagshelf API tagshelf/ping
        /// </summary>
        /// <returns>
        /// Returns a pong message with the username who made the request.
        /// </returns>
        public Ping ping()
        {
            RestRequest request = new RestRequest("tagshelf/ping", Method.GET);
            return Get<Ping>(request);
        }
    }
}
