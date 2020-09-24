using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace YeezyAndASwanson
{
    public class YeezyQuote
    {
        public YeezyQuote()
        {

        }

        public static string YeezyYeets()
        {


            var kanyeURL = "https://api.kanye.rest";

            var client = new HttpClient();

            var KanyeResponse = client.GetStringAsync(kanyeURL).Result;

            var KanyeQuote = JObject.Parse(KanyeResponse).GetValue("quote").ToString();

            return $"Yeezy Yeets {KanyeQuote}";

        }


    }
}
