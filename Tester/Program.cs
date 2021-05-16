using Newtonsoft.Json;
using System;
using TagshelfApi.Cache.Concrete;
using TagshelfApi.Client.Concrete;
using TagshelfApi.Tooling.Concrete;

namespace Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            var logger = new ErrorLogger();
            var tagshelfApi = new TagshelfApiClient("<app_api_key>", "Tester", new InMemoryCache(), new TagshelfApi.Serialization.Concrete.JsonSerializer(), logger);

            #region Status
            /*
             * Provides network information on TagShelf’s systems.
             */
            var status = tagshelfApi.Status();
            Console.WriteLine("=================================================");
            Console.WriteLine("tagshelf/status response");
            Console.WriteLine("=================================================");
            Console.WriteLine(JsonConvert.SerializeObject(status, Formatting.Indented));
            #endregion

            #region who-am-i
            /*
             * Provides account information for the requesting user.
             */
            var whoAmI = tagshelfApi.whoAmI();
            Console.WriteLine("=================================================");
            Console.WriteLine("tagshelf/who-am-i response");
            Console.WriteLine("=================================================");
            Console.WriteLine(JsonConvert.SerializeObject(whoAmI, Formatting.Indented));
            Console.WriteLine("\n");
            #endregion

            #region ping
            /*
             * Returns a pong message with the username who made the request.
             */
            var ping = tagshelfApi.ping();
            Console.WriteLine("=================================================");
            Console.WriteLine("tagshelf/ping response");
            Console.WriteLine("=================================================");
            Console.WriteLine(JsonConvert.SerializeObject(ping, Formatting.Indented));
            #endregion
        }
    }
}
